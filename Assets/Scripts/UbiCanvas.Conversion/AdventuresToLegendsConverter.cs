using Cysharp.Threading.Tasks;
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

		public async Task ImportAtlasContainer(string projectPath) {
			var uvManagerPath = System.IO.Path.Combine(projectPath, "json", "atlascontainer");
			var outPath = System.IO.Path.Combine(projectPath, "data", "_patch");
			var files = System.IO.Directory.Exists(uvManagerPath) ? System.IO.Directory.GetFiles(uvManagerPath, "*.json") : null;
			if (files != null && files.Any()) {
				files = files.OrderBy(f => f).ToArray();
				Dictionary<string, UbiArt.UV.UVAtlas> newUVEntries = new Dictionary<string, UbiArt.UV.UVAtlas>();
				using (var rlContextExt = CreateContext(Settings.Mode.RaymanLegendsPC)) {
					await rlContextExt.Loader.LoadInitial();
					var uvManager = rlContextExt.Loader.uvAtlasManager;

					foreach (var f in files) {
						var json = System.IO.File.ReadAllText(f);
						var curUVEntries = JsonConvert.DeserializeObject<Dictionary<string, UbiArt.UV.UVAtlas>>(json);
						foreach (var entry in curUVEntries) {
							if(!newUVEntries.ContainsKey(entry.Key)) // For high priority entries, prefix them with _ or something
								newUVEntries[entry.Key] = entry.Value;
						}
					}
					foreach (var entry in newUVEntries) {
						var path = new Path(entry.Key, cooked: false);
						if(!uvManager.atlas.ContainsKey(path.stringID))
							uvManager.atlas.Add(path.stringID, entry.Value);
					}
					var bun = new UbiArt.Bundle.BundleFile();
					bun.AddFile(rlContextExt.Loader.CookedPaths[new Path("atlascontainer").stringID], uvManager);
					await rlContextExt.Loader.WriteFilesRaw(outPath, bun);
				}
			}
		}

		public async Task ImportLocalisation(string projectPath) {
			// WIP
			var locJSONPath = System.IO.Path.Combine(projectPath, "json", "localisation");
			var outPath = System.IO.Path.Combine(projectPath, "output");
			var files = System.IO.Directory.Exists(locJSONPath) ? System.IO.Directory.GetFiles(locJSONPath, "*.json") : null;
			if (files != null && files.Any()) {
				files = files.OrderBy(f => f).ToArray();
				using (var rlContextExt = CreateContext(Settings.Mode.RaymanLegendsPC)) {
					await rlContextExt.Loader.LoadInitial();
					var loc = rlContextExt.Loader.localisation;
					Path pLoc = new Path("EngineData/Localisation/", "localisation.loc8") { specialUncooked = true };
					var locales = loc.Locales;
					Dictionary<string, int> langCodeMap = Enumerable.Range(0, locales.Length).ToDictionary(l => locales[l].ToUpperInvariant());

					foreach (var f in files) {
						var json = System.IO.File.ReadAllText(f);
						var locData = JsonConvert.DeserializeObject<List<JSON_LocalisationData>>(json);
						foreach (var l in locData) {
							var id = new LocalisationId(l.ID);
							foreach (var lang in l.Text) {
								var k = lang.Key.ToUpperInvariant();
								if (langCodeMap.ContainsKey(k)) {
									var langIndex = langCodeMap[k];
									if (loc.strings.ContainsKey(langIndex)) {
										var langMap = loc.strings[langIndex];
										langMap.Add(id, new LocText() { text = lang.Value });
									}
								} else {
									throw new Exception($"Lang code not found: {lang.Key}");
								}
							}
						}
					}

					var bun = new UbiArt.Bundle.BundleFile();
					bun.AddFile(pLoc, loc);
					await rlContextExt.Loader.WriteFilesRaw(outPath, bun);
				}
			}
		}

		public async Task ImportLevelsAndCostumes(string projectPath) {
			var levelsJsonPath = System.IO.Path.Combine(projectPath, "json", "levels");
			var outPath = System.IO.Path.Combine(projectPath, "data", "_patch");
			var costumesBuildPath = System.IO.Path.Combine(projectPath, "data", "_costumes_build");

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
					var costumesBun = new UbiArt.Bundle.BundleFile();

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

					async Task BuildCostume(JSON_CostumeInfo costume) {
						var family = costume.Family.ToLowerInvariant();

						if (costume.TrailColor == null && costume.DeathBubbleColor != null) {
							var c = costume.DeathBubbleColor;
							costume.TrailColor = new UbiArt.Color(c.r, c.g, c.b, 0.5019608f);
						}
						var textureBanksDict = costume.TextureBanks?.ToDictionary(kv => new StringID(kv.Key));
						foreach (var bnk in costume.TextureBanks) {
							bnk.Value.ID = bnk.Key;
						}

						JSON_CostumeInfo.JSON_TextureBank GetBankByID(StringID sid, string fallback = null) {
							// Try to get specific bank from dictionary first.
							if (costume.TextureBanks != null) {
								if (textureBanksDict.ContainsKey(sid)) {
									return textureBanksDict[sid].Value;
								}
								if (fallback != null) {
									if(costume.TextureBanks.ContainsKey(fallback))
										return costume.TextureBanks[fallback];
								}
								if(costume.TextureBanks.ContainsKey("pack"))
									return costume.TextureBanks["pack"];
							}
							return null;
						}

						if (!string.IsNullOrWhiteSpace(costume.ActorPath_Main)) {
							var cookedPath = new Path(costume.ActorPath_Main).CookedPath(rlContextExt);
							if (!System.IO.File.Exists(System.IO.Path.Combine(costumesBuildPath, cookedPath.FullPath))) {
								var basePath = $"world/common/playablecharacter/{family}/";
								var actorToClone = family switch {
									"teensy"  => $"{basePath}teensy_classicking.act",
									_ => $"{basePath}{family}.act"
								};
								var pOriginalActor = new Path(actorToClone);
								pOriginalActor.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();

								var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
								var newActor = (Actor)(await rlContextExt.Loader.Clone(originalActor.obj, "act"));
								var newActorContainer = new ContainerFile<Actor>() {
									read = true,
									obj = newActor
								};

								// Load template too
								originalActor.obj.LUA.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();
								var originalActorTPL = originalActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();

								var mainPlayerControllerComponent = newActor.GetComponent<RO2_PlayerControllerComponent>();
								var mainAnimatedComponent = newActor.GetComponent<AnimatedComponent>();
								var tplAnimatedComponent = originalActorTPL.obj.GetComponent<AnimatedComponent_Template>();

								mainPlayerControllerComponent.trailPath = new Path(costume.TemplatePath_Trail);
								mainAnimatedComponent.subSkeleton = new StringID(costume.SubSkeleton);
								foreach (var tpl_b in tplAnimatedComponent.animSet.animPackage.textureBank) {
									if (!mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Any(act_b => act_b.id == tpl_b.id)) {
										mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Add(new TextureBankPath() {
											sizeOf = 1340,
											id = tpl_b.id,
											materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
											textureSet = new GFXMaterialTexturePathSet() {
												sizeOf = 1036,
											},

										});
									}
								}
								foreach (var tb in mainAnimatedComponent.subAnimInfo.animPackage.textureBank) {
									var jsonb = GetBankByID(tb.id);
									tb.patchBank = new Path(jsonb.PBK);
									tb.textureSet.diffuse = new Path(jsonb.Diffuse);
									tb.textureSet.back_light = new Path(jsonb.Backlight);
								}

								/*var scoreActor = player.defaultGameScreenInfo.actors[1].file.GetObject<ContainerFile<UbiArt.ITF.Actor>>();
								scoreActor.obj.GetComponent<RO2_PlayerHudScoreComponent>().characterMaterial.textureSet.diffuse = player.iconTexturePath;*/


								costumesBun.AddFile(cookedPath, newActorContainer);
							}
						}

						if (!string.IsNullOrWhiteSpace(costume.ActorPath_Moskito)) {
							var cookedPath = new Path(costume.ActorPath_Moskito).CookedPath(rlContextExt);
							if (!System.IO.File.Exists(System.IO.Path.Combine(costumesBuildPath, cookedPath.FullPath))) {
								var moskitoFamily = family switch {
									"rayman" => "ray",
									"globox" => "glob",
									_ => family
								};
								var basePath = $"world/common/shooter/playablecharacter/shootermoskito{moskitoFamily}/";
								var actorToClone = family switch {
									"teensy" => $"{basePath}shootermoskitoteensy_classicking.act",
									_ => $"{basePath}shootermoskito{moskitoFamily}.act"
								};
								var pOriginalActor = new Path(actorToClone);
								pOriginalActor.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();

								var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
								var newActor = (Actor)(await rlContextExt.Loader.Clone(originalActor.obj, "act"));
								var newActorContainer = new ContainerFile<Actor>() {
									read = true,
									obj = newActor
								};

								// Load template too
								originalActor.obj.LUA.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();
								var originalActorTPL = originalActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();

								var mainAnimatedComponent = newActor.GetComponent<AnimatedComponent>();
								var tplAnimatedComponent = originalActorTPL.obj.GetComponent<AnimatedComponent_Template>();

								// No need to set the subskeleton for the Moskito actor! It's always null
								//mainAnimatedComponent.subSkeleton = new StringID(costume.SubSkeleton);
								
								foreach (var tpl_b in tplAnimatedComponent.animSet.animPackage.textureBank) {
									if (!mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Any(act_b => act_b.id == tpl_b.id)) {
										mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Add(new TextureBankPath() {
											sizeOf = 1340,
											id = tpl_b.id,
											materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
											textureSet = new GFXMaterialTexturePathSet() {
												sizeOf = 1036,
											},

										});
									}
								}
								foreach (var tb in mainAnimatedComponent.subAnimInfo.animPackage.textureBank) {
									var jsonb = GetBankByID(tb.id, fallback: "pack_shootermoskito");
									if (jsonb.ID != "pack") {
										// Source is a version that has Moskito sprites. Use this patchbank for everything.
										tb.patchBank = new Path(jsonb.PBK);

										if (jsonb.ID != "pack_shootermoskito"
											|| (tb.id != new StringID("shootermoskitodeath")  // These two are never included in pack_shootermoskito 
												&& tb.id != new StringID($"shootermoskitoray_a"))
											) {
											tb.textureSet.diffuse = new Path(jsonb.Diffuse);
											tb.textureSet.back_light = new Path(jsonb.Backlight);
										}
									} else {
										// Source is the main packed sprite sheet. No Moskito sprites in this, so use the default PBK for those instead.
										if (tb.id != new StringID("shootermoskitodeath")
											&& tb.id != new StringID($"shootermoskitoray_a") // Used for teensy & barbara too
											&& tb.id != new StringID($"shootermoskitoglob_a") // Only Globox has his own bank
										) {
											tb.patchBank = new Path(jsonb.PBK);

											tb.textureSet.diffuse = new Path(jsonb.Diffuse);
											tb.textureSet.back_light = new Path(jsonb.Backlight);
										}
									}
								}

								costumesBun.AddFile(cookedPath, newActorContainer);
							}
						}

						if (!string.IsNullOrWhiteSpace(costume.ActorPath_Duck)) {
							var cookedPath = new Path(costume.ActorPath_Duck).CookedPath(rlContextExt);
							if (!System.IO.File.Exists(System.IO.Path.Combine(costumesBuildPath, cookedPath.FullPath))) {
								var basePath = $"world/common/playablecharacter/duck/";
								var actorToClone = $"{basePath}duck_{family}.act";
								var pOriginalActor = new Path(actorToClone);
								pOriginalActor.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();

								var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
								var newActor = (Actor)(await rlContextExt.Loader.Clone(originalActor.obj, "act"));
								var newActorContainer = new ContainerFile<Actor>() {
									read = true,
									obj = newActor
								};

								// Load template too
								originalActor.obj.LUA.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();
								var originalActorTPL = originalActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();

								var mainAnimatedComponent = newActor.GetComponent<AnimatedComponent>();
								var tplAnimatedComponent = originalActorTPL.obj.GetComponent<AnimatedComponent_Template>();

								// No need to set the subskeleton for the Moskito actor! It's always null
								//mainAnimatedComponent.subSkeleton = new StringID(costume.SubSkeleton);

								foreach (var tpl_b in tplAnimatedComponent.animSet.animPackage.textureBank) {
									if (!mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Any(act_b => act_b.id == tpl_b.id)) {
										mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Add(new TextureBankPath() {
											sizeOf = 1340,
											id = tpl_b.id,
											materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
											textureSet = new GFXMaterialTexturePathSet() {
												sizeOf = 1036,
											},

										});
									}
								}
								foreach (var tb in mainAnimatedComponent.subAnimInfo.animPackage.textureBank) {
									void ConfigureTexturesBasedOnDuckType() {
										var duckTypeInt = (((int)costume.DuckType) + 1);
										var duckPath = $"world/common/playablecharacter/duck/animation/";
										if (tb.id == new StringID("duck_a1")) {
											duckPath += $"duck_a{duckTypeInt}";
										} else {
											duckPath += $"duck_c{duckTypeInt}";
										}
										tb.textureSet.diffuse = new Path($"{duckPath}.tga");
										tb.textureSet.back_light = new Path($"{duckPath}_back.tga");
									}
									var jsonb = GetBankByID(tb.id, fallback: "pack_duck");
									if (jsonb.ID != "pack" && jsonb.ID != "pack_duck") {
										// Source is a version that has Duck sprites. Use this patchbank regardless
										tb.patchBank = new Path(jsonb.PBK);

										// To allow for easier json editing, automatically determine the duck body sprites to use based on duck type enum.
										// You can still specify the sprites too, this only happens if diffuse is null
										if (jsonb.Diffuse == null && (tb.id == new StringID("duck_a1") || tb.id == new StringID("duck_c1"))) { // Duck bodies
											ConfigureTexturesBasedOnDuckType();
										} else {
											tb.textureSet.diffuse = new Path(jsonb.Diffuse);
											tb.textureSet.back_light = new Path(jsonb.Backlight);
										}
									} else {
										if (tb.id == new StringID("duck_a1") || tb.id == new StringID("duck_c1")) {
											// Don't change PBK
											ConfigureTexturesBasedOnDuckType();
										} else {
											tb.patchBank = new Path(jsonb.PBK);
											tb.textureSet.diffuse = new Path(jsonb.Diffuse);
											tb.textureSet.back_light = new Path(jsonb.Backlight);
										}
									}
								}

								costumesBun.AddFile(cookedPath, newActorContainer);
							}
						}

						if (!string.IsNullOrWhiteSpace(costume.ActorPath_ScoreHUD)) {
							var cookedPath = new Path(costume.ActorPath_ScoreHUD).CookedPath(rlContextExt);
							if (!System.IO.File.Exists(System.IO.Path.Combine(costumesBuildPath, cookedPath.FullPath))) {
								var basePath = $"world/common/ui/common/playerscore/";
								var actorToClone = family switch {
									"teensy" => $"{basePath}scorehud_teensyclassicking.act",
									_ => $"{basePath}scorehud_{family}.act"
								};
								var pOriginalActor = new Path(actorToClone);
								pOriginalActor.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();

								var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
								var newActor = (Actor)(await rlContextExt.Loader.Clone(originalActor.obj, "act"));
								var newActorContainer = new ContainerFile<Actor>() {
									read = true,
									obj = newActor
								};

								newActor.GetComponent<RO2_PlayerHudScoreComponent>().characterMaterial.textureSet.diffuse = new Path(costume.IconPath);

								costumesBun.AddFile(cookedPath, newActorContainer);
							}
						}

						if (!string.IsNullOrWhiteSpace(costume.ActorPath_Painting)) {
							var cookedPath = new Path(costume.ActorPath_Painting).CookedPath(rlContextExt);
							if (!System.IO.File.Exists(System.IO.Path.Combine(costumesBuildPath, cookedPath.FullPath))) {
								var basePath = $"world/home/actor/costumes/";
								var actorToClone = family switch {
									"teensy" => $"{basePath}costumeteensy_classicking.act",
									"barbara" => $"{basePath}costumebarbara_mainroom.act",
									_ => $"{basePath}costume{family}.act"
								};
								var pOriginalActor = new Path(actorToClone);
								pOriginalActor.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();

								var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
								var newActor = (Actor)(await rlContextExt.Loader.Clone(originalActor.obj, "act"));
								var newActorContainer = new ContainerFile<Actor>() {
									read = true,
									obj = newActor
								};

								newActor.LUA = new Path(costume.TemplatePath_Painting);

								var costumeComponent = newActor.GetComponent<RO2_PlayerCostumeComponent>();
								costumeComponent.costumeId = new StringID(costume.CostumeID);
								costumeComponent.nameLocId = new LocalisationId(costume.NameID);
								costumeComponent.descriptionLocId = new LocalisationId(costume.DescriptionID);

								costumesBun.AddFile(cookedPath, newActorContainer);
							}
						}

						if (!string.IsNullOrWhiteSpace(costume.TemplatePath_Painting)) {
							var cookedPath = new Path(costume.TemplatePath_Painting).CookedPath(rlContextExt);
							if (!System.IO.File.Exists(System.IO.Path.Combine(costumesBuildPath, cookedPath.FullPath))) {
								var basePath = $"world/home/actor/costumes/components/";
								var actorToClone = family switch {
									"teensy" => $"{basePath}costumeteensy_classicking.tpl",
									_ => $"{basePath}costume{family}.tpl"
								};
								var pOriginalActor = new Path(actorToClone);
								var animPath = new Path($"world/common/playablecharacter/{family}/animation/{costume.Painting.Animation}.anm");
								pOriginalActor.LoadObject(rlContextExt);
								animPath.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();

								var paintingAnim = animPath.GetObject<AnimTrack>();
								var originalTPL = pOriginalActor.GetObject<GenericFile<Actor_Template>>();
								var newTPL = (Actor_Template)(await rlContextExt.Loader.Clone(originalTPL.obj, "tpl"));
								var newTPLContainer = new GenericFile<Actor_Template>(newTPL) {
									sizeOf = originalTPL.sizeOf
								};

								var animComponent = newTPL.GetComponent<AnimLightComponent_Template>();
								var subAnim = animComponent.animSet.animations.FirstOrDefault(a => a.friendlyName == new StringID("Available"));
								var ogAnimPath = subAnim.name;
								subAnim.name = animPath;
								var aabb = animComponent.animSet.animPackage.animPathAABB.FirstOrDefault(a => a.path == ogAnimPath);
								aabb.path = animPath;
								aabb.name = new StringID(costume.Painting.Animation);
								// TODO: Also adjust aabb.aabb here

								// Add texture banks required by animation
								//animComponent.animSet.animPackage.textureBank.Clear();
								var textureBank = animComponent.animSet.animPackage.textureBank;
								foreach (var bml in paintingAnim.bml) {
									foreach (var entry in bml.entries) {
										var bankID = entry.textureBankId;
										if (!textureBank.Any(tb => tb.id == bankID)) {
											textureBank.Add(new TextureBankPath() {
												sizeOf = 1340,
												id = bankID,
												materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
												textureSet = new GFXMaterialTexturePathSet() {
													sizeOf = 1036,
												}
											});
											newTPLContainer.sizeOf += 1340 + 1036;
										}
									}
								}
								// Fill in costume texture/pbk references
								foreach (var tb in textureBank) {
									var jsonb = GetBankByID(tb.id, fallback: "pack_costume");
									tb.patchBank = new Path(jsonb.PBK);
									tb.textureSet.diffuse = new Path(jsonb.Diffuse);
									tb.textureSet.back_light = new Path(jsonb.Backlight);
								}

								costumesBun.AddFile(cookedPath, newTPLContainer);
							}
						}

						if (!string.IsNullOrWhiteSpace(costume.TemplatePath_Trail)) {
							var cookedPath = new Path(costume.TemplatePath_Trail).CookedPath(rlContextExt);
							if (!System.IO.File.Exists(System.IO.Path.Combine(costumesBuildPath, cookedPath.FullPath))) {
								var basePath = $"world/common/fx/actors/trails/";
								var actorToClone = family switch {
									"teensy" => $"{basePath}teleporttrail_teensyclassicking.tpl",
									_ => $"{basePath}teleporttrail_{family}.tpl"
								};
								var pOriginalActor = new Path(actorToClone);
								pOriginalActor.LoadObject(rlContextExt);
								await rlContextExt.Loader.LoadLoop();

								var originalTPL = pOriginalActor.GetObject<GenericFile<Actor_Template>>();
								var newTPL = (Actor_Template)(await rlContextExt.Loader.Clone(originalTPL.obj, "tpl"));
								var newTPLContainer = new GenericFile<Actor_Template>(newTPL) {
									sizeOf = originalTPL.sizeOf
								};

								// The trail color is set in 3 places:
								newTPL.GetComponent<TextureGraphicComponent_Template>().defaultColor = costume.TrailColor;

								var t3dc = newTPL.GetComponent<Trail3DComponent_Template>();
								foreach(var trail in t3dc.trailList) trail.color = costume.TrailColor;

								var fxc = newTPL.GetComponent<FxBankComponent_Template>();
								fxc.Fx[0].gen._params.defaultColor = costume.TrailColor;

								costumesBun.AddFile(cookedPath, newTPLContainer);
							}
						}

					}

					void AddLock(JSON_LockData l, string tag, RO2_GameManagerConfig_Template.LockDataClass.NodeBehaviorType behavior, string parent) {
						if(l == null) return;
						RO2_GameManagerConfig_Template.LockDataClass lockData = new RO2_GameManagerConfig_Template.LockDataClass() {
							sizeOf = 28,
							lockCount = l.LockCount,
							lockType = l.LockType,
							behaviorType = behavior,
							tag = new StringID(tag),
							parent = parent == null? new StringID(0x85A77AC7) : new StringID(parent) // TODO: what is the string that has ID 0x85A77AC7? it's used for the main gallery items
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
								entry.TemplatePath_Trail = $"world/common/fx/actors/trails/teleporttrail_{entry.CostumeID.ToLowerInvariant().Replace("_","")}.tpl";

								// Determine decoration brick path
								var decFamily = entry.Family.ToLowerInvariant();
								if(decFamily == "barbara") decFamily += "_cr";
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

								await BuildCostume(entry);
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

					var bun = new UbiArt.Bundle.BundleFile();
					bun.AddFile(rlContextExt.Loader.CookedPaths[pGameConfig.stringID], gameConfigISG);
					bun.AddFile(rlContextExt.Loader.CookedPaths[pSgsContainer.stringID], sceneConfigManager);
					bun.AddFile(rlContextExt.Loader.CookedPaths[pHomeISC.stringID], homeISC);
					await rlContextExt.Loader.WriteFilesRaw(outPath, bun);

					if (!costumesBun.IsEmpty) {
						await rlContextExt.Loader.WriteFilesRaw(costumesBuildPath, costumesBun);
					}
				}
			}
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

		public async Task ConvertCostumes(string projectPath) {
			var mainMode = "mini";
			var dataID = $"costumes_{mainMode}";
			Path pGameConfig = new Path("enginedata/gameconfig/gameconfig.isg");
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
				if(!p.IsNull && p.Object != null) bun.AddFile(p.CookedPath(rlContextExt), p.Object);
			}

			using (var miniContext = CreateContext(Settings.Mode.RaymanMiniMacOS)) {
				await miniContext.Loader.LoadInitial();
				uint baseLocId = 9000;

				miniContext.Loader.LoadGenericFile(pGameConfig, isg => {
					miniContext.Loader.gameConfig = isg.obj as RO2_GameManagerConfig_Template;
				});
				await miniContext.Loader.LoadLoop();

				var playerIDInfo = miniContext.Loader.gameConfig.playerIDInfo;

				foreach(var skin in playerIDInfo)
				{
					var player = skin.obj as RO2_PlayerIDInfo;
					//if(player.family != "Rayman" && player.family != "Globox" && player.family != "Barbara") continue;
					if(rlContextExt.Loader.gameConfig.playerIDInfo.Any(c => c.obj.id.ToUpperInvariant() == player.id.ToUpperInvariant())) continue;

					// Load main actor & template
					player.defaultGameScreenInfo.actors[0].file.LoadObject(miniContext);
					await miniContext.Loader.LoadLoop();
					var mainActor = player.defaultGameScreenInfo.actors[0].file.GetObject<ContainerFile<UbiArt.ITF.Actor>>();
					var mainPlayerControllerComponent = mainActor.obj.GetComponent<RO2_PlayerControllerComponent>();
					var mainAnimatedComponent = mainActor.obj.GetComponent<AnimatedComponent>();
					
					mainPlayerControllerComponent.trailPath.LoadObject(miniContext);
					mainActor.obj.LUA.LoadObject(miniContext);
					await miniContext.Loader.LoadLoop();

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
						jsonTexBanks[GetTexBankID(tb.id)] = new JSON_CostumeInfo.JSON_TextureBank() {
							PBK = tb.patchBank.FullPath,
							Diffuse = tb.textureSet.diffuse.FullPath,
							Backlight = tb.textureSet.back_light.FullPath,

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
						tb.patchBank.LoadObject(miniContext);
						tb.textureSet.diffuse.LoadObject(miniContext);
						tb.textureSet.back_light.LoadObject(miniContext);
					}
					void AddBankToBundle(TextureBankPath tb) {
						AddPathToBundle(tb.patchBank);
						AddPathToBundle(tb.textureSet.diffuse);
						AddPathToBundle(tb.textureSet.back_light);
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
						NameID = AddLocalisation(miniContext, baseLocId, player.lineIdName),
						DescriptionID = AddLocalisation(miniContext, baseLocId, player.lineIdDescription),
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
					player.iconTexturePath.LoadObject(miniContext);
					await miniContext.Loader.LoadLoop();

					// Add atlas entry for icon texture
					if (miniContext.Loader.uvAtlasManager.atlas.ContainsKey(player.iconTexturePath.stringID)) {
						newUVEntries[player.iconTexturePath.FullPath] = miniContext.Loader.uvAtlasManager.atlas[player.iconTexturePath.stringID];
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
