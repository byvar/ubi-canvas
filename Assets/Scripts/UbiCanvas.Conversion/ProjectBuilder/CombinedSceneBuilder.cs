using ImageMagick.Formats.Pdf;
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
									}, subscene.ActorName);

									if (simpleISC.Spacing != null) pos = pos + simpleISC.Spacing;
								}
								//isc.ACTORS = new CArrayO<Generic<Actor>>(isc.ACTORS.Reverse().ToArray());

								long sceneBaseCheckpointIndex = 0;
								for (int i = 0; i < simpleISC.Subscenes.Count; i++) {
									var subscene = simpleISC.Subscenes[i];
									var scene = subscene.Data;
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
											exitScene.AddActor(exitChangePageActor, exitChangePageActor.USERFRIENDLY);
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
	}
}
