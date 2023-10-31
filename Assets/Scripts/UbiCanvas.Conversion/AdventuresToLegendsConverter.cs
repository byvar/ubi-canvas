using Cysharp.Threading.Tasks;
using ImageMagick;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.Animation;
using UbiArt.ITF;
using UbiArt.Localisation;
using UbiCanvas.Conversion.Json;
using UbiCanvas.Helpers;
using UnityEngine;

namespace UbiCanvas.Conversion {
	public class AdventuresToLegendsConverter : IDisposable {
		public Context LegendsContext { get; set; }
		public Context MainContext { get; set; }
		public ConversionSettings ConversionSettings { get; set; }
		public Settings OldSettings { get; set; }
		public Settings NewSettings { get; set; }
		public string ProjectPath { get; set; }
		public string ExportID { get; set; }
		public string LegendsPath { get; set; }

		public AdventuresToLegendsConverter(Context mainContext, string rlPath, string projectPath, string exportID = null) {
			MainContext = mainContext;
			if (exportID == null) {
				var lvlPath = UnitySettings.SelectedLevelFile;
				string sceneName = System.IO.Path.GetFileName(lvlPath);
				if (sceneName.Contains('.')) sceneName = sceneName.Substring(0, sceneName.IndexOf('.'));
				exportID = sceneName;
			}
			ExportID = exportID;

			Loader l = mainContext.Loader;
			var structs = l.Context.Cache.Structs;
			var oldSettings = l.Settings;

			ProjectPath = projectPath;
			LegendsPath = rlPath;
			OldSettings = oldSettings;
			var settings = Settings.FromMode(Mode.RaymanLegendsPC);
			NewSettings = settings;

			// Create conversion settings
			var conversionSettings = new ConversionSettings() {
				OldSettings = oldSettings
			};
			ConversionSettings = conversionSettings;
			InitPathConversionRules();

			LegendsContext = CreateContext(Mode.RaymanLegendsPC, enableSerializerLog: false);
			LegendsContext.AddSettings<ConversionSettings>(new ConversionSettings() {
				LockPaths = true
			});
		}

		protected void InitPathConversionRules() {
			var conversionSettings = ConversionSettings;
			var oldSettings = OldSettings;

			if (oldSettings.Game == Game.RA || oldSettings.Game == Game.RM) {
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("common/matshader/", "common/matshader_adv/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("common/fx/lifeelements/water/", "common/fx/lifeelements/water_adv/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("common/platform/aspinetwork/", "common/platform/aspinetwork_adv/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("rotation_biggear.tpl", "rotation_biggear_adv.tpl"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("lightingmushroom.tpl", "lightingmushroom_adv.tpl"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("umbrella/classic/", "umbrella/adv/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/adversarial/soccerpunch/actor/soccerball/", "world/adversarial/soccerpunch/actor/soccerball_adv/"));
				//conversionSettings.PathConversionRules.Add(
				//	new PathConversionRule("world/common/friendly/lumschain/components/lumschain.tpl", "world/common/friendly/lumschain/components/lumschain_adv.tpl"));
				/*conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/fireworks/", "world/common/fx/textures/fireworks_adv/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/star/", "world/common/fx/textures/star_adv/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/light/", "world/common/fx/textures/light_adv/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/smoke/", "world/common/fx/textures/smoke_adv/")); // TODO: fix smoke textures coming from egghunt
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/smoke_adv/fx_steam_anim_01.tga", "world/common/fx/textures/smoke/fx_steam_anim_01.tga"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/smoke_adv/fx_smokeship_01.tga", "world/common/fx/textures/smoke/fx_smokeship_01.tga"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/pollen/", "world/common/fx/textures/pollen_adv/"));*/
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures/", "world/common/fx/textures_adv/"));
				/*conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures_adv/smoke/fx_smokeship_01.tga", "world/common/fx/textures/smoke/fx_smokeship_01.tga"));*/

				/*conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/", "world/common/fx_/"));*/
				/*conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/lifeelements2/dust/", "world/common/fx/lifeelements2/dust_adv/"));*/
				//conversionSettings.PathConversionRules.Add(
				//	new PathConversionRule("world/common/ldfrieze/polystyrene/frieze/", "world/common/ldfrieze/polystyrene/frieze_adv/"));

				// Teensies
				//conversionSettings.PathConversionRules.Add(
				//	new PathConversionRule("world/common/friendly/bt_friendly/teensy/components/teensy.tpl", "world/common/friendly/bt_friendly/teensy/components/teensy_rlc.tpl"));
				//conversionSettings.PathConversionRules.Add(
				//	new PathConversionRule("world/common/breakable/post/components/post.tpl", "world/common/breakable/post/components/post_rlc.tpl"));

				// Enemy animations
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/enemy/jacquouille/animation/", "world/common/enemy/jacquouille/animation_rlc/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/mountain/common/enemy/minotaur/animation/", "world/mountain/common/enemy/minotaur/animation_rlc/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/enemy/toad/animation/", "world/common/enemy/toad/animation_rlc/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/mountain/common/friendly/light_bulbalums/animation/", "world/mountain/common/friendly/light_bulbalums/animation_rlc/"));
				/*conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/enemy/toad/", "world/common/enemy/toad_rlc/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/enemy/jacquouille/", "world/common/enemy/jacquouille_rlc/"));*/

				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("enginedata/actortemplates/tpl_staticmeshvertexcomponent.tpl", "enginedata/actortemplates/tpl_staticmeshvertexcomponent_rlc.tpl"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/blocker/drc/mechadoor/actor/tweening/door1.tpl", "world/common/blocker/drc/mechadoor/actor/tweening/door1_rlc.tpl"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/mountain/mecha/playground/enemy/buzzsaw/", "world/mountain/mecha/playground/enemy/buzzsaw_rlc/"));
				//conversionSettings.PathConversionRules.Add(
				//	new PathConversionRule("world/landofthedead/common/enemy/balancingaxe/", "world/landofthedead/common/enemy/balancingaxe_rlc/"));

				// Tweening (rename for sounds)
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/logicactor/tweening/tweeneditortype/components/", "world/common/logicactor/tweening/tweeneditortype/components_rlc/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/logicactor/tweening/tweeneditortype/components_rlc/tween_notype.tpl", "world/common/logicactor/tweening/tweeneditortype/components/tween_notype.tpl"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/lifeelements/musical/", "world/common/fx/lifeelements_rlc/musical/"));
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/friendly/skullcoin/components/skullcoin.tpl", "world/common/friendly/skullcoin/components/skullcoin_rlc.tpl"));
			}
			if (oldSettings.Game == Game.RM) {
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("common/lifeelements/dragonfly/", "common/lifeelements/dragonfly_mini/"));
			}
		}

		public async Task Init() {
			StartLoadingScreen();

			ConversionSettings.WwiseConversionSettings = await LoadWwiseConfig(MainContext, ProjectPath);
			await LegendsContext.Loader.LoadInitial();
			await LegendsContext.Loader.LoadLoop();
		}

		protected void StartLoadingScreen() {
			Controller.Obj.loadingScreen.Active = true;
			GlobalLoadState.DetailedState = "Exporting map";
			GlobalLoadState.LoadState = GlobalLoadState.State.Initializing;
		}
		protected void StopLoadingScreen() {
			Debug.Log($"Finished exporting {ExportID}.");
			GlobalLoadState.DetailedState = "Finished";
			GlobalLoadState.LoadState = GlobalLoadState.State.Finished;
			Controller.Obj.loadingScreen.Active = false;
		}

		public async Task ProcessAllLoadedScenes() {
			var mainContext = MainContext;
			var structs = mainContext.Cache.Structs;
			var loadedScenes = structs[typeof(ContainerFile<Scene>)];
			var scenes = loadedScenes.ToArray();
			foreach (var scene in scenes) {
				var sc =(ContainerFile<Scene>)(scene.Value);
				if (sc?.obj != null) {
					await ProcessScene(sc.obj);
				}
			}
		}

		public async Task ProcessScene(Scene scene = null) {
			scene ??= Controller.Obj.MainScene.obj;
			var settings = NewSettings;
			var mainContext= MainContext;
			var conversionSettings = ConversionSettings;

			// Print scene path
			var structs = mainContext.Cache.Structs;
			var loadedScenes = structs[typeof(ContainerFile<Scene>)];
			var loadedScene = loadedScenes.FirstOrDefault(s => ((ContainerFile<Scene>)s.Value).obj == scene);
			var scenePath = mainContext.Loader.Paths[loadedScene.Key];
			UnityEngine.Debug.Log($"Processing scene: {scenePath}");

			LevelSpecificChanges(mainContext, settings, scene);

			PerformHangSpotWorkaround(mainContext, settings, scene);
			AddRelayToMushrooms(mainContext, settings, scene);

			AddTriggerMoreEventTweens(mainContext, settings, scene);
			CreateTemplatesForInstanceRelays(mainContext, settings, scene);

			CreateFriseParents(mainContext, settings, scene);
			await MakeFrisesStartPaused(mainContext, settings, scene);
			CreateLightingFrisesForRenderParams(mainContext, settings, scene);

			AddSceneConfigForRotatingPlatform(mainContext, settings, scene);

			await Task.CompletedTask;
		}

		public async Task ProcessNonScene() {
			var settings = NewSettings;
			var mainContext = MainContext;
			var conversionSettings = ConversionSettings;

			FixNinjas(mainContext, settings);
			FixAllUTurnAnimations(mainContext, settings);
			UpdateSoundFXReferences(mainContext, settings, conversionSettings);
			FixLumKingMusic(mainContext, settings);
			FixCameraModifierBlend(mainContext, settings);
			FixAspiNetworks(mainContext, settings);
			FixTeensies(mainContext, settings);
			PerformHangSpotWorkaround_TPLFix(mainContext, settings);
			AddPreInstructionSets(mainContext, settings);

			FixStaticMeshVertexComponentCulling(mainContext, settings);
			AddCaptainAI(mainContext, settings);
			DowngradeFxUV(mainContext, settings);

			FixEnemiesWithShieldUp(mainContext, settings);
			//FixSwimmingToads(mainContext, settings);

			DuplicateActorTemplatesForStartPaused(mainContext);
			DuplicateLightingMushroomForGPEColor(mainContext, settings);
			AddStickToPolylinePhysComponentForSoccerBall(mainContext, settings);

			await Task.CompletedTask;
		}

		public async Task Write(string outPath, bool exportRaw = true) {
			var mainContext = MainContext;
			var settings = NewSettings;
			var exportID = ExportID;
			var projectPath = ProjectPath;
			var basePath = LegendsPath;

			Loader l = mainContext.Loader;
			var structs = l.Context.Cache.Structs;
			var oldSettings = OldSettings;
			var conversionSettings = ConversionSettings;
			// Add locked paths from Legends context
			conversionSettings.LockPaths = true;
			conversionSettings.LockedPaths = LegendsContext.GetSettings<ConversionSettings>().LockedPaths;

			// Step 1: create new paths dictionary
			var ogDir = l.Settings.ITFDirectory;
			var newDir = settings.ITFDirectory;
			var cookedPathMapping = new Dictionary<StringID, Path>();
			var uncookedPathMapping = new Dictionary<StringID, Path>();
			foreach (var structType in structs) {
				foreach (var structMap in structType.Value) {
					var ogPath = l.CookedPaths[structMap.Key];
					if (ogPath.folder != null && ogPath.folder.Contains(ogDir)) {
						cookedPathMapping[structMap.Key] = new Path(ogPath.FullPath.Replace(ogDir, newDir), true);
					} else {
						cookedPathMapping[structMap.Key] = new Path(ogPath.FullPath, true);
					}
					cookedPathMapping[structMap.Key].ConvertPath(conversionSettings);

					uncookedPathMapping[structMap.Key] = new Path(l.Paths[structMap.Key].FullPath, true);
					uncookedPathMapping[structMap.Key].ConvertPath(conversionSettings);
				}
			}
			// Step 2, load uv atlas manager from Legends, and make a list of all entries from Adventures required for the exported level.
			Dictionary<string, UbiArt.UV.UVAtlas> newUVEntries = new Dictionary<string, UbiArt.UV.UVAtlas>();
			using (var rlContextExt = new Context(UnitySettings.GameDirs[Mode.RaymanLegendsPC],
				Settings.FromMode(Mode.RaymanLegendsPC),
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController())) {
				await rlContextExt.Loader.LoadInitial();
				var uvManager = rlContextExt.Loader.uvAtlasManager;

				// For every texture, if there's an entry in the atlas manager, and if that entry isn't in Legends, then add it to "new entries".
				foreach (var tex in structs[typeof(TextureCooked)]) {
					var originalPathID = tex.Key;
					var convertedPath = uncookedPathMapping[originalPathID];
					if (l.uvAtlasManager.atlas.ContainsKey(originalPathID)) {
						if (uvManager.atlas.ContainsKey(convertedPath.stringID) || newUVEntries.ContainsKey(convertedPath.FullPath)) {
							//rlContextExt.SystemLogger?.LogWarning($"Cannot merge UV manager, already contains {convertedPath.stringID}");
						} else {
							newUVEntries[convertedPath.FullPath] = l.uvAtlasManager.atlas[originalPathID];
							//uvManager.atlas[convertedPath.stringID] = l.uvAtlasManager.atlas[curPath.stringID];
						}
					}
				}
			}

			// Step 3, load bundles, for each struct check if it's already present in the bundle, otherwise add it
			using (var rlContext = new Context(basePath, settings,
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController())) {
				await rlContext.Loader.LoadBundles();
				var bun = new UbiArt.Bundle.BundleFile(rlContext);
				var ogBun = rlContext.Loader.Bundles["Bundle"];

				// Add all original files to new bundle
				/*foreach (var f in ogBun.packMaster.files) {
					var fData = await ogBun.GetFile(rlContext, rlContext.Loader.BigFiles["Bundle"].Deserializer, f.Item2);
					bun.AddFile(f.Item2, fData);
				}*/
				// Add new data
				foreach (var structType in structs) {
					foreach (var structMap in structType.Value) {
						var curPath = cookedPathMapping[structMap.Key];
						if (curPath.filename == "localisation.loc8") continue;
						//if (!bun.HasPreprocessedFile(curPath)) {
						if (!rlContext.Loader.AnyBundleContainsFile(curPath)) {
							bun.AddFile(curPath, structMap.Value);
							if (curPath.filename.Contains(".tpl")) {
								Debug.Log($"Added template: {curPath.FullPath}");
							}
						} else {
							/*var p = rlContext.Loader.GetPathFromBundleByStringID(curPath.stringID);
							if (p.FullPath != curPath.FullPath) {
								Debug.LogWarning("StringID mismatch");
							}*/
							if (curPath.filename.Contains(".tpl")) {
								Debug.Log($"Skipped adding template: {curPath.FullPath}");
							}
						}
					}
				}

				// Write bundle
				rlContext.AddSettings<ConversionSettings>(conversionSettings);
				if (exportRaw) {
					await rlContext.Loader.WriteFilesRaw(outPath, bun);
				} else {
					await rlContext.Loader.WriteBundle(outPath, bun);
				}
			}

			// Write atlas list
			if (newUVEntries.Any()) {
				string exportFile = System.IO.Path.Combine(projectPath, "json", "atlascontainer", $"{exportID}.json");
				System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
				System.IO.File.WriteAllText(exportFile, JsonConvert.SerializeObject(newUVEntries, Formatting.Indented));
				Debug.Log($"Exported json: {exportFile}");
			}
			// Write list of wwise files required by this map
			if (conversionSettings.WwiseConversionSettings.UsedEvents.Any()) {
				string exportFile = System.IO.Path.Combine(projectPath, "json", "wwise", $"{exportID}.json");
				System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
				var usedEvents = conversionSettings.WwiseConversionSettings.UsedEvents;
				var usedFiles = usedEvents
					.Select(ue => conversionSettings.WwiseConversionSettings.Events[ue])
					.SelectMany(ue => ue.Actions)
					.SelectMany(ua => ua.Sounds)
					.Select(us => us.Filename)
					.ToList();
				System.IO.File.WriteAllText(exportFile, JsonConvert.SerializeObject(usedFiles, Formatting.Indented));
				Debug.Log($"Exported json: {exportFile}");
			}
		}

		protected Context CreateContext(Mode mode,
			string basePath = null,
			bool enableSerializerLog = true) {
			if (basePath == null) basePath = UnitySettings.GameDirs[mode];

			Context context = new(basePath, Settings.FromMode(mode),
				serializerLogger: enableSerializerLog ? new MapViewerSerializerLogger() : null,
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController());

			return context;

		}


		protected async Task<T> LoadFile<T>(Context context, Path file) where T : class, ICSerializable, new() {
			Path uncookedPath = file;
			T outputObject = default;

			context.Loader.LoadFile<T>(uncookedPath, (t) => outputObject = t);
			await context.Loader.LoadLoop();
			return outputObject;
		}
		protected async Task<T> LoadFileLegends<T>(Path file) where T : class, ICSerializable, new()
			=> await LoadFile<T>(LegendsContext, file);

		public async Task ConvertCostumes(string projectPath, Mode sourceMode) {
			var mainMode = "";
			uint baseLocId = 0;
			if (sourceMode == Mode.RaymanMiniMacOS) {
				mainMode = "mini2";
				baseLocId = 9000;
			} else if (sourceMode == Mode.RaymanAdventuresAndroid || sourceMode == Mode.RaymanAdventuresiOS) {
				mainMode = "adventures2";
				baseLocId = 20000;
			}
			var dataID = $"costumes_{mainMode}";
			Path pGameConfig = new Path("enginedata/gameconfig/gameconfig.isg");
			Path pGameConfigExtended = new Path("enginedata/gameconfigextended/gameconfigextended.isg");
			var levelsJsonPath = System.IO.Path.Combine(projectPath, "json", "levels");
			var dataOutputPath = System.IO.Path.Combine(projectPath, "data", dataID);

			using var rlContextExt = CreateContext(Mode.RaymanLegendsPC);
			await rlContextExt.Loader.LoadInitial();
			rlContextExt.Loader.LoadGenericFile(new Path("enginedata/gameconfig/gameconfig.isg"), isg => {
				rlContextExt.Loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
			});
			await rlContextExt.Loader.LoadLoop();

			Dictionary<string, UbiArt.UV.UVAtlas> newUVEntries = new Dictionary<string, UbiArt.UV.UVAtlas>();

			var rnd = new System.Random();
			int priority = 23;

			UbiArt.Bundle.BundleFile bun = new UbiArt.Bundle.BundleFile();
			List<JSON_LocalisationData> localisationList = new List<JSON_LocalisationData>();
			JSON_LevelsConfig levelsConfig = new JSON_LevelsConfig() {
				Costumes = new List<JSON_CostumeInfo>()
			};

			Dictionary<StringID, string> subskeletonDictionary = new Dictionary<StringID, string>();
			Dictionary<StringID, string> texBankDictionary = new Dictionary<StringID, string>();
			CreateStringIDDictionaries();

			void CreateStringIDDictionaries() {
				void AddSkeletonString(string str) => subskeletonDictionary[new StringID(str)] = str;
				void AddTexBankString(string str) => texBankDictionary[new StringID(str)] = str;
				// General
				AddSkeletonString(null);
				AddTexBankString(null);

				// Rayman subskeletons. Other characters don't have them
				// TODO: There's one other added for adventures
				AddSkeletonString("Naked");
				AddSkeletonString("Knight");
				AddSkeletonString("Basic");
				AddSkeletonString("Splinter");
				AddSkeletonString("Mario");
				AddSkeletonString("Demo");

				// BankIDs
				for (char i = 'a'; i < 'k'; i++) AddTexBankString($"rayman_{i}1");
				for (char i = 'a'; i < 'k'; i++) AddTexBankString($"globox_{i}1");
				for (char i = 'a'; i < 'k'; i++) AddTexBankString($"teensy_{i}1");
				for (char i = 'a'; i < 'k'; i++) AddTexBankString($"barbara_{i}1");


			}
			string GetSubskeleton(StringID sid) => subskeletonDictionary[sid];
			string GetTexBankID(StringID sid) => texBankDictionary[sid];

			uint AddLocalisation(Context c, uint baseID, uint id) {
				var loc = c.Loader.localisation;
				var locales = loc.Locales;
				
				var jsonData = new JSON_LocalisationData() {
					ID = baseID + id,
					Text = new Dictionary<string, string>()
				};
				foreach (var lang in loc.strings) {
					if (lang.Value.ContainsKey(id)) {
						jsonData.Text[locales[lang.Key]] = lang.Value[id].text;
					}
				}

				localisationList.Add(jsonData);
				return jsonData.ID;
			}

			void AddPathToBundle(Path p) {
				if(p != null && !p.IsNull && p.Object != null) bun.AddFile(p.CookedPath(rlContextExt), p.Object);
			}

			using (var sourceContext = CreateContext(sourceMode)) {
				await sourceContext.Loader.LoadInitial();

				RO2_GameConfigExtended_Template gcExtended = null;

				sourceContext.Loader.LoadGenericFile(pGameConfig, isg => {
					sourceContext.Loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
				});
				if (sourceMode == Mode.RaymanAdventuresAndroid || sourceMode == Mode.RaymanAdventuresiOS) {
					sourceContext.Loader.LoadGenericFile(pGameConfigExtended, isg => {
						gcExtended = isg.obj as RO2_GameConfigExtended_Template;
					});
				}
				await sourceContext.Loader.LoadLoop();

				var playerIDInfo = sourceContext.Loader.gameConfig.playerIDInfo.ToList();
				if (gcExtended?.playerIDInfo != null) {
					playerIDInfo.AddRange(gcExtended.playerIDInfo);
				}

				foreach(var skin in playerIDInfo)
				{
					var player = skin.obj as RO2_PlayerIDInfo;
					//if(player.family != "Rayman" && player.family != "Globox" && player.family != "Barbara") continue;
					//if(rlContextExt.Loader.gameConfig.playerIDInfo.Any(c => c.obj.id.ToUpperInvariant() == player.id.ToUpperInvariant())) continue;

					// Load main actor & template
					player.defaultGameScreenInfo.actors[0].file.LoadObject(sourceContext);
					await sourceContext.Loader.LoadLoop();
					var mainActor = player.defaultGameScreenInfo.actors[0].file.GetObject<ContainerFile<UbiArt.ITF.Actor>>();
					var mainPlayerControllerComponent = mainActor.obj.GetComponent<RO2_PlayerControllerComponent>();
					var mainAnimatedComponent = mainActor.obj.GetComponent<AnimatedComponent>();
					
					mainPlayerControllerComponent.trailPath.LoadObject(sourceContext);
					mainActor.obj.LUA.LoadObject(sourceContext);
					await sourceContext.Loader.LoadLoop();

					var tpl = mainActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();
					var tplAnimatedComponent = tpl.obj.GetComponent<AnimatedComponent_Template>();
					var trailTpl = mainPlayerControllerComponent.trailPath.GetObject<GenericFile<Actor_Template>>();

					// Make list of texture banks
					var gameTexBanks = new List<TextureBankPath>();
					gameTexBanks.AddRange(mainAnimatedComponent.subAnimInfo.animPackage.textureBank);
					foreach (var tb in tplAnimatedComponent.animSet.animPackage.textureBank) {
						if(!gameTexBanks.Any(t => t.id == tb.id)) gameTexBanks.Add(tb);
					}
					Dictionary<string, JSON_CostumeInfo.JSON_TextureBank> jsonTexBanks = new Dictionary<string, JSON_CostumeInfo.JSON_TextureBank>();
					foreach (var tb in gameTexBanks) {
						//UnityEngine.Debug.Log($"{player.id} - {GetTexBankID(tb.id)}");
						jsonTexBanks[GetTexBankID(tb.id)] = new JSON_CostumeInfo.JSON_TextureBank() {
							PBK = tb.patchBank?.FullPath,
							Diffuse = tb.textureSet?.diffuse?.FullPath,
							Backlight = tb.textureSet?.back_light?.FullPath,

							GameBank = tb
						};
					}
					if (jsonTexBanks.Any()) {
						var packBank = jsonTexBanks.FirstOrDefault().Value;
						if (jsonTexBanks.Any(tb => tb.Value.PBK != packBank.PBK || tb.Value.Diffuse != packBank.Diffuse || tb.Value.Backlight != packBank.Backlight)) {
							packBank = null;
						}
						if (packBank != null) {
							jsonTexBanks.Clear();
							jsonTexBanks.Add("pack", packBank);
						}
					}

					void ResolveBank(TextureBankPath tb) {
						tb.patchBank?.LoadObject(sourceContext);
						tb.textureSet?.diffuse?.LoadObject(sourceContext);
						tb.textureSet?.back_light?.LoadObject(sourceContext);
					}
					void AddBankToBundle(TextureBankPath tb) {
						AddPathToBundle(tb.patchBank);
						AddPathToBundle(tb.textureSet?.diffuse);
						AddPathToBundle(tb.textureSet?.back_light);
					}

					string GetRandomCostumeAnimation() {
						var family = player.family.ToLowerInvariant();
						int count = family switch {
							"rayman" => 7,
							"globox" => 6,
							"teensy" => 11,
							"barbara" => 10,
							_ => throw new NotImplementedException($"Invalid family {player.family}")
						};
						int selection = rnd.Next(1, count+1);
						return $"costume_{selection:D2}";
					}

					var playerJSON = new JSON_CostumeInfo() {
						CostumeID = player.id,
						NameID = AddLocalisation(sourceContext, baseLocId, player.lineIdName),
						DescriptionID = AddLocalisation(sourceContext, baseLocId, player.lineIdDescription),
						Family = player.family,
						ScoreHudID = player.defaultGameScreenInfo.actors[1].file.filename.Replace("scorehud_","").Replace(".act",""),
						MoskitoID = player.id.ToLowerInvariant().Replace("rayman", "ray").Replace("globox", "glob"),
						DuckID = player.id.ToLowerInvariant(),

						IconPath = player.iconTexturePath.FullPath,
						IconSize = player.iconSizeInTexture,
						DeathBubbleColor = player.deathBubbleColor,

						Painting = new JSON_CostumeInfo.JSON_CostumePainting() {
							BackgroundColor = player.deathBubbleColor, //new UbiArt.Color(0, 0, 0, 1), // TODO
							LevelDependency = null,
							Priority = priority++,
							Unlockable = false,
							Animation = GetRandomCostumeAnimation(),
						},
						CostumeType = RO2_CostumeDescriptor_Template.CostumeType2.Regular,

						Lock = new JSON_LockData() {
							LockCount = 0,
							LockType = RO2_GameManagerConfig_Template.LockDataClass.MapLockType.None,
						},

						SubSkeleton = GetSubskeleton(mainAnimatedComponent.subSkeleton),

						DuckType = JSON_CostumeInfo.JSON_DuckType.Normal,

						TextureBanks = jsonTexBanks,

						TrailColor = trailTpl.obj.GetComponent<TextureGraphicComponent_Template>().defaultColor,

					};
					levelsConfig.Costumes.Add(playerJSON);

					// Load all assets to be exported
					if (jsonTexBanks != null) {
						foreach (var tb in jsonTexBanks) {
							ResolveBank(tb.Value.GameBank);
						}
					}
					player.iconTexturePath.LoadObject(sourceContext);
					await sourceContext.Loader.LoadLoop();

					// Add atlas entry for icon texture
					if (sourceContext.Loader.uvAtlasManager.atlas.ContainsKey(player.iconTexturePath.stringID)) {
						newUVEntries[player.iconTexturePath.FullPath] = sourceContext.Loader.uvAtlasManager.atlas[player.iconTexturePath.stringID];
					}

					// Add all assets to be exported to bundle
					if (jsonTexBanks != null) {
						foreach (var tb in jsonTexBanks) {
							AddBankToBundle(tb.Value.GameBank);
						}
					}
					AddPathToBundle(player.iconTexturePath);
				}

			}

			if (!bun.IsEmpty) {
				await rlContextExt.Loader.WriteFilesRaw(dataOutputPath, bun);
				Debug.Log($"Exported data: {dataOutputPath}");
			}

			// Write atlas list
			if (newUVEntries.Any()) {
				string exportFile = System.IO.Path.Combine(projectPath, "json", "atlascontainer", $"{dataID}.json");
				System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
				System.IO.File.WriteAllText(exportFile, JsonConvert.SerializeObject(newUVEntries, Formatting.Indented));
				Debug.Log($"Exported json: {exportFile}");
			}

			// Write localisation
			if (localisationList.Any()) {
				var exportFile = System.IO.Path.Combine(projectPath, "json", "localisation", $"localisation_{dataID}.json");
				System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
				System.IO.File.WriteAllText(exportFile, JsonConvert.SerializeObject(localisationList, Formatting.Indented));
				Debug.Log($"Exported json: {exportFile}");
			}

			// Write levels config
			if (levelsConfig.Costumes.Any()) {
				var exportFile = System.IO.Path.Combine(projectPath, "json", "levels", $"{dataID}.json");
				System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
				System.IO.File.WriteAllText(exportFile, JsonConvert.SerializeObject(levelsConfig, Formatting.Indented));
				Debug.Log($"Exported json: {exportFile}");
			}
		}

		public async Task<WwiseConversionSettings> LoadWwiseConfig(Context context, string projectPath) {
			var inPath = System.IO.Path.Combine(projectPath, "wwise");

			JSON_WwiseInfo wwiseInfo = null;

			var wwiseName = context.Settings.Game == Game.RA ? "adventures" : "mini";
			var json = System.IO.File.ReadAllText(System.IO.Path.Combine(inPath, $"sounds_{wwiseName}.json"));
			wwiseInfo = JsonConvert.DeserializeObject<JSON_WwiseInfo>(json);

			// Create dictionaries for better performance
			Dictionary<long, JSON_WwiseEvent> wwiseEventsLookup = new Dictionary<long, JSON_WwiseEvent>();
			Dictionary<long, JSON_WwiseAction> wwiseActionsLookup = new Dictionary<long, JSON_WwiseAction>();
			Dictionary<long, WwiseConversionSettings.Action> wwiseActionsClassesLookup = new Dictionary<long, WwiseConversionSettings.Action>();
			foreach (var ev in wwiseInfo.Events) {
				wwiseEventsLookup[ev.ID] = ev;
			}
			foreach (var act in wwiseInfo.Actions) {
				wwiseActionsLookup[act.ID] = act;
			}

			var conversionSettings = new WwiseConversionSettings();
			WwiseConversionSettings.Curve CreateCurve(JSON_WwiseCurve curve) {
				if(curve == null) return null;
				return new WwiseConversionSettings.Curve() {
					Points = curve.Points.Select(p => new WwiseConversionSettings.CurvePoint() {
						X = p.X,
						Y = p.Y
					}).ToArray()
				};
			}
			foreach (var att in wwiseInfo.Attenuations) {
				conversionSettings.Attenuations.Add(att.ID, new WwiseConversionSettings.Attenuation() {
					Volume = CreateCurve(att.Volume),
					Spread = CreateCurve(att.Spread),
				});
			}

			GenericFile<CSerializable> soundConfigISG = null;

			context.Loader.LoadGenericFile(new Path("enginedata/gameconfig/soundconfig.isg"), (isg) => soundConfigISG = isg);
			await context.Loader.LoadLoop();

			var soundConfig = (SoundConfig_Template)(soundConfigISG.obj);
			foreach (var entry in wwiseActionsLookup) {
				var wwiseID = entry.Key;
				var busWwiseID = entry.Value.BusID;
				var wwiseBusItem = soundConfig.WwiseLookUpTable.FirstOrDefault(w => w.ID == busWwiseID);
				var act = new WwiseConversionSettings.Action() {
					ID = entry.Value.ID,
					ExtID = entry.Value.ExtID,
					IsLoop = entry.Value.IsLoop,
					IsStop = entry.Value.IsStop,
					MaxInstances = entry.Value.MaxInstances > 0 ? ((long?)entry.Value.MaxInstances) : null,
					KillNewest = entry.Value.KillNewest,
					IsSequence = entry.Value.IsSequence,
					AvoidRepeat = entry.Value.AvoidRepeatCount > 0,
					Attenuation = entry.Value.Attenuation,
					Bus = wwiseBusItem?.name,
					Sounds = entry.Value.Sounds.Select(s => new WwiseConversionSettings.Sound() {
						Filename = $"sound/wwise/{s.Filename}"
					}).ToList()
				};
				if (entry.Value.Properties != null) {
					foreach (var prop in entry.Value.Properties.Properties) {
						act.Properties.Add(new WwiseConversionSettings.Property() {
							Name = prop.Name,
							Value = prop.Value
						});
					}
					foreach (var prop in entry.Value.Properties.RangedProperties) {
						act.RangedProperties.Add(new WwiseConversionSettings.RangedProperty() {
							Name = prop.Name,
							Min = prop.Min,
							Max = prop.Max
						});
					}
				}
				wwiseActionsClassesLookup.Add(act.ID, act);
			}
			foreach (var entry in wwiseEventsLookup) {
				var wwiseID = entry.Key;
				var wwiseItem = soundConfig.WwiseLookUpTable.FirstOrDefault(w => w.ID == wwiseID);

				var ev = new WwiseConversionSettings.Event() {
					Item = wwiseItem,
					Name = entry.Value.Name
				};
				foreach (var a in entry.Value.Actions) {
					if(wwiseActionsClassesLookup.ContainsKey(a)) ev.Actions.Add(wwiseActionsClassesLookup[a]);
				}
				conversionSettings.Events.Add(ev.Item.GUID, ev);
			}

			return conversionSettings;
		}

		#region Specific adjustments
		public void LevelSpecificChanges(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var loadedScenes = structs[typeof(ContainerFile<Scene>)];
			var loadedScene = loadedScenes.FirstOrDefault(s => ((ContainerFile<Scene>)s.Value).obj == scene);
			var scenePath = l.Paths[loadedScene.Key];

			switch (scenePath.FullPath) {
				case "world/rlc_dojo/festivalofspeed/dojo_festivalofspeed_nmi.isc": {
						ZiplineToRope_OnlyLeft(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_dojo/iseethelight/dojo_iseethelight_lum_base.isc": {
						ZiplineToRope_OnlyLeft(oldContext, newSettings, scene);

						// Fix ungrabbable lum chains
						List<string> userFriendly = new List<string>() {
							"lumschain@2", "lumschain@4","lumschain@5", // 3 combined lum chains
							"lumschain", "lumschain@6", "lumschain@8", "lumschain@9", "lumschain@10", "lumschain@11", "lumschain@12", "lumschain@13", // At end
						};
						foreach (var lc in userFriendly) {
							FixOneLumsChainSpawnMode(oldContext, newSettings, scene.FindActor(a => a.USERFRIENDLY == lc).Result);
						}
						var lumKingLink = scene.FindActor(a => a.USERFRIENDLY == "lumking").Result.GetComponent<LinkComponent>();
						List<string> endLums = new List<string>() {
							"lumschain", "lumschain@6", "lumschain@8", "lumschain@9", "lumschain@10", "lumschain@11", "lumschain@12", "lumschain@13", // At end
						};
						foreach (var endLum in endLums) {
							lumKingLink.Children.Add(new ChildEntry() {
								Path = new ObjectPath() {
									id = endLum,
									levels = new CListO<ObjectPath.Level>() {
										new ObjectPath.Level() {
											name = "grp@4"
										}
									}
								}
							});
						}
						break;
					}
				case "world/rlc_enchantedforest/overgrowncastle/enchantedforest_overgrowncastle_exp_base.isc": {
						var path = new Path("world/common/breakable/lumsjar/components/lumjar_nocol_nophys.tpl");
						var breakables = scene.FindActors(a => a.LUA == path);
						foreach (var b in breakables) {
							FixLumJarNoPhys(oldContext, b.Result);
						}
						break;
					}
				case "world/rlc_nemo/missionimprobable/nemo_missionimprobable_nmi_base.isc": {
						// Move trigger a bit. This one doesn't trigger on retries, I think because Rayman spawns inside it rather than "entering" it.
						// ActivatedOnGo also doesn't exxist in Legends.
						var pickableTree = new PickableTree(scene);
						var triggerNode = pickableTree.FollowObjectPath(new ObjectPath("jewelthief_ld|trigger_box_once@12"));
						var trigger = triggerNode.Pickable as Actor;
						trigger.SCALE = new Vec2d(2f,2f);
						trigger.POS2D = new Vec2d(94.22f, 14.86f);
						var trig = trigger.GetComponent<TriggerComponent>();
						trig.mode = TriggerComponent.Mode.Multiple;
						trig.activatedOnGo = false;
						break;
					}
				case "world/rlc_beanstalk/lumwaterslide/beanstalk_lumwaterslide_lum_base.isc":
				case "world/rlc_beanstalk/lumwaterslide/beanstalk_lumwaterslide_lum_clusters.isc":
				case "world/rlc_beanstalk/beanvillage/beanstalk_beanvillage_exp_base.isc": {
						var clearColor = scene.FindActor(a => a.USERFRIENDLY.StartsWith("clearcolo"));
						var rp = clearColor.Result.GetComponent<RenderParamComponent>();
						var ogColor = rp.Lighting.GlobalColor;
						var mul = 0.7f;
						var alphaMul = 1f;
						rp.Lighting.GlobalColor = new UbiArt.Color(ogColor.r * mul, ogColor.g * mul, ogColor.b * mul, ogColor.a * alphaMul);
						break;
					}
				case "world/rlc_nemo/pollutedbay/nemo_pollutedbay_nmi_base.isc": {
						// There's a toad that usually gets stuck in the floor and dies offscreen. Move it up a unit to fix it
						var disappearingToad = scene.FindActor(a => a.USERFRIENDLY == "basictoad_nemo@1");
						disappearingToad.Result.POS2D = disappearingToad.Result.POS2D + new Vec2d(0f, 1f);
						break;
					}
				case "world/rlc_dojo/forbiddencity/dojo_forbiddencity_exp_base.isc": {
						AllSMVToFrise(oldContext, scene);
						break;
					}
				case "world/rlc_castle/ghostclusters/hauntedcastle_ghostclusters_nmi_base.isc": {
						AllSMVToFrise(oldContext, scene);
						break;
					}
				/*case "world/rlc_nemo/lumelevator/nemo_lumelevator_lum_base.isc": {
						AllSMVToFrise(oldContext, scene);
						break;
					}*/
				case "world/rlc_dojo/rooftoprumble/dojo_rooftoprumble_nmi_base.isc": {
						ApplySpecialRenderParamsToScene(scene);
						break;
					}
			}
		}

		public void ApplySpecialRenderParamsToScene(Scene scene, RenderParamComponent rp = null) {
			if (rp == null) {
				// Find first RenderParam in scene
				rp = scene.FindActor(a => a.GetComponent<RenderParamComponent>() != null).Result.GetComponent<RenderParamComponent>();
			}
			var globalStaticFog = rp.Lighting.GlobalStaticFog;
			var globalBrightness = rp.Lighting.GlobalBrightness;
			var globalFogOpacity = rp.Lighting.GlobalFogOpacity;

			void ApplyToPrimitiveParameters(GFXPrimitiveParam pp) {
				if (pp.UseGlobalLighting) {
					if (pp.useStaticFog) {
						pp.colorFog = /*pp.colorFactor * globalStaticFog*/ globalStaticFog * new UbiArt.Color(1, 1, 1, ((globalFogOpacity + 1f) / 2f));
					}
					pp.FrontLightBrightness = globalBrightness;
				}
			}

			/*var animatedActors = scene.FindActors(a => a.GetComponent<AnimLightComponent>() != null);
			foreach (var act in animatedActors) {
				var anim = act.Result.GetComponent<AnimLightComponent>();
				if(anim.PrimitiveParameters == null) anim.PrimitiveParameters = new GFXPrimitiveParam();
				ApplyToPrimitiveParameters(anim.PrimitiveParameters);
			}*/
			var graphicActors = scene.FindActors(a => a.GetComponent<GraphicComponent>() != null);
			foreach (var act in graphicActors) {
				var graphicsComponents = act.Result.GetComponents<GraphicComponent>();
				foreach (var gc in graphicsComponents) {
					if (gc.PrimitiveParameters == null) gc.PrimitiveParameters = new GFXPrimitiveParam();
					ApplyToPrimitiveParameters(gc.PrimitiveParameters);
				}
			}
			var frises = scene.FindPickables(p => p is Frise f && f.PrimitiveParameters.UseGlobalLighting);
			foreach (var f in frises) {
				var fr = (Frise)f.Result;
				if (fr.PrimitiveParameters == null) fr.PrimitiveParameters = new GFXPrimitiveParam();
				ApplyToPrimitiveParameters(fr.PrimitiveParameters);
			}
		}

		public void FixAllUTurnAnimations(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			// Note: Caused by UTurn animation having extra unflipped frames after UTurn AnimGameplayEvent event (0xB3EF049E) not supported in Legends
			// Stop event = 0xD42CA04D
			var structs = oldContext.Cache.Structs;
			var anims = structs[typeof(AnimTrack)];
			if (anims == null) return;

			var flipMarker = new StringID(0xB3EF049E);
			var stopMarker = new StringID(0xD42CA04D);
			bool IsFlip(AnimTrackFrameEvents.AnimMarkerEvent e) => e.type == AnimTrackFrameEvents.AnimMarkerEvent.AnimMarkerEventType.AnimGameplayEvent && e.marker == flipMarker;
			bool IsStop(AnimTrackFrameEvents.AnimMarkerEvent e) => e.type == AnimTrackFrameEvents.AnimMarkerEvent.AnimMarkerEventType.AnimAnimationEvent && e.marker == stopMarker;

			foreach (var animPair in anims) {
				var anim = animPair.Value as AnimTrack;
				if (anim.frameEvents != null) {
					var frameFlip = anim.frameEvents.FirstOrDefault(f => f.events?.Any(e => IsFlip(e)) ?? false);
					if(frameFlip == null) continue;
					var frameStop = anim.frameEvents.FirstOrDefault(f => f.events?.Any(e => IsStop(e)) ?? false);
					if(frameStop == null) continue;
					if(frameFlip.frame != frameStop.frame - 1) continue;

					// Remove flip event
					frameFlip.events = new CListO<AnimTrackFrameEvents.AnimMarkerEvent>(frameFlip.events.Where(e => !IsFlip(e)).ToList());
					// Add stop events to flip frame
					foreach (var ev in frameStop.events) {
						frameFlip.events.Add(ev);
					}
					// Remove stop frame
					anim.frameEvents = new CListO<AnimTrackFrameEvents>(anim.frameEvents.Where(f => f != frameStop).ToList());
				}
			}
		}

		public void FixCameraModifierBlend(Context oldContext, Settings newSettings) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if (actorTemplates == null) return;
			foreach (var tplPair in actorTemplates) {
				var tpl = tplPair.Value as GenericFile<Actor_Template>;
				var CM = tpl?.obj?.GetComponent<CameraModifierComponent_Template>();
				if (CM != null) {
					CM.CM.modifierBlend = 0.006f;
					CM.CM.modifierInertie = 0.82f;
					CM.CM.constraintDelayToActivate = Vec3d.One * 2f;
					CM.CM.constraintDelayToDisable = Vec3d.One * 2f;
				}
			}

		}

		public void FixAspiNetworks(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var l = oldContext.Loader;
			foreach (var act in l.LoadedActors) {
				if(act.GetComponent<RO2_AspiNetworkComponent>() == null) continue;

				var tpl = act.template?.obj;
				if (tpl.GetComponent<BoxInterpolatorComponent_Template>() == null) {
					var tplBoxInterplator = tpl.AddComponent<BoxInterpolatorComponent_Template>();
				}
				if (act.GetComponent<BoxInterpolatorComponent>() == null) {
					var box = act.AddComponent<BoxInterpolatorComponent>();
					box.innerBox = new AABB() {
						MIN = new Vec2d(-100f, -100f),
						MAX = new Vec2d(100f, 100f),
					};
					box.outerBox = box.innerBox;
				}
			}
		}
		public async void FixEnemiesWithShieldUp(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var shieldJacqouillePath = new Path("world/rlc/common/enemy/jacquouille/shieldjacquouille/components/shieldjacquouilleshieldup.tpl");
			var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(shieldJacqouillePath);
			if (tpl != null) {
				var legendsPath = new Path("world/common/enemy/jacquouille/stackjacquouille/components/stackjacquouille_bottom.tpl");
				var newTPL = await LoadFileLegends<GenericFile<Actor_Template>>(legendsPath);

				var btai = newTPL.obj.GetComponent<RO2_EnemyBTAIComponent_Template>();
				btai.disabledPhys = false;
				btai.hitReward = 10; // Match Adventures enemies
				btai.rehitReward = 10;

				// Change original TPL to this modified Legends TPL
				tpl.obj = newTPL.obj;
				tpl.sizeOf = newTPL.sizeOf + 0x10000;

				// Modify all actors to match
				var l = oldContext.Loader;
				foreach (var act in l.LoadedActors.Where(a => a.template == tpl)) {
					act.AddComponent<RO2_DRC_FXGrabComponent>();
				}
			}

			// Toad shieldup
			var shieldToadPath = new Path("world/rlc/common/enemy/toad/shieldtoad/components/shieldtoadshieldup.tpl");
			tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(shieldToadPath);
			if (tpl != null) {
				var animComponent = tpl.obj.GetComponent<AnimatedComponent_Template>();
				var animTree = animComponent.tree;

				if (animTree != null) {
					// We always choose the path where standup input (0x7145406F) should be equal to 1, and make that the only choice 
					void ReplaceNode(int index, BlendTreeNodeTemplate<AnimTreeResult> node) {
						var nodename = animTree.nodes[index].obj.nodeName;
						node.nodeName = nodename;
						animTree.nodes[index] = new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(node);
					}


					// HitReflex uses animation: AF6E8A0B. This is a huge decider that checks what state the toad is in. This is not necessary. Use the "standup" one only. (This needs to be purely 0x0D20E1EA)
					var hitReflexNode = animTree.nodes[6];
					ReplaceNode(6, ((BlendTreeNodeChooseBranch_Template<AnimTreeResult>)((BlendTreeNodeChooseBranch_Template<AnimTreeResult>)hitReflexNode.obj).leafs[1].obj).leafs[1].obj);
					//hitReflexNode.obj.nodeName = new StringID(0xAF6E8A0B);

					var appearGroundNode = animTree.nodes[8]; // Use shield version of appearground only
					ReplaceNode(8, ((BlendTreeNodeChooseBranch_Template<AnimTreeResult>)appearGroundNode.obj).leafs[1].obj);
					//appearGroundNode.obj.nodeName = new StringID(0x75BACA2E);

					// Idle animation (0x6158A88A) should choose the "standup" branch (0xAC4C2BC4) by default
					var idleNode = animTree.nodes[14];
					ReplaceNode(14, ((BlendTreeNodeChooseBranch_Template<AnimTreeResult>)((BlendTreeNodeChooseBranch_Template<AnimTreeResult>)idleNode.obj).leafs[0].obj).leafs[2].obj);
					//idleNode.obj.nodeName = new StringID(0x6158A88A);

					var uturnNode = animTree.nodes[15];
					ReplaceNode(15, ((BlendTreeNodeChooseBranch_Template<AnimTreeResult>)((BlendTreeNodeChooseBranch_Template<AnimTreeResult>)uturnNode.obj).leafs[0].obj).leafs[0].obj);
					//uturnNode.obj.nodeName = new StringID(0xC2FA619D);

					// Transitions:
					// Remove transitions: 0 1 2 3 4 5 6 9 10 11 12
					// Change transition 7:
					// from: idlenode.nodename
					// to: hitreflexnode.nodename
					// and 8: the opposite
					var transition7 = animTree.nodeTransitions[7];
					var transition8 = animTree.nodeTransitions[8];
					var transition13 = animTree.nodeTransitions[13];
					animTree.nodeTransitions = new CListO<BlendTreeTransition_Template<AnimTreeResult>>() {
						transition7, transition8, transition13
					};
					transition7.from = new CArrayO<StringID>() { idleNode.obj.nodeName };
					transition7.to = new CArrayO<StringID>() { hitReflexNode.obj.nodeName };
					transition8.from = transition7.to;
					transition8.to = transition7.from;
				}

				var btTree = tpl.obj.GetComponent<RO2_EnemyBTAIComponent_Template>().behaviorTree;

				// BT: Get rid of RO2_BTActionHitTarget_Template
				// First node in sequence is removeFact. The other one is HitTarget. We want to remove HitTarget
				var hitTargetDecider = (BTDeciderHasFact_Template)btTree.nodes[8].obj;
				var removeFactNode = ((BTSequence_Template)hitTargetDecider.nodes[0].node.obj).nodes[0];
				hitTargetDecider.nodes[0] = removeFactNode;

				var idleDecider1 = (BTDecider_Template)btTree.nodes[0].obj;
				var idleDecider2 = (BTDeciderHasFact_Template)idleDecider1.nodes[2].node.obj;
				idleDecider2.nodes = new CListO<BTNodeTemplate_Ref>() {
					idleDecider2.nodes[2] // Remove shield-related nodes
				};

				//tree.nodes

				/*
				 * BT: HitReflex uses animation: AF6E8A0B. This needs to be purely 0x0D20E1EA
				 * BT: Get rid of:
				 * - RO2_BTActionHitTarget_Template
				 * - RO2_BTActionCovertFromTarget_Template
				 * - the sequence that plays 0xBA3DAC4A (or maybe just set shield to false)
				 * 
				 * */
			}
		}

		public async void FixSwimmingToads(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var swimToadPath = new Path("world/rlc/common/enemy/toad/shootingtoad/shootingtoad_nemo/components/shootingtoad_swim.tpl");
			var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(swimToadPath);
			if (tpl != null) {
				var legendsPath = new Path("world/common/enemy/toad/shootingtoad_underwater/components/shootingtoad_underwater.tpl");
				var newTPL = await LoadFileLegends<GenericFile<Actor_Template>>(legendsPath);

				var btai = newTPL.obj.GetComponent<RO2_EnemyBTAIComponent_Template>();
				//btai.disabledPhys = false;
				btai.hitReward = 10; // Match Adventures enemies
				btai.rehitReward = 10;

				// Change original TPL to this modified Legends TPL
				tpl.obj = newTPL.obj;
				tpl.sizeOf = newTPL.sizeOf + 0x10000;

				// Modify all actors to match
				/*var l = oldContext.Loader;
				foreach (var act in l.LoadedActors.Where(a => a.template == tpl)) {
					act.AddComponent<RO2_DRC_FXGrabComponent>();
				}*/
			}
		}

		public void AllSMVToFrise(Context oldContext, Scene scene, Predicate<Actor> criteria = null) {
			var smvs = scene.FindActors(a => a.GetComponent<StaticMeshVertexComponent>() != null && (criteria?.Invoke(a) ?? true));
			foreach (var smv in smvs) {
				SMVToFriseGroup(oldContext, smv.Result, scene, containingScene: smv.ContainingScene);
			}
		}
		public SubSceneActor SMVToFriseGroup(Context oldContext, Actor smvActor, Scene mainScene, Scene containingScene = null) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var loadedScenes = structs[typeof(ContainerFile<Scene>)];
			var loadedScene = loadedScenes.FirstOrDefault(s => ((ContainerFile<Scene>)s.Value).obj == mainScene);
			var scenePath = l.Paths[loadedScene.Key];

			StaticMeshVertexComponent smv = smvActor.GetComponent<StaticMeshVertexComponent>();
			SubSceneActor friseScene = new SubSceneActor() {
				USERFRIENDLY = smvActor.USERFRIENDLY,
				POS2D = smvActor.POS2D,
				SCALE = smvActor.SCALE,
				ANGLE = smvActor.ANGLE,
				xFLIPPED = smvActor.xFLIPPED,
				parentBind = smvActor.parentBind,
				UPDATEDEPENDENCYLIST = smvActor.UPDATEDEPENDENCYLIST,
				RELATIVEZ = smvActor.RELATIVEZ,
				STARTPAUSE = smvActor.STARTPAUSE,
				INSTANCEDATAFILE = smvActor.INSTANCEDATAFILE,
				USEVIEWFRUSTUMFLAG = smvActor.USEVIEWFRUSTUMFLAG,
				persistenceId = smvActor.persistenceId,

				LUA = new Path("enginedata/actortemplates/subscene.tpl"),

				EMBED_SCENE = true,
				ZFORCED = true,
				SCENE = new UbiArt.Nullable<Scene>(new Scene())
			};
			var scene = friseScene.SCENE.value;

			// Now, we create a frise config based on the SMV's material settting
			var fcg = new GenericFile<FriseConfig>(new FriseConfig() {
				TAGS = new CListP<string>(new List<string>() {
					"frieze"
				}),
				textureConfigs = new CListO<FriseTextureConfig>() {
					new FriseTextureConfig() {
						material = smv.material
					}
				},
				gameMaterial = new Path() // Null, no collision
			});

			int index = 1;
			var pathBase = $"{scenePath.GetFilenameWithoutExtension(fullPath: true, removeCooked: true)}_smvfrieze/";
			var newPath = new Path($"{pathBase}smv_{index}.fcg");
			while (structs[typeof(GenericFile<FriseConfig>)].ContainsKey(newPath.stringID)) {
				// Check the previously exported configs to see if they match

				var otherFCG = l.Context.Cache.Get<GenericFile<FriseConfig>>(newPath);
				if ((otherFCG.obj.textureConfigs?.Count ?? 0) == 1) {
					var texConfig = otherFCG.obj.textureConfigs.FirstOrDefault();
					var mat = texConfig.material;
					if (mat?.shaderPath == smv.material?.shaderPath
						&& mat?.textureSet?.diffuse == smv.material?.textureSet?.diffuse) {
						// The rest will match too, consider this identical
						fcg = otherFCG;
						break;
					}
				}

				index++;
				newPath = new Path($"{pathBase}smv_{index}.fcg");
			}
			if (!structs[typeof(GenericFile<FriseConfig>)].ContainsKey(newPath.stringID)) {
				var newCookedPath = newPath.CookedPath(MainContext);
				l.CookedPaths[newPath.stringID] = newCookedPath;
				l.Paths[newPath.stringID] = newPath;
				structs[typeof(GenericFile<FriseConfig>)][newPath.stringID] = fcg;
			}

			// Now, convert the SMV to a bunch of frises
			foreach (var mesh in smv.staticMeshElements) {
				var fr = new Frise() {
					USERFRIENDLY = mesh.frisePath.id,
					POS2D = new Vec2d(mesh.pos?.x ?? 0, mesh.pos?.y ?? 0),
					RELATIVEZ = mesh.pos?.z ?? 0,
					PrimitiveParameters = (GFXPrimitiveParam)smv.PrimitiveParameters.Clone("isc"),

					PreComputedForCook = true,
					ConfigName = new Path(newPath.FullPath),
				};
				fr.ColorFactor  = fr.ColorFactor * mesh.color;
				
				Vec2d LocalToGlobal(Vec2d point) => (point * fr.SCALE).Rotate(fr.ANGLE) + fr.POS2D;
				Vec3d LocalToGlobal3D(Vec3d point) {
					var v2d = LocalToGlobal(new Vec2d(point.x, point.y));
					return new Vec3d(v2d.x, v2d.y, point.z + fr.RELATIVEZ);
				}
				Vec2d TransformPoint(Vec2d v) => v - fr.POS2D;
				Vec3d TransformPoint3D(Vec3d v) => new Vec3d(v.x - fr.POS2D.x, v.y - fr.POS2D.y, v.z - fr.RELATIVEZ);


				Vec2d totalMin = TransformPoint(new Vec2d(
					mesh.staticVertexList.Min(v => v.pos?.x ?? 0),
					mesh.staticVertexList.Min(v => v.pos?.y ?? 0)));
				Vec2d totalMax = TransformPoint(new Vec2d(
					mesh.staticVertexList.Max(v => v.pos?.x ?? 0),
					mesh.staticVertexList.Max(v => v.pos?.y ?? 0)));

				fr.PointsList = CreatePolyPointList(new Vec2d[] {
						totalMin, new Vec2d(totalMin.x, totalMax.y), totalMax, new Vec2d(totalMax.x, totalMin.y)
					});

				PolyPointList CreatePolyPointList(Vec2d[] vectors, bool loop = true) {
					var points = new PolyPointList() {
						LocalPoints = new CListO<PolyLineEdge>(vectors.Select(p => new PolyLineEdge() {
							POS = p,
							Scale = 1f,
						}).ToList()),
						Loop = loop,
					};
					if (loop) {
						points.LocalPoints.Add(new PolyLineEdge() {
							POS = vectors[0],
							Scale = 1f,
						});
					}
					points.RecomputeData();
					return points;
				}

				if (!mesh.animated) {
					// Mesh is static
					fr.meshBuildData = new UbiArt.Nullable<Frise.MeshBuildData>(new Frise.MeshBuildData() {
						StaticIndexList = new CListO<Frise.IndexList>(),
						StaticVertexList = new CListO<VertexPCT>()
					});
					var indices = mesh.staticIndexList;
					var vertices = mesh.staticVertexList.Select(v => new VertexPCT() {
						pos = TransformPoint3D(v.pos),
						color = v.color,
						uv = v.uv1
					});
					fr.meshBuildData.value.StaticIndexList = new CListO<Frise.IndexList>(
						new List<Frise.IndexList>() {
							new Frise.IndexList() {
								IdTexConfig = 0,
								List = new CListP<ushort>(indices.ToList())
							}
						}
					);
					fr.meshBuildData.value.StaticVertexList = new CListO<VertexPCT>(vertices.ToList());

					// Fill in meshStaticAABB based on visual data
					if (fr.meshBuildData.value?.StaticVertexList?.Any() ?? false) {
						fr.meshStaticData = new UbiArt.Nullable<Frise.MeshStaticData>(new Frise.MeshStaticData() {
							LocalAABB = new AABB() {
								MIN = new Vec2d(fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.y)),
								MAX = new Vec2d(fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.y))
							},
							WorldAABB = new AABB() {
								//MIN = new Vec2d(float.NegativeInfinity, float.NegativeInfinity),
								//MAX = new Vec2d(float.PositiveInfinity, float.PositiveInfinity),
								MIN = new Vec2d(fr.meshBuildData.value.StaticVertexList.Min(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.StaticVertexList.Min(v => LocalToGlobal3D(v.pos).y)),
								MAX = new Vec2d(fr.meshBuildData.value.StaticVertexList.Max(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.StaticVertexList.Max(v => LocalToGlobal3D(v.pos).y))
							},
						});
						fr.AABB_MinZ = fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.z);
						fr.AABB_MaxZ = fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.z);
					}
				} else {
					// Mesh is animated
					fr.meshBuildData = new UbiArt.Nullable<Frise.MeshBuildData>(new Frise.MeshBuildData() {
						AnimIndexList = new CListO<Frise.IndexList>(),
						AnimVertexList = new CListO<VertexPNC3T>()
					});
					var indices = mesh.staticIndexList;
					var vertices = mesh.staticVertexList.Select(v => new VertexPNC3T() {
						pos = TransformPoint3D(v.pos),
						color = v.color,
						uv1 = v.uv1,
						uv2 = v.uv2,
						uv3 = v.uv3,
						uv4 = v.uv4,
					});
					fr.meshBuildData.value.AnimIndexList = new CListO<Frise.IndexList>(
						new List<Frise.IndexList>() {
							new Frise.IndexList() {
								IdTexConfig = 0,
								List = new CListP<ushort>(indices.ToList())
							}
						}
					);
					fr.meshBuildData.value.AnimVertexList = new CListO<VertexPNC3T>(vertices.ToList());

					// Fill in meshAnimAABB based on visual data
					if (fr.meshBuildData.value?.AnimVertexList?.Any() ?? false) {
						fr.meshAnimData = new UbiArt.Nullable<Frise.MeshAnimData>(new Frise.MeshAnimData() {
							LocalAABB = new AABB() {
								MIN = new Vec2d(fr.meshBuildData.value.AnimVertexList.Min(v => v.pos.x), fr.meshBuildData.value.AnimVertexList.Min(v => v.pos.y)),
								MAX = new Vec2d(fr.meshBuildData.value.AnimVertexList.Max(v => v.pos.x), fr.meshBuildData.value.AnimVertexList.Max(v => v.pos.y))
							},
							WorldAABB = new AABB() {
								//MIN = new Vec2d(float.NegativeInfinity, float.NegativeInfinity),
								//MAX = new Vec2d(float.PositiveInfinity, float.PositiveInfinity),
								MIN = new Vec2d(fr.meshBuildData.value.AnimVertexList.Min(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.AnimVertexList.Min(v => LocalToGlobal3D(v.pos).y)),
								MAX = new Vec2d(fr.meshBuildData.value.AnimVertexList.Max(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.AnimVertexList.Max(v => LocalToGlobal3D(v.pos).y))
							},
						});
						fr.AABB_MinZ = fr.meshBuildData.value.AnimVertexList.Min(v => v.pos.z);
						fr.AABB_MaxZ = fr.meshBuildData.value.AnimVertexList.Max(v => v.pos.z);
					}
				}

				scene.AddActor(fr, fr.USERFRIENDLY);
			}




			if (containingScene != null) {
				containingScene.DeletePickable(smvActor);
				containingScene.AddActor(friseScene, friseScene.USERFRIENDLY);
			}

			return friseScene;
		}

		public void FixTeensies(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var teensyPath = new Path("world/common/friendly/bt_friendly/teensy/components/teensy.tpl");

			var l = oldContext.Loader;
			foreach (var act in l.LoadedActors) {
				if (!(act.STARTPAUSE && act.GetComponent<RO2_FriendlyBTAIComponent>()?.prisonerType == RO2_FriendlyBTAIComponent.Enum_prisonerType.Pole)) continue;
				act.STARTPAUSE = false;
			}

			var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(teensyPath);
			if (tpl != null) {
				var btai = tpl.obj.GetComponent<RO2_FriendlyBTAIComponent_Template>();
				var nodes = btai.behaviorTree.nodes;
				foreach (var node in nodes) {
					switch (node?.obj) {
						case RO2_BTActionPrisonerRope_Template rope:
							if(rope.countLumsReward == 100) rope.countLumsReward = 25;
							break;
						case RO2_BTActionPrisonerCage_Template cage:
							if(cage.countLumsReward == 100) cage.countLumsReward = 25;
							break;
						case RO2_BTActionPrisonerPole_Template pole:
							if(pole.countLumsReward == 100) pole.countLumsReward = 25;
							break;
						case RO2_BTActionPrisonerTorture_Template torture:
							if(torture.countLumsReward == 100) torture.countLumsReward = 25;
							break;
					}
				}
			}
		}
		public void PerformHangSpotWorkaround(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var hangspots = scene.FindActors(a => a.GetComponent<RO2_HangSpotComponent>() != null);
			foreach (var res in hangspots) {
				var act = res.Result;
				var tpl = act.template?.obj;
				var hangspotTPL = tpl.GetComponent<RO2_HangSpotComponent_Template>();
				var hangspotLinks = act.GetComponent<LinkComponent>();
				if (hangspotTPL != null && !hangspotTPL.allowOneHangOnly && (hangspotLinks?.Children?.Any() ?? false)) {
					Actor CreateHangRelay(string suffix, Generic<UbiArt.ITF.Event> listenEvent, Generic<UbiArt.ITF.Event> relayEvent, bool once) {
						var newPath = new Path(act.LUA.FullPath.Replace(".tpl", $"_{suffix}.tpl"));
						var newCookedPath = new Path(l.CookedPaths[act.LUA.stringID].FullPath.Replace(".tpl", $"_{suffix}.tpl"), true);
						var relay = new Actor() {
							LUA = newPath,
							USERFRIENDLY = $"{act.USERFRIENDLY}_{suffix}",
							POS2D = act.POS2D
						};
						l.AddLoadedActor(relay);
						var links = relay.AddComponent<LinkComponent>();
						links.Children = new CListO<ChildEntry>(hangspotLinks.Children.ToList());

						if (once) {
							// If it can only occur once, we have to abuse a TweenComponent and set the template to STARTPAUSED.
							// We make sure the tweening autostarts and is limited to 1 iteration.
							// Then, we set the template to STARTPAUSED, this way we can control when it starts.
							var tween = relay.AddComponent<TweenComponent>();
							tween.startSet = new StringID("Set");
							tween.instructionSets = new CListO<TweenComponent.InstructionSet>() {
								new TweenComponent.InstructionSet() {
									name = new StringID("Set"),
									instructions = new CArrayO<Generic<TweenInstruction>>() {
										new Generic<TweenInstruction>(new TweenEvent())
									}
								}
							};
						} else {
							// If the event can occur multiple times, we can simply relay the event
							relay.AddComponent<RelayEventComponent>();
						}

						if (CreateTemplateIfNecessary(newPath, "HANG", out var newTPLContainer, relay)) {
							var newTPL = newTPLContainer.obj;

							newTPL.AddComponent<LinkComponent_Template>();
							if (once) {
								newTPL.STARTPAUSED = true;
								var tweenTPL = newTPL.AddComponent<TweenComponent_Template>();
								tweenTPL.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
									new TweenComponent_Template.InstructionSet() {
										name = new StringID("Set"),
										iterationCount = 1,
										instructions = new CListO<Generic<TweenInstruction_Template>>() {
											new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
												triggerSelf = false,
												triggerChildren = true,
												_event = relayEvent,
											})
										}
									}
								};
							} else {
								var relayTPL = newTPL.AddComponent<RelayEventComponent_Template>();
								relayTPL.relays = new CListO<RelayData>(new List<RelayData>() {
									new RelayData() {
										triggerChildren = true,
										triggerSelf = false,
										eventToListen = listenEvent,
										eventToRelay = relayEvent
									},
								});
								if (once) {
									relayTPL.relays.Add(new RelayData() {
										triggerSelf = true,
										triggerChildren = false,
										eventToListen = new Generic<UbiArt.ITF.Event>(new EventPause() {
											pause = true
										}),
										eventToRelay = new Generic<UbiArt.ITF.Event>(new EventPause() {
											pause = true
										})
									});
								}
							}
						}
						res.ContainingScene.AddActor(relay, relay.USERFRIENDLY);

						return relay;
					}

					List<Actor> createdRelays = new List<Actor>();
					if ((hangspotTPL.hangEventTriggerOnce && hangspotTPL.onHangEvent?.obj != null)
						|| (hangspotTPL.unHangEventTriggerOnce && hangspotTPL.onUnhangEvent?.obj != null)) {
						// We use nonsensical hang events, if we use a relay (i.e. when not "once") this can be captured easily and "converted" into the actual event
						// We can't just use the original events here because Relay doesn't recognize the parameters (e.g. trigger event on/off)
						var newHangEvent = new Generic<UbiArt.ITF.Event>(new RO2_EventCommandAttackStart());
						var newUnhangEvent = new Generic<UbiArt.ITF.Event>(new RO2_EventCommandAttackStop());
						// If the event should only be sent once, we use a different approach with a TweenComponent that autostarts when unpaused.
						// So the hang events should become unpause events in that case.
						if(hangspotTPL.hangEventTriggerOnce)
							newHangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventPause() { pause = false });
						if (hangspotTPL.unHangEventTriggerOnce)
							newUnhangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventPause() { pause = false });

						var relay = CreateHangRelay("relay_hang", newHangEvent, hangspotTPL.onHangEvent, hangspotTPL.hangEventTriggerOnce);
						createdRelays.Add(relay);
						relay = CreateHangRelay("relay_unhang", newUnhangEvent, hangspotTPL.onUnhangEvent, hangspotTPL.unHangEventTriggerOnce);
						createdRelays.Add(relay);

						// Moved to TPLFix function called way later in the process
						//hangspotTPL.onHangEvent = newHangEvent;
						//hangspotTPL.onUnhangEvent = newUnhangEvent;
					}
					if (createdRelays.Any()) {
						hangspotLinks.Children = new CListO<ChildEntry>();
						foreach (var r in createdRelays) {
							hangspotLinks.Children.Add(new ChildEntry() {
								Path = new ObjectPath(r.USERFRIENDLY)
							});
						}
					}
				}
			}

		}

		public void AddRelayToMushrooms(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var mushrooms = scene.FindActors(a => a.GetComponent<RO2_LightingMushroomComponent>() != null);
			foreach (var res in mushrooms) {
				var act = res.Result;
				var tpl = act.template?.obj;
				var mushroomComponent = act.GetComponent<RO2_LightingMushroomComponent>();
				var mushroomTPL = tpl.GetComponent<RO2_LightingMushroomComponent_Template>();
				var mushroomLinks = act.GetComponent<LinkComponent>();
				var triggerTPL = tpl.GetComponent<TriggerComponent_Template>();
				//var triggerComponent = act.GetComponent<TriggerComponent>();

				bool HasRelayComponent() => act.GetComponent<RelayEventComponent>() != null;//triggerTPL != null && triggerTPL.triggerChildren && triggerTPL.triggerOnHit && !triggerTPL.triggerOnDetector && !triggerTPL.triggerSelf && (triggerTPL.onEnterEvent?.obj is EventTrigger);

				if (mushroomTPL != null && (mushroomLinks?.Children?.Any() ?? false) && !HasRelayComponent()) {

					// Make trigger 
					var ogPath = act.LUA;
					var ogTpl = act.template;
					var suffix = "triggermushroom";
					bool once = mushroomComponent.fireOnce;
					if (once) suffix += "_once";
					if (CloneTemplateIfNecessary(ogPath, suffix, "TRIGGER MUSHROOM", ogTpl, out var newTpl, act)) {
						triggerTPL = newTpl.obj.GetComponent<TriggerComponent_Template>();
						mushroomTPL = newTpl.obj.GetComponent<RO2_LightingMushroomComponent_Template>();
						if (once) {
							mushroomTPL.RestartTimer = float.MaxValue;
						}
						newTpl.sizeOf += 0x10000;
						var rel = newTpl.obj.AddComponent<RelayEventComponent_Template>();
						rel.relays = new CListO<RelayData> {
							new RelayData() {
								eventToListen = new Generic<UbiArt.ITF.Event>(new PunchStim()), // Note: enemies can also send PunchStim!
								eventToRelay = new Generic<UbiArt.ITF.Event>(new EventTrigger() { activated = true }),
								triggerSelf = false,
								triggerChildren = true
							}
						};
					}
					/*if (once) {
						triggerComponent.mode = TriggerComponent.Mode.Once;
					}*/
					act.AddComponent<RelayEventComponent>();


					Actor CreateTween(string suffix, IEnumerable<ChildEntry> links, CListO<Generic<UbiArt.ITF.Event>> events, double distance) {
						var luaPath = new Path("world/common/logicactor/tweening/tweeneditortype/components/tween_notype.tpl");
						var tweenAct = new Actor() {
							LUA = luaPath,
							USERFRIENDLY = $"{act.USERFRIENDLY}_{suffix}",
							POS2D = act.POS2D
						};
						l.AddLoadedActor(tweenAct);
						var tween = tweenAct.AddComponent<TweenComponent>();
						var linkComponent = tweenAct.AddComponent<LinkComponent>();
						linkComponent.Children = new CListO<ChildEntry>(links.ToList());

						tween.startSet = new StringID("Set");
						var instructions = events.Select(e => new Generic<TweenInstruction>(new TweenEvent())).ToList();
						var instructionsTPL = events.Select(e => new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
							triggerSelf = false,
							triggerChildren = true,
							_event = e,
							duration = 0
						})).ToList();
						if (distance > 0) {
							var fireworkSpeed = mushroomTPL.Speed;
							var timeBeforeTrigger = distance / fireworkSpeed;

							if (timeBeforeTrigger > 0) {
								instructions = new List<Generic<TweenInstruction>>() {
									new Generic<TweenInstruction>(new TweenWait())
								}.Concat(instructions).ToList();
								instructionsTPL = new List<Generic<TweenInstruction_Template>>() {
									new Generic<TweenInstruction_Template>(new TweenWait_Template() {
										duration = (float)timeBeforeTrigger
									})
								}.Concat(instructionsTPL).ToList();
							}
						}
						if (once) {
							float waitTimeAfterExplosion = MathF.Max(mushroomTPL.LightingTimer, mushroomTPL.TimeToFade);

							instructions.Add(new Generic<TweenInstruction>(new TweenWait()));
							instructions.Add(new Generic<TweenInstruction>(new TweenEvent()));
							instructionsTPL.Add(new Generic<TweenInstruction_Template>(new TweenWait_Template() {
								duration = waitTimeAfterExplosion
							}));
							instructionsTPL.Add(new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
								triggerSelf = false,
								triggerChildren = false,
								triggerBoundChildren = true,
								_event = new Generic<UbiArt.ITF.Event>(new EventTrigger() { activated = true })
								//triggerChildren = true,
								//_event = new Generic<UbiArt.ITF.Event>(new RO2_EventLightingMushroomExplosion()) // Fitting rubbish event only used by final boss for some reason
							}));
							mushroomComponent.fireOnce = false;
						}

						tween.instructionSets = new CListO<TweenComponent.InstructionSet>() {
							new TweenComponent.InstructionSet() {
								name = new StringID("Set"),
								instructions = new CArrayO<Generic<TweenInstruction>>(instructions.ToArray())
							}
						};
						tween.instanceTemplate = new UbiArt.Nullable<TweenComponent_Template>(new TweenComponent_Template());
						var tpl = tween.instanceTemplate.value;
						tpl.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
							new TweenComponent_Template.InstructionSet() {
								name = new StringID("Set"),
								iterationCount = 1,
								triggable = true,
								instructions = new CListO<Generic<TweenInstruction_Template>>(instructionsTPL)
							}
						};
						tween.autoStart = false;

						res.ContainingScene.AddActor(tweenAct, tweenAct.USERFRIENDLY);

						return tweenAct;
					}
					Actor CreatePauseSwitch(string suffix, Actor parent) {
						var pausePath = new Path("world/common/logicactor/tweening/tweeneditortype/components/tween_notype.tpl");

						var pauseswitch = new Actor() {
							USERFRIENDLY = $"{act.USERFRIENDLY}_{suffix}",
							LUA = pausePath
						};
						if (parent != null) {
							pauseswitch.parentBind = new UbiArt.Nullable<Bind>(new Bind() {
								parentPath = new ObjectPath(parent.USERFRIENDLY),
							});
						}
						l.AddLoadedActor(pauseswitch);


						var tween = pauseswitch.AddComponent<TweenComponent>();
						var linkComponent = pauseswitch.AddComponent<LinkComponent>();
						linkComponent.Children = new CListO<ChildEntry>() {
							new ChildEntry() {
								Path = new ObjectPath(act.USERFRIENDLY) // Link to mushroom actor
							}
						};

						tween.startSet = new StringID("Pause");
						tween.autoStart = false;
						tween.instructionSets = new CListO<TweenComponent.InstructionSet>(new List<TweenComponent.InstructionSet>() {
							new TweenComponent.InstructionSet() {
								name = "Pause",
								instructions = new CArrayO<Generic<TweenInstruction>>(new Generic<TweenInstruction>[] {
									new Generic<TweenInstruction>(new TweenEvent() {
									})
								})
							},
						});
						tween.instanceTemplate = new UbiArt.Nullable<TweenComponent_Template>(new TweenComponent_Template());
						var tpl = tween.instanceTemplate.value;
						tpl.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
							new TweenComponent_Template.InstructionSet() {
								name = new StringID("Pause"),
								iterationCount = 1,
								triggable = true,
								instructions = new CListO<Generic<TweenInstruction_Template>>() {
									new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
										triggerSelf = false,
										triggerChildren = true,
										_event = new Generic<UbiArt.ITF.Event>(new EventShow() {
											alpha = 0f,
											transitionTime = 1f,
											pauseOnEnd = true
										}),
										duration = 0
									})
								}
							}
						};
						res.ContainingScene.AddActor(pauseswitch, pauseswitch.USERFRIENDLY);

						return pauseswitch;
					}
					// Move links to new tween actor
					var explosionIndexTag = new StringID(0xB8E2264A);
					var triggerOnFireTag = new StringID(0xE060828E);

					List<ChildEntry> GetCleanedCopyOfLinks(IEnumerable<ChildEntry> links) {
						var newLinks = links.Select(l => new ChildEntry() {
							Path = l.Path,
							TagValues = new CListO<TagValue>(l.TagValues?.Where(t => t.Tag != explosionIndexTag && t.Tag != triggerOnFireTag).ToList())
						});
						return newLinks.ToList();
					}
					void LinkTween(Actor act) {
						mushroomLinks.Children.Add(new ChildEntry() {
							Path = new ObjectPath(act.USERFRIENDLY)
						});
					}


					var links = mushroomLinks.Children;
					mushroomLinks.Children = new CListO<ChildEntry>();
					var linksOnFire = links.Where(l => l.HasTag(triggerOnFireTag));
					if (linksOnFire.Any()) {
						var tween = CreateTween("tween_onfire", GetCleanedCopyOfLinks(linksOnFire), new CListO<Generic<UbiArt.ITF.Event>>() {
							new Generic<UbiArt.ITF.Event>(new EventTrigger() { activated = true })
						}, 0);
						LinkTween(tween);
					}
					var linksOnExplosion = links.Where(l => !l.HasTag(triggerOnFireTag));
					var tweenDistances = mushroomComponent.MushroomTargets.Select(t => t?.Position?.Magnitude ?? 0).ToArray();
					var maxDistance = tweenDistances.Max();
					int maxDistanceIndex = Array.IndexOf(tweenDistances, maxDistance);

					for (int i = 0; i < mushroomComponent.MushroomTargets.Count; i++) {
						var linksOnExplosion_i = linksOnExplosion.Where(l => 
						(i == 0 && (!l.TryGetTagValue<uint>(explosionIndexTag, out _))) // if target index isn't specified, default to 0
						|| (l.TryGetTagValue<uint>(explosionIndexTag, out uint t) && t == i));

						var tween = CreateTween($"tween_target_{i}", GetCleanedCopyOfLinks(linksOnExplosion_i), new CListO<Generic<UbiArt.ITF.Event>>() {
							new Generic<UbiArt.ITF.Event>(new EventTrigger() { activated = true })
						}, tweenDistances[i]);
						LinkTween(tween);

						if (once && i == maxDistanceIndex) {
							// We're not done yet. Need to create a pauseswitch with the mushroom actor as target
							// And the tween as parentBind
							CreatePauseSwitch("pauseswitch", tween);
						}
					}
				}
			}

		}

		public void PerformHangSpotWorkaround_TPLFix(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if (actorTemplates == null) return;

			foreach (var tplPair in actorTemplates) {
				var tpl = (GenericFile<Actor_Template>)tplPair.Value;
				var hangspotTPL = tpl?.obj?.GetComponent<RO2_HangSpotComponent_Template>();
				if(hangspotTPL == null) continue;


				if ((hangspotTPL.hangEventTriggerOnce && hangspotTPL.onHangEvent?.obj != null)
					|| (hangspotTPL.unHangEventTriggerOnce && hangspotTPL.onUnhangEvent?.obj != null)) {
					// We use nonsensical hang events, if we use a relay (i.e. when not "once") this can be captured easily and "converted" into the actual event
					// We can't just use the original events here because Relay doesn't recognize the parameters (e.g. trigger event on/off)
					var newHangEvent = new Generic<UbiArt.ITF.Event>(new RO2_EventCommandAttackStart());
					var newUnhangEvent = new Generic<UbiArt.ITF.Event>(new RO2_EventCommandAttackStop());
					// If the event should only be sent once, we use a different approach with a TweenComponent that autostarts when unpaused.
					// So the hang events should become unpause events in that case.
					if (hangspotTPL.hangEventTriggerOnce)
						newHangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventPause() { pause = false });
					if (hangspotTPL.unHangEventTriggerOnce)
						newUnhangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventPause() { pause = false });
					
					hangspotTPL.onHangEvent = newHangEvent;
					hangspotTPL.onUnhangEvent = newUnhangEvent;
				}
			}
		}

		public void AddPreInstructionSets(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var structs = oldContext.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if (actorTemplates == null) return;
			var l = oldContext.Loader;

			void ProcessTweenComponent(TweenComponent tween, TweenComponent_Template tpl) {
				if (tween.instructionSets == null) tween.instructionSets = new CListO<TweenComponent.InstructionSet>();
				// Instantiate the preInstructionSets, add them to beginning of instruction sets list
				List<TweenComponent.InstructionSet> preInstructionSets = new List<TweenComponent.InstructionSet>();
				foreach (var pre in tpl.preInstructionSets) {
					var set = new TweenComponent.InstructionSet() {
						name = pre.name
					};
					TweenInstruction InstantiateInstruction(TweenInstruction_Template ctpl) => ctpl?.Instantiate(oldContext);
					set.instructions = new CArrayO<Generic<TweenInstruction>>(pre.instructions.Select(c => new Generic<TweenInstruction>(InstantiateInstruction(c.obj))).ToArray());
					preInstructionSets.Add(set);
				}

				tween.instructionSets = new CListO<TweenComponent.InstructionSet>(preInstructionSets.Concat(tween.instructionSets).ToList());
			}
			void ProcessTweenComponentTPL(TweenComponent_Template tpl) {
				// Link preInstructionSets
				for (int i = 0; i < tpl.preInstructionSets.Count; i++) {
					var set = tpl.preInstructionSets[i];
					var nextSet = (i+1) < tpl.preInstructionSets.Count ? tpl.preInstructionSets[i+1] : tpl.instructionSets.FirstOrDefault();
					if(nextSet == null) continue;
					if(set.nextSet == null || set.nextSet.IsNull) set.nextSet = nextSet.name;
				}
				// Add preInstructionSets to beginning of instruction sets list
				tpl.instructionSets = new CListO<TweenComponent_Template.InstructionSet>(tpl.preInstructionSets.Concat(tpl.instructionSets).ToList());
			}

			// Process every actor template that has TweenComponent
			foreach (var tplPair in actorTemplates) {
				var tpl = tplPair.Value as GenericFile<Actor_Template>;
				if (tpl?.obj == null) continue;
				var tweenComponentTPL = tpl.obj.GetComponent<TweenComponent_Template>();
				if(tweenComponentTPL?.preInstructionSets == null || tweenComponentTPL.preInstructionSets.Count == 0) continue;

				// Found a template that uses preInstructionSets.
				// Now find every actor in the scene that uses this template without instanceTemplate
				var tweenActors = l.LoadedActors.Where(a => a.template?.obj == tpl?.obj);
				foreach (var act in tweenActors) {
					var tweenComponent = act.GetComponent<TweenComponent>();
					if(tweenComponent?.instanceTemplate?.value != null) continue; // Actor uses instance template, leave for later

					ProcessTweenComponent(tweenComponent, tweenComponentTPL);
				}
				ProcessTweenComponentTPL(tweenComponentTPL);
			}

			// Now, same for tween components that use instanceTemplate
			var tweenComponents = l.LoadedActors.Where(a => a.GetComponent<TweenComponent>() != null);
			foreach (var act in tweenComponents) {
				var tweenComponent = act.GetComponent<TweenComponent>();
				var tweenComponentTPL = tweenComponent?.instanceTemplate?.value;
				if(tweenComponentTPL?.preInstructionSets == null || tweenComponentTPL.preInstructionSets.Count == 0)
					continue;

				ProcessTweenComponent(tweenComponent, tweenComponentTPL);
				ProcessTweenComponentTPL(tweenComponentTPL);
			}
		}

		public void AddTriggerMoreEventTweens(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var triggers = scene.FindActors(a => a.GetComponent<TriggerComponent>() != null);
			foreach (var res in triggers) {
				var act = res.Result;
				var triggerComponent = act.GetComponent<TriggerComponent>();
				if(!(triggerComponent.onEnterMoreEvent?.Any() ?? false) && !(triggerComponent.onExitMoreEvent?.Any() ?? false))
					continue;
				var tpl = act.template?.obj;
				var triggerTPL = tpl.GetComponent<TriggerComponent_Template>();
				var triggerLinks = act.GetComponent<LinkComponent>();
				if(!(triggerLinks?.Children?.Any() ?? false))
					continue;

				if (!(triggerTPL.onEnterEvent?.obj is EventTrigger) && (triggerTPL.onExitEvent?.obj != null)) {
					oldContext?.SystemLogger?.LogWarning($"Unexpected moreEvents with trigger template: {act.LUA?.FullPath}");
				}


				if ((triggerComponent.onEnterMoreEvent?.Any() ?? false)) {
					CreateTween("entermoreevent", triggerComponent.onEnterMoreEvent);
				}
				if ((triggerComponent.onExitMoreEvent?.Any() ?? false)) {
					oldContext?.SystemLogger?.LogWarning($"Trigger has exit events: {act.USERFRIENDLY}");
					CreateTween("exitmoreevent", triggerComponent.onExitMoreEvent);
				}

				Actor CreateTween(string suffix, CListO<Generic<UbiArt.ITF.Event>> events) {
					var luaPath = new Path("world/common/logicactor/tweening/tweeneditortype/components/tween_notype.tpl");
					var tweenAct = new Actor() {
						LUA = luaPath,
						USERFRIENDLY = $"{act.USERFRIENDLY}_{suffix}",
						POS2D = act.POS2D
					};
					l.AddLoadedActor(tweenAct);
					var tween = tweenAct.AddComponent<TweenComponent>();
					var links = tweenAct.AddComponent<LinkComponent>();
					links.Children = new CListO<ChildEntry>(triggerLinks.Children.ToList());

					tween.startSet = new StringID("Set");
					var instructions = events.Select(e => new Generic<TweenInstruction>(new TweenEvent())).ToArray();
					var instructionsTPL = events.Select(e => new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
						triggerSelf = false,
						triggerChildren = true,
						_event = e,
						duration = 0
					})).ToList();
					tween.instructionSets = new CListO<TweenComponent.InstructionSet>() {
						new TweenComponent.InstructionSet() {
							name = new StringID("Set"),
							instructions = new CArrayO<Generic<TweenInstruction>>(instructions)
						}
					};
					tween.instanceTemplate = new UbiArt.Nullable<TweenComponent_Template>(new TweenComponent_Template());
					var tpl = tween.instanceTemplate.value;
					tpl.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
						new TweenComponent_Template.InstructionSet() {
							name = new StringID("Set"),
							iterationCount = 1,
							triggable = true,
							instructions = new CListO<Generic<TweenInstruction_Template>>(instructionsTPL)
						}
					};
					tween.autoStart = false;

					res.ContainingScene.AddActor(tweenAct, tweenAct.USERFRIENDLY);
					triggerLinks.Children.Add(new ChildEntry() {
						Path = new ObjectPath(tweenAct.USERFRIENDLY)
					});

					return tweenAct;
				}
			}
		}


		public void CreateTemplatesForInstanceRelays(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var loadedScenes = structs[typeof(ContainerFile<Scene>)];
			var loadedScene = loadedScenes.FirstOrDefault(s => ((ContainerFile<Scene>)s.Value).obj == scene);
			var scenePath = l.Paths[loadedScene.Key];

			int index = 1;
			var pathBase = $"{scenePath.GetFilenameWithoutExtension(fullPath: true, removeCooked: true)}_instancerelays/";

			var relays = scene.FindActors(a => a.GetComponent<RelayEventComponent>()?.relays?.Any() ?? false);
			foreach (var res in relays) {
				var act = res.Result;
				var tpl = act.template;
				var relayComponent = act.GetComponent<RelayEventComponent>();
				var relayTPL = tpl.obj.GetComponent<RelayEventComponent_Template>();

				if(relayTPL.relays == null) relayTPL.relays = new CListO<RelayData>();
				var newRelays = relayTPL.relays.Concat(relayComponent.relays).ToList();
				relayComponent.relays = new CListO<RelayData>(); // Empty instance relays

				var newPath = new Path($"{pathBase}relay_{index}.tpl");
				while (structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
					index++;
					newPath = new Path($"{pathBase}relay_{index}.tpl");
				}
				index++;

				l.Context.SystemLogger?.LogInfo($"Creating relay template (INSTANCE RELAY): {newPath.FullPath}");
				var newTpl = new GenericFile<Actor_Template>(tpl?.obj.Clone("tpl"/*, context: LegendsContext*/) as Actor_Template);
				newTpl.sizeOf = tpl.sizeOf + 0x10000;
				
				newTpl.obj.GetComponent<RelayEventComponent_Template>().relays = new CListO<RelayData>(newRelays);

				var newCookedPath = newPath.CookedPath(MainContext);
				l.CookedPaths[newPath.stringID] = newCookedPath;
				l.Paths[newPath.stringID] = newPath;
				structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTpl;

				act.template = newTpl;
				act.templatePickable = newTpl.obj;
				act.LUA = newPath;
			}

		}

		public void FixStaticMeshVertexComponentCulling(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(new Path("enginedata/actortemplates/tpl_staticmeshvertexcomponent.tpl"));

			if (tpl?.obj == null) return;

			// Add a box interpolator - this will overwrite the culling for the static mesh vertex component
			tpl?.obj?.AddComponent<BoxInterpolatorComponent_Template>();

			var smvs = oldContext.Loader.LoadedActors.Where(a => a.GetComponent<StaticMeshVertexComponent>() != null);
			foreach (var smva in smvs) {
				var smvc = smva.GetComponent<StaticMeshVertexComponent>();

				// Enlarge AABB
				if (smvc.localAABB == null) smvc.localAABB = new AABB();
				var aabb = smvc.localAABB;
				aabb.MIN = aabb.MIN - new Vec2d(100, 100);
				aabb.MAX = aabb.MAX + new Vec2d(100, 100);

				// Add box interpolator
				var box = smva.AddComponent<BoxInterpolatorComponent>();
				box.innerBox = aabb;
				box.outerBox = aabb;

				/*box.innerBox = new AABB() {
					MIN = new Vec2d(float.MinValue, float.MinValue),
					MAX = new Vec2d(float.MaxValue, float.MaxValue)
				};
				box.outerBox = box.innerBox;*/
			}
		}

		public void AddCaptainAI(Context oldContext, Settings newSettings) {
			const string captainStateInput = "captain_state";
			var exitflagPath = new Path("world/rlc/common/gpe/exitflag/components/exitflag.tpl");
			var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(exitflagPath);

			if (tpl?.obj == null) return;
			//tpl.obj.AddComponent<LinkComponent_Template>();

			// Add & configure new AnimatedComponent input
			var animComponent = tpl.obj.GetComponent<AnimatedComponent_Template>();
			if(animComponent.inputs == null) animComponent.inputs = new CListO<InputDesc>();
			animComponent.inputs.Add(new InputDesc() {
				name = captainStateInput,
				varType = InputDesc.InputType.U32
			});
			animComponent.tree = new AnimTree_Template() {
				nodes = new CListO<Generic<BlendTreeNodeTemplate<AnimTreeResult>>>(),
				nodeTransitions = new CListO<BlendTreeTransition_Template<AnimTreeResult>>()
			};
			void AddStateMachine(string name, string prefix, string topAnimation) {
				animComponent.tree.nodes.Add(new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new BlendTreeNodeChooseBranch_Template<AnimTreeResult>() {
					nodeName = new StringID(name),
					leafs = new CListO<Generic<BlendTreeNodeTemplate<AnimTreeResult>>>() {
					new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
						nodeName = new StringID($"{prefix}_{topAnimation}"),
						animationName = new StringID($"{topAnimation}")
					}),
					new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
						nodeName = new StringID($"{prefix}_shaking_flags"),
						animationName = new StringID("shaking_flags")
					}),
					new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
						nodeName = new StringID($"{prefix}_stand"),
						animationName = new StringID("stand")
					}),
				},
					leafsCriterias = new CListO<BlendTreeNodeChooseBranch_Template<AnimTreeResult>.BlendLeaf>() {
					new BlendTreeNodeChooseBranch_Template<AnimTreeResult>.BlendLeaf() {
						criterias = new CListO<CriteriaDesc>() {
							new CriteriaDesc() {
								name = new StringID(captainStateInput),
								eval = "==",
								evaluation = CriteriaDesc.Enum_evaluation.Equals,
								value = 2
							}
						},
					},
					new BlendTreeNodeChooseBranch_Template<AnimTreeResult>.BlendLeaf() {
						criterias = new CListO<CriteriaDesc>() {
							new CriteriaDesc() {
								name = new StringID(captainStateInput),
								eval = "==",
								evaluation = CriteriaDesc.Enum_evaluation.Equals,
								value = 1
							}
						},
					},
					new BlendTreeNodeChooseBranch_Template<AnimTreeResult>.BlendLeaf() {
						// No criteria for this last one
					},
				},
				}));
				animComponent.tree.nodeTransitions.Add(new BlendTreeTransition_Template<AnimTreeResult>() {
					from = new CArrayO<StringID>() { new StringID($"{prefix}_stand") },
					to = new CArrayO<StringID>() { new StringID($"{prefix}_shaking_flags") },
					blend = 3,
					node = new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
						animationName = new StringID(0xBB5E3A4C)
					})
				});
				animComponent.tree.nodeTransitions.Add(new BlendTreeTransition_Template<AnimTreeResult>() {
					from = new CArrayO<StringID>() { new StringID($"{prefix}_shaking_flags") },
					to = new CArrayO<StringID>() { new StringID($"{prefix}_stand") },
					blend = 3,
					node = new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
						animationName = new StringID(0xC160B565)
					})
				});
			}
			AddStateMachine("state_machine", "sm", "speedrun_go");
			AddStateMachine("state_machine_lastpage", "smlp", "yeah2");
			animComponent.defaultAnimation = new StringID("state_machine");
			

			// Add BT AI
			var btAI = tpl.obj.AddComponent<RO2_BTAIComponent_Template>();
			btAI.registerToAIManager = false;
			btAI.faction = 37;
			btAI.behaviorTree = new BehaviorTree_Template() {
				root = new BTNodeTemplate_Ref() {
					node = new Generic<BTNode_Template>(new BTDecider_Template() {
						nodes = new CListO<BTNodeTemplate_Ref>() {
							new BTNodeTemplate_Ref() {
								node = new Generic<BTNode_Template>(new BTSequence_Template() {
									nodes = new CListO<BTNodeTemplate_Ref>() {
										new BTNodeTemplate_Ref() { nameId = new StringID("action_playanim_idle") },
										new BTNodeTemplate_Ref() { nameId = new StringID("decider_isnear_shakeflags") },
										new BTNodeTemplate_Ref() { nameId = new StringID("decider_isnear_go") },
									}
								})
							}
						},
					}),
				},
				nodes = new CArrayO<Generic<BTNode_Template>>() {
					new Generic<BTNode_Template>(new BTDeciderHasPlayerNear_Template() {
						name = new StringID("decider_isnear_go"),
						nodes = new CListO<BTNodeTemplate_Ref>() {
							new BTNodeTemplate_Ref() {
								node = new Generic<BTNode_Template>(new BTSequence_Template() {
									nodes = new CListO<BTNodeTemplate_Ref>() {
										new BTNodeTemplate_Ref() { nameId = "set_fact" },
										new BTNodeTemplate_Ref() {
											node = new Generic<BTNode_Template>(new BTActionSendEventToActor_Template() {
												_event = new Generic<UbiArt.ITF.Event>(new EventSetUintInput() {
													inputName = new StringID(captainStateInput),
													inputValue = 2
												}),
											})
										}
									}
								})
							}
						},
						radius = 2.5f,
					}),
					new Generic<BTNode_Template>(new BTDeciderHasPlayerNear_Template() {
						name = new StringID("decider_isnear_shakeflags"),
						nodes = new CListO<BTNodeTemplate_Ref>() {
							new BTNodeTemplate_Ref() {
								node = new Generic<BTNode_Template>(new BTSequence_Template() {
									nodes = new CListO<BTNodeTemplate_Ref>() {
										new BTNodeTemplate_Ref() { nameId = "set_fact" },
										new BTNodeTemplate_Ref() {
											node = new Generic<BTNode_Template>(new BTActionSendEventToActor_Template() {
												_event = new Generic<UbiArt.ITF.Event>(new EventSetUintInput() {
													inputName = new StringID(captainStateInput),
													inputValue = 1
												}),
											})
										}
									}
								})
							}
						},
						radius = 6f,
					}),
					new Generic<BTNode_Template>(new BTActionSendEventToActor_Template() {
						name = new StringID("action_playanim_idle"),
						_event = new Generic<UbiArt.ITF.Event>(new EventSetUintInput() {
							inputName = new StringID(captainStateInput),
							inputValue = 0
						}),
					}),
					new Generic<BTNode_Template>(new BTActionSetFact_Template() {
						name = new StringID("set_fact"),
						fact = new StringID("fact_setanimation"),
						type = BTActionSetFact_Template.EValueType2.UInteger32,
						value = "1"
					}),
				}
			};

			// Now that this is done, find all objects that use it in the scene and add the RO2_BTAIComponent
			var exitActors = oldContext.Loader.LoadedActors.Where(a => a.LUA == exitflagPath);
			foreach (var act in exitActors) {
				if (act.GetComponent<RO2_BTAIComponent>() == null) {
					act.AddComponent<RO2_BTAIComponent>();
					//act.Result.AddComponent<RO2_BTAIComponent>();
				}
			}
		}

		public void FixLumKingMusic(Context oldContext, Settings newSettings) {
			// Note: music manager works and starts the song, but lum king doesn't turn any lums purple :(
			var musicManagerPath = new Path("sound/common/modifiers/lums/junglelummusicmanager.tpl");
			var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(musicManagerPath);

			if (tpl?.obj == null) return;
			var sndComponent = tpl.obj.GetComponent<SoundComponent_Template>();

			sndComponent.soundList.Remove(sndComponent.soundList.FirstOrDefault(s => s?.name?.stringID == 0xAC205A3F));

			sndComponent.soundList.Add(new SoundDescriptor_Template() {
				name = new StringID(0x6FB3BF00),
				volume = new Volume(-3 - 8),
				category = new StringID(0xF03C38A1),
				maxInstances = 4,
				limitMode = 1,
				limitModeEnum = LimiterDef.LimiterMode.StopOldest,
				files = new CListO<Path>(new List<Path>() {
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"), // 0
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_g7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_a7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_d8.wav"), // 5
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_g8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_f8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_d8.wav"), // 10
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_b7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_g7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_g7.wav"), // 15
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_a7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_d8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"), // 20
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_d8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
				}),
				_params = new SoundParams() {
					numChannels = 1,
					randomVolMin = new Volume(-1),
					fadeInTime = 0.01f,
					fadeOutTime = 0.01f,
					filterQ = 1f,
					playMode = SoundParams.PlayMode.Sequence,
					playMode2 = SoundParams.PlayMode2.Sequence,
					modifiers = new CArrayO<Generic<SoundModifier>>() {
						new Generic<SoundModifier>(new SpatializedPanning() {
							widthMin = 100,
							widthMax = 1000,
						}),
						new Generic<SoundModifier>(new ScreenRollOff() {
							distanceMin = 100,
							distanceMax = 1000,
						}),
					},
				},
			});

			sndComponent.soundList.Add(new SoundDescriptor_Template() {
				name = new StringID(0xAC205A3F),
				volume = new Volume(-9 - 8),
				category = new StringID(0xF03C38A1),
				limitCategory = new StringID(0x39283153),
				maxInstances = 4,
				limitMode = 1,
				limitModeEnum = LimiterDef.LimiterMode.StopOldest,
				files = new CListO<Path>(new List<Path>() {
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_01.wav"), // 0
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_07.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_05.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_01.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_01.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_01.wav"), // 5
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_02.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_03.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_07.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_06.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_07.wav"), // 10
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_05.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_jungleworld_picked_lvl01_04.wav"),
				}),
				_params = new SoundParams() {
					numChannels = 1,
					fadeInTime = 0.01f,
					fadeOutTime = 0.01f,
					filterQ = 1f,
					playMode = SoundParams.PlayMode.Sequence,
					playMode2 = SoundParams.PlayMode2.Sequence,
					modifiers = new CArrayO<Generic<SoundModifier>>() {
						new Generic<SoundModifier>(new SpatializedPanning() {
							widthMin = 100,
							widthMax = 1000,
						}),
						new Generic<SoundModifier>(new ScreenRollOff() {
							distanceMin = 100,
							distanceMax = 1000,
						}),
					},
				},
			});

			sndComponent.soundList.Add(new SoundDescriptor_Template() {
				name = new StringID(0xB131152D),
				volume = new Volume(-3 - 8),
				category = new StringID(0xF03C38A1),
				maxInstances = 4,
				limitMode = 1,
				limitModeEnum = LimiterDef.LimiterMode.StopOldest,
				files = new CListO<Path>(new List<Path>() {
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"), // 0
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_g7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_a7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_d8.wav"), // 5
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav")
				}),
				_params = new SoundParams() {
					numChannels = 1,
					randomVolMin = new Volume(-1),
					fadeInTime = 0.01f,
					fadeOutTime = 0.01f,
					filterQ = 1f,
					playMode = SoundParams.PlayMode.Sequence,
					playMode2 = SoundParams.PlayMode2.Sequence,
					modifiers = new CArrayO<Generic<SoundModifier>>() {
						new Generic<SoundModifier>(new SpatializedPanning() {
							widthMin = 100,
							widthMax = 1000,
						}),
						new Generic<SoundModifier>(new ScreenRollOff() {
							distanceMin = 100,
							distanceMax = 1000,
						}),
					},
				},
			});

			sndComponent.soundList.Add(new SoundDescriptor_Template() {
				name = new StringID(0x506D5E97),
				volume = new Volume(-3 - 8),
				category = new StringID(0xF03C38A1),
				maxInstances = 4,
				limitMode = 1,
				limitModeEnum = LimiterDef.LimiterMode.StopOldest,
				files = new CListO<Path>(new List<Path>() {
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"), // 0
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_g7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_a7.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_d8.wav"), // 5
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_e8.wav"),
					new Path("sound/200_characters/210_common/lums/sfx_lums_picked_lvl01_c8.wav")
				}),
				_params = new SoundParams() {
					numChannels = 1,
					randomVolMin = new Volume(-1),
					fadeInTime = 0.01f,
					fadeOutTime = 0.01f,
					filterQ = 1f,
					playMode = SoundParams.PlayMode.Sequence,
					playMode2 = SoundParams.PlayMode2.Sequence,
					modifiers = new CArrayO<Generic<SoundModifier>>() {
						new Generic<SoundModifier>(new SpatializedPanning() {
							widthMin = 100,
							widthMax = 1000,
						}),
						new Generic<SoundModifier>(new ScreenRollOff() {
							distanceMin = 100,
							distanceMax = 1000,
						}),
					},
				},
			});

			sndComponent.soundList.Add(new SoundDescriptor_Template() {
				name = new StringID(0xEB7569D6),
				volume = new Volume(-6 - 8),
				category = new StringID(0xF03C38A1),
				limitMode = 0,
				limitModeEnum = LimiterDef.LimiterMode.RejectNew,
				maxInstances = 1,
				files = new CListO<Path>(new List<Path>() {
					new Path("sound/200_characters/210_common/lums/sfx_lumking_picked.wav")
				}),
				_params = new SoundParams() {
					numChannels = 1,
					randomVolMin = new Volume(-1),
					filterQ = 1f,
					playMode = SoundParams.PlayMode.Sequence,
					playMode2 = SoundParams.PlayMode2.Sequence,
					modifiers = new CArrayO<Generic<SoundModifier>>() {
						new Generic<SoundModifier>(new SpatializedPanning() {
							widthMin = 0.5f,
							widthMax = 2f,
						}),
						new Generic<SoundModifier>(new ScreenRollOff() {
							distanceMin = 0.2f,
							distanceMax = 2f,
						}),
						new Generic<SoundModifier>(new ZRollOff() {
							distanceMin = 10f,
							distanceMax = 20f,
						}),
					},
				},
			});

			sndComponent.soundList.Add(new SoundDescriptor_Template() {
				name = new StringID(0xE2C196EA),
				volume = new Volume(-7 - 8),
				category = new StringID(0xF03C38A1),
				limitCategory = new StringID(0x0DF47974),
				limitMode = 1,
				limitModeEnum = LimiterDef.LimiterMode.StopOldest,
				maxInstances = 1,
				files = new CListO<Path>(new List<Path>() {
					new Path("sound/300_music/310_common/buffer/mus_lumsking_03_4m.wav"),
					new Path("sound/300_music/310_common/buffer/mus_lumsking_02_4m.wav"),
					new Path("sound/300_music/310_common/buffer/mus_lumsking_06_4m.wav"),
					new Path("sound/300_music/310_common/buffer/mus_lumsking_08_4m.wav"),
				}),
				_params = new SoundParams() {
					numChannels = 2,
					randomVolMin = new Volume(-1),
					filterQ = 1f,
					playMode = SoundParams.PlayMode.Random,
					playMode2 = SoundParams.PlayMode2.Random,
					modifiers = new CArrayO<Generic<SoundModifier>>(),
				},
			});

			sndComponent.soundList.Add(new SoundDescriptor_Template() {
				name = new StringID(0x83E80B90),
				volume = new Volume(-7 - 8),
				category = new StringID(0xF03C38A1),
				limitCategory = new StringID(0x0DF47974),
				limitMode = 1,
				limitModeEnum = LimiterDef.LimiterMode.StopOldest,
				maxInstances = 1,
				files = new CListO<Path>(new List<Path>() {
					new Path("sound/300_music/310_common/buffer/mus_lumsking_03_4m_50fps.wav"),
					new Path("sound/300_music/310_common/buffer/mus_lumsking_02_4m_50fps.wav"),
					new Path("sound/300_music/310_common/buffer/mus_lumsking_06_4m_50fps.wav"),
					new Path("sound/300_music/310_common/buffer/mus_lumsking_08_4m_50fps.wav"),
				}),
				_params = new SoundParams() {
					numChannels = 2,
					randomVolMin = new Volume(-1),
					filterQ = 1f,
					playMode = SoundParams.PlayMode.Random,
					playMode2 = SoundParams.PlayMode2.Random,
					modifiers = new CArrayO<Generic<SoundModifier>>(),
				},
			});

			var lummusic = tpl.obj.AddComponent<RO2_LumMusicManagerAIComponent_Template>();

			// Now that this is done, find all objects that use it in the scene and add the lummusic component
			var lumMusicActors = oldContext.Loader.LoadedActors.Where(a => a.LUA == musicManagerPath);
			foreach (var act in lumMusicActors) {
				if (act.GetComponent<RO2_LumMusicManagerAIComponent>() == null) {
					act.AddComponent<RO2_LumMusicManagerAIComponent>();
				}
			}

			
			// Uncomment to add murfy actors to lum kings
			/*var lumKingPath = new Path("world/common/friendly/lums/components/lumking.tpl");
			if (!actorTemplates.ContainsKey(lumKingPath.stringID)) return;

			// Now that this is done, find all objects that use it in the scene and add the lummusic component
			var lumKingActors = scene.FindActors(a => a.LUA == lumKingPath);

			foreach (var lumKingActor in lumKingActors) {
				AddMurfyGenericTouchActor(oldContext, newSettings, lumKingActor.ContainingScene, lumKingActor.Result);
			}*/
		}
		public void AddMurfyGenericTouchActor(Context oldContext, Settings newSettings, Scene scene, Actor act) {
			var l = oldContext.Loader;
			// Create murfy activation action
			var murfyTrigger = new Actor() {
				LUA = new Path("world/common/logicactor/automurphy/component/trigger_box_automurphyactivation.tpl"),
				USERFRIENDLY = "trigger_box_automurphyactivation",
				POS2D = act.POS2D
			};
			l.AddLoadedActor(murfyTrigger);
			murfyTrigger.AddComponent<LinkComponent>();

			var playerDetector = murfyTrigger.AddComponent<PlayerDetectorComponent>();
			playerDetector.localOffset = new Vec2d(0, 0);
			playerDetector.localScale = new Vec2d(3f, 3f);
			playerDetector.useShapeTransform = true;

			murfyTrigger.AddComponent<RO2_DRCMandatoryZoneComponent>();

			if (scene.AddActor(murfyTrigger, "trigger_box_automurphyactivation")) {
				oldContext?.SystemLogger?.LogInfo($"Added Murfy activation actor for {act.USERFRIENDLY}");
			}

			// Create murfy forced action: touch crank (gyro)
			var murfyAction = new Actor() {
				LUA = new Path("world/common/logicactor/automurphy/component/trigger_box_murphyforcedaction.tpl"),
				USERFRIENDLY = "trigger_box_murphyforcedaction",
				POS2D = act.POS2D,
				RELATIVEZ = 0f,
				SCALE = new Vec2d(7.5f, 7.5f)
			};
			l.AddLoadedActor(murfyAction);
			var murfyActionLink = murfyAction.AddComponent<LinkComponent>(); // Link to gyrocontroller later
			var murfyActionShape = murfyAction.AddComponent<ShapeComponent>();
			murfyActionShape.useShapeTransform = false;
			murfyActionShape.localScale = new Vec2d(10, 10);
			var forcedAction = murfyAction.AddComponent<RO2_DRCForceActionComponent>();
			forcedAction.forcedAction = RO2_DRCForceActionComponent.Enum_forcedAction.GenericTouch;
			forcedAction.autoAction = false;
			forcedAction.useToTargetTravel = true;
			forcedAction.toTargetTravel = new RO2_TravelData() {
				duration = 0.3f,
				accelType = RO2_TravelData.AccelType.InvX2,
				speedType = RO2_TravelData.SpeedType.Uniform
			};
			forcedAction.actionTravel = new RO2_TravelData() {
				duration = 0.2f,
				accelType = RO2_TravelData.AccelType.X2,
				speedType = RO2_TravelData.SpeedType.Uniform
			};
			forcedAction.canBackward = false;
			forcedAction.activationData = new RO2_DRCForceActionComponent.ActivationData() {
				activationMode = RO2_DRCForceActionComponent.ActivationData.Enum_activationMode.Multiple,
				stopOnZoneExit = true,
				canRestartAction = true,
				saveBackward = true,
				saveBackwardOnActionExit = true
			};
			if (scene.AddActor(murfyAction, "trigger_box_murphyforcedaction")) {
				oldContext?.SystemLogger?.LogInfo($"Added Murfy forced action actor for {act.USERFRIENDLY}");
			}

			// Add gyro controller
			var trajectoryNode = new Actor() {
				USERFRIENDLY = "am_trajectorynode",
				LUA = new Path("world/common/logicactor/automurphy/component/am_trajectorynode.tpl"),
				POS2D = act.POS2D,
				RELATIVEZ = 0.145384f,
				SCALE = new Vec2d(2.228791f, 2.228791f),
			};
			l.AddLoadedActor(trajectoryNode);
			var trajectoryComponent = trajectoryNode.AddComponent<RO2_FATrajectoryComponent>();
			var linkComponent = trajectoryNode.AddComponent<LinkComponent>();

			if (scene.AddActor(trajectoryNode, "am_trajectorynode")) {
				oldContext?.SystemLogger?.LogInfo($"Added trajectorynode actor for {act.USERFRIENDLY}");
			}
			// Create links
			murfyActionLink.Children = new CListO<ChildEntry>() {
				new ChildEntry() {
					Path = new ObjectPath() {
						id = trajectoryNode.USERFRIENDLY
					},
				},
			};
		}

		public void FixNinjas(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if (actorTemplates == null) return;

			foreach (var tplPair in actorTemplates) {
				var tpl = tplPair.Value as GenericFile<Actor_Template>;
				if (tpl?.obj == null) continue;
				var animatedComponent = tpl.obj.GetComponent<AnimatedComponent_Template>();
				if (animatedComponent?.animSet?.animPackage?.skeleton?.FullPath == "world/rlc_dojo/common/enemy/ninja/animation/ninja_squeleton.skl") {
					if (animatedComponent?.animSet?.animations == null) continue;
					var anticip = animatedComponent.animSet.animations.FirstOrDefault(a => a.friendlyName?.stringID == 0xFE5F88A2);
					if (anticip != null) anticip.loop = false;
					var endDash = animatedComponent.animSet.animations.FirstOrDefault(a => a.friendlyName?.stringID == 0xAFC27BAE);
					if (endDash != null) endDash.loop = false;

					var poly = tpl.obj.GetComponent<PolylineComponent_Template>();
					if (poly != null) {
						// Danger polylines
						poly.polylineParams.Add(new PolylineParameters() {
								sizeOf = 240,
								environment = true,
								usePhantom = false,
								gameMaterial = new Path("gamematerial/enemy_danger.gmt"),
								polylines = new CListO<StringID>() {
								//new StringID(0xCD8DBD3C), // Hit
								new StringID(0x74B9C0D0), // Dash - inner
								new StringID(0x2A16222C) // Dash - outer
							}
						});
						// Ignored polylines
						poly.polylineParams.Add(new PolylineParameters() {
								sizeOf = 240,
								environment = false,
								usePhantom = false,
								polylines = new CListO<StringID>() {
								new StringID(0xCD8DBD3C), // Hit
								//new StringID(0x74B9C0D0), // Dash - inner
								//new StringID(0x2A16222C) // Dash - outer
							}
						});
					}

					// Try to find fireFX to make it stop after a bit as a workaround for no stop event
					var fxComponent = tpl.obj.GetComponent<FxBankComponent_Template>();
					if (fxComponent?.Fx != null) {
						var fireFX = fxComponent.Fx.Where(fx =>
							fx.name == new StringID(0x4BAAEDA4) ||
							fx.name == new StringID(0x58B79F4F) ||
							fx.name == new StringID(0xE60FAEB1));
						if (fireFX != null) {
							foreach (var fx in fireFX) {
								fx.gen._params.emitterMaxLifeTime = 1.5f;
							}
						}
					}
					/*var fxController = tpl.obj.GetComponent<FXControllerComponent_Template>();
					if (fxController?.fxControlList != null) {
						var fireFX = fxController.fxControlList.FirstOrDefault(fx => fx.name == new StringID(0xBC2A0802));
						if (fireFX != null) {
							fireFX.fxStopOnEndAnim = true;
						}
					}*/
				}
			}

		}
		public void ZiplineToRope_OnlyLeft(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var pickableTree = new PickableTree(scene);
			var ziplines = scene.FindActors(a => a.USERFRIENDLY.StartsWith("chainrope_attach_zipline"));
			foreach (var z in ziplines) {
				var link = z.Result.GetComponent<LinkComponent>();
				if (link == null) continue;
				var ziplineTarget = link.Children[0].Path;

				var targetNode = pickableTree.FollowObjectPath(z.Path, ziplineTarget);
				if (targetNode.Pickable.POS2D.x < z.Result.POS2D.x) { // Zipline goes left
					ZiplineToRope(oldContext, newSettings, z.Result);
				}
			}
		}
		public void TriggerAllLumChains(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var lumChains = scene.FindActors(a => a.LUA?.FullPath == "world/common/friendly/lumschain/components/lumschain.tpl");
			foreach (var lc in lumChains) {
				var containingScene = lc.ContainingScene;
				var lcActor = lc.Result;
				var bezier = lcActor.GetComponent<RO2_BezierTreeComponent>();
				var firstPos = bezier.branch.nodes.FirstOrDefault().pos;
				List<Vec3d> positions = new List<Vec3d>();
				Vec3d curPos = Vec3d.Zero;
				foreach (var node in bezier.branch.nodes) {
					curPos = curPos + node.pos;
					positions.Add(curPos);
				}
				var chain = lcActor.GetComponent<RO2_LumsChainComponent>();
				var minX = positions.Min(n => n.x) * lcActor.SCALE.x + lcActor.POS2D.x;
				var minY = positions.Min(n => n.y) * lcActor.SCALE.y + lcActor.POS2D.y;
				var maxX = positions.Max(n => n.x) * lcActor.SCALE.x + lcActor.POS2D.x;
				var maxY = positions.Max(n => n.y) * lcActor.SCALE.y + lcActor.POS2D.y;
				var trigger = new Actor() {
					USERFRIENDLY = "trigger_box_once",
					LUA = new Path("world/common/logicactor/trigger/components/trigger_box_once.tpl"),
					POS2D = new Vec2d((maxX - minX) / 2f, (maxY - minY) / 2f),
					SCALE = new Vec2d((maxX - minX) + 1f, (maxY - minY) + 1f),
				};
				oldContext.Loader.AddLoadedActor(trigger);
				var l = trigger.AddComponent<LinkComponent>();
				l.Children = new CListO<ChildEntry>() {
					new ChildEntry() {
						Path = new ObjectPath() {
							id = lcActor.USERFRIENDLY
						},
						TagValues = new CListO<TagValue>() {
							new TagValue() {
								Tag = new StringID(0x099FC5CF),
								Value = "0.5"
							}
						}
					}
				};
				var pdc = trigger.AddComponent<PlayerDetectorComponent>();
				pdc.useShapeTransform = false;
				var t = trigger.AddComponent<TriggerComponent>();
				t.mode = TriggerComponent.Mode.Multiple;
				containingScene.AddActor(trigger, trigger.USERFRIENDLY);
				oldContext?.SystemLogger?.LogInfo($"Added trigger: {trigger.USERFRIENDLY}");
			}
		}

		public void FixAllLumsChainSpawnMode(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var lumChains = scene.FindActors(a => a.GetComponent<RO2_LumsChainComponent>()?.spawnMode == RO2_LumsChainComponent.SpawnMode.StartSpawned_Begin_Delayed);
			foreach (var lc in lumChains) {
				var containingScene = lc.ContainingScene;
				var lcActor = lc.Result;
				var bezier = lcActor.GetComponent<RO2_BezierTreeComponent>();
				/*bool hasTween = false;
				foreach (var node in bezier.branch.nodes) {
					if (node.tween?.value != null) {
						hasTween = true;
						break;
					}
				}
				if(hasTween) continue;*/

				var chain = lcActor.GetComponent<RO2_LumsChainComponent>();
				if (chain.trajectory == RO2_LumsChainComponent.Trajectory.GoToTheEnd) {
					chain.spawnMode = RO2_LumsChainComponent.SpawnMode.StartSpawned_Begin;
					chain.trajectory = RO2_LumsChainComponent.Trajectory.FollowChain;
				}
			}
		}
		public void FixOneLumsChainSpawnMode(Context oldContext, Settings newSettings, Actor act) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var chain = act.GetComponent<RO2_LumsChainComponent>();
			chain.spawnMode = RO2_LumsChainComponent.SpawnMode.StartSpawned_Begin;
			chain.trajectory = RO2_LumsChainComponent.Trajectory.FollowChain;
		}

		public void AllZiplinesToRopes(Context oldContext, Settings newSettings, ConversionSettings conversionSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if (actorTemplates == null) return;

			conversionSettings.PathConversionRules.Add(
					new PathConversionRule("chainrope_attach_zipline.tpl", "chainrope_attach_zipline_adv.tpl"));

			foreach (var tplPair in actorTemplates) {
				var tpl = tplPair.Value as GenericFile<Actor_Template>;
				if (tpl?.obj == null) continue;
				var rope = tpl.obj.GetComponent<RopeComponent_Template>();
				if (rope == null) continue;
				rope.gameMaterial = new Path("gamematerial/basicliana_h.gmt");
				rope.cutSectionGameMaterial = rope.gameMaterial;
			}

		}
		public void ZiplineToRope(Context oldContext, Settings newSettings, Actor act) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			if (!structs.ContainsKey(typeof(GenericFile<Actor_Template>)))
				structs[typeof(GenericFile<Actor_Template>)] = new Dictionary<StringID, ICSerializable>();
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];

			var ogTPLPath = act.LUA;
			var newTPLPath = new Path(act.LUA.FullPath.Replace("chainrope_attach_zipline.tpl", "chainrope_attach_ziprope.tpl"));
			act.LUA = newTPLPath;
			if (!actorTemplates.ContainsKey(newTPLPath.stringID)) {
				var newTPL = new GenericFile<Actor_Template>(act.template.obj.Clone("tpl") as Actor_Template);
				newTPL.sizeOf = act.template.sizeOf;
				actorTemplates[newTPLPath.stringID] = newTPL;
				l.Paths[newTPLPath.stringID] = newTPLPath;
				l.CookedPaths[newTPLPath.stringID] = newTPLPath.CookedPath(oldContext);


				var rope = newTPL.obj.GetComponent<RopeComponent_Template>();
				if (rope != null) {
					// TODO: Change game material sound
					rope.gameMaterial = new Path("gamematerial/basicliana_h.gmt");
					rope.cutSectionGameMaterial = rope.gameMaterial;

					// Change texture so you can distinguish ropes from ziplines
					rope.bezierRenderer.material.textureSet.diffuse = new Path("world/common/platform/rope/texture/rope.tga");
					rope.bezierRenderer.material.textureSet.back_light = new Path("world/common/platform/rope/texture/rope_back.tga");
					rope.bezierRenderer.beginLength = 0.05f;
					rope.bezierRenderer.endLength = 0.1f;
					rope.bezierRenderer.beginWidth = 0.7f;
					rope.bezierRenderer.midWidth = 0.7f;
					rope.bezierRenderer.endWidth = 0.7f;
					rope.bezierRenderer.tileLength = 5.6f;
					rope.bezierRenderer.tessellationLength = 0.3f;
					rope.bezierRenderer.divMode = BezierCurveRenderer_Template.BezierDivMode.Fix82;
					rope.beginMaterial.textureSet.diffuse = new Path("world/common/platform/rope/texture/rope_extremity_01.tga");
					rope.beginMaterial.textureSet.back_light = new Path("world/common/platform/rope/texture/rope_extremity_01_back.tga");
					rope.endMaterial.textureSet.diffuse = new Path("world/common/platform/rope/texture/rope_extremity_02.tga");
					rope.endMaterial.textureSet.back_light = new Path("world/common/platform/rope/texture/rope_extremity_02_back.tga");
				}
			}
		}
		public void UpdateSoundFXReferences(Context oldContext, Settings newSettings, ConversionSettings conversionSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if (actorTemplates != null) {
				foreach (var tplPair in actorTemplates) {
					var tpl = tplPair.Value as GenericFile<Actor_Template>;
					if (tpl?.obj == null) continue;
					var soundComponent = tpl.obj.GetComponent<SoundComponent_Template>();
					var fxComponent = tpl.obj.GetComponent<FXControllerComponent_Template>();
					if(soundComponent?.soundList == null || fxComponent?.fxControlList == null) continue; // Needs a sound component

					// Remove broken sound descriptor which can occur in Adventures
					var sounds = soundComponent.soundList.Where(snd => snd != null && (snd.HasWwiseEvent || snd.HasFiles));
					soundComponent.soundList = new CListO<SoundDescriptor_Template>(sounds?.ToList());

					bool hasStop = false;
					Dictionary<StringID, StringID> StopLinksSndDesc = new Dictionary<StringID, StringID>();
					Dictionary<StringID, StringID> StopLinksFx = new Dictionary<StringID, StringID>();

					foreach (var fx in fxComponent.fxControlList) {
						if(fx.sounds == null) continue;
						foreach (var snd in fx.sounds) {
							var sndDesc = soundComponent.soundList.FirstOrDefault(s => s?.name == snd);
							if(sndDesc == null) continue;
							var wwEventID = sndDesc.WwiseEventGUID;
							var wwEvent = conversionSettings.WwiseConversionSettings.Events.TryGetItem(wwEventID);
							if (wwEvent == null) continue;

							foreach (var a in wwEvent.Actions) {
								if (a.IsStop) {
									if (StopLinksSndDesc.ContainsKey(sndDesc.name)) continue;
									var extId = a.ExtID;
									var firstEventThatThisStops = soundComponent.soundList
										.FirstOrDefault(s => conversionSettings.WwiseConversionSettings.Events
										.TryGetItem(s.WwiseEventGUID)?.Actions.Any(ac => !ac.IsStop && ac.ExtID == extId) ?? false);
									if (firstEventThatThisStops != null) {
										StopLinksSndDesc[sndDesc.name] = firstEventThatThisStops.name;
										var firstFXThatThisStops = fxComponent.fxControlList.FirstOrDefault(f => f.sounds.Contains(firstEventThatThisStops.name));
										if (firstFXThatThisStops != null) {
											StopLinksFx[fx.name] = firstFXThatThisStops.name;
										}
									}
									hasStop = true;
									
								}
							}

							//hasStop = hasStop | wwEvent.Actions.Any(a => a.IsStop);


							//if(hasStop) break;
						}
						//if (hasStop) break;
					}
					if(!hasStop) continue;
					if (StopLinksFx.Any()) {
						/*UnityEngine.Debug.LogWarning($"{oldContext.Loader.Paths[tplPair.Key]}: Has StopLinksFX:");
						foreach (var fx in StopLinksFx) {
							UnityEngine.Debug.LogWarning($"{oldContext.Loader.Paths[tplPair.Key]}: {fx.Key}-{fx.Value}");
						}*/
						UnityEngine.Debug.LogWarning($"{oldContext.Loader.Paths[tplPair.Key].filename}: Has StopLinksFX");
					}

					void ProcessInstructionSet(TweenComponent_Template.InstructionSet set) {
						List<Generic<TweenInstruction_Template>> instructions = new List<Generic<TweenInstruction_Template>>();
						foreach (var instr in set.instructions) {
							if (instr?.obj is TweenFX_Template fx) {
								if (!fx.stop && StopLinksFx.ContainsKey(fx.fx)) {
									instructions.Add(new Generic<TweenInstruction_Template>(new TweenFX_Template() {
										duration = 0,
										name = new StringID(),
										stop = true,
										fx = StopLinksFx[fx.fx],
										useLocalInitialPos = fx.useLocalInitialPos,
										sizeOf = fx.sizeOf
									}));
								}
							}
							instructions.Add(instr);
						}
						set.instructions = new CListO<Generic<TweenInstruction_Template>>(instructions);
					}
					void ProcessInstructionSet2(TweenInstructionSet_Template set) {
						List<Generic<TweenInstruction_Template>> instructions = new List<Generic<TweenInstruction_Template>>();
						foreach (var instr in set.instructions) {
							if (instr?.obj is TweenFX_Template fx) {
								if (!fx.stop && StopLinksFx.ContainsKey(fx.fx)) {
									instructions.Add(new Generic<TweenInstruction_Template>(new TweenFX_Template() {
										duration = 0,
										name = new StringID(),
										stop = true,
										fx = StopLinksFx[fx.fx],
										useLocalInitialPos = fx.useLocalInitialPos,
										sizeOf = fx.sizeOf
									}));
								}
							}
							instructions.Add(instr);
						}
						set.instructions = new CListO<Generic<TweenInstruction_Template>>(instructions);
					}
					void ProcessTweenComponent_Template(TweenComponent_Template tweenComponent) {
						if (tweenComponent != null) {
							// Check for FX
							var instructionSets = tweenComponent.instructionSets;
							var preInstructionSets = tweenComponent.preInstructionSets;
							if (instructionSets != null) {
								foreach (var set in instructionSets) {
									ProcessInstructionSet(set);
								}
							}
							if (preInstructionSets != null) {
								foreach (var set in preInstructionSets) {
									ProcessInstructionSet(set);
								}
							}
						}
					}

					var tweenComponent = tpl.obj.GetComponent<TweenComponent_Template>();
					if (tweenComponent != null) {
						ProcessTweenComponent_Template(tweenComponent);
						var sceneActors = l.LoadedActors.Where(a => a.template?.obj == tpl.obj && a.GetComponent<TweenComponent>() != null);
						foreach (var act in sceneActors) {
							var tween = act.GetComponent<TweenComponent>();
							if (tween != null) {
								if (tween?.instanceTemplate?.value != null) {
									tweenComponent = act.GetComponent<TweenComponent>().instanceTemplate.value;
									ProcessTweenComponent_Template(tweenComponent);
								}
								if (tween.instructionSets != null) {
									foreach (var set in tween.instructionSets) {
										var template = tweenComponent.instructionSets.FirstOrDefault(i => i.name == set.name);
										if (template.instructions.Count > set.instructions.Count) {
											// We added a new instruction, have to add it here too

											List<Generic<TweenInstruction>> instructions = new List<Generic<TweenInstruction>>();
											int curInstructionIndex = 0; 
											foreach (var instr in set.instructions) {
												var templateInstruction = template.instructions[curInstructionIndex];
												if (templateInstruction?.obj is TweenFX_Template fxTPL && fxTPL.stop) {
													// Check if this stop instruction was added!
													if (curInstructionIndex + 1 < template.instructions.Count) {
														var nextTemplateInstruction = template.instructions[curInstructionIndex+1];
														if (nextTemplateInstruction?.obj is TweenFX_Template fxTPL2 && !fxTPL2.stop && StopLinksFx.ContainsKey(fxTPL2.fx) && StopLinksFx[fxTPL2.fx] == fxTPL.fx) {
															// This is an added StopFX. So add it here too.
															instructions.Add(new Generic<TweenInstruction>(new TweenFX() {
																name = new StringID()
															}));
															curInstructionIndex++;
															if (curInstructionIndex >= template.instructions.Count) break;
															templateInstruction = template.instructions[curInstructionIndex];
														}
													}
												}
												if (instr?.obj is TweenFX fx) {
													if ((fx.target?.levels?.Count ?? 0) != 0 || !string.IsNullOrWhiteSpace(fx.target?.id)) {
														// ObjectPath is not null
														//throw new Exception("TweenFX is targeting another object!");
													}
												}
												instructions.Add(instr);
												curInstructionIndex++;
											}
											set.instructions = new CArrayO<Generic<TweenInstruction>>(instructions.ToArray());
										}
									}
								}
							}
						}
					}
					var bezierTree = tpl.obj.GetComponent<RO2_BezierTreeComponent_Template>();
					if (bezierTree != null) {
						// Check for FX
						var instructionSets = bezierTree.tweenInterpreter?.instructionSets;
						foreach (var set in instructionSets) {
							ProcessInstructionSet2(set);
						}
					}

					// Process sound FX events in animations
					var animComponent = tpl.obj.GetComponent<AnimLightComponent_Template>();
					if (animComponent != null) {
						var anims = animComponent.animSet?.animations;
						if (anims != null) {
							foreach (var animTPL in anims) {
								var anim = animTPL?.name?.GetObject<AnimTrack>();
								if(anim == null || anim.frameEvents == null) continue;
								foreach (var fr in anim.frameEvents) {
									if(fr.events == null || fr.events.Count == 0 || !fr.events.Any(f => f.type == AnimTrackFrameEvents.AnimMarkerEvent.AnimMarkerEventType.AnimFXEvent)) continue;
									List<AnimTrackFrameEvents.AnimMarkerEvent> events = new List<AnimTrackFrameEvents.AnimMarkerEvent>();
									foreach (var ev in fr.events) {
										if (ev.type == AnimTrackFrameEvents.AnimMarkerEvent.AnimMarkerEventType.AnimFXEvent) {
											if (ev.enableFX && StopLinksFx.ContainsKey(ev.marker)) {
												events.Add(new AnimTrackFrameEvents.AnimMarkerEvent() {
													type = AnimTrackFrameEvents.AnimMarkerEvent.AnimMarkerEventType.AnimFXEvent,
													marker = StopLinksFx[ev.marker],
													enableFX = false,
													sizeOf = ev.sizeOf,
													posLocal = ev.posLocal,
													name = new StringID(),
												});
											}
										}
										events.Add(ev);
									}
									fr.events = new CListO<AnimTrackFrameEvents.AnimMarkerEvent>(events);
								}
							}
						}
					}
				}
			}

		}
		public void DowngradeFxUV(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if(actorTemplates == null) return;

			Dictionary<Path, UbiArt.UV.UVAtlas> textures = new Dictionary<Path, UbiArt.UV.UVAtlas>();
			void AddAtlas(Path p) {
				var atlas = l.uvAtlasManager.GetAtlasIfExists(p);
				if(atlas != null) textures[p] = atlas;
			}

			foreach (var tplPair in actorTemplates) {
				var tpl = tplPair.Value as GenericFile<Actor_Template>;
				if(tpl?.obj == null) continue;
				var fxc = tpl.obj.GetComponent<FxBankComponent_Template>();
				if(fxc?.Fx == null) continue;
				foreach (var fx in fxc.Fx) {
					var textureSet = fx?.material?.textureSet;
					AddAtlas(textureSet?.diffuse);
					AddAtlas(textureSet?.back_light);
				}
			}

			foreach (var texturePair in textures) {
				var atlas = texturePair.Value;
				if (atlas != null) {
					if(atlas.uvParams != null && atlas.uvParams.Any())
						atlas.uvParams = new CMap<int, UbiArt.UV.UVparameters>();

					foreach (var uvPair in atlas.uvData) {
						var uvdata = uvPair.Value;
						if (uvdata.uvs == null || uvdata.uvs.Count == 0) continue;
						int count = uvdata.uvs.Count;
						if (count != 2) {
							// We need to fix this one...
							Vec2d min = new Vec2d(uvdata.uvs.Min(uv => uv.x), uvdata.uvs.Min(uv => uv.y));
							Vec2d max = new Vec2d(uvdata.uvs.Max(uv => uv.x), uvdata.uvs.Max(uv => uv.y));
							Vec2d pivot = min + ((max - min) / 2f);
							if (atlas.pivots != null && atlas.pivots.ContainsKey(uvPair.Key)) {
								var oldPivot = atlas.pivots[uvPair.Key];
								var newPivot = new Vec2d(oldPivot.x, oldPivot.y);
								if (pivot.x != newPivot.x || pivot.y != newPivot.y) {
									pivot = newPivot;
									var maxDist = max - pivot;
									var minDist = pivot - min;
									var halfDimensions = new Vec2d(
										System.MathF.Max(maxDist.x, minDist.x),
										System.MathF.Max(maxDist.y, minDist.y));
									min = pivot - halfDimensions;
									max = pivot + halfDimensions;
								}
							}
							uvdata.uvs = new CArrayO<Vec2d>(new Vec2d[] {
								min, max
							});
						}
					}
				}
			}
		}
		public void CreateFriseParents(Context oldContext, Settings newSettings, Scene scene) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			List<SubSceneActor> parentActors = new List<SubSceneActor>();

			bool ShouldCreateParentActorForFrise(Frise f) {
				if (!(newSettings.Game == Game.RA || newSettings.Game == Game.RM)) {
					if (f.parentBind != null && f.parentBind.read == true)
						return true;
					//if(f.STARTPAUSE)
					//	return true;
					if (f.COMPONENTS != null && f.COMPONENTS.Any(c => c?.obj != null))
						return true;
				}
				return false;
			}
			SubSceneActor CreateParentActor(Frise f) {
				var newFrise = f.Clone("isc") as Frise;
				var parent = Merger.Merge<SubSceneActor>(f);
				parent.EMBED_SCENE = true;
				parent.SCENE = new UbiArt.Nullable<Scene>(new Scene() {
					FRISE = new CListO<Frise>() { newFrise }
				});
				//parent.IS_SINGLE_PIECE = true;
				//parent.ZFORCED = true;

				var config = f.config?.obj;
				if (config?.COMPONENTS != null && config.COMPONENTS.Any(c => c?.obj != null)) {
					// Create new actor template too
					// But first, check if it should be created
					var ogPath = f.ConfigName;
					var newPath = new Path(ogPath.FullPath.Replace(".fcg", "__friseparent.tpl"));
					if (newPath.stringID == ogPath.stringID) {
						l.Context.SystemLogger?.LogInfo($"Could not rename path: {ogPath.FullPath}");
					}
					parent.LUA = new Path(newPath.FullPath);


					if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
						l.Context.SystemLogger?.LogInfo($"Duplicating template (Frise with Components): {ogPath.FullPath}");
						var newTpl = new GenericFile<Actor_Template>(Merger.Merge<Actor_Template>(config));
						newTpl.sizeOf = f.config.sizeOf;
						var oldCookedPath = l.CookedPaths[ogPath.stringID];
						var newCookedPath = new Path(oldCookedPath.FullPath.Replace(".fcg", "__friseparent.tpl"), true);
						l.CookedPaths[newPath.stringID] = newCookedPath;
						l.Paths[newPath.stringID] = newPath;
						structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTpl;
					}
					parent.template = (GenericFile<Actor_Template>)structs[typeof(GenericFile<Actor_Template>)][newPath.stringID];
				} else {
					parent.LUA = new Path(SubSceneActor.DefaultPath);
					parent.template = (GenericFile<Actor_Template>)structs[typeof(GenericFile<Actor_Template>)][parent.LUA.stringID];
					parent.COMPONENTS = null;
				}
				//parent.USERFRIENDLY = $"{USERFRIENDLY}__friseparent";
				//parent.ZFORCED = true;
				//parent.IS_SINGLE_PIECE = true;
				//parent.DIRECT_PICKING = false;

				// Reset transform as it has been assigned to the subsceneactor
				newFrise.parentBind = null;
				newFrise.isEnabled = true;
				newFrise.xFLIPPED = false;
				newFrise.POS2D = Vec2d.Zero;
				newFrise.SCALE = Vec2d.One;
				newFrise.RELATIVEZ = 0;
				newFrise.ANGLE = 0;
				newFrise.COMPONENTS = null;

				return parent;
			}

			// First, search for frises pointed to in LinkComponents
			{
				HashSet<Frise> processedFrises = new HashSet<Frise>();
				var sceneTree = new PickableTree(scene);
				var linkComponentSearch = scene.FindActors(a => a.GetComponent<LinkComponent>()?.Children?.Count > 0);

				foreach (var linkResult in linkComponentSearch) {
					var linkPath = linkResult.Path;

					var linkComponent = linkResult.Result.GetComponent<LinkComponent>();
					
					// Special case: Aspi networks need to be linked to the frise and its actor only!
					if(linkResult.Result.GetComponent<RO2_AspiNetworkComponent>() != null) continue;

					foreach (var linkChild in linkComponent.Children) {
						try {
							PickableTree.Node result = sceneTree.FollowObjectPath(linkPath, linkChild.Path);
							if (result.Pickable is Frise frise && !processedFrises.Contains(frise)) {
								processedFrises.Add(frise);
								var containingScene = result.Parent.Scene;

								var parentActor = CreateParentActor(frise);

								// Remove frise from scene and add parent actor
								if (containingScene.ACTORS == null) containingScene.ACTORS = new CArrayO<Generic<Actor>>();
								containingScene.ACTORS.Add(new Generic<Actor>(parentActor));
								containingScene.FRISE.Remove(frise);

								parentActors.Add(parentActor);
							}
						} catch (Exception ex) {
							oldContext?.SystemLogger?.LogWarning($"Error: {linkResult.Result.USERFRIENDLY} - {linkComponent.Children.Count}");
							oldContext?.SystemLogger?.LogWarning(ex);
						}
					}
				}
			}

			// Then, search for remaining frises that have a parentBind or components
			var friseSearch = scene.FindPickables(p => (p is Frise f) && ShouldCreateParentActorForFrise(f));
			if (friseSearch?.Any() == true) {
				// Create parent actors
				foreach (var friseResult in friseSearch) {
					var containingScene = friseResult.ContainingScene;
					var frise = (Frise)(friseResult.Result);

					var parentActor = CreateParentActor(frise);

					// Remove frise from scene and add parent actor
					if (containingScene.ACTORS == null) containingScene.ACTORS = new CArrayO<Generic<Actor>>();
					containingScene.ACTORS.Add(new Generic<Actor>(parentActor));
					containingScene.FRISE.Remove(frise);

					parentActors.Add(parentActor);

				}
			}
			if(parentActors.Any()) {
				var sceneTree = new PickableTree(scene);
				var linkComponentSearch = scene.FindActors(a => a.GetComponent<LinkComponent>()?.Children?.Count > 0);

				// Update link components
				foreach (var linkResult in linkComponentSearch) {
					var linkPath = linkResult.Path;

					var linkComponent = linkResult.Result.GetComponent<LinkComponent>();
					
					// Special case: Aspi networks need to be linked to the frise and its actor only!
					if (linkResult.Result.GetComponent<RO2_AspiNetworkComponent>() != null) continue;

					List<pair<Pickable, ChildEntry>> childrenToDuplicate = new List<pair<Pickable, ChildEntry>>();
					foreach (var linkChild in linkComponent.Children) {
						try {
							PickableTree.Node result = sceneTree.FollowObjectPath(linkPath, linkChild.Path);
							if (result.Pickable != null && parentActors.Contains(result.Pickable)) {
								childrenToDuplicate.Add(new pair<Pickable, ChildEntry>(result.Pickable, linkChild));
							}
						} catch (Exception ex) {
							oldContext?.SystemLogger?.LogWarning(ex);
						}
					}
					foreach (var dupChild in childrenToDuplicate) {
						var newChild = new ChildEntry() {
							Path = new ObjectPath() {
								id = dupChild.Item2.Path.id,
								absolute = dupChild.Item2.Path.absolute
							},
							TagValues = dupChild.Item2.TagValues
						};
						newChild.Path.levels = new CListO<ObjectPath.Level>();
						if (dupChild.Item2.Path.levels != null) {
							foreach(var lev in dupChild.Item2.Path.levels)
								newChild.Path.levels.Add(lev);
						}
						newChild.Path.levels.Add(new ObjectPath.Level() {
							name = dupChild.Item1.USERFRIENDLY
						});
						linkComponent.Children.Add(newChild);
						l.Context.SystemLogger?.LogInfo($"Duplicating LinkComponent for duplicated Frise: {newChild.Path.id}");
					}
				}
			}
		}

		public async Task MakeFrisesStartPaused(Context oldContext, Settings newSettings, Scene scene) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			async Task<Path> GetModdedPauseSwitch() {
				var ogPath = new Path("world/jungle/level/ju_rl_1_castle/actor/pauseswitch.tpl");
				var newPath = new Path("world/jungle/level/ju_rl_1_castle/actor/pauseswitch_modaabb.tpl");

				if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
					l.Context.SystemLogger?.LogInfo($"Duplicating template (MOD ABBB): {ogPath.FullPath}");
					var ogTpl = await LoadFileLegends<GenericFile<Actor_Template>>(ogPath);
					var newTpl = new GenericFile<Actor_Template>(ogTpl.obj?.Clone("tpl"/*, context: LegendsContext*/) as Actor_Template);
					newTpl.sizeOf = ogTpl.sizeOf + 0x10000;
					newTpl.obj.AddComponent<BoxInterpolatorComponent_Template>();

					var oldCookedPath = LegendsContext.Loader.CookedPaths[ogPath.stringID];
					var newCookedPath = new Path(oldCookedPath.FullPath.Replace(".tpl", "_modaabb.tpl"), true);
					l.CookedPaths[newPath.stringID] = newCookedPath;
					l.Paths[newPath.stringID] = newPath;
					structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTpl;
				}

				return newPath;
			}

			var sceneTree = new PickableTree(scene);
			var startpauseFrises = scene.FindPickables(p => p.STARTPAUSE && (p is Frise || p is SubSceneActor));
			if (startpauseFrises.Any()) {
				var moddedPauseSwitchPath = await GetModdedPauseSwitch();

				// Create pauseswitch actor
				var pauseswitch = new Actor() {
					USERFRIENDLY = "pauseswitch_modaabb",
					LUA = moddedPauseSwitchPath
				};
				l.AddLoadedActor(pauseswitch);
				var spawnPoint = scene.FindActor(a => a.GetComponent<CheckpointComponent>()?.INDEX == 0);
				if (spawnPoint?.Result == null) {
					spawnPoint = scene.FindActor(a => a.GetComponent<CheckpointComponent>() != null);
				}
				var pos = spawnPoint.Result.POS2D;
				if (spawnPoint.Path.levels?.Count > 0) {
					var node = sceneTree.Root.GetNodeWithObjectPath(spawnPoint.Path);
					while (node.Parent != null) {
						node = node.Parent;
						if (node.Pickable != null) {
							pos = node.Pickable.POS2D + node.Pickable.SCALE * pos;
						}
					}
				}
				// Calculate global position
				pauseswitch.POS2D = pos;

				var link = pauseswitch.AddComponent<LinkComponent>();
				link.Children = new CListO<ChildEntry>();
				var tween = pauseswitch.AddComponent<TweenComponent>();
				tween.startSet = new StringID("Pause");
				tween.instructionSets = new CListO<TweenComponent.InstructionSet>(new List<TweenComponent.InstructionSet>() {
					new TweenComponent.InstructionSet() {
						name = "Pause",
						instructions = new CArrayO<Generic<TweenInstruction>>(new Generic<TweenInstruction>[] {
							new Generic<TweenInstruction>(new TweenEvent() {
							})
						})
					},
					new TweenComponent.InstructionSet() {
						name = "Unpause",
						instructions = new CArrayO<Generic<TweenInstruction>>(new Generic<TweenInstruction>[] {
							new Generic<TweenInstruction>(new TweenEvent() {
							})
						})
					},
				});
				var box = pauseswitch.AddComponent<BoxInterpolatorComponent>();
				box.innerBox = new AABB() {
					MIN = new Vec2d(-10000, -10000),
					MAX = new Vec2d( 10000,  10000)
				};
				box.outerBox = box.innerBox;
				scene.AddActor(pauseswitch, "pauseswitch_modaabb");

				// Link all frises that were STARTPAUSE in the pauseswitch
				foreach (var f in startpauseFrises) {
					f.Result.STARTPAUSE = false;
					link.Children.Add(new ChildEntry() {
						Path = f.Path
					});
					l.Context.SystemLogger?.LogInfo($"Linking frise to pauseswitch: {f.Path}");
				}
			}
		}

		public void CreateLightingFrisesForRenderParams(Context oldContext, Settings newSettings, Scene scene) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var sceneTree = new PickableTree(scene);
			var renderParams = scene.FindActors(a => a?.GetComponent<RenderParamComponent>()?.Lighting?.Enable == true);
			if (!renderParams.Any()) return;

			foreach (var rpResult in renderParams) {
				var act = rpResult.Result;
				var rpScene = rpResult.ContainingScene;
				var rp = act.GetComponent<RenderParamComponent>();
				var lighting = rp.Lighting;
				var box = act.GetComponent<BoxInterpolatorComponent>();
				var aabb = box?.innerBox;
				if(aabb == null) aabb = new AABB() {
					MIN = Vec2d.One * -1f / 0.5f,
					MAX = Vec2d.One * 1f / 0.5f,
				};
				var outerAABB = box?.outerBox;
				Vec2d totalMin = new Vec2d(
					MathF.Min(aabb.MIN.x, outerAABB?.MIN?.x ?? aabb.MIN.x),
					MathF.Min(aabb.MIN.y, outerAABB?.MIN?.y ?? aabb.MIN.y));
				Vec2d totalMax = new Vec2d(
					MathF.Max(aabb.MAX.x, outerAABB?.MAX?.x ?? aabb.MAX.x),
					MathF.Max(aabb.MAX.y, outerAABB?.MAX?.y ?? aabb.MAX.y));

				void CreateMaskResolver(string name, string template, float z) {
					var newAct = new Actor() {
						POS2D = act.POS2D,
						ANGLE = act.ANGLE,
						SCALE = act.SCALE,
						RELATIVEZ = act.RELATIVEZ + z,
						USERFRIENDLY = $"{act.USERFRIENDLY}_{name}",
						xFLIPPED = act.xFLIPPED,
						LUA = new Path(template),
					};
					l.AddLoadedActor(newAct);
					var mr = newAct.AddComponent<MaskResolverComponent>(new MaskResolverComponent() {
						clearBackLightBuffer = false,
						clearFrontLightBuffer = false
					});
					if (rp.ClearColor != null && rp.ClearColor.Enable) {
						mr.clearBackLightBuffer = true;
						mr.clearFrontLightBuffer = true;
						mr.clearBackLightColor = rp.ClearColor.ClearBackLightColor;
						mr.clearFrontLightColor = rp.ClearColor.ClearFrontLightColor;
					}
					if (box != null) {
						var outerAABB = box.outerBox;
						var scale = outerAABB.MAX - outerAABB.MIN;
						var center = outerAABB.MIN + (scale / 2f);
						newAct.POS2D = act.POS2D + center;
						newAct.SCALE = act.SCALE * scale;
					}
					rpScene.AddActor(newAct, newAct.USERFRIENDLY);
				}
				CreateMaskResolver("resolvebothmask", "world/common/levelart/light/lightresolver/components/resolvebothmask.tpl", z: -3f);

				// Create lighting frise
				PolyPointList CreatePolyPointList(Vec2d[] vectors, bool loop = true) {
					var points = new PolyPointList() {
						LocalPoints = new CListO<PolyLineEdge>(vectors.Select(p => new PolyLineEdge() {
							POS = p,
							Scale = 1f,
						}).ToList()),
						Loop = loop,
					};
					if (loop) {
						points.LocalPoints.Add(new PolyLineEdge() {
							POS = vectors[0],
							Scale = 1f,
						});
					}
					points.RecomputeData();
					return points;
				}

				void CreateFrise(string name, string template, float z = 0) {
					var fr = new Frise() {
						POS2D = act.POS2D,
						ANGLE = act.ANGLE,
						SCALE = act.SCALE,
						RELATIVEZ = act.RELATIVEZ + z,
						USERFRIENDLY = $"{act.USERFRIENDLY}_{name}",
						xFLIPPED = act.xFLIPPED,

						PreComputedForCook = true,
						ConfigName = new Path(template),

					};
					Vec2d LocalToGlobal(Vec2d point) => (point * fr.SCALE).Rotate(fr.ANGLE) + fr.POS2D;
					Vec3d LocalToGlobal3D(Vec3d point) {
						var v2d = LocalToGlobal(new Vec2d(point.x, point.y));
						return new Vec3d(v2d.x, v2d.y, point.z + fr.RELATIVEZ);
					}

					fr.PointsList = CreatePolyPointList(new Vec2d[] {
						totalMin, new Vec2d(totalMin.x, totalMax.y), totalMax, new Vec2d(totalMax.x, totalMin.y)
					});


					// Fill in visual data
					fr.meshBuildData = new UbiArt.Nullable<Frise.MeshBuildData>(new Frise.MeshBuildData() {
						StaticIndexList = new CListO<Frise.IndexList>(),
						StaticVertexList = new CListO<VertexPCT>()
					});
					var indices = new CListP<ushort>();
					var vertices = new CListO<VertexPCT>();

					void AddSquare(Vec2d min, Vec2d max,
						float alphaBottomLeft = 1f, float alphaBottomRight = 1f,
						float alphaTopLeft = 1f, float alphaTopRight = 1f) {
						int vertsCount = vertices.Count;
						indices.Add((ushort)(vertsCount + 0));
						indices.Add((ushort)(vertsCount + 1));
						indices.Add((ushort)(vertsCount + 2));
						indices.Add((ushort)(vertsCount + 1));
						indices.Add((ushort)(vertsCount + 3));
						indices.Add((ushort)(vertsCount + 2));
						vertices.Add(new VertexPCT() {
							pos = new Vec3d(min.x, max.y, 0f),
							uv = new Vec2d(0, 0),
							color = new ColorInteger(1, 1, 1, alphaTopLeft)
						});
						vertices.Add(new VertexPCT() {
							pos = new Vec3d(max.x, max.y, 0f),
							uv = new Vec2d(1, 0),
							color = new ColorInteger(1, 1, 1, alphaTopRight)
						});
						vertices.Add(new VertexPCT() {
							pos = new Vec3d(min.x, min.y, 0f),
							uv = new Vec2d(0, 1),
							color = new ColorInteger(1, 1, 1, alphaBottomLeft)
						});
						vertices.Add(new VertexPCT() {
							pos = new Vec3d(max.x, min.y, 0f),
							uv = new Vec2d(1, 1),
							color = new ColorInteger(1, 1, 1, alphaBottomRight)
						});
					}
					fr.meshBuildData.value.StaticIndexList = new CListO<Frise.IndexList>(
						new List<Frise.IndexList>() {
							new Frise.IndexList() {
								IdTexConfig = 0,
								List = indices
							}
						}
					);
					fr.meshBuildData.value.StaticVertexList = vertices;
					AddSquare(aabb.MIN, aabb.MAX);
					if (outerAABB != null) {
						// Sides
						if(outerAABB.MIN.x < aabb.MIN.x)
							AddSquare(new Vec2d(outerAABB.MIN.x, aabb.MIN.y), new Vec2d(aabb.MIN.x, aabb.MAX.y), alphaBottomLeft: 0f, alphaTopLeft: 0f); // Left side
						if(outerAABB.MAX.x > aabb.MAX.x)
							AddSquare(new Vec2d(aabb.MAX.x, aabb.MIN.y), new Vec2d(outerAABB.MAX.x, aabb.MAX.y), alphaBottomRight: 0f, alphaTopRight: 0f); // Right side
						if(outerAABB.MIN.y < aabb.MIN.y)
							AddSquare(new Vec2d(aabb.MIN.x, outerAABB.MIN.y), new Vec2d(aabb.MAX.x, aabb.MIN.y), alphaBottomLeft: 0f, alphaBottomRight: 0f); // Bottom side
						if(outerAABB.MAX.y > aabb.MAX.y)
							AddSquare(new Vec2d(aabb.MIN.x, aabb.MAX.y), new Vec2d(aabb.MAX.x, outerAABB.MAX.y), alphaTopLeft: 0f, alphaTopRight: 0f); // Top side

						// Corners
						if (outerAABB.MIN.x < aabb.MIN.x && outerAABB.MIN.y < aabb.MIN.y)
							AddSquare(new Vec2d(outerAABB.MIN.x, outerAABB.MIN.y), new Vec2d(aabb.MIN.x, aabb.MIN.y), alphaBottomLeft: 0f, alphaBottomRight: 0f, alphaTopLeft: 0f); // Bottom left corner
						if (outerAABB.MAX.x > aabb.MAX.x && outerAABB.MIN.y < aabb.MIN.y)
							AddSquare(new Vec2d(aabb.MAX.x, outerAABB.MIN.y), new Vec2d(outerAABB.MAX.x, aabb.MIN.y), alphaBottomLeft: 0f, alphaBottomRight: 0f, alphaTopRight: 0f); // Bottom right corner
						if (outerAABB.MIN.x < aabb.MIN.x && outerAABB.MAX.y > aabb.MAX.y)
							AddSquare(new Vec2d(outerAABB.MIN.x, aabb.MAX.y), new Vec2d(aabb.MIN.x, outerAABB.MAX.y), alphaTopLeft: 0f, alphaTopRight: 0f, alphaBottomLeft: 0f); // Top left corner
						if (outerAABB.MAX.x > aabb.MAX.x && outerAABB.MAX.y > aabb.MAX.y)
							AddSquare(new Vec2d(aabb.MAX.x, aabb.MAX.y), new Vec2d(outerAABB.MAX.x, outerAABB.MAX.y), alphaTopLeft: 0f, alphaTopRight: 0f, alphaBottomRight: 0f); // Top right corner
					}

					// Fill in meshStaticAABB based on visual data
					if (fr.meshBuildData.value?.StaticVertexList?.Any() ?? false) {
						fr.meshStaticData = new UbiArt.Nullable<Frise.MeshStaticData>(new Frise.MeshStaticData() {
							LocalAABB = new AABB() {
								MIN = new Vec2d(fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.y)),
								MAX = new Vec2d(fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.x), fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.y))
							},
							WorldAABB = new AABB() {
								MIN = new Vec2d(fr.meshBuildData.value.StaticVertexList.Min(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.StaticVertexList.Min(v => LocalToGlobal3D(v.pos).y)),
								MAX = new Vec2d(fr.meshBuildData.value.StaticVertexList.Max(v => LocalToGlobal3D(v.pos).x), fr.meshBuildData.value.StaticVertexList.Max(v => LocalToGlobal3D(v.pos).y))
							},
						});
						fr.AABB_MinZ = fr.meshBuildData.value.StaticVertexList.Min(v => v.pos.z);
						fr.AABB_MaxZ = fr.meshBuildData.value.StaticVertexList.Max(v => v.pos.z);
					}

					fr.PrimitiveParameters.colorFactor = lighting.GlobalColor;
					fr.PrimitiveParameters.colorFog = UbiArt.Color.White;

					rpScene.FRISE.Add(fr);
				}

				CreateFrise("frontlightfill", "world/common/levelart/light/lightfrieze/frontlightfill.fcg", z: -2f);

				// Remove lighting from RenderParamComponent
				rp.Lighting.Enable = false;
				rp.Lighting = null;
			}
		}
		public void DuplicateActorTemplatesForStartPaused(Context oldContext) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			for(int i = 0; i < l.LoadedActors.Count; i++) { // Not foreach, as actors can be added during the loop
				var act = l.LoadedActors[i];
				if (act.STARTPAUSE && !(act.template?.obj?.STARTPAUSED ?? false) && !(act is SubSceneActor)) {

					var ogPath = act.LUA;
					var ogTpl = act.template;

					if (CloneTemplateIfNecessary(ogPath, "startpaused", "STARTPAUSE", ogTpl, out var newTpl, act)) {
						newTpl.obj.STARTPAUSED = true;
					}
					act.STARTPAUSE = false;
				}
			}
		}

		public void FixLumJarNoPhys(Context oldContext, Actor act) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var physComponent = act.GetComponent<StickToPolylinePhysComponent>();
			var disabled = physComponent.StartDisable;
			var ogPath = act.LUA;
			var ogTpl = act.template;

			var suffix = disabled ? "disablephys" : "modphys";

			if (CloneTemplateIfNecessary(ogPath, suffix, "MODPHYS", ogTpl, out var newTpl, act)) {
				var newTplPhys = newTpl.obj.GetComponent<StickToPolylinePhysComponent_Template>();
				if (disabled) {
					newTplPhys.physGravityMultiplier = 0f;
					newTplPhys.physWeight = 0f;
					newTplPhys.physForce2Speed = 0f;
					newTplPhys.physFriction = 0f;
					newTplPhys.physAngularAirMultiplier = 0f;
					newTplPhys.physFanForceMultiplier = 0f;
					newTplPhys.physWindMultiplier = 0f;
					newTplPhys.physWaterMultiplier = 0f;
				}
				newTplPhys.physRadius = 0f;
				var animTPL = newTpl.obj.GetComponent<AnimatedComponent_Template>();
				animTPL.posOffset = new Vec2d(0,-0.8f);
			}
		}

		public void DuplicateLightingMushroomForGPEColor(Context oldContext, Settings newSettings) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			for (int i = 0; i < l.LoadedActors.Count; i++) { // Not foreach, as actors can be added during the loop
				var act = l.LoadedActors[i];
				var lightingMushroom = act.GetComponent<RO2_LightingMushroomComponent>();
				if (lightingMushroom != null) {
					var gpeColor = lightingMushroom.GPEColor;
					if (gpeColor != uint.MaxValue) {
						if (act.template?.obj?.GetComponent<AnimMeshVertexComponent_Template>() != null) {
							var ogPath = act.LUA;
							var ogTpl = act.template;

							if (CloneTemplateIfNecessary(ogPath, $"gpe{gpeColor}", "LightingMushroom.GPEColor", ogTpl, out var newTpl, act)) {
								var newComponents = new List<Generic<ActorComponent_Template>>();
								foreach (var c in newTpl.obj.COMPONENTS) {
									if (c?.obj is AnimMeshVertexComponent_Template amvComponent) {
										var ogAMVPath = amvComponent.amvPath;
										var newAmvComponent = Merger.Merge<AnimMeshVertexComponent_Template>(amvComponent);
										newAmvComponent.amvPath = new Path(ogAMVPath.FullPath.Replace(".asc", $"__gpe{gpeColor}.asc"));
										var newC = new Generic<ActorComponent_Template>(newAmvComponent);
										newComponents.Add(newC);
									} else {
										newComponents.Add(c);
									}

								}
								newTpl.obj.COMPONENTS = new CArrayO<Generic<ActorComponent_Template>>(newComponents.ToArray());
							}
						}
					}
				}
			}

			// Go over AnimMeshVertex and duplicate those
			if (structs.ContainsKey(typeof(AnimMeshVertex))) {
				Dictionary<Path, AnimMeshVertex> amvToAdd = new Dictionary<Path, AnimMeshVertex>();
				foreach (var amv in structs[typeof(AnimMeshVertex)]) {
					var oldAMV = (AnimMeshVertex)amv.Value;
					for (int i = 0; i < 3; i++) {
						var newAMV = DuplicateLightingMushroomAMV(newSettings, oldAMV, i);
						if (newAMV != null) {
							// Add paths
							var oldPath = l.Paths[amv.Key];
							var oldCookedPath = l.CookedPaths[amv.Key];
							l.Context.SystemLogger?.LogInfo($"Duplicating AMV (LightingMushroom.GPEColor {i}): {oldPath.FullPath}");

							var newPath = new Path(oldPath.FullPath.Replace(".asc", $"__gpe{i}.asc"));
							var newCookedPath = new Path(oldCookedPath.FullPath.Replace(".asc", $"__gpe{i}.asc"), true);

							l.Paths[newPath.stringID] = newPath;
							l.CookedPaths[newPath.stringID] = newCookedPath;

							amvToAdd[newPath] = newAMV;

						}
					}
				}
				foreach (var amv in amvToAdd) {
					structs[typeof(AnimMeshVertex)][amv.Key.stringID] = amv.Value;
				}
			}
		}
		public AnimMeshVertex DuplicateLightingMushroomAMV(Settings settings, AnimMeshVertex oldAMV, int gpeColor) {
			oldAMV.Reinit(settings);
			StringID colorExclusiveAnim, flyAnim, hitAnim, shakeAnim, standAnim, growAnim = null;

			if (gpeColor == 1) { // yellow
				colorExclusiveAnim = new StringID(0xd724387b);
				flyAnim = new StringID(0x41ae4f92);
				hitAnim = new StringID(0x83e3949e);
				shakeAnim = new StringID(0x5f4c34a6);
				standAnim = new StringID(0x2817e8a0);
				growAnim = new StringID(0xe414651a);
			} else if (gpeColor == 0) {
				colorExclusiveAnim = new StringID(0x12545ccf);
				flyAnim = new StringID(0x342e90ca);
				hitAnim = new StringID(0xc47cf1fe);
				shakeAnim = new StringID(0xd6f54d17);
				standAnim = new StringID(0xb604d072);
				growAnim = new StringID(0xfcacddee);
			} else if (gpeColor == 2) { // purple
				colorExclusiveAnim = new StringID(0xebdbf09c);
				flyAnim = new StringID(0xffad5202);
				hitAnim = new StringID(0xb49c8333);
				shakeAnim = new StringID(0xad58fda);
				standAnim = new StringID(0x9d7c590e);
				growAnim = new StringID(0xaf9e8eb4);
			} else {
				return null;
			}
			if(!oldAMV.animFriendly.Contains(flyAnim) || !oldAMV.animFriendly.Contains(growAnim) || !oldAMV.animFriendly.Contains(standAnim))
				return null;

			var newAMV = Merger.Merge<AnimMeshVertex>(oldAMV);
			var strings = new string[] { "fly", "grow", "hit", "shake", "stand" }; // Legends needs 4 variations of each animation
			
			oldAMV.Reinit(settings);

			newAMV.animFriendly = new CListO<StringID>(
				new List<StringID>() {
					colorExclusiveAnim,
				}
			);
			List<StringID> ogAnims = new List<StringID>();
			ogAnims.Add(colorExclusiveAnim);

			foreach (var str in strings) {
				for (int i = 0; i < 4; i++) {
					newAMV.animFriendly.Add(new StringID($"{str}0{i+1}"));
					ogAnims.Add(
						str switch {
							"fly" => flyAnim,
							"grow" => growAnim,
							"hit" => hitAnim,
							"shake" => shakeAnim,
							"stand" => standAnim,
							_ => throw new Exception("Unexpected OG Anim string in DuplicateLightingMushroomAMV")
						});
				}
			}

			newAMV.animIndex = new CListP<uint>(
				ogAnims.Select(ogAnim => oldAMV.animIndex[oldAMV.animFriendly.IndexOf(ogAnim)]).ToList()
			);

			return newAMV;
		}
		public void AddStickToPolylinePhysComponentForSoccerBall(Context oldContext, Settings newSettings) {
			Loader l = oldContext.Loader;

			for (int i = 0; i < l.LoadedActors.Count; i++) { // Not foreach, as actors can be added during the loop
				var act = l.LoadedActors[i];
				var ball = act.GetComponent<RO2_BallComponent>();
				if (ball != null) {
					var stickToPolyline = act.GetComponent<StickToPolylinePhysComponent>();
					if (stickToPolyline == null) {
						stickToPolyline = act.AddComponent<StickToPolylinePhysComponent>();
						var tplBall = act.template?.obj?.GetComponent<RO2_BallComponent_Template>();
						var tplStickToPolyline = act.template?.obj?.GetComponent<StickToPolylinePhysComponent_Template>();
						if (tplStickToPolyline == null) {
							tplStickToPolyline = act.template?.obj?.AddComponent<StickToPolylinePhysComponent_Template>();
							tplStickToPolyline.physRadius = 0.58f;
							tplStickToPolyline.physWeight = 0.3f;
							tplStickToPolyline.physGravityMultiplier = 0.5f;
							tplStickToPolyline.physAirFriction = 4f; // / ball.bounceMultiplier,

							// Hack: Apply bounceMultiplier to bounceCoefFactor in template
							tplBall.bounceCoefFactor_x *= ball.bounceMultiplier;
							tplBall.bounceCoefFactor_y *= ball.bounceMultiplier;
						}
						// Hack: Also set cameraRegisterDelay to float.maxvalue to prevent the camera from moving towards it all the time
						tplBall.cameraRegisterDelay = float.MaxValue;
					}
				}
			}
		}
		public void AddSceneConfigForRotatingPlatform(Context oldContext, Settings newSettings, Scene scene) {

			// TODO: Browse scene instead
			Loader l = oldContext.Loader;

			// Find any rotating platforms
			bool foundRotatingPlatform = false;
			/*foreach (var act in l.LoadedActors) {
				if (act.GetComponent<RLC_RotatingPlatformComponent>() != null) {
					foundRotatingPlatform = true;
					break;
				}
			}*/
			var rotatingPlatformsSearch = scene.FindActors(act => act.GetComponent<RLC_RotatingPlatformComponent>() != null);
			if (rotatingPlatformsSearch?.Any() == true) {
				foundRotatingPlatform = true;
				foreach (var act in rotatingPlatformsSearch) {
					string parentName = null;
					if (act?.Path?.levels != null) {
						parentName = act?.Path?.levels?.Last().name;
					}
					AddMurfyActorsForRotatingPlatform(oldContext, act.ContainingScene, act.Result, parentName);
				}
			}

			if (foundRotatingPlatform) {
				// Find start point
				/*var checkpointSearch = scene.FindActor(act => act.GetComponent<CheckpointComponent>()?.INDEX == 0);
				Actor checkpointActor = checkpointSearch?.Result;
				if (checkpointSearch != null) {
					var sc = checkpointSearch.ContainingScene;

					AddMurfyActorsForRotatingPlatform(oldContext, sc, checkpointActor);

				}*/

				// Add sceneConfig to scene
				if (scene.sceneConfigs == null) scene.sceneConfigs = new SceneConfigs();
				var scfg = scene.sceneConfigs;
				if (scfg.sceneConfigs == null) scfg.sceneConfigs = new CArrayO<Generic<SceneConfig>>();
				var obj = new RO2_SceneConfig_Platform() {
					DRCGameplayMode = RO2_SceneConfig_Base.Enum_DRCGameplayMode.Coop
				};
				scfg.sceneConfigs.Add(new Generic<SceneConfig>(obj));

			}
		}
		public void AddMurfyActorsForRotatingPlatform(Context oldContext, Scene scene, Actor act, string parentName) {
			var l = oldContext.Loader;

			// Create murfy activation action
			var murfyTrigger = new Actor() {
				LUA = new Path("world/common/logicactor/automurphy/component/trigger_box_automurphyactivation.tpl"),
				USERFRIENDLY = "trigger_box_automurphyactivation",
				POS2D = act.POS2D
			};
			l.AddLoadedActor(murfyTrigger);
			murfyTrigger.AddComponent<LinkComponent>();

			var playerDetector = murfyTrigger.AddComponent<PlayerDetectorComponent>();
			playerDetector.localOffset = new Vec2d(0, 0);
			playerDetector.localScale = new Vec2d(3f, 3f);
			playerDetector.useShapeTransform = true;

			murfyTrigger.AddComponent<RO2_DRCMandatoryZoneComponent>();

			if (scene.AddActor(murfyTrigger, "trigger_box_automurphyactivation")) {
				oldContext?.SystemLogger?.LogInfo($"Added Murfy activation actor for {act.USERFRIENDLY}");
			}

			// Create murfy forced action: touch crank (gyro)
			var murfyAction = new Actor() {
				LUA = new Path("world/common/logicactor/automurphy/component/trigger_box_murphyforcedaction.tpl"),
				USERFRIENDLY = "trigger_box_murphyforcedaction_rotatingplatform",
				POS2D = act.POS2D,
				RELATIVEZ = 0.17f,
				SCALE = new Vec2d(7.5f, 7.5f)
			};
			l.AddLoadedActor(murfyAction);
			var murfyActionLink = murfyAction.AddComponent<LinkComponent>(); // Link to gyrocontroller later
			var murfyActionShape = murfyAction.AddComponent<ShapeComponent>();
			murfyActionShape.useShapeTransform = false;
			murfyActionShape.localScale = new Vec2d(10,10);
			var forcedAction = murfyAction.AddComponent<RO2_DRCForceActionComponent>();
			forcedAction.forcedAction = RO2_DRCForceActionComponent.Enum_forcedAction.Gyro;
			forcedAction.autoAction = false;
			forcedAction.useToTargetTravel = true;
			forcedAction.toTargetTravel = new RO2_TravelData() {
				duration = 0.3f,
				accelType = RO2_TravelData.AccelType.InvX2,
				speedType = RO2_TravelData.SpeedType.Uniform
			};
			forcedAction.gyroData = new RO2_DRCForceActionComponent.GyroData() {
				speed = 3.141593f,
				accel = 1.047198f,
				decel = 2.443459f,
				invertRotation = false
			};
			forcedAction.activationData = new RO2_DRCForceActionComponent.ActivationData() {
				activationMode = RO2_DRCForceActionComponent.ActivationData.Enum_activationMode.Multiple,
				stopOnZoneExit = true,
				canRestartAction = true,
				saveBackward = true,
				saveBackwardOnActionExit = true
			};
			if (scene.AddActor(murfyAction, "trigger_box_murphyforcedaction_rotatingplatform")) {
				oldContext?.SystemLogger?.LogInfo($"Added Murfy forced action actor for {act.USERFRIENDLY}");
			}

			// Add gyro controller
			var gyroController = new Actor() {
				USERFRIENDLY = "gyrocontroller_rotatingplatform",
				LUA = new Path("world/common/logicactor/gyroscope/components/gyrocontroller.tpl"),
				POS2D = act.POS2D,
				RELATIVEZ = 0.145384f,
				SCALE = new Vec2d(2.228791f, 2.228791f),
			};
			l.AddLoadedActor(gyroController);
			var gyroTex = gyroController.AddComponent<TextureGraphicComponent>();
			gyroTex.disableLight = 0;
			gyroTex.PrimitiveParameters = new GFXPrimitiveParam() {
				colorFog = new UbiArt.Color(1f, 1f, 1f, 0f),
			};
			gyroTex.material = new GFXMaterialSerializable() {
				textureSet = new GFXMaterialTexturePathSet() {
					diffuse = new Path("world_old/7_landofthedead/levelart/deadjail/frieze/mechanic/wheel_gpe.tga"),
					back_light = new Path("world_old/7_landofthedead/levelart/deadjail/frieze/mechanic/wheel_gpe_back.tga"),
				},
				shaderPath = new Path("world/common/matshader/regularbuffer/backlighted.msh")
			};
			var gyroComp = gyroController.AddComponent<RO2_GyroControllerComponent>();
			gyroComp.cursorSmooth = 0.1f;
			gyroComp.angleMultiplier = 1.5f;
			gyroComp.forcedAngleMultiplier = 1f;
			gyroComp.TVOffcameraZOffset = 25f;
			gyroComp.TVOffcameraResetMultiplier = false;
			var gyroControllerLink = gyroController.AddComponent<LinkComponent>();
			gyroController.AddComponent<RO2_CrankComponent>().shape = new EditableShape() {
				shape = new Generic<PhysShape>(new PhysShapeBox() {
					Points = new CListO<Vec2d>() {
						new Vec2d(-2.22879f, -2.22879f),
						new Vec2d(-2.22879f, 2.22879f),
						new Vec2d(2.22879f, 2.22879f),
						new Vec2d(2.22879f, -2.22879f),
					},
					normals = new CListO<Vec2d>() {
						Vec2d.Left,
						Vec2d.Up,
						Vec2d.Right,
						Vec2d.Down,
					},
					edge = new CListO<Vec2d>() {
						Vec2d.Up,
						Vec2d.Right,
						Vec2d.Down,
						Vec2d.Left,
					},
					distances = new CArrayP<float>(Enumerable.Repeat(4.45758f, 4).ToArray()),
					Extent = Vec2d.One,
				})
			};
			gyroController.AddComponent<TouchDetectorComponent>().useShapeTransform = false;
			gyroController.AddComponent<TriggerComponent>().mode = TriggerComponent.Mode.Multiple;
			var tuto = gyroController.AddComponent<RO2_DisplayTutoIconComponent>();
			tuto.tutoType = RO2_DisplayTutoIconComponent.TutoType.DRC_Tap;
			tuto.tutoType2 = RO2_DisplayTutoIconComponent.TutoType2.DRC_Tap;
			tuto.scale = 3;
			tuto.displayTuto = true;
			gyroController.AddComponent<FXControllerComponent>();
			gyroController.AddComponent<SoundComponent>();

			if (scene.AddActor(gyroController, "gyrocontroller_rotatingplatform")) {
				oldContext?.SystemLogger?.LogInfo($"Added gyrocontroller actor for {act.USERFRIENDLY}");
			}
			// Create links
			murfyActionLink.Children = new CListO<ChildEntry>() {
				new ChildEntry() {
					Path = new ObjectPath() {
						id = gyroController.USERFRIENDLY
					},
				},
			};
			gyroControllerLink.Children = new CListO<ChildEntry>() {
				new ChildEntry() {
					Path = new ObjectPath() {
						id = parentName ?? scene.ACTORS[1].obj.USERFRIENDLY,
						levels = parentName != null ? new CListO<ObjectPath.Level>() {
							new ObjectPath.Level() {
								name = parentName,
								parent = true,
							},
						} : null,
					},
					TagValues = new CListO<TagValue>() {
						new TagValue() {
							Tag = new StringID(0xFC4D8276),
							Value = "",
						}
					}
				},
			};
		}

		// Returns true if the new template was created with this call
		public bool CloneTemplateIfNecessary(Path ogPath, string suffix, string reason, GenericFile<Actor_Template> ogTPL, out GenericFile<Actor_Template> newTPL, Actor act = null) {
			var oldContext = MainContext;
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var newPath = new Path(ogPath.FullPath.Replace(".tpl", $"__{suffix}.tpl"));

			bool clonedTemplate = false;
			if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
				clonedTemplate = true;
				l.Context.SystemLogger?.LogInfo($"Duplicating template ({reason}): {ogPath.FullPath}");
				newTPL = new GenericFile<Actor_Template>(ogTPL.obj?.Clone("tpl"/*, context: LegendsContext*/) as Actor_Template);
				newTPL.sizeOf = ogTPL.sizeOf;

				var oldCookedPath = l.CookedPaths[ogPath.stringID];
				var newCookedPath = new Path(oldCookedPath.FullPath.Replace(".tpl", $"__{suffix}.tpl"), true);
				l.CookedPaths[newPath.stringID] = newCookedPath;
				l.Paths[newPath.stringID] = newPath;
				structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTPL;
			} else {
				newTPL = (GenericFile<Actor_Template>)structs[typeof(GenericFile<Actor_Template>)][newPath.stringID];
			}
			if (act != null) {
				act.LUA = new Path(newPath.FullPath);
				act.template = newTPL;
			}

			return clonedTemplate;
		}


		public bool CreateTemplateIfNecessary(Path newPath, string reason, out GenericFile<Actor_Template> newTPL, Actor act = null) {
			var oldContext = MainContext;
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			bool createdTemplate = false;
			if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
				createdTemplate = true;
				l.Context.SystemLogger?.LogInfo($"Creating template ({reason}): {newPath.FullPath}");
				newTPL = new GenericFile<Actor_Template>(new Actor_Template());

				var newCookedPath = newPath.CookedPath(oldContext);
				l.CookedPaths[newPath.stringID] = newCookedPath;
				l.Paths[newPath.stringID] = newPath;
				structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTPL;
			} else {
				newTPL = (GenericFile<Actor_Template>)structs[typeof(GenericFile<Actor_Template>)][newPath.stringID];
			}
			if (act != null) {
				act.LUA = new Path(newPath.FullPath);
				act.template = newTPL;
			}

			return createdTemplate;
		}
		#endregion


		#region Dispose

		public void Close() {
			StopLoadingScreen();
			LegendsContext?.Dispose();
		}
		public void Dispose() {
			Close();
		}

		#endregion
	}
}
