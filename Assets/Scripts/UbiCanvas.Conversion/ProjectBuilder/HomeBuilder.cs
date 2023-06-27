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

			var files = System.IO.Directory.Exists(levelsJsonPath) ? System.IO.Directory.GetFiles(levelsJsonPath, "*.json") : null;
			if (files != null && files.Any()) {
				files = files.OrderBy(f => f).ToArray();
				Dictionary<string, UbiArt.UV.UVAtlas> newUVEntries = new Dictionary<string, UbiArt.UV.UVAtlas>();
				using (var rlContextExt = CreateContext(Settings.Mode.RaymanLegendsPC)) {
					await rlContextExt.Loader.LoadInitial();
					ContainerFile<Scene> homeISC = null;
					GenericFile<CSerializable> gameConfigISG = null;
					UbiArt.SceneConfig.SceneConfigManager sceneConfigManager = null;
					Path pSgsContainer = new Path("sgscontainer");
					Path pGameConfig = new Path("enginedata/gameconfig/gameconfig.isg");
					Path pHomeISC = new Path("world/home/level/home.isc");
					Path pHomeSGS = new Path("world/home/level/home.sgs");

					rlContextExt.Loader.LoadGenericFile(pGameConfig, isg => {
						gameConfigISG = isg;
						rlContextExt.Loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
					});
					rlContextExt.Loader.LoadFile<ContainerFile<Scene>>(pHomeISC, isc => {
						homeISC = isc;
					});
					rlContextExt.Loader.LoadFile<UbiArt.SceneConfig.SceneConfigManager>(pSgsContainer, result =>
						sceneConfigManager = result);
					await rlContextExt.Loader.LoadLoop();
					var gc = rlContextExt.Loader.gameConfig;
					var homeConfig = homeISC.obj.sceneConfigs.sceneConfigs[0].obj as RO2_SceneConfig_Home;
					var sgsHomeConfig = sceneConfigManager.sgsMap[pHomeISC.stringID].obj as RO2_SceneConfig_Home;


					void EnableUbiRay() {
						var ubiRayStringID = new StringID("Rayman_ubi");
						var ubiRay = homeConfig.costumeDescriptors.FirstOrDefault(c => c.costumeTag == ubiRayStringID);
						ubiRay.costumetype2 = RO2_CostumeDescriptor_Template.CostumeType2.Regular;
						ubiRay.costumetype = RO2_CostumeDescriptor_Template.CostumeType.Regular;
						ubiRay = sgsHomeConfig.costumeDescriptors.FirstOrDefault(c => c.costumeTag == ubiRayStringID);
						ubiRay.costumetype2 = RO2_CostumeDescriptor_Template.CostumeType2.Regular;
						ubiRay.costumetype = RO2_CostumeDescriptor_Template.CostumeType.Regular;
					}

					void AddLock(JSON_LockData l, string tag, RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType behavior, string parent) {
						if (l == null) return;
						RO2_GameManagerConfig_Template.LockDataClass lockData = new RO2_GameManagerConfig_Template.LockDataClass() {
							sizeOf = 28,
							lockCount = l.LockCount,
							lockType = l.LockType,
							behaviorType = behavior,
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
								homeConfig.costumeDescriptors.Add(costumeDesc);
								sgsHomeConfig.costumeDescriptors.Add(costumeDesc);

								AddLock(entry.Lock, entry.CostumeID, RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.CostumeFrame, "Costumes");
								AddTagText(entry.CostumeID, entry.NameID);

								CostumesBuilder.Costumes.Add(entry);
							}
						}

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
								AddTagText(entry.WorldID, entry.NameID);
							}
						}
						if (levelsConfig?.Levels != null) {
							foreach (var entry in levelsConfig.Levels) {
								RO2_GameManagerConfig_Template.MapConfig map = new RO2_GameManagerConfig_Template.MapConfig() {
									sizeOf = 984,
									tag = new StringID(entry.MapID),
									worldTag = new StringID(entry.WorldID),
									mapPath = new Path(entry.MapPath),
									mapNameId = new LocalisationId(4721),
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
								AddLock(entry.Lock, entry.MapID, RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.Level, entry.WorldID);
								AddTagText(entry.MapID, entry.NameID);
							}
						}
						if (levelsConfig?.MainPaintings != null) {
							foreach (var entry in levelsConfig.MainPaintings) {
								bool isWorld = entry.HubPath != null;
								var lockType = isWorld ? RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.World
									: RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType.Level;

								RO2_PackageDescriptor_Template painting = new RO2_PackageDescriptor_Template() {
									mapName = entry.ID,
									decorationBrickPath = new Path(entry.DecorationBrickPath),
									hideDecoration = false,
									hubPath = isWorld ? new Path(entry.HubPath) : null,
									mapPath = !isWorld ? new Path(entry.MapPath) : null,
									priority = entry.Priority,
									alternatePriority = entry.Priority,
								};
								homeConfig.packageDescriptors.Add(painting);
								sgsHomeConfig.packageDescriptors.Add(painting);
								AddLock(entry.Lock, entry.ID, lockType, null);
							}
						}
					}

					Bundle.AddFile(rlContextExt.Loader.CookedPaths[pGameConfig.stringID], gameConfigISG);
					Bundle.AddFile(rlContextExt.Loader.CookedPaths[pSgsContainer.stringID], sceneConfigManager);
					Bundle.AddFile(rlContextExt.Loader.CookedPaths[pHomeISC.stringID], homeISC);
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
