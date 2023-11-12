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
	public class HomeBuilder : ProjectBuilder {

		public CostumeActorsBuilder CostumesBuilder { get; set; }

		public HomeBuilder(string projectPath) : base(projectPath) {
			CostumesBuilder = new CostumeActorsBuilder(projectPath);
		}

		public override string ID => "home";

		protected override async Task BuildInternal() {
			var levelsJsonPath = System.IO.Path.Combine(ProjectPath, "json", "levels");

			var files = System.IO.Directory.Exists(levelsJsonPath) ? System.IO.Directory.GetFiles(levelsJsonPath, "*.json", System.IO.SearchOption.AllDirectories) : null;
			if (files != null && files.Any()) {
				files = files.OrderBy(f => f).ToArray();
				Dictionary<string, UbiArt.UV.UVAtlas> newUVEntries = new Dictionary<string, UbiArt.UV.UVAtlas>();

				List<JSON_LevelsConfig> PostProcessCostumesOrder = new List<JSON_LevelsConfig>();
				
				ContainerFile<Scene> homeISC = null;
				GenericFile<CSerializable> gameConfigISG = null;
				ContainerFile<Generic<SceneConfig>> homeSGS = null;
				GenericFile<RO2_HomeManager_Template> homeConfigISG = null;
				//UbiArt.SceneConfig.SceneConfigManager sceneConfigManager = null;
				//Path pSgsContainer = new Path("sgscontainer");
				Path pGameConfig = new Path("enginedata/gameconfig/gameconfig.isg");
				Path pHomeISC = new Path("world/home/level/home.isc");
				Path pHomeSGS = new Path("world/home/level/home.sgs");
				Path pHomeConfig = new Path("enginedata/gameconfig/homeconfig.isg");

				TargetContext.Loader.LoadGenericFile(pGameConfig, isg => {
					gameConfigISG = isg;
					TargetContext.Loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
				});
				TargetContext.Loader.LoadFile<GenericFile<RO2_HomeManager_Template>>(pHomeConfig, isg => {
					homeConfigISG = isg;
				});
				TargetContext.Loader.LoadFile<ContainerFile<Scene>>(pHomeISC, isc => {
					homeISC = isc;
				});
				TargetContext.Loader.LoadFile<ContainerFile<Generic<SceneConfig>>>(pHomeSGS, result =>
					homeSGS = result);
				await TargetContext.Loader.LoadLoop();
				var gc = TargetContext.Loader.gameConfig;
				var hc = homeConfigISG.obj;
				var homeSceneConfig = homeISC.obj.sceneConfigs.sceneConfigs[0].obj as RO2_SceneConfig_Home;
				var sgsHomeSceneConfig = homeSGS.obj.obj as RO2_SceneConfig_Home;
			
				/*var challengePath = new Path("world/challenge/run_egypt/challengerun/challenge_run_main.isc");
				var challengeScene = await LoadFileFromPatchData<ContainerFile<Scene>>(TargetContext, challengePath.FullPath);
				var cfgs = challengeScene.obj.sceneConfigs;
				var cfg = cfgs.sceneConfigs[(int)cfgs.activeSceneConfig];
				sceneConfigManager.sgsMap[challengePath.FullPath] = cfg;*/

				await ExtendCostumeRoom();
				await ExtendTrainingRoom();

				void EnableUbiRay() {
					var ubiRayStringID = new StringID("Rayman_ubi");
					var ubiRay = homeSceneConfig.costumeDescriptors.FirstOrDefault(c => c.costumeTag == ubiRayStringID);
					ubiRay.costumetype2 = RO2_CostumeDescriptor_Template.CostumeType2.Regular;
					ubiRay.costumetype = RO2_CostumeDescriptor_Template.CostumeType.Regular;
					ubiRay = sgsHomeSceneConfig.costumeDescriptors.FirstOrDefault(c => c.costumeTag == ubiRayStringID);
					ubiRay.costumetype2 = RO2_CostumeDescriptor_Template.CostumeType2.Regular;
					ubiRay.costumetype = RO2_CostumeDescriptor_Template.CostumeType.Regular;
				}

				void AddLock(JSON_LockData l, string tag, RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType behavior, string parent) {
					if (l == null) return;
					RO2_GameManagerConfig_Template.LockDataClass lockData = new RO2_GameManagerConfig_Template.LockDataClass() {
						sizeOf = 28,
						lockCount = l.LockCount,
						lockType = l.LockType,
						behaviorType = l.BehaviorType ?? behavior,
						tag = new StringID(tag),
						parent = parent == null ? new StringID(0x85A77AC7) : new StringID(parent) // TODO: what is the string that has ID 0x85A77AC7? it's used for the main gallery items
					};
					gc.lockData.Add(lockData);
				}
				void AddTagText(string tag, uint locId) {
					gc.tagText.Add(new RO2_GameManagerConfig_Template.TagTextClass() {
						sizeOf = 12,
						tag = new StringID(tag),
						locID = new LocalisationId(locId)
					});
				}

				EnableUbiRay();
				foreach (var f in files) {
					var json = System.IO.File.ReadAllText(f);
					var levelsConfig = JsonConvert.DeserializeObject<JSON_LevelsConfig>(json);

					if (levelsConfig?.Costumes != null) {
						foreach (var entry in levelsConfig.Costumes) {
							// Fill in actor paths based on costumeID
							var moskitoFamily = entry.Family.ToLowerInvariant() switch {
								"rayman" => "ray",
								"globox" => "glob",
								_ => entry.Family.ToLowerInvariant()
							};
							if (entry.MoskitoID == null) {
								entry.MoskitoID = entry.CostumeID.ToLowerInvariant().Replace(entry.Family.ToLowerInvariant(), moskitoFamily);
							}
							if (entry.DuckID == null) entry.DuckID = entry.CostumeID.ToLowerInvariant();

							entry.ActorPath_Main = $"world/common/playablecharacter/{entry.Family.ToLowerInvariant()}/{entry.CostumeID.ToLowerInvariant()}.act";
							entry.ActorPath_ScoreHUD = $"world/common/ui/common/playerscore/scorehud_{entry.ScoreHudID.ToLowerInvariant()}.act";
							entry.ActorPath_Moskito = $"world/common/shooter/playablecharacter/shootermoskito{moskitoFamily}/shootermoskito{entry.MoskitoID.ToLowerInvariant()}.act";
							entry.ActorPath_Duck = $"world/common/playablecharacter/duck/duck_{entry.DuckID.ToLowerInvariant()}.act";
							entry.ActorPath_Painting = $"world/home/actor/costumes/costume{entry.CostumeID.ToLowerInvariant()}.act";
							entry.TemplatePath_Painting = $"world/home/actor/costumes/components/costume{entry.CostumeID.ToLowerInvariant()}.tpl";
							entry.TemplatePath_Trail = $"world/common/fx/actors/trails/teleporttrail_{entry.CostumeID.ToLowerInvariant().Replace("_", "")}.tpl";

							// Determine decoration brick path
							var decFamily = entry.Family.ToLowerInvariant();
							if (decFamily == "barbara") decFamily += "_cr";
							var decorationBrickPath = $"world/home/paintings_and_notifications/painting_costumes/painting_costume_{decFamily}.isc";


							RO2_PlayerIDInfo player = new RO2_PlayerIDInfo() {
								sizeOf = 264,
								id = entry.CostumeID,
								family = entry.Family,
								iconTexturePath = new Path(entry.IconPath),
								iconSizeInTexture = entry.IconSize,
								deathBubbleColor = entry.DeathBubbleColor,
								defaultGameScreenInfo = new PlayerIDInfo.GameScreenInfo() {
									sizeOf = 28,
									actors = new CListO<PlayerIDInfo.ActorInfo>()
								},
							};
							player.defaultGameScreenInfo.actors.Add(new PlayerIDInfo.ActorInfo() {
								sizeOf = 184,
								file = new Path(entry.ActorPath_Main),
								isAlwaysActive = false,
								isPlayable = true,
								gameModes = new CListP<uint>() { 0 },
								isDynamicallyLoaded = false,
								mainGameMode = 0xFFFFFFFF,
							});
							player.defaultGameScreenInfo.actors.Add(new PlayerIDInfo.ActorInfo() {
								sizeOf = 184,
								file = new Path(entry.ActorPath_ScoreHUD),
								isAlwaysActive = true,
								isPlayable = false,
								gameModes = new CListP<uint>() { 0, 1, 2 },
								isDynamicallyLoaded = false,
								mainGameMode = 0xFFFFFFFF,
							});
							player.defaultGameScreenInfo.actors.Add(new PlayerIDInfo.ActorInfo() {
								sizeOf = 184,
								file = new Path(entry.ActorPath_Moskito),
								isAlwaysActive = false,
								isPlayable = true,
								gameModes = new CListP<uint>() { 0, 1, 2 },
								isDynamicallyLoaded = true,
								mainGameMode = 1,
							});
							player.defaultGameScreenInfo.actors.Add(new PlayerIDInfo.ActorInfo() {
								sizeOf = 184,
								file = new Path(entry.ActorPath_Duck),
								isAlwaysActive = false,
								isPlayable = true,
								gameModes = new CListP<uint>() { 2 },
								isDynamicallyLoaded = true,
								mainGameMode = 2,
							});

							gc.playerIDInfo.Add(new Generic<PlayerIDInfo>(player));
							//gc.sizeOf += 2048;
							gameConfigISG.sizeOf += 2048;

							gc.costumes.Add(new RO2_CostumeInfo_Template() {
								sizeOf = 180,
								playerIDInfo = new StringID(entry.CostumeID),
								painting = new Path(entry.ActorPath_Painting),
								backgroundColor = entry.Painting.BackgroundColor,
								levelDependency = new StringID(entry.Painting.LevelDependency)
							});

							RO2_CostumeDescriptor_Template costumeDesc = new RO2_CostumeDescriptor_Template() {
								costumeTag = new StringID(entry.CostumeID),
								priority = entry.Painting.Priority,
								decorationBrickPath = new Path(decorationBrickPath),
								costumetype2 = entry.CostumeType,
								unlockable = entry.Painting.Unlockable,
							};
							homeSceneConfig.costumeDescriptors.Add(costumeDesc);
							sgsHomeSceneConfig.costumeDescriptors.Add(costumeDesc);

							AddLock(entry.Lock, entry.CostumeID, RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.CostumeFrame, "Costumes");
							AddTagText(entry.CostumeID, entry.NameID);

							CostumesBuilder.Costumes.Add(entry);
						}
					}
					if(levelsConfig?.CostumesOrder != null && levelsConfig.CostumesOrder.Any())
						PostProcessCostumesOrder.Add(levelsConfig);

					if (levelsConfig?.Worlds != null) {
						foreach (var entry in levelsConfig.Worlds) {
							RO2_GameManagerConfig_Template.WorldConfig world = new RO2_GameManagerConfig_Template.WorldConfig() {
								sizeOf = 324,
								tag = new StringID(entry.WorldID),
								defaultScoreRecapPath = new Path(entry.DefaultScoreRecapPath),
								interactiveLoadingPath = new Path(entry.InteractiveLoadingPath),
								teensyUnlockCountRetro1 = (uint)entry.TeensyUnlockCountRetro1,
								teensyUnlockCountRetro2 = (uint)entry.TeensyUnlockCountRetro2,
								presence = new StringID(entry.Presence),
							};
							gc.worldsInfo.Add(world);
							gameConfigISG.sizeOf += 1024;
							AddTagText(entry.WorldID, entry.NameID);
						}
					}
					if (levelsConfig?.Levels != null) {
						foreach (var entry in levelsConfig.Levels) {
							RO2_GameManagerConfig_Template.MapConfig map = new RO2_GameManagerConfig_Template.MapConfig() {
								sizeOf = 984,
								tag = new StringID(entry.MapID),
								worldTag = new StringID(entry.WorldID),
								mapPath = new PathRef(entry.MapPath),
								mapNameId = new LocalisationId(entry.NameID),
								texturePath = new Path(entry.TexturePath),
								maxLumsCount = (uint)entry.LumsCount,
								scoreRecapPath = new Path(entry.ScoreRecapPath),
								loading = new Path(entry.Loading),
								loadingOut = new Path(entry.LoadingOut),
								mapType = RO2_GameManagerConfig_Template.MapConfig.MAPTYPE.NORMAL,

								teensyCount = entry.TeensyCount switch {
									0 => RO2_GameManagerConfig_Template.MapConfig.TeensyCount.None,
									3 => RO2_GameManagerConfig_Template.MapConfig.TeensyCount._3,
									10 => RO2_GameManagerConfig_Template.MapConfig.TeensyCount._10,
									_ => throw new Exception($"Incorrect teensy count: {entry.TeensyCount}")
								},

								horizontal = entry.Horizontal,
								startLeft = entry.StartLeft,
								difficulty = (uint)entry.Difficulty,
							};
							gc.levelsInfo.Add(map);
							gameConfigISG.sizeOf += 0x800;
							AddLock(entry.Lock, entry.MapID, RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.Level, entry.WorldID);
							AddTagText(entry.MapID, entry.NameID);
						}
					}
					if (levelsConfig?.MainPaintings != null) {
						foreach (var entry in levelsConfig.MainPaintings) {
							bool isWorld = entry.HubPath != null;
							var behaviorType = isWorld ? RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.World
								: RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.Level;

							RO2_PackageDescriptor_Template painting = new RO2_PackageDescriptor_Template() {
								mapName = entry.ID,
								decorationBrickPath = new Path(entry.DecorationBrickPath),
								hideDecoration = false,
								hubPath = isWorld ? new Path(entry.HubPath) : null,
								mapPath = !isWorld ? new PathRef(entry.MapPath) : null,
								priority = entry.Priority,
								alternatePriority = entry.Priority,
							};
							homeSceneConfig.packageDescriptors.Add(painting);
							sgsHomeSceneConfig.packageDescriptors.Add(painting);
							AddLock(entry.Lock, entry.ID, behaviorType, null);
						}
					}
					if (levelsConfig?.Challenges != null) {
						foreach (var entry in levelsConfig.Challenges) {
							var competition = new CompetitionLevelInfo() {
								sizeOf = 172,
								mode = entry.Mode,
								isg = new PathRef(entry.Path),
								frequency = entry.Frequency,
								objective = entry.Objective,
								score_validation = entry.ScoreValidation,
								level = new StringID(entry.MapID)
							};
							hc.competitionsLevels.Add(competition);
							homeConfigISG.sizeOf += 0x100;
						}
					}
				}

				// Now reassign costume priorities
				foreach (var levelsConfig in PostProcessCostumesOrder) {
					var order = levelsConfig.CostumesOrder;
					foreach (var entry in order) {
						int priority = entry.Key;
						string costumeID = entry.Value;
						StringID costumeSID = new StringID(costumeID);

						var desc = homeSceneConfig.costumeDescriptors.FirstOrDefault(c => c.costumeTag == costumeSID);
						if (desc == null) {
							TargetContext?.SystemLogger?.LogInfo($"Costume descriptor not found: {costumeID}");
						} else {
							desc.priority = priority;
							desc = sgsHomeSceneConfig.costumeDescriptors.FirstOrDefault(c => c.costumeTag == costumeSID);
							desc.priority = priority;
						}
					}
				}
				//UnityEngine.Debug.Log(PrintCostumeOrder(gc, homeConfig));


				Bundle.AddFile(TargetContext.Loader.CookedPaths[pGameConfig.stringID], gameConfigISG);
				Bundle.AddFile(TargetContext.Loader.CookedPaths[pHomeConfig.stringID], homeConfigISG);
				Bundle.AddFile(TargetContext.Loader.CookedPaths[pHomeSGS.stringID], homeSGS);
				Bundle.AddFile(TargetContext.Loader.CookedPaths[pHomeISC.stringID], homeISC);
			}
		}

		private string PrintCostumeOrder(RO2_GameManagerConfig_Template gc, RO2_SceneConfig_Home homeConfig) {
			StringBuilder b = new StringBuilder();
			Dictionary<StringID, string> players = new Dictionary<StringID, string>();
			var ordered = homeConfig.costumeDescriptors.OrderBy(c => c.priority);
			
			foreach(var player in gc.playerIDInfo)
				players.Add(new StringID(player.obj.id), player.obj.id);

			foreach(var desc in ordered)
				b.AppendLine($"\"{desc.priority}\": {players[desc.costumeTag]},");

			return b.ToString();
		}

		private async Task ExtendTrainingRoom() {

			ContainerFile <Scene> challengeISC = null;
			Path pChallengeISC = new Path("world/home/level/challenge/challenge.isc");

			/*var minX = -30;
			var maxX = +30;
			var extendMinX = -500;
			var extendMaxX = +500;
			var scaleFactorX = 7f;*/

			TargetContext.Loader.LoadFile<ContainerFile<Scene>>(pChallengeISC, isc => {
				challengeISC = isc;
			});
			await TargetContext.Loader.LoadLoop();

			// Process training scene
			var trainingSSA = challengeISC.obj.FindActor(a => a is SubSceneActor && a.USERFRIENDLY == "training").Result as SubSceneActor;
			var scene = trainingSSA.SCENE.value;

			// For now, just replace the last two...
			var webPickable = scene.FindPickable(p => p.USERFRIENDLY == "challenge_goingdown_web");
			webPickable.ContainingScene.DeletePickable(webPickable.Result);
			var spacing = new Vec2d(7f, 0f);

			var lastPos = scene.FindPickable(p => p.USERFRIENDLY == "challenge_drc").Result.POS2D;
			lastPos += spacing;
			var ssa = await CreateSubSceneActorFromScene("world/home/brick/challenge/challenge_classicrun_egypt.isc");
			scene.AddActor(ssa, ssa.USERFRIENDLY);
			ssa.POS2D = lastPos;
			lastPos += spacing;
			ssa = await CreateSubSceneActorFromScene("world/home/brick/challenge/challenge_classicrun_dojo.isc");
			scene.AddActor(ssa, ssa.USERFRIENDLY);
			ssa.POS2D = lastPos;

			await ReplaceSceneByName("challenge_classicrun", "world/home/brick/challenge/challenge_classicrun.isc");
			await ReplaceSceneByName("challenge_shaolin", "world/home/brick/challenge/challenge_shaolin.isc");
			await ReplaceSceneByName("challenge_goingup", "world/home/brick/challenge/challenge_goingup.isc");
			await ReplaceSceneByName("challenge_goingdown", "world/home/brick/challenge/challenge_goingdown.isc");
			await ReplaceSceneByName("challenge_drc", "world/home/brick/challenge/challenge_drc.isc");

			Bundle.AddFile(pChallengeISC.CookedPath(TargetContext), challengeISC);

			async Task<SubSceneActor> CreateSubSceneActorFromScene(string path) {
				var newScene = await LoadFileFromPatchData<ContainerFile<Scene>>(TargetContext, path);
				if(newScene == null) return null;
				var newActor = new SubSceneActor() {
					USERFRIENDLY = new Path(path).GetFilenameWithoutExtension(removeCooked: true),
					LUA = new Path("enginedata/actortemplates/subscene.tpl"),

					EMBED_SCENE = true,
					ZFORCED = true,
					SCENE = new UbiArt.Nullable<Scene>((Scene)(await TargetContext.Loader.Clone(newScene?.obj, "isc")))
				};
				return newActor;
			}
			async Task ReplaceScene(SubSceneActor act, string path) {
				var newScene = await LoadFileFromPatchData<ContainerFile<Scene>>(TargetContext, path);
				if (newScene == null) return;
				act.SCENE = new UbiArt.Nullable<Scene>(newScene.obj);
			}
			async Task ReplaceSceneByName(string name, string path) {
				await ReplaceScene(scene.FindActor(a => a.USERFRIENDLY == name && a is SubSceneActor).Result as SubSceneActor, path);
			}
		}

		private async Task ExtendCostumeRoom() {

			ContainerFile<Scene> costumesISC = null;
			Path pCostumesISC = new Path("world/home/level/costumes/costume_main.isc");

			var minX = -30;
			var maxX = +30;
			var extendMinX = -500;
			var extendMaxX = +500;
			var scaleFactorX = 7f;

			TargetContext.Loader.LoadFile<ContainerFile<Scene>>(pCostumesISC, isc => {
				costumesISC = isc;
			});
			await TargetContext.Loader.LoadLoop();

			// Frises
			//ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "frontlightfill@2").Result);
			//ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "frontlightfill@4").Result);
			RescalePickable((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "frontlightfill@2").Result);
			RescalePickable((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "frontlightfill@4").Result);
			ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "fx_particlesuspension_fill").Result);
			ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "groundwood").Result, uvScale: 3.5f);
			ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "groundwood@1").Result, uvScale: 3.5f);
			ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "groundsandy").Result, uvScale: 3.5f);
			ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "invisibleground_woodhome").Result);
			ProcessFrise((Frise)costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "tent_background@1").Result, uvScale: 8f);

			// Lighting actors
			RescalePickable(costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "resolvebothmask@1").Result);
			RescalePickable(costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "clearcolor").Result);

			// Sound triggers
			RescalePickable(costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "triggersound_amb_home_house_int").Result);
			RescalePickable(costumesISC.obj.FindPickable(p => p.USERFRIENDLY == "music_stop_5s@1").Result);


			Bundle.AddFile(pCostumesISC.CookedPath(TargetContext), costumesISC);


			void ProcessFrise(Frise f, float uvScale = 1f) {
				float ExtendGlobalToLocal(float extend) => extend / f.SCALE.x;
				Vec2d LocalToGlobal(Vec2d point) => (point * f.SCALE) + f.POS2D;

				ProcessPolyPointList(f.PointsList, false);
				if (f.collisionData?.value?.LocalCollisionList != null) {
					foreach (var lst in f.collisionData?.value?.LocalCollisionList) {
						ProcessPolyPointList(lst, false);
					}
				}
				if (f.collisionData?.value?.WorldCollisionList != null) {
					foreach (var lst in f.collisionData?.value?.WorldCollisionList) {
						ProcessPolyPointList(lst?.PolyPointList, true);
						if (lst?.PolyPointList != null) {
							lst.AABB.MIN.x = lst.PolyPointList.LocalPoints.Min(p => p.POS.x);
							lst.AABB.MIN.y = lst.PolyPointList.LocalPoints.Min(p => p.POS.y);
							lst.AABB.MAX.x = lst.PolyPointList.LocalPoints.Max(p => p.POS.x);
							lst.AABB.MAX.y = lst.PolyPointList.LocalPoints.Max(p => p.POS.y);
						}
					}
				}

				if (f.meshBuildData?.value?.StaticVertexList != null) {
					foreach (var vert in f.meshBuildData.value.StaticVertexList) {
						var gpos = LocalToGlobal(new Vec2d(vert.pos.x, vert.pos.y));
						if (gpos.x < minX) {
							vert.pos.x += ExtendGlobalToLocal(extendMinX);
							vert.uv.x += ExtendGlobalToLocal(extendMinX) / (f.config.obj.fill.scale.x * uvScale); // Haven't figured out how this works yet sadly, so I need to specify uv scale manually. Seems to be related to both scale in "fill" and "width" value in config.
						} else if (gpos.x > maxX) {
							vert.pos.x += ExtendGlobalToLocal(extendMaxX);
							vert.uv.x += ExtendGlobalToLocal(extendMaxX) / (f.config.obj.fill.scale.x * uvScale);
						}
					}
				}
				void ProcessPolyPointList(PolyPointList pts, bool isGlobal) {
					if(pts == null) return;
					foreach (var pt in pts.LocalPoints) {
						ExtendVec2d(pt.POS, isGlobal);
					}
					pts.RecomputeData();
				}
				void ExtendVec2d(Vec2d vec, bool isGlobal) {
					if(vec == null) return;
					if (isGlobal) {
						if (vec.x < minX) {
							vec.x += extendMinX;
						} else if (vec.x > maxX) {
							vec.x += extendMaxX;
						}
					} else {
						var global = LocalToGlobal(vec);
						if (global.x < minX) {
							vec.x += ExtendGlobalToLocal(extendMinX);
						} else if (global.x > maxX) {
							vec.x += ExtendGlobalToLocal(extendMaxX);
						}
					}
				}
				ExtendVec2d(f.meshStaticData?.value?.LocalAABB?.MIN, false);
				ExtendVec2d(f.meshStaticData?.value?.LocalAABB?.MAX, false);

				ExtendVec2d(f.meshStaticData?.value?.WorldAABB?.MIN, true);
				ExtendVec2d(f.meshStaticData?.value?.WorldAABB?.MAX, true);
			}

			void RescalePickable(Pickable p) {
				p.SCALE.x *= scaleFactorX;
				if (p is Frise f) {
					Vec2d LocalToGlobal(Vec2d point) => (point * f.SCALE) + f.POS2D;

					var aabb = f.meshStaticData?.value;
					if (aabb?.LocalAABB != null) {
						aabb.WorldAABB.MIN = LocalToGlobal(aabb.LocalAABB.MIN);
						aabb.WorldAABB.MAX = LocalToGlobal(aabb.LocalAABB.MAX);
					}
				}
			}
		}

		public override async Task Build() {
			await base.Build();
			await CostumesBuilder.Build();
		}

		public override void Clean() {
			base.Clean();
			CostumesBuilder.Clean();
		}
	}
}
