﻿using ImageMagick.Formats.Pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;
using UbiCanvas.Conversion.Json;

namespace UbiCanvas.Conversion {
	public class CombinedSceneBuilder : ProjectBuilder {

		public CombinedSceneBuilder(string projectPath) : base(projectPath) {
		}

		public override string ID => "combinedscene";

		protected override async Task BuildInternal() {
			var inPath = System.IO.Path.Combine(ProjectPath, "json", "combinedscene");


			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in System.IO.Directory.GetFiles(dir, "*.json", System.IO.SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');

					string uncookedPath = relativePath;
					uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));
					if (!uncookedPath.ToLowerInvariant().EndsWith(".isc")) {
						uncookedPath = $"{uncookedPath}.isc";
					}
					var cookedPath = new Path(uncookedPath).CookedPath(TargetContext);

					if (true || !FileIsAlreadyBuilt(cookedPath)) {
						var json = System.IO.File.ReadAllText(file);

						if (uncookedPath.ToLowerInvariant().EndsWith(".isc")) {
							var simpleISC = JsonConvert.DeserializeObject<JSON_SimpleCombinedScene>(json);
							var isc = new Scene();

							isc.ACTORS = new CArrayO<Generic<Actor>>();
							isc.FRISE = new CListO<Frise>();
							if (simpleISC.Subscenes != null) {
								// Add subscenes
								Vec2d pos = Vec2d.Zero;
								for (int i = 0; i < simpleISC.Subscenes.Count; i++) {
									var subscene = simpleISC.Subscenes[i];
									var scene = await LoadFileFromPatchData<ContainerFile<Scene>>(TargetContext, subscene.Path);
									if (scene == null) {
										TargetContext?.SystemLogger?.LogWarning($"{GetType().Name}: Couldn't find scene: {subscene.Path}");
										continue;
									}
									subscene.Data = scene.obj;
									if (string.IsNullOrWhiteSpace(subscene.ActorName)) {
										var pathNoExtension = subscene.Path.Substring(0, subscene.Path.IndexOf('.'));
										subscene.ActorName = pathNoExtension;
									}
									if (subscene.Position != null) pos = subscene.Position;

									// Add subsceneActor
									isc.AddActor(new SubSceneActor() {
										USERFRIENDLY = subscene.ActorName,
										POS2D = pos,
										EMBED_SCENE = true,
										//RELATIVEPATH = new Path(subscene.Path),
										LUA = new Path("enginedata/actortemplates/subscene.tpl"),
										ZFORCED = false,
										IS_SINGLE_PIECE = false,
										SCENE = new UbiArt.Nullable<Scene>(scene.obj)
									});

									if (simpleISC.Spacing != null) pos = pos + simpleISC.Spacing;
								}
								//isc.ACTORS = new CArrayO<Generic<Actor>>(isc.ACTORS.Reverse().ToArray());

								long sceneBaseCheckpointIndex = 0;
								for (int i = 0; i < simpleISC.Subscenes.Count; i++) {
									var subscene = simpleISC.Subscenes[i];
									var scene = subscene.Data;
									if(scene == null) continue;
									// Add exit triggers

									// 1. Find all exits of the current scene
									var exits = scene.FindActors(a => a.LUA?.FullPath?.EndsWith("exitflag.tpl") ?? false);
									if (exits == null || exits.Count == 0) {
										exits = scene.FindActors(a => a.LUA?.FullPath?.EndsWith("exitflag__startpaused.tpl") ?? false);
									}
									// 2. Find first checkpoint of the next scene
									var nextScene = (i+1) < simpleISC.Subscenes.Count ? simpleISC.Subscenes[i+1] : null;
									var nextCheckpoint = nextScene?.Data?.FindActor(a => a.GetComponent<CheckpointComponent>()?.INDEX == 0);

									if (nextCheckpoint != null) {
										// There is a "next checkpoint" -> exit trigger becomes a page portal to the next scene

										// 3. Add portal object for each exit leading to previously created portal object
										foreach (var exit in exits) {
											var exitScene = exit.ContainingScene;
											var exitChangePageActor = CreatePagePortal();
											exitScene.AddActor(exitChangePageActor);
											exitChangePageActor.POS2D = exit.Result.POS2D;
											exitChangePageActor.RELATIVEZ = exit.Result.RELATIVEZ;
											exitChangePageActor.xFLIPPED = exit.Result.xFLIPPED;

											string checkpointPath = "..|";
											if (exit.Path.levels != null) {
												foreach(var l in exit.Path.levels) checkpointPath += "..|"; // The exit path will never contain any parent levels
											}
											checkpointPath += $"{nextScene.ActorName}|{nextCheckpoint.Path.FullPath}";

											var exitLink = exitChangePageActor.GetComponent<LinkComponent>();
											exitLink.Children.Add(new ChildEntry() {
												Path = new ObjectPath(checkpointPath)
											});
										}
									} else {
										// There is no "next checkpoint" -> exit trigger becomes an exit map ritual trigger!

										foreach (var exit in exits) {
											if (exit.Result?.GetComponent<AnimatedComponent>() != null) {
												var ac = exit.Result.GetComponent<AnimatedComponent>();
												ac.defaultAnim = new StringID("state_machine_lastpage");
											}

											var exitScene = exit.ContainingScene;
											var exitRitualActor = CreateExitRitualManager(simpleISC.TeensiesCount, simpleISC.Invasion);
											string invasionParent = null;
											if (simpleISC.Invasion) {
												var teensyRocketActor = scene.FindActor(a => a?.LUA?.FullPath == "world/common/friendly/teensyrocket/components/teensyrocket.tpl");
												if (teensyRocketActor != null) {
													var teensyRocketScene = teensyRocketActor.ContainingScene;
													invasionParent = teensyRocketActor.Path.levels.LastOrDefault().name;
													teensyRocketScene.AddActor(exitRitualActor);
													exitRitualActor.POS2D = new Vec2d(0, 0.562496f);
													exitRitualActor.RELATIVEZ = 0f;
													exitRitualActor.xFLIPPED = false;
												} else {
													exitScene.AddActor(exitRitualActor);
													exitRitualActor.POS2D = exit.Result.POS2D;
													exitRitualActor.RELATIVEZ = exit.Result.RELATIVEZ;
													exitRitualActor.xFLIPPED = exit.Result.xFLIPPED;
												}
											} else {
												exitScene.AddActor(exitRitualActor);
												exitRitualActor.POS2D = exit.Result.POS2D;
												exitRitualActor.RELATIVEZ = exit.Result.RELATIVEZ;
												exitRitualActor.xFLIPPED = exit.Result.xFLIPPED;
											}

											var triggerActor = CreateTriggerBoxExitRitual();
											exitScene.AddActor(triggerActor);
											triggerActor.POS2D = exit.Result.POS2D;
											triggerActor.RELATIVEZ = exit.Result.RELATIVEZ;
											triggerActor.xFLIPPED = exit.Result.xFLIPPED;
											triggerActor.SCALE = new Vec2d(2,2);

											var triggerLink = triggerActor.GetComponent<LinkComponent>();
											if (simpleISC.Invasion && invasionParent != null) {
												triggerLink.Children.Add(new ChildEntry() {
													Path = new ObjectPath(invasionParent)
												});
											} else {
												triggerLink.Children.Add(new ChildEntry() {
													Path = new ObjectPath(exitRitualActor.USERFRIENDLY)
												});
											}

										}
									}

									// Update checkpoint indices
									var checkpoints = scene.FindActors(a => a.GetComponent<CheckpointComponent>() != null);
									long sceneMaxCheckpointIndex = -1;
									foreach (var checkp in checkpoints) {
										var cpc = checkp.Result.GetComponent<CheckpointComponent>();
										if (cpc.INDEX > sceneMaxCheckpointIndex) sceneMaxCheckpointIndex = cpc.INDEX;

										cpc.INDEX = cpc.INDEX + (uint)sceneBaseCheckpointIndex;
									}
									sceneBaseCheckpointIndex += sceneMaxCheckpointIndex + 1;
								}
							}

							isc.sceneConfigs = new SceneConfigs();
							isc.sceneConfigs.sceneConfigs = new CArrayO<Generic<SceneConfig>>();
							if (simpleISC.Invasion) {
								isc.sceneConfigs.sceneConfigs.Add(new Generic<SceneConfig>(new RO2_SceneConfig_Invasion()));
							}
							GenerateSGSFile(isc, new Path(uncookedPath));

							var iscFile = new ContainerFile<Scene>() {
								read = true,
								obj = isc
							};
							Bundle.AddFile(cookedPath, iscFile);
						}
					}
				}
			}
		}

		protected void GenerateSGSFile(Scene scene, Path scenePath) {
			var sceneConfigs = scene?.sceneConfigs;
			var configs = scene?.sceneConfigs?.sceneConfigs;
			if (configs == null || !configs.Any()) return;
			// Now that we've checked that, clone the configs. This way any incompatible configs will be removed too.
			sceneConfigs = ((SceneConfigs)scene.sceneConfigs.Clone("isc", context: TargetContext));
			configs = sceneConfigs.sceneConfigs;

			var defaultConfigIndex = sceneConfigs.activeSceneConfig;
			if (defaultConfigIndex >= configs.Count) defaultConfigIndex = 0;
			var chosenConfig = configs[(int)defaultConfigIndex]?.obj;
			if (chosenConfig == null) return;

			var sgsPath = new Path(scenePath.FullPath.Replace(".isc", ".sgs"));

			var sgsFile = new ContainerFile<Generic<SceneConfig>>() {
				obj = new Generic<SceneConfig>(chosenConfig)
			};
			Bundle.AddFile(sgsPath.CookedPath(TargetContext), sgsFile);
		}

		protected void FillPickable(Pickable pickable, JSON_SimplePickable simple) {
			pickable.POS2D = simple.Position ?? Vec2d.Zero;
			pickable.SCALE = simple.Scale ?? Vec2d.One;
			pickable.RELATIVEZ = simple.Z;
			pickable.ANGLE = new Angle(simple.Angle);
			pickable.USERFRIENDLY = simple.Name;
			pickable.xFLIPPED = simple.XFlip;
		}

		protected Actor CreatePagePortal() {
			var pagePortal = new Actor() {
				LUA = new Path("world/common/logicactor/teleport/components/pageportal.tpl"),
				USERFRIENDLY = "trigger_changepage_2way"
			};
			var lc = pagePortal.AddComponent<LinkComponent>();
			lc.Children = new CListO<ChildEntry>();
			var ptc = pagePortal.AddComponent<PrefetchTargetComponent>();
			ptc.ZONE = new EditableShape() {
				shape = new Generic<PhysShape>(new PhysShapeBox() {
					Extent = new Vec2d(10,10)
				}),
			};
			var pdc = pagePortal.AddComponent<PlayerDetectorComponent>();
			//pdc.useShapeTransform = true;
			//pdc.localScale = 
			var ppc = pagePortal.AddComponent<RO2_PagePortalComponent>();
			ppc.oneWay = false;
			//ppc.enterExitDist = 0;
			var vlc = pagePortal.AddComponent<VirtualLinkComponent>();
			return pagePortal;
		}

		protected Actor CreateExitRitualManager(int teensyCount, bool invasion) {
			if(teensyCount < 3) teensyCount = 3;
			var exitRitual = new Actor() {
				LUA = invasion
				? new Path("world/common/logicactor/exitritual/exitritualmanager/components/exitritualmanager_invasion.tpl")
				: new Path($"world /common/logicactor/exitritual/exitritualmanager/components/exitritualmanager_retro_{teensyCount}.tpl"),
				USERFRIENDLY = invasion ? "exitritualmanager_invasion" : "exitritualmanager"
			};
			var lc = exitRitual.AddComponent<LinkComponent>();
			lc.Children = new CListO<ChildEntry>();
			var ermc = exitRitual.AddComponent<RO2_ExitRitualManagerComponent>();
			var pc = exitRitual.AddComponent<PolylineComponent>();
			var ac = exitRitual.AddComponent<AnimatedComponent>();
			ac.disableLight = 0;
			if (teensyCount == 3) {
				var ptc = exitRitual.AddComponent<PrefetchTargetComponent>();
				if (invasion) {
					ptc.ZONE = new EditableShape() {
						shape = new Generic<PhysShape>(new PhysShapeBox() {
							Points = new CListO<Vec2d>() {
								new Vec2d(-13.7f, -7.700012f),
								new Vec2d(-13.7f, 7.700012f),
								new Vec2d(13.7f, 7.700012f),
								new Vec2d(13.7f, -7.700012f),
							},
							normals = new CListO<Vec2d>() { Vec2d.Left, Vec2d.Up, Vec2d.Right, Vec2d.Down },
							edge = new CListO<Vec2d>() { Vec2d.Up, Vec2d.Right, Vec2d.Down, Vec2d.Left },
							distances = new CArrayP<float>() { 15.40002f, 27.39999f, 15.40002f, 27.39999f },
							Extent = new Vec2d(13.7f, 7.7f)
						}),
						localOffset = new Vec2d(0, 3.5f)
					};
				} else {
					ptc.ZONE = new EditableShape() {
						shape = new Generic<PhysShape>(new PhysShapeBox() {
							Extent = new Vec2d(10, 10)
						}),
					};
				}
			}
			var fccc = exitRitual.AddComponent<FXControllerComponent>();
			var fbc = exitRitual.AddComponent<FxBankComponent>();
			fbc.disableLight = 0;
			var sc = exitRitual.AddComponent<SoundComponent>();
			return exitRitual;
		}

		protected Actor CreateTriggerBoxExitRitual() {
			var trig = new Actor() {
				LUA = new Path("world/common/logicactor/trigger/components/trigger_box_startexitritual.tpl"),
				USERFRIENDLY = "trigger_box_startexitritual"
			};
			var lc = trig.AddComponent<LinkComponent>();
			lc.Children = new CListO<ChildEntry>();
			var pdc = trig.AddComponent<PlayerDetectorComponent>();
			var tc = trig.AddComponent<TriggerComponent>();
			tc.mode = TriggerComponent.Mode.OnceAndRetrigger;

			return trig;
		}
	}
}
