using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.Animation;
using UbiArt.ITF;
using UnityEngine;

namespace UbiCanvas.Conversion {
	public class AdventuresToLegendsConverter {
		public async UniTask Convert(Context mainContext, string rlPath, string outPath) {
			var basePath = System.IO.Path.GetDirectoryName(rlPath);
			var settings = Settings.Init(Settings.Mode.RaymanLegendsPC);

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
				conversionSettings.PathConversionRules.Add(
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
					new PathConversionRule("world/common/fx/textures/pollen/", "world/common/fx/textures/pollen_adv/"));
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

			DuplicateActorTemplatesForStartPaused(mainContext);
			DuplicateLightingMushroomForGPEColor(mainContext, settings);
			AddStickToPolylinePhysComponentForSoccerBall(mainContext, settings);
			AddSceneConfigForRotatingPlatform(mainContext, settings, Controller.Obj.MainScene.obj);


			// Step 1: create new paths dictionary
			var ogDir = l.Settings.ITFDirectory;
			var newDir = settings.ITFDirectory;
			var pathMapping = new Dictionary<StringID, Path>();
			foreach (var structType in structs) {
				foreach (var structMap in structType.Value) {
					var ogPath = l.CookedPaths[structMap.Key];
					if (ogPath.folder != null && ogPath.folder.Contains(ogDir)) {
						pathMapping[structMap.Key] = new Path(ogPath.FullPath.Replace(ogDir, newDir), true);
					} else {
						pathMapping[structMap.Key] = ogPath;
					}
					pathMapping[structMap.Key].ConvertPath(conversionSettings);
				}
			}
			// Step 2, load uv atlas manager, and combine with adventures. Write patch_PC
			UbiArt.UV.UVAtlasManager uvManager = null;
			Path uvManagerPath = null;
			using (var rlContextExt = new Context(UnitySettings.GameDirs[Settings.Mode.RaymanLegendsPC],
				Settings.Init(Settings.Mode.RaymanLegendsPC),
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController())) {
				await rlContextExt.Loader.LoadInitial();
				uvManager = rlContextExt.Loader.uvAtlasManager;
				foreach (var uv in l.uvAtlasManager.atlas) {
					if (!uvManager.atlas.ContainsKey(uv.Key)) uvManager.atlas.Add(uv);
				}
				// Add renamed UV atlas
				foreach (var tex in structs[typeof(TextureCooked)]) {
					var curPath = pathMapping[tex.Key];
					if (l.uvAtlasManager.atlas.ContainsKey(curPath.stringID)) {
						var convertedPath = new Path(curPath.FullPath);
						convertedPath.ConvertPath(conversionSettings);
						if (convertedPath != curPath) {
							if (uvManager.atlas.ContainsKey(convertedPath.stringID)) {
								rlContextExt.SystemLogger?.LogWarning($"Cannot merge UV manager, already contains {convertedPath.stringID}");
							} else {
								uvManager.atlas[convertedPath.stringID] = l.uvAtlasManager.atlas[curPath.stringID];
							}
						}
					}
				}
				uvManagerPath = rlContextExt.Loader.CookedPaths[new Path("", "atlascontainer.ckd").stringID];
			}

			// Step 3, load bundles, for each struct check if it's already present in the bundle, otherwise add it
			using (var rlContext = new Context(basePath, settings,
				fileManager: new MapViewerFileManager(),
				systemLogger: new UnitySystemLogger(),
				asyncController: new UniTaskAsyncController())) {
				await rlContext.Loader.LoadBundles();
				var bun = new UbiArt.Bundle.BundleFile();
				var patch = new UbiArt.Bundle.BundleFile();
				var ogBun = rlContext.Loader.Bundles["Bundle"];

				// Add all original files to new bundle
				/*foreach (var f in ogBun.packMaster.files) {
					var fData = await ogBun.GetFile(rlContext, rlContext.Loader.BigFiles["Bundle"].Deserializer, f.Item2);
					bun.AddFile(f.Item2, fData);
				}*/
				// Add new data
				foreach (var structType in structs) {
					foreach (var structMap in structType.Value) {
						var curPath = pathMapping[structMap.Key];
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
				await rlContext.Loader.WriteBundle(outPath, bun);

				//Write patch
				patch.AddFile(uvManagerPath, uvManager);
				await rlContext.Loader.WriteBundle(System.IO.Path.Combine(basePath, "patch_PC.ipk"), patch);
			}
		}


		#region Specific adjustments
		public void DuplicateActorTemplatesForStartPaused(Context oldContext) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			foreach (var act in l.LoadedActors) {
				if (act.STARTPAUSE && !(act.template?.obj?.STARTPAUSED ?? false)) {

					var ogPath = act.LUA;
					var ogTpl = act.template;

					var newPath = new Path(ogPath.FullPath.Replace(".tpl", "__startpaused.tpl"));
					act.LUA = new Path(newPath.FullPath);

					if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
						l.Context.SystemLogger?.LogInfo($"Duplicating template (STARTPAUSE): {ogPath.FullPath}");
						var newTpl = new GenericFile<Actor_Template>() {
							obj = ogTpl.obj?.Clone("tpl") as Actor_Template,
							className = new StringID(ogTpl.obj.ClassCRC ?? uint.MaxValue)
						};
						newTpl.obj.STARTPAUSED = true;
						var oldCookedPath = l.CookedPaths[ogPath.stringID];
						var newCookedPath = new Path(oldCookedPath.FullPath.Replace(".tpl", "__startpaused.tpl"), true);
						l.CookedPaths[newPath.stringID] = newCookedPath;
						l.Paths[newPath.stringID] = newPath;
						structs[typeof(GenericFile<Actor_Template>)][newPath.stringID] = newTpl;
					}
					act.template = (GenericFile<Actor_Template>)structs[typeof(GenericFile<Actor_Template>)][newPath.stringID];
				}
			}
		}
		public void DuplicateLightingMushroomForGPEColor(Context oldContext, Settings newSettings) {
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			foreach (var act in l.LoadedActors) {
				var lightingMushroom = act.GetComponent<RO2_LightingMushroomComponent>();
				if (lightingMushroom != null) {

					// Trigger hack (Adventures & Mini send trigger events when the mushroom is hit) TODO: Improve.
					var tmpl = act.template?.obj?.GetComponent<TriggerComponent_Template>();
					if (tmpl != null) {
						tmpl.triggerChildren = true;
						tmpl.triggerOnHit = true;
						tmpl.triggerOnDetector = false;
						tmpl.onEnterEvent = new Generic<UbiArt.ITF.Event>() {
							obj = new EventTrigger() {
								activated = true,
							}
						};
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

								var newTpl = new GenericFile<Actor_Template>() {
									obj = ogTpl.obj?.Clone("tpl") as Actor_Template,
									className = new StringID(ogTpl.obj.ClassCRC ?? uint.MaxValue)
								};

								newTpl.obj.COMPONENTS = new CArrayO<Generic<ActorComponent_Template>>();
								foreach (var c in ogTpl.obj.COMPONENTS) {
									if (c?.obj is AnimMeshVertexComponent_Template amvComponent) {
										var ogAMVPath = amvComponent.amvPath;
										var newAmvComponent = Merger.Merge<AnimMeshVertexComponent_Template>(amvComponent);
										newAmvComponent.amvPath = new Path(ogAMVPath.FullPath.Replace(".asc", $"__gpe{gpeColor}.asc"));
										var newC = new Generic<ActorComponent_Template>() {
											obj = newAmvComponent,
											className = new StringID(newAmvComponent?.ClassCRC ?? uint.MaxValue)
										};
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

			foreach (var act in l.LoadedActors) {
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
			foreach (var act in l.LoadedActors) {
				if (act.GetComponent<RLC_RotatingPlatformComponent>() != null) {
					foundRotatingPlatform = true;
					break;
				}
			}
			if (foundRotatingPlatform) {
				// Find start point
				var checkpointSearch = scene.FindActor(act => act.GetComponent<CheckpointComponent>()?.INDEX == 0);
				Actor checkpointActor = checkpointSearch?.Result;
				if (checkpointSearch != null) {
					var sc = checkpointSearch.ContainingScene;

					// Create murfy activation action
					var murfyTrigger = new Actor() {
						LUA = new Path("world/common/logicactor/automurphy/component/trigger_box_automurphyactivation.tpl"),
						USERFRIENDLY = "trigger_box_automurphyactivation",
						POS2D = checkpointActor.POS2D,
					};
					murfyTrigger.AddComponent<LinkComponent>();

					var playerDetector = murfyTrigger.AddComponent<PlayerDetectorComponent>();
					playerDetector.localOffset = new Vec2d(1.597768f, 1.616089f);
					playerDetector.localScale = new Vec2d(2.387086f, 5.156033f);
					playerDetector.useShapeTransform = true;

					murfyTrigger.AddComponent<RO2_DRCMandatoryZoneComponent>();

					if (sc.AddActor(murfyTrigger, "trigger_box_automurphyactivation")) {
						oldContext?.SystemLogger?.LogInfo($"Added Murfy activation actor");
					}

					// Create murfy forced action (follow player)
					var murfyAction = new Actor() {
						LUA = new Path("world/common/logicactor/automurphy/component/trigger_box_murphyforcedaction.tpl"),
						USERFRIENDLY = "trigger_box_murphyforcedaction_start",
						POS2D = checkpointActor.POS2D,
					};
					murfyAction.AddComponent<LinkComponent>();
					murfyAction.AddComponent<ShapeComponent>().useShapeTransform = false;
					var forcedAction = murfyAction.AddComponent<RO2_DRCForceActionComponent>();
					forcedAction.forcedAction = RO2_DRCForceActionComponent.Enum_forcedAction.NoTouch;
					forcedAction.followPlayer = true;
					forcedAction.followPlayerUseCamDir = true;
					forcedAction.canBackward = true;
					forcedAction.canBackwardAnytime = true;
					forcedAction.actionTravel = new RO2_TravelData() {
						duration = 5,
						accelType = RO2_TravelData.AccelType.Linear,
						speedType = RO2_TravelData.SpeedType.Uniform
					};
					forcedAction.activationData = new RO2_DRCForceActionComponent.ActivationData() {
						activationMode = RO2_DRCForceActionComponent.ActivationData.Enum_activationMode.Multiple,
						saveBackward = true,
						saveBackwardOnActionExit = true
					};
					if (sc.AddActor(murfyAction, "trigger_box_murphyforcedaction_start")) {
						oldContext?.SystemLogger?.LogInfo($"Added Murfy forced action actor");
					}

				}

				// Add sceneConfig to scene
				if (scene.sceneConfigs == null) scene.sceneConfigs = new SceneConfigs();
				var scfg = scene.sceneConfigs;
				if (scfg.sceneConfigs == null) scfg.sceneConfigs = new CArrayO<Generic<SceneConfig>>();
				var obj = new RO2_SceneConfig_Platform() {
					DRCGameplayMode = RO2_SceneConfig_Base.Enum_DRCGameplayMode.Coop,
				};
				scfg.sceneConfigs.Add(new Generic<SceneConfig>() {
					obj = obj,
					className = new StringID(obj.ClassCRC ?? uint.MaxValue)
				});

			}
		}
		#endregion
	}
}
