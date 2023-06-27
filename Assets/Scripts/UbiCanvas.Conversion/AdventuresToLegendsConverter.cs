﻿using Cysharp.Threading.Tasks;
using ImageMagick;
using JetBrains.Annotations;
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
using UnityEngine;

namespace UbiCanvas.Conversion {
	public class AdventuresToLegendsConverter {
		public async UniTask Convert(Context mainContext, string rlPath, string outPath, string projectPath, bool exportRaw = true) {
			var basePath = rlPath;
			var settings = Settings.Init(Settings.Mode.RaymanLegendsPC);

			string lvlPath = UnitySettings.SelectedLevelFile;
			string sceneName = System.IO.Path.GetFileName(lvlPath);
			if (sceneName.Contains('.')) sceneName = sceneName.Substring(0, sceneName.IndexOf('.'));

			Loader l = mainContext.Loader;
			var structs = l.Context.Cache.Structs;
			var oldSettings = l.Settings;

			// Create conversion settings
			var conversionSettings = new ConversionSettings() {
				OldSettings = oldSettings,
			};
			if (oldSettings.game == Settings.Game.RA || oldSettings.game == Settings.Game.RM) {
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
					new PathConversionRule("world/adversarial/soccerpunch/actor/soccerball/", "world/adversarial/soccerpunch/actor/soccerball_adv/"));

				// FX - Sadly, can't just replace the whole textures folder (it breaks maps like spikyspinners), so... case by case
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
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/textures_adv/smoke/fx_smokeship_01.tga", "world/common/fx/textures/smoke/fx_smokeship_01.tga"));
				// TODO: Find a solution for the ParticleGenerator "meshes" not being supported in RL

				/*conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/", "world/common/fx_/"));*/
				/*conversionSettings.PathConversionRules.Add(
					new PathConversionRule("world/common/fx/lifeelements2/dust/", "world/common/fx/lifeelements2/dust_adv/"));*/
				//conversionSettings.PathConversionRules.Add(
				//	new PathConversionRule("world/common/ldfrieze/polystyrene/frieze/", "world/common/ldfrieze/polystyrene/frieze_adv/"));
			}
			if (oldSettings.game == Settings.Game.RM) {
				conversionSettings.PathConversionRules.Add(
					new PathConversionRule("common/lifeelements/dragonfly/", "common/lifeelements/dragonfly_mini/"));
			}

			CreateFriseParents(mainContext, settings, Controller.Obj.MainScene.obj);
			DuplicateActorTemplatesForStartPaused(mainContext);
			DuplicateLightingMushroomForGPEColor(mainContext, settings);
			AddStickToPolylinePhysComponentForSoccerBall(mainContext, settings);
			AddSceneConfigForRotatingPlatform(mainContext, settings, Controller.Obj.MainScene.obj);


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
			using (var rlContextExt = new Context(UnitySettings.GameDirs[Settings.Mode.RaymanLegendsPC],
				Settings.Init(Settings.Mode.RaymanLegendsPC),
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
				string exportFile = System.IO.Path.Combine(projectPath, "json", "atlascontainer", $"{sceneName}.json");
				System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(exportFile));
				System.IO.File.WriteAllText(exportFile, JsonConvert.SerializeObject(newUVEntries, Formatting.Indented));
				Debug.Log($"Exported json: {exportFile}");
			}
			Debug.Log($"Finished exporting {sceneName}.");
		}

		protected Context CreateContext(Settings.Mode mode,
			string basePath = null,
			bool enableSerializerLog = true) {
			if (basePath == null) basePath = UnitySettings.GameDirs[mode];

			Context context = new(basePath, Settings.Init(mode),
				serializerLogger: enableSerializerLog ? new MapViewerSerializerLogger() : null,
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController());

			return context;

		}

		public async Task ConvertCostumes(string projectPath, Settings.Mode sourceMode) {
			var mainMode = "";
			uint baseLocId = 0;
			if (sourceMode == Settings.Mode.RaymanMiniMacOS) {
				mainMode = "mini";
				baseLocId = 9000;
			} else if (sourceMode == Settings.Mode.RaymanAdventuresAndroid) {
				mainMode = "adventures";
				baseLocId = 20000;
			}
			var dataID = $"costumes_{mainMode}";
			Path pGameConfig = new Path("enginedata/gameconfig/gameconfig.isg");
			Path pGameConfigExtended = new Path("enginedata/gameconfigextended/gameconfigextended.isg");
			var levelsJsonPath = System.IO.Path.Combine(projectPath, "json", "levels");
			var dataOutputPath = System.IO.Path.Combine(projectPath, "data", dataID);

			using var rlContextExt = CreateContext(Settings.Mode.RaymanLegendsPC);
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
				if (sourceMode == Settings.Mode.RaymanAdventuresAndroid) {
					sourceContext.Loader.LoadGenericFile(pGameConfigExtended, isg => {
						gcExtended = isg.obj as RO2_GameConfigExtended_Template;
					});
				}
				await sourceContext.Loader.LoadLoop();

				var playerIDInfo = sourceContext.Loader.gameConfig.playerIDInfo.ToList();
				if (gcExtended.playerIDInfo != null) {
					playerIDInfo.AddRange(gcExtended.playerIDInfo);
				}

				foreach(var skin in playerIDInfo)
				{
					var player = skin.obj as RO2_PlayerIDInfo;
					//if(player.family != "Rayman" && player.family != "Globox" && player.family != "Barbara") continue;
					if(rlContextExt.Loader.gameConfig.playerIDInfo.Any(c => c.obj.id.ToUpperInvariant() == player.id.ToUpperInvariant())) continue;

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

		#region Specific adjustments
		public void CreateFriseParents(Context oldContext, Settings newSettings, Scene scene) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			List<SubSceneActor> parentActors = new List<SubSceneActor>();

			bool ShouldCreateParentActorForFrise(Frise f) {
				if (!(newSettings.game == Settings.Game.RA || newSettings.game == Settings.Game.RM)) {
					if (f.parentBind != null && f.parentBind.read == true)
						return true;
					if (f.COMPONENTS != null && f.COMPONENTS.Any(c => c?.obj != null))
						return true;
				}
				return false;
			}
			SubSceneActor CreateParentActor(Frise f) {
				var newFrise = f.Clone("isc") as Frise;
				var parent = Merger.Merge<SubSceneActor>(f);
				parent.EMBED_SCENE = true;
				parent.SCENE = new UbiArt.Nullable<Scene>() {
					read = true,
					value = new Scene() {
						FRISE = new CListO<Frise>() { newFrise }
					}
				};

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
		public void DuplicateActorTemplatesForStartPaused(Context oldContext) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			for(int i = 0; i < l.LoadedActors.Count; i++) { // Not foreach, as actors can be added during the loop
				var act = l.LoadedActors[i];
				if (act.STARTPAUSE && !(act.template?.obj?.STARTPAUSED ?? false)) {

					var ogPath = act.LUA;
					var ogTpl = act.template;

					var newPath = new Path(ogPath.FullPath.Replace(".tpl", "__startpaused.tpl"));
					act.LUA = new Path(newPath.FullPath);

					if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
						l.Context.SystemLogger?.LogInfo($"Duplicating template (STARTPAUSE): {ogPath.FullPath}");
						var newTpl = new GenericFile<Actor_Template>(ogTpl.obj?.Clone("tpl") as Actor_Template);
						newTpl.sizeOf = ogTpl.sizeOf;
						newTpl.obj.STARTPAUSED = true;
						var oldCookedPath = l.CookedPaths[ogPath.stringID];
						var newCookedPath = new Path(oldCookedPath.FullPath.Replace(".tpl", "__startpaused.tpl"), true);
						l.CookedPaths[newPath.stringID] = newCookedPath;
						l.Paths[newPath.stringID] = newPath;
						structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTpl;
					}
					act.template = (GenericFile<Actor_Template>)structs[typeof(GenericFile<Actor_Template>)][newPath.stringID];
					act.STARTPAUSE = false;
				}
			}
		}
		public void DuplicateLightingMushroomForGPEColor(Context oldContext, Settings newSettings) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			for (int i = 0; i < l.LoadedActors.Count; i++) { // Not foreach, as actors can be added during the loop
				var act = l.LoadedActors[i];
				var lightingMushroom = act.GetComponent<RO2_LightingMushroomComponent>();
				if (lightingMushroom != null) {

					// Trigger hack (Adventures & Mini send trigger events when the mushroom is hit) TODO: Improve.
					var tmpl = act.template?.obj?.GetComponent<TriggerComponent_Template>();
					if (tmpl != null) {
						tmpl.triggerChildren = true;
						tmpl.triggerOnHit = true;
						tmpl.triggerOnDetector = false;
						tmpl.onEnterEvent = new Generic<UbiArt.ITF.Event>(new EventTrigger() { activated = true });
						tmpl.onEnterEvent.className = new StringID(tmpl.onEnterEvent.obj.ClassCRC ?? uint.MaxValue);
						tmpl.onExitEvent = null;
					}
					// TODO: Change restartTimer in template as well if fireOnce is set

					var gpeColor = lightingMushroom.GPEColor;
					if (gpeColor != uint.MaxValue) {
						if (act.template?.obj?.GetComponent<AnimMeshVertexComponent_Template>() != null) {
							var ogPath = act.LUA;
							var ogTpl = act.template;

							var newPath = new Path(ogPath.FullPath.Replace(".tpl", $"__gpe{gpeColor}.tpl"));
							act.LUA = new Path(newPath.FullPath);

							if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
								l.Context.SystemLogger?.LogInfo($"Duplicating template (LightingMushroom.GPEColor): {ogPath.FullPath}");

								var newTpl = new GenericFile<Actor_Template>(ogTpl.obj?.Clone("tpl") as Actor_Template);

								newTpl.obj.COMPONENTS = new CArrayO<Generic<ActorComponent_Template>>();
								foreach (var c in ogTpl.obj.COMPONENTS) {
									if (c?.obj is AnimMeshVertexComponent_Template amvComponent) {
										var ogAMVPath = amvComponent.amvPath;
										var newAmvComponent = Merger.Merge<AnimMeshVertexComponent_Template>(amvComponent);
										newAmvComponent.amvPath = new Path(ogAMVPath.FullPath.Replace(".asc", $"__gpe{gpeColor}.asc"));
										var newC = new Generic<ActorComponent_Template>(newAmvComponent);
										newTpl.obj.COMPONENTS.Add(newC);
									} else {
										newTpl.obj.COMPONENTS.Add(c);
									}

								}
								var oldCookedPath = l.CookedPaths[ogPath.stringID];
								var newCookedPath = new Path(oldCookedPath.FullPath.Replace(".tpl", $"__gpe{gpeColor}.tpl"), true);
								l.CookedPaths[newPath.stringID] = newCookedPath;
								l.Paths[newPath.stringID] = newPath;
								structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTpl;
							}
							act.template = (GenericFile<Actor_Template>)structs[typeof(GenericFile<Actor_Template>)][newPath.stringID];
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
					DRCGameplayMode = RO2_SceneConfig_Base.Enum_DRCGameplayMode.Coop,
				};
				scfg.sceneConfigs.Add(new Generic<SceneConfig>(obj));

			}
		}
		public void AddMurfyActorsForRotatingPlatform(Context oldContext, Scene scene, Actor act, string parentName) {

			// Create murfy activation action
			var murfyTrigger = new Actor() {
				LUA = new Path("world/common/logicactor/automurphy/component/trigger_box_automurphyactivation.tpl"),
				USERFRIENDLY = "trigger_box_automurphyactivation",
				POS2D = act.POS2D
			};
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
		#endregion
	}
}
