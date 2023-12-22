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
		public Context LegendsContextNoLockedPaths { get; set; }
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

			Version = GetVersion(MainContext);

			// Create conversion settings
			var conversionSettings = new ConversionSettings() {
				OldContext = MainContext,
				OldSettings = oldSettings
			};
			ConversionSettings = conversionSettings;
			InitPathConversionRules();

			LegendsContext = CreateContext(Mode.RaymanLegendsPC, enableSerializerLog: false);
			LegendsContext.AddSettings<ConversionSettings>(new ConversionSettings() {
				LockPaths = true
			});
			LegendsContextNoLockedPaths = CreateContext(Mode.RaymanLegendsPC, enableSerializerLog: false);
		}

		public enum SpecialVersion {
			None = 0,
			EventDesertMarathon,
			EventGoldenMarathon,
			EventWinter,
			EventSummer,
			EventHalloween,
			EventEaster,
		}

		public SpecialVersion Version { get; set; }

		public static SpecialVersion GetVersion(Context context) {
			SpecialVersion version = SpecialVersion.None;
			if (context.FileManager.DirectoryExists($"{context.BasePath}cache/itf_cooked/android/world/rlc_egypt/")) {
				version = SpecialVersion.EventDesertMarathon;
			} else if (context.FileManager.FileExists($"{context.BasePath}cache/itf_cooked/android/world/challenge/run/challengerun/tscs/dojobar_double.tsc.ckd")) {
				version = SpecialVersion.EventGoldenMarathon;
			} else if (context.FileManager.FileExists($"{context.BasePath}cache/itf_cooked/android/world/rlc/common/ui/specialevent/winter/winter_intropopup.tga.ckd")) {
				version = SpecialVersion.EventWinter;
			} else if (context.FileManager.FileExists($"{context.BasePath}cache/itf_cooked/android/world/rlc/common/ui/specialevent/halloween/halloween_intropopup.tga.ckd")) {
				version = SpecialVersion.EventHalloween;
			} else if (context.FileManager.FileExists($"{context.BasePath}cache/itf_cooked/android/world/rlc/common/ui/specialevent/summer/summer_intropopup.tga.ckd")) {
				version = SpecialVersion.EventSummer;
			} else if (context.FileManager.FileExists($"{context.BasePath}cache/itf_cooked/android/world/rlc/common/ui/specialevent/easter/easter_intropopup.tga.ckd")) {
				version = SpecialVersion.EventEaster;
			}
			return version;
		}

		protected void InitPathConversionRules() {
			var conversionSettings = ConversionSettings;
			var oldSettings = OldSettings;

			void AddPathConversionRule(string path, string replace) => conversionSettings.PathConversionRules.Add(new PathConversionRule(path, replace));

			if (oldSettings.Game == Game.RA || oldSettings.Game == Game.RM) {
				AddPathConversionRule("common/matshader/", "common/matshader_adv/");
				AddPathConversionRule("common/fx/lifeelements/water/", "common/fx/lifeelements/water_adv/");
				AddPathConversionRule("common/platform/aspinetwork/", "common/platform/aspinetwork_adv/");
				AddPathConversionRule("world/music/castlesiege/playground/", "world/music/castlesiege/playground_rlc/");
				AddPathConversionRule("rotation_biggear.tpl", "rotation_biggear_adv.tpl");
				AddPathConversionRule("lightingmushroom.tpl", "lightingmushroom_adv.tpl");
				AddPathConversionRule("world/jungle/common/platform/liana/liana_zipline/components/liana_zipline_freelength.tpl", "world/jungle/common/platform/liana/liana_zipline/components/liana_zipline_freelength_rlc.tpl");
				AddPathConversionRule("umbrella/classic/", "umbrella/adv/");
				AddPathConversionRule("world/adversarial/soccerpunch/actor/soccerball/", "world/adversarial/soccerpunch/actor/soccerball_adv/");
				AddPathConversionRule("world/adversarial/soccerpunch/actor/soccerball_adv/animation/stand.anm", "world/adversarial/soccerpunch/actor/soccerball/animation/stand.anm");
				AddPathConversionRule("world/adversarial/soccerpunch/actor/soccerball_adv/animation/roll_left.anm", "world/adversarial/soccerpunch/actor/soccerball/animation/roll_left.anm");
				AddPathConversionRule("world/adversarial/soccerpunch/actor/soccerball_adv/animation/roll_right.anm", "world/adversarial/soccerpunch/actor/soccerball/animation/roll_right.anm");
				AddPathConversionRule("world/adversarial/soccerpunch/actor/soccerball_adv/animation/add_halo.anm", "world/adversarial/soccerpunch/actor/soccerball/animation/add_halo.anm");

				//AddPathConversionRule("world/common/friendly/lumschain/components/lumschain.tpl", "world/common/friendly/lumschain/components/lumschain_adv.tpl");
				/*AddPathConversionRule("world/common/fx/textures/fireworks/", "world/common/fx/textures/fireworks_adv/");
				AddPathConversionRule("world/common/fx/textures/star/", "world/common/fx/textures/star_adv/");
				AddPathConversionRule("world/common/fx/textures/light/", "world/common/fx/textures/light_adv/");
				AddPathConversionRule("world/common/fx/textures/smoke/", "world/common/fx/textures/smoke_adv/"); // TODO: fix smoke textures coming from egghunt
				AddPathConversionRule("world/common/fx/textures/smoke_adv/fx_steam_anim_01.tga", "world/common/fx/textures/smoke/fx_steam_anim_01.tga");
				AddPathConversionRule("world/common/fx/textures/smoke_adv/fx_smokeship_01.tga", "world/common/fx/textures/smoke/fx_smokeship_01.tga");
				AddPathConversionRule("world/common/fx/textures/pollen/", "world/common/fx/textures/pollen_adv/");*/
				AddPathConversionRule("world/common/fx/textures/", "world/common/fx/textures_adv/");
				/*AddPathConversionRule("world/common/fx/textures_adv/smoke/fx_smokeship_01.tga", "world/common/fx/textures/smoke/fx_smokeship_01.tga");*/
				/*AddPathConversionRule("world/common/fx/", "world/common/fx_/");*/
				/*AddPathConversionRule("world/common/fx/lifeelements2/dust/", "world/common/fx/lifeelements2/dust_adv/");*/
				//AddPathConversionRule("world/common/ldfrieze/polystyrene/frieze/", "world/common/ldfrieze/polystyrene/frieze_adv/");

				// Teensies
				//AddPathConversionRule("world/common/friendly/bt_friendly/teensy/components/teensy.tpl", "world/common/friendly/bt_friendly/teensy/components/teensy_rlc.tpl");
				//AddPathConversionRule("world/common/breakable/post/components/post.tpl", "world/common/breakable/post/components/post_rlc.tpl");

				// Enemy animations
				AddPathConversionRule("world/common/enemy/jacquouille/animation/", "world/common/enemy/jacquouille/animation_rlc/");
				AddPathConversionRule("world/mountain/common/enemy/minotaur/animation/", "world/mountain/common/enemy/minotaur/animation_rlc/");
				AddPathConversionRule("world/common/enemy/toad/animation/", "world/common/enemy/toad/animation_rlc/");
				AddPathConversionRule("world/mountain/common/friendly/light_bulbalums/animation/", "world/mountain/common/friendly/light_bulbalums/animation_rlc/");
				/*AddPathConversionRule("world/common/enemy/toad/", "world/common/enemy/toad_rlc/");
				AddPathConversionRule("world/common/enemy/jacquouille/", "world/common/enemy/jacquouille_rlc/");*/
				
				AddPathConversionRule("enginedata/actortemplates/tpl_staticmeshvertexcomponent.tpl", "enginedata/actortemplates/tpl_staticmeshvertexcomponent_rlc.tpl");
				AddPathConversionRule("world/common/blocker/drc/mechadoor/actor/tweening/door1.tpl", "world/common/blocker/drc/mechadoor/actor/tweening/door1_rlc.tpl");
				AddPathConversionRule("world/mountain/mecha/playground/enemy/buzzsaw/", "world/mountain/mecha/playground/enemy/buzzsaw_rlc/");
				//AddPathConversionRule("world/landofthedead/common/enemy/balancingaxe/", "world/landofthedead/common/enemy/balancingaxe_rlc/");

				// Tweening (rename for sounds)
				AddPathConversionRule("world/common/logicactor/tweening/tweeneditortype/components/", "world/common/logicactor/tweening/tweeneditortype/components_rlc/");
				AddPathConversionRule("world/common/logicactor/tweening/tweeneditortype/components_rlc/tween_notype.tpl", "world/common/logicactor/tweening/tweeneditortype/components/tween_notype.tpl");
				AddPathConversionRule("world/common/fx/lifeelements/musical/", "world/common/fx/lifeelements_rlc/musical/");
				AddPathConversionRule("world/common/friendly/skullcoin/components/skullcoin.tpl", "world/common/friendly/skullcoin/components/skullcoin_rlc.tpl");
				AddPathConversionRule("world/ocean/common/platform/geyserplatform/", "world/ocean/common/platform/geyserplatform_rlc/");
				//AddPathConversionRule("world/common/logicactor/shape/components/editableshape.tpl", "world/common/logicactor/shape/components/editableshape_rlc.tpl");

				// Challenges
				switch (Version) {
					case SpecialVersion.EventDesertMarathon:
						AddPathConversionRule("world/challenge/run/", "world/egypt/challenge/run/");
						AddPathConversionRule("world/landofthedead/", "world/egypt/landofthedead/");
						AddPathConversionRule("world/rlc_landofthedead/", "world/egypt/rlc_landofthedead/");
						AddPathConversionRule("world/common/enemy/devilbob/", "world/egypt/common/enemy/devilbob/");
						AddPathConversionRule("challengerun/challenge_run_main", "challengerun/challenge_run_egypt");
						break;
					case SpecialVersion.EventGoldenMarathon:
						AddPathConversionRule("world/challenge/run/", "world/goldenkingdom/challenge/run/");
						AddPathConversionRule("world/landofthedead/", "world/goldenkingdom/landofthedead/");
						AddPathConversionRule("world/rlc_landofthedead/", "world/goldenkingdom/rlc_landofthedead/");
						AddPathConversionRule("challengerun/challenge_run_main", "challengerun/challenge_run_dojo");
						break;
					default:
						AddPathConversionRule("world/challenge/run/", "world/rlc/challenge/run/");
						AddPathConversionRule("challengerun/challenge_run_main", "challengerun/challenge_run_rlc");
						break;
				}

				// Rabbids
				InitRabbidPathConversion(Version, conversionSettings);
			}
			if (oldSettings.Game == Game.RM) {
				AddPathConversionRule("world/jungle/common/friendly/lightingmushroom/", "world/jungle/common/friendly/lightingmushroom_mini/");
				AddPathConversionRule("common/lifeelements/dragonfly/", "common/lifeelements/dragonfly_mini/");
				AddPathConversionRule("world/landofthedead/", "world/landofthedead_mini/");
				//AddPathConversionRule("world/landofthedead/common/breakable/bonestack/", "world/landofthedead/common/breakable/bonestack_mini/");
				//AddPathConversionRule("world/landofthedead/common/breakable/bonesbridge/", "world/landofthedead/common/breakable/bonesbridge_mini/");
				AddPathConversionRule("world/jungle/common/platform/mushroomplatform/", "world/jungle/common/platform/mushroomplatform_mini/");
				AddPathConversionRule("world/common/platform/fluidfall/", "world/common/platform/fluidfall_mini/");
				AddPathConversionRule("world/jungle/common/platform/geyser/", "world/jungle/common/platform/geyser_mini/");
				AddPathConversionRule("world/music/common/platform/snakeride/", "world/music/common/platform/snakeride_mini/");
				AddPathConversionRule("world/music/common/platform/friendlyroot/", "world/music/common/platform/friendlyroot_mini/");
				AddPathConversionRule("world/food/common/enemy/foodspikysnake/", "world/food/common/enemy/foodspikysnake_mini/");
				AddPathConversionRule("world/common/friendly/bulb_explosif/", "world/common/friendly/bulb_explosif_mini/");
				AddPathConversionRule("world/rlc_dojo/gpe/plateform/bouncycanvas/", "world/rlc_dojo/gpe/plateform/bouncycanvas_mini/");
				AddPathConversionRule("world/common/enemy/janod/", "world/common/enemy/janod_mini/");
				AddPathConversionRule("world/jungle/common/enemy/spikyflower/", "world/jungle/common/enemy/spikyflower_mini/");
				AddPathConversionRule("world/challenge/common_challenge/actor/", "world/challenge/common_challenge/actor_mini/");
				AddPathConversionRule("world/challenge/common_challenge/actor_mini/countdown.act", "world/challenge/common_challenge/actor/countdown.act");
				AddPathConversionRule("world/challenge/common_challenge/actor_mini/components/countdown.tpl", "world/challenge/common_challenge/actor/components/countdown.tpl");
				AddPathConversionRule("world/challenge/common_challenge/actor_mini/treasurereachedfx.act", "world/challenge/common_challenge/actor/treasurereachedfx.act");
				AddPathConversionRule("world/common/friendly/swingman/", "world/common/friendly/swingman_mini/");
				AddPathConversionRule("world/jungle/common/friendly/kuyalum/", "world/jungle/common/friendly/kuyalum_mini/");
				AddPathConversionRule("world/jungle/common/platform/liana/", "world/jungle/common/platform/liana_mini/");
				AddPathConversionRule("world/common/platform/rope/", "world/common/platform/rope_mini/");
				AddPathConversionRule("world/common/platform/switchplatformwood/", "world/common/platform/switchplatformwood_mini/");
				AddPathConversionRule("world/ocean/common/platform/switchplatform/", "world/ocean/common/platform/switchplatform_mini/");
			}
			// TODO: Use boxinterpolator for this one
			if (oldSettings.Game == Game.RM) {
				AddPathConversionRule("junglelummusicmanager.tpl", "junglelummusicmanager_mini.tpl");
			} else {
				AddPathConversionRule("junglelummusicmanager.tpl", "junglelummusicmanager_rlc.tpl");
			}
			if (oldSettings.Platform == GamePlatform.Vita) {
				//conversionSettings.PathConversionRules.Add(
				//	new PathConversionRule("world/mountain/mecha/playground/enemy/buzzsaw/", "world/mountain/mecha/playground/enemy/buzzsaw_vita/"));
				conversionSettings.TextureConversion = ConvertTextureVita;
			}
		}

		void InitRabbidPathConversion(SpecialVersion version, ConversionSettings conversionSettings) {
			void AddPathConversionRule(string path, string replace) => conversionSettings.PathConversionRules.Add(new PathConversionRule(path, replace));

			switch (version) {
				case SpecialVersion.EventHalloween:
					AddPathConversionRule("world/rlc/common/enemy/rabbid/", "world/rlc/common/enemy/rabbid_halloween/");
					break;
				case SpecialVersion.EventWinter:
					AddPathConversionRule("world/rlc/common/enemy/rabbid/", "world/rlc/common/enemy/rabbid_winter/");
					break;
				case SpecialVersion.EventEaster:
					AddPathConversionRule("world/rlc/common/enemy/rabbid/", "world/rlc/common/enemy/rabbid_normal/");
					break;
				case SpecialVersion.EventSummer:
					AddPathConversionRule("world/rlc/common/enemy/rabbid/", "world/rlc/common/enemy/rabbid_summer/");
					break;
				default:
					AddPathConversionRule("world/rlc/common/enemy/rabbid/", "world/rlc/common/enemy/rabbid_renaissance/");
					break;
			}
		}

		public async Task Init() {
			StartLoadingScreen();

			if (MainContext.Settings.Game == Game.RA || MainContext.Settings.Game == Game.RM) {
				ConversionSettings.WwiseConversionSettings = await LoadWwiseConfig(MainContext, ProjectPath);
			}
			await LegendsContext.Loader.LoadInitial();
			await LegendsContext.Loader.LoadLoop();
			await LegendsContextNoLockedPaths.Loader.LoadInitial();
			await LegendsContextNoLockedPaths.Loader.LoadLoop();
		}

		protected void StartLoadingScreen() {
			if(Controller.Obj?.loadingScreen != null) Controller.Obj.loadingScreen.Active = true;
			GlobalLoadState.DetailedState = "Exporting map";
			GlobalLoadState.LoadState = GlobalLoadState.State.Initializing;
		}
		protected void StopLoadingScreen() {
			Debug.Log($"Finished exporting {ExportID}.");
			GlobalLoadState.DetailedState = "Finished";
			GlobalLoadState.LoadState = GlobalLoadState.State.Finished;
			if (Controller.Obj?.loadingScreen != null) Controller.Obj.loadingScreen.Active = false;
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

		public void ConvertTextureVita(Context context, ConversionSettings conv, TextureCooked tex) {
			if(tex?.Data == null) return;

			if (conv.OldSettings.Platform == GamePlatform.Vita && context.Settings.Platform != GamePlatform.Vita) {
				using System.IO.MemoryStream ms = new System.IO.MemoryStream(tex.Data);
				var gxt = new GXTConvert.FileFormat.GxtBinary(ms);
				var texture = gxt.Textures[0];
				var pngTex = texture.EncodeToPNG();

				using (var img = new MagickImage(pngTex)) {
					img.Format = MagickFormat.Dds;
					img.Settings.SetDefine(MagickFormat.Dds, "compression", "none");
					img.AutoOrient(); // Orient TGA based on origin point
					var w = (ushort)img.Width;
					var h = (ushort)img.Height;
					tex.Data = img.ToByteArray();
					tex.Header.DataSize = (uint)tex.Data.Length;
					tex.Header.Width = w;
					tex.Header.Height = h;
					tex.Header.CompressionType = 0;
					tex.Header.DataSize2 = tex.Header.DataSize;
				}
			}
		}

		public async Task ProcessSceneVita(Scene scene = null, bool generateSGS = false) {
			await Task.CompletedTask;
			scene ??= Controller.Obj.MainScene.obj;
			var mainContext = MainContext;
			if (scene.sceneConfigs == null) scene.sceneConfigs = new SceneConfigs();
			var scfg = scene.sceneConfigs;
			if (scfg.sceneConfigs == null) scfg.sceneConfigs = new CArrayO<Generic<SceneConfig>>();
			var obj = new RO2_SceneConfig_Platform() {
				DRCGameplayMode = RO2_SceneConfig_Base.Enum_DRCGameplayMode.AutoPlayerOnly,
				istouchScreenMap = true
			};
			scfg.sceneConfigs.Add(new Generic<SceneConfig>(obj));


			var spawnPoint = scene.FindActor(a => a.GetComponent<CheckpointComponent>()?.INDEX == 0);
			if (spawnPoint?.Result == null) {
				spawnPoint = scene.FindActor(a => a.GetComponent<CheckpointComponent>() != null);
			}
			var drcs = scene.FindActors(a => a.GetComponent<RO2_DRCMandatoryZoneComponent>() != null);
			foreach (var res in drcs) {
				var act = res.Result;
				var tpl = act.template;
				var drcTPL = tpl.obj.GetComponent<RO2_DRCMandatoryZoneComponent_Template>();
				drcTPL.autoMurphy = 1;
			}
			/*var pos = spawnPoint.Result.POS2D;
			var murfyTrigger = await AddNewActor(spawnPoint.ContainingScene, new Path("world/common/logicactor/automurphy/component/trigger_box_automurphyactivation.tpl"), contextToLoadFrom: LegendsContext);
			murfyTrigger.POS2D = pos + new Vec2d(2f, 0f);
			murfyTrigger.RELATIVEZ = spawnPoint.Result.RELATIVEZ;
			murfyTrigger.ANGLE = spawnPoint.Result.ANGLE;
			//murfyTrigger.GetComponent<TriggerComponent>().mode = TriggerComponent.Mode.Once;
			var playerDetector = murfyTrigger.GetComponent<PlayerDetectorComponent>();
			playerDetector.localOffset = new Vec2d(0, 0);
			playerDetector.localScale = new Vec2d(3f, 3f);
			playerDetector.useShapeTransform = true;

			MainContext.Loader.CookedPaths[murfyTrigger.LUA.stringID] = murfyTrigger.LUA.CookedPath(MainContext);

			if (CloneTemplateIfNecessary(murfyTrigger.LUA, "nonauto", "NON AUTOMURFY", murfyTrigger.template, out var newTPL, act: murfyTrigger)) {
				var drc = newTPL.obj.GetComponent<RO2_DRCMandatoryZoneComponent_Template>();
				drc.autoMurphyMultiAllowed = 0;
				drc.autoMurphy = 0;
			}*/

			if (generateSGS) {
				GenerateSGSFile(mainContext, scene);
			}
		}

		public HashSet<Scene> ProcessedScenes = new HashSet<Scene>();

		public Path GetScenePath(Scene scene) {
			var structs = MainContext.Cache.Structs;
			var loadedScenes = structs[typeof(ContainerFile<Scene>)];
			var loadedScene = loadedScenes.FirstOrDefault(s => ((ContainerFile<Scene>)s.Value).obj == scene);
			var scenePath = MainContext.Loader.Paths[loadedScene.Key];

			return scenePath;
		}

		public async Task ProcessScene(Scene scene = null, bool generateSGS = false) {
			scene ??= Controller.Obj.MainScene.obj;

			if(ProcessedScenes.Contains(scene)) return;
			ProcessedScenes.Add(scene);

			var settings = NewSettings;
			var mainContext= MainContext;
			var conversionSettings = ConversionSettings;

			// Print scene path
			var scenePath = GetScenePath(scene);
			UnityEngine.Debug.Log($"Processing scene: {scenePath}");

			await SpawnRabbids(mainContext, settings, scene); // Before LevelSpecificChanges!

			await LevelSpecificChanges(mainContext, settings, scene);

			if (generateSGS) {
				// We aren't in a brick, but in a main scene
				await SpawnLumMusicManagerIfNecessary(mainContext, settings, scene);
			}

			MiniHandleMRDARKScene(mainContext, settings, scene);

			FixBasketNinjas(mainContext, settings, scene);

			PerformHangSpotWorkaround(mainContext, settings, scene);
			AddRelayToMushrooms(mainContext, settings, scene);

			AddTriggerMoreEventTweens(mainContext, settings, scene);
			CreateTemplatesForInstanceRelays(mainContext, settings, scene);
			AddRelaysForMultipleEventTriggers(mainContext, settings, scene);
			//await SimpleRelaysToTweens(mainContext, settings, scene);

			CreateFriseParents(mainContext, settings, scene);
			await MakeFrisesStartPaused(mainContext, settings, scene);
			CreateLightingFrisesForRenderParams(mainContext, settings, scene);

			AddSceneConfigForRotatingPlatform(mainContext, settings, scene);

			if (generateSGS) {
				GenerateSGSFile(mainContext, scene);
			}

			await Task.CompletedTask;
		}

		public async Task ProcessNonScene() {
			var settings = NewSettings;
			var mainContext = MainContext;
			var conversionSettings = ConversionSettings;

			// Do this first
			await ProcessChallengeTemplates(mainContext, settings);

			// Then start fixing non-scene stuff
			await FixLumChainsBrightness(mainContext, settings);
			FixNinjas(mainContext, settings);
			FixRabbids(mainContext, settings);
			FixCaptainHelloAnimationBug(mainContext, settings);
			FixAllUTurnAnimations(mainContext, settings);
			UpdateSoundFXReferences(mainContext, settings, conversionSettings);
			FixLumKingMusic(mainContext, settings);
			FixCameraModifierBlend(mainContext, settings);
			FixAspiNetworks(mainContext, settings);
			FixTeensies(mainContext, settings);
			PerformHangSpotWorkaround_TPLFix(mainContext, settings);
			AddPreInstructionSets(mainContext, settings);

			FixBubblesFX(mainContext, settings);

			FixStaticMeshVertexComponentCulling(mainContext, settings);
			AddCaptainAI(mainContext, settings);
			DowngradeFxUV(mainContext, settings);

			await FixEnemiesWithShieldUp(mainContext, settings);
			FixShapeExcluders(mainContext, settings);
			//FixSwimmingToads(mainContext, settings);
			AdjustGhostBrightness(mainContext, settings);

			await UseBetterEggForSoccerBall(mainContext, settings);

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
			foreach (var p in LegendsContext.GetSettings<ConversionSettings>().LockedPaths) {
				conversionSettings.LockedPaths.Add(p);
			}

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
			var conversionSettings = new WwiseConversionSettings();

			// Create dictionaries for better performance
			Dictionary<long, JSON_WwiseEvent> wwiseEventsLookup = new Dictionary<long, JSON_WwiseEvent>();
			Dictionary<long, JSON_WwiseAction> wwiseActionsLookup = new Dictionary<long, JSON_WwiseAction>();
			Dictionary<long, WwiseConversionSettings.Action> wwiseActionsClassesLookup = new Dictionary<long, WwiseConversionSettings.Action>();


			// Mini sound files are higher quality - we pick those if they exist. Otherwise we load the Adventures file
			// Might cause issues though... revert to old code if it does!
			var jsonFiles = new string[] { "mini", "adventures" };
			var useAdventuresPaths = new string[] { // For sounds with this in the filename, we use the Adventures sound events
				"nmi_basictoad/", "sfx_lums_jungleworld_picked_lvl01_0"
			};
			HashSet<long> useAdventuresActions = new HashSet<long>();
			foreach (var wwiseName in jsonFiles) {
				bool preferAdventures = wwiseName == "adventures" && context.Settings.Game == Game.RA;
				var json = System.IO.File.ReadAllText(System.IO.Path.Combine(inPath, $"sounds_{wwiseName}.json"));
				wwiseInfo = JsonConvert.DeserializeObject<JSON_WwiseInfo>(json);
				foreach (var act in wwiseInfo.Actions) {
					if (preferAdventures) {
						if (act.Sounds != null && act.Sounds.Any(s => useAdventuresPaths.Any(p => s.Filename?.Contains(p) ?? false))) {
							useAdventuresActions.Add(act.ID);
						}
					}
					if (wwiseActionsLookup.ContainsKey(act.ID) && !useAdventuresActions.Contains(act.ID)) continue;
					wwiseActionsLookup[act.ID] = act;
				}
				foreach (var ev in wwiseInfo.Events) {
					if (wwiseEventsLookup.ContainsKey(ev.ID)) {
						if(!preferAdventures || ev.Actions == null || !ev.Actions.Any(a => useAdventuresActions.Contains(a))) continue;
					}
					wwiseEventsLookup[ev.ID] = ev;
				}
				foreach (var att in wwiseInfo.Attenuations) {
					if(conversionSettings.Attenuations.ContainsKey(att.ID)) continue;
					conversionSettings.Attenuations.Add(att.ID, new WwiseConversionSettings.Attenuation() {
						Volume = CreateCurve(att.Volume),
						Spread = CreateCurve(att.Spread),
					});
				}
			}

			WwiseConversionSettings.Curve CreateCurve(JSON_WwiseCurve curve) {
				if(curve == null) return null;
				return new WwiseConversionSettings.Curve() {
					Points = curve.Points.Select(p => new WwiseConversionSettings.CurvePoint() {
						X = p.X,
						Y = p.Y
					}).ToArray()
				};
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
				if(wwiseItem == null) continue;

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

		public void GenerateSGSFile(Context mainContext, Scene scene) {
			var sceneConfigs = scene?.sceneConfigs;
			var configs = scene?.sceneConfigs?.sceneConfigs;
			if (configs == null || !configs.Any()) return;
			// Now that we've checked that, clone the configs. This way any incompatible configs will be removed too.
			sceneConfigs = ((SceneConfigs)scene.sceneConfigs.Clone("isc", context: LegendsContextNoLockedPaths));
			configs = sceneConfigs.sceneConfigs;
			
			var defaultConfigIndex = sceneConfigs.activeSceneConfig;
			if(defaultConfigIndex >= configs.Count) defaultConfigIndex = 0;
			var chosenConfig = configs[(int)defaultConfigIndex]?.obj;
			if(chosenConfig == null) return;

			var structs = mainContext.Cache.Structs;
			var loadedScenes = structs[typeof(ContainerFile<Scene>)];
			var loadedScene = loadedScenes.FirstOrDefault(s => ((ContainerFile<Scene>)s.Value).obj == scene);
			var scenePath = mainContext.Loader.Paths[loadedScene.Key];

			var sgsPath = new Path(scenePath.FullPath.Replace(".isc", ".sgs"));

			if(mainContext.Cache.Get<ContainerFile<Generic<SceneConfig>>>(sgsPath) == null) {
				var sgs = new ContainerFile<Generic<SceneConfig>>() {
					obj = new Generic<SceneConfig>(chosenConfig)
				};

				mainContext.Loader.CookedPaths[sgsPath.stringID] = sgsPath.CookedPath(mainContext);
				mainContext.Loader.Paths[sgsPath.stringID] = sgsPath;
				mainContext.Cache.Add<ContainerFile<Generic<SceneConfig>>>(sgsPath.stringID, sgs);
			}
		}

		#region Specific adjustments
		public async Task LevelSpecificChanges(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var scenePath = GetScenePath(scene);

			switch (scenePath.FullPath) {
				case "world/rlc_intro/intro_firstlevel.isc": {
						// Add soccer ball
						var egg1 = scene.FindActor(a => a.USERFRIENDLY == "Egg1");
						var eggBall = await AddNewActor(egg1.ContainingScene, new Path("world/adversarial/soccerpunch/actor/soccerball/components/ball.tpl"));
						//eggBall.POS2D = egg1.Result.POS2D + Vec2d.Up * 3;
						eggBall.RELATIVEZ = egg1.Result.RELATIVEZ;
						//eggBall.POS2D = new Vec2d(-8.74f, 6.48f);
						eggBall.POS2D = new Vec2d(20.13f, -7.97f);
						eggBall.GetComponent<AnimLightComponent>().defaultAnim = "stand";
						eggBall.GetComponent<RO2_BallComponent>().bounceMultiplier = 0.5f;


						// Remove intro cutscene & eggs
						var act = scene.FindActor(a => a.USERFRIENDLY == "intro_firstlevel_cine");
						act.ContainingScene.DeletePickable(act.Result);
						var eggs = scene.FindActors(a => a.USERFRIENDLY.ToLowerInvariant().StartsWith("egg"));
						foreach (var egg in eggs) {
							egg.ContainingScene.DeletePickable(egg.Result);
						}
						var armada = scene.FindActor(a => a.USERFRIENDLY == "ARMADA_BG@2");
						armada.Result.STARTPAUSE = false;

						var flower = scene.FindActor(a => a.USERFRIENDLY == "floweranimonly");
						flower.Result.GetComponent<AnimatedComponent>().defaultAnim = "dance";

						var forbiddenregions = scene.FindPickables(p => p.USERFRIENDLY == "nocrushattack" || p.USERFRIENDLY == "nohelico");
						foreach (var p in forbiddenregions) {
							p.ContainingScene.DeletePickable(p.Result);
						}

						var boat1 = scene.FindActors(a => (a.USERFRIENDLY == "grp" || a.USERFRIENDLY == "captain") && a.POS2D.x < 0);
						foreach (var p in boat1) {
							p.ContainingScene.DeletePickable(p.Result);
						}

						await CreateIntroActors(oldContext, newSettings, scene);
						break;
					}
				case "world_arcade/ra_trunk/levels/trk_ra_09_storminggiants/trk_ra_09_storminggiants.isc": {
						var toads = scene.FindActors(a => a.USERFRIENDLY.StartsWith("shootingtoad_big"));
						foreach (var res in toads) {
							var toad = res.Result.GetComponent<RO2_EnemyBTAIComponent>();
							toad.useRangedAttack = true;
							toad.useRangedAttack_RL = 1;
							//toad.RA_timeBetweenBullet *= 2;
							//toad.RA_timeBetweenSequence *= 2;
							toad.useTrigger = true;
							toad.appearType = RO2_EnemyBTAIComponent.Enum_appearType.FromGround;
							toad.appearType2 = RO2_EnemyBTAIComponent.Enum_appearType2.FromGround;
						}
						break;
					}
				case "world_arcade/ra_musical/ra_mus_trunk/ra_mus_trunk.isc": {
						// TODO: Re-enable
						var cm = scene.FindActor(a => a.USERFRIENDLY == "cameramodifier_musical@6");
						cm.Result.STARTPAUSE = true;

						scene.FindActor(a => a.USERFRIENDLY == "challengefirewall").Result.GetComponent<RO2_ChallengeFireWallComponent>().screenPosition = new Vec2d(0.5f, 0.5f);

						UseFastCameras(scene);

						scene.FindActor(a => a.USERFRIENDLY == "chest").Result.GetComponent<AnimatedComponent>().PrimitiveParameters.colorFactor.a = 1f;
						var n = scene.FindActor(a => a.USERFRIENDLY == "chesttrajectorynode@2").Result.GetComponent<LinkComponent>();
						//n.Children[0].TagValues[0].Value = "8.2";
						n.Children[0].AddTag("MaxSpeed", "11");
						n.Children[0].AddTag("SafeDistance", "2");
						n = scene.FindActor(a => a.USERFRIENDLY == "chesttrajectorynode@3").Result.GetComponent<LinkComponent>();
						n.Children[0].TagValues[0].Value = "8.2";
						n.Children[0].TagValues[1].Value = "11";

						// Ungrabbable lum chain
						var lc = scene.FindActor(a => a.USERFRIENDLY == "lumschain@6");
						FixOneLumsChainSpawnMode(oldContext, newSettings, lc.Result);

						// Second wallrun
						scene.FindActor(a => a.USERFRIENDLY == "chesttrajectorynode@16").Result.POS2D = new Vec2d(460f, -56.00015f);

						// Shooting toad
						n = scene.FindActor(a => a.USERFRIENDLY == "chesttrajectorynode@24").Result.GetComponent<LinkComponent>();
						n.Children[0].AddTag("MinSpeed", "8.2");
						n.Children[0].AddTag("MaxSpeed", "11");
						n.Children[0].AddTag("SafeDistance", "2");

						// Chest moves too fast for grab thing that moves up
						n = scene.FindActor(a => a.USERFRIENDLY == "chesttrajectorynode@28").Result.GetComponent<LinkComponent>();
						n.Children[0].TagValues[0].Value = "8"; // MinSpeed = slower
						//n.Children[0].TagValues[1].Value = "11";
						n.Children[0].AddTag("SafeDistance", "2");

						// Toad immediately after this fires too soon
						var fasttoad = scene.FindActor(a => a.USERFRIENDLY == "shootingtoad_big@5");//.Result.GetComponent<RO2_EnemyBTAIComponent>();
						fasttoad.Result.POS2D += Vec2d.Left * 3f;
						//fasttoad.RA_timeBetweenBullet *= 2f;
						//fasttoad.RA_timeBetweenSequence *= 2f;


						// Add flower bumper to autograb zipline
						var containingScene = scene.FindActor(a => a.USERFRIENDLY == "chesttrajectorynode@32").ContainingScene;
						var bump = await AddNewActor(containingScene, new Path("world/jungle/common/platform/flower_bumper/components/flower_bumper_2m.tpl"), contextToLoadFrom: LegendsContext);
						bump.POS2D = new Vec2d(628.3f, 40.32f);
						bump.RELATIVEZ = -0.02f;
						bump.SCALE = Vec2d.One * 5f;
						bump.ANGLE = new Angle(180f, degrees: true);


						// Ungrabbable lum chain at very end
						lc = scene.FindActor(a => a.USERFRIENDLY == "lumschain@20");
						FixOneLumsChainSpawnMode(oldContext, newSettings, lc.Result);
						break;
					}
				case "world/rlc_dojo/festivalofspeed/dojo_festivalofspeed_nmi.isc": {
						ZiplineToRope_OnlyLeft(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_dojo/greatwallwaterfall/dojo_greatwallwaterfall_lum_firelums.isc": {
						var mood = scene.FindActor(a => a.USERFRIENDLY == "mood1");
						var rp = mood.Result.GetComponent<RenderParamComponent>();
						rp.Lighting.GlobalColor.a += 0.2f;
						InvertZiplines_OnlyLeft(oldContext, newSettings, scene);
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
				case "world/rlc_maze/lumlabyrinth/maze_lumlabyrinth_lum_base.isc": {
						UseFastCameras(scene);
						break;
					}
				case "world/rlc_avatar/teensietorment/avatar_teensietorment_exp_base.isc": {
						UseFastCameras(scene);
						break;
					}
				case "world/rlc_avatar/thornrush/avatar_thornrush_spd_base.isc": {
						// Invincibility Road 1
						var badtoad = scene.FindActor(a => a.USERFRIENDLY == "stiltstoad_level1@3");
						badtoad.ContainingScene.DeletePickable(badtoad.Result);
						//badtoad.Result.POS2D = new Vec2d(305.72f, -62.93f);

						var bumper = await AddNewActor(scene, new Path("world/jungle/common/platform/flower_bumper/components/flower_bumper_2m.tpl"),contextToLoadFrom: LegendsContext);
						bumper.POS2D = new Vec2d(298.36f, -65.23f);
						bumper.SCALE = new Vec2d(4f, 4f);
						bumper.ANGLE = new Angle(-50.8f, degrees: true);
						bumper = await AddNewActor(scene, new Path("world/jungle/common/platform/flower_bumper/components/flower_bumper_2m.tpl"), contextToLoadFrom: LegendsContext);
						bumper.POS2D = new Vec2d(302.69f, -62.46f);
						bumper.SCALE = new Vec2d(4f, 4f);
						bumper.ANGLE = new Angle(-120f, degrees: true);
						bumper = await AddNewActor(scene, new Path("world/jungle/common/platform/flower_bumper/components/flower_bumper_2m.tpl"), contextToLoadFrom: LegendsContext);
						bumper.POS2D = new Vec2d(305.59f, -65.38f);
						bumper.SCALE = new Vec2d(5f, 5f);
						bumper.ANGLE = new Angle(-40f, degrees: true);
						/*bumper = await AddNewActor(scene, new Path("world/jungle/common/platform/flower_bumper/components/flower_bumper_2m.tpl"), contextToLoadFrom: LegendsContext);
						bumper.POS2D = new Vec2d(308.37f, -60.84f);
						bumper.SCALE = new Vec2d(6f, 6f);
						bumper.ANGLE = new Angle(-101f, degrees: true);*/

						/*thorn = scene.FindActor(a => a.USERFRIENDLY == "spikyroot_challengegoingdown@15");
						bez = thorn.Result.GetComponent<RO2_BezierTreeComponent>();
						var nodes = bez.branch.nodes;
						nodes[1].pos = new Vec3d(3.815491f, 6.468521f, 0f);
						nodes[2].pos = new Vec3d(2.832153f, 6.742771f, 0f);
						nodes[3].pos = new Vec3d(11.40936f, -8.100277f, 0f);
						nodes[4].pos = new Vec3d(7.100133f, -4.234735f, 0f);
						nodes[5].pos = new Vec3d(-4.946198f, 2.453018f, 0f);
						nodes[6].pos = new Vec3d(4.322418f, 0.2609711f, 0f);
						nodes[1].tangent = new Vec2d(-1.203461f, 1.685204f);
						nodes[2].tangent = new Vec2d(4.750458f, 0.4666748f);
						nodes[3].tangent = new Vec2d(10.50998f, 5.059999f);
						nodes[4].tangent = new Vec2d(-2.163971f, -1.079552f);
						nodes[5].tangent = new Vec2d(0.789978f, 2.139305f);
						nodes[6].tangent = new Vec2d(-0.3680115f, -1.506638f);*/

						// Invincibility Route 2
						var thorn = scene.FindActor(a => a.USERFRIENDLY == "spikyroot_challengegoingdown@18");
						var bez = thorn.Result.GetComponent<RO2_BezierTreeComponent>();
						bez.branch.nodes.Remove(bez.branch.nodes.Last());

						thorn = scene.FindActor(a => a.USERFRIENDLY == "spikyroot_challengegoingdown@19");
						//thorn.ContainingScene.DeletePickable(thorn.Result);
						bez = thorn.Result.GetComponent<RO2_BezierTreeComponent>();
						var nodes = bez.branch.nodes;
						nodes[0].pos = new Vec3d(-1.730011f, 15.56f, 0f);
						nodes[1].pos = new Vec3d(4.879994f, -11.72f, 0f);
						nodes[2].pos = new Vec3d(11.97845f, -0.9524038f, 0f);
						nodes[3].pos = new Vec3d(-0.6474915f, -3.677177f, 0f);
						nodes[0].tangent = new Vec2d(-1.77f, -4.050353f);
						nodes[1].tangent = new Vec2d(5.11001f, 0.4399989f);
						nodes[2].tangent = new Vec2d(1.249786f, -1.229557f);
						nodes[3].tangent = new Vec2d(-2.282532f, -0.5797653f);

						/*bumper = await AddNewActor(scene, new Path("world/jungle/common/platform/flower_bumper/components/flower_bumper_2m.tpl"), contextToLoadFrom: LegendsContext);
						bumper.POS2D = new Vec2d(357.03f, -55.82f) + new Vec2d(1, -1);
						bumper.SCALE = new Vec2d(6f, 6f);
						bumper.ANGLE = new Angle(-120f, degrees: true);*/

						var stiltstoad1 = scene.FindActor(a => a.USERFRIENDLY == "stiltstoad_level1");
						stiltstoad1.ContainingScene.DeletePickable(stiltstoad1.Result);
						stiltstoad1 = scene.FindActor(a => a.USERFRIENDLY == "stiltstoad_level1@2");
						stiltstoad1.ContainingScene.DeletePickable(stiltstoad1.Result);

						var badrabbid = scene.FindActor(a => a.USERFRIENDLY == "seasonaleventenemyspawner@2");
						//badrabbid.ContainingScene.DeletePickable(badrabbid.Result);
						badrabbid.Result.POS2D = new Vec2d(356.35f, -66.39f);
						break;
					}
				case "world/rlc_avatar/ruinride/avatar_ruinride_lum_base.isc": {
						var lk = scene.FindActor(a => a.USERFRIENDLY == "lumking@1");
						lk.ContainingScene.DeletePickable(lk.Result);
						var lkReplacement = await SpawnTeensyCage(lk.ContainingScene,
							RO2_FriendlyBTAIComponent.Prisoner.Soldier, 0, TeensyWorldType.Jungle, CageType.Flying, false, mirror: true, name: lk.Result.USERFRIENDLY);
						lkReplacement.parentBind = lk.Result.parentBind;
						lkReplacement.STARTPAUSE = lk.Result.STARTPAUSE;
						lkReplacement.RELATIVEZ = lk.Result.RELATIVEZ;
						lkReplacement.POS2D = lk.Result.POS2D;

						lk = scene.FindActor(a => a.USERFRIENDLY == "lumking");
						lk.ContainingScene.DeletePickable(lk.Result);
						lkReplacement = await SpawnTeensyCage(lk.ContainingScene,
							RO2_FriendlyBTAIComponent.Prisoner.Soldier, 1, TeensyWorldType.Jungle, CageType.Flying, true, mirror: true, name: lk.Result.USERFRIENDLY);
						lkReplacement.parentBind = lk.Result.parentBind;
						lkReplacement.STARTPAUSE = lk.Result.STARTPAUSE;
						lkReplacement.RELATIVEZ = lk.Result.RELATIVEZ;
						lkReplacement.POS2D = lk.Result.POS2D;
						break;
					}
				case "world/rlc_enchantedforest/overgrowncastle/enchantedforest_overgrowncastle_exp_base.isc": {
						var path = new Path("world/common/breakable/lumsjar/components/lumjar_nocol_nophys.tpl");
						var breakables = scene.FindActors(a => a.LUA == path);
						foreach (var b in breakables) {
							FixLumJarNoPhys(oldContext, b.Result);
						}
						await CreateTutoActors(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_enchantedforest/forestegghunt/enchantedforest_forestegghunt_exp_base.isc": {
						await CreateTutoActors(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_nemo/sunkensecrets/nemo_sunkensecrets_exp_base.isc": {
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

						// Remove bonesbridge to remove need for crush attack
						var bonesbridge = pickableTree.FollowObjectPath(new ObjectPath("grp@1|bonesbridge_02"));
						bonesbridge.Parent.Scene.DeletePickable(bonesbridge.Pickable);

						// Make jump easier at end by moving rings closer together
						var ring = scene.FindActor(a => a.USERFRIENDLY == "ring@7");
						ring.Result.POS2D += new Vec2d(1.5f, 0f);
						ring = scene.FindActor(a => a.USERFRIENDLY == "ring@8");
						ring.Result.POS2D -= new Vec2d(1.5f, 0f);
						var ringFog = pickableTree.FollowObjectPath(new ObjectPath("jewelthief_graph|simplefog@20"));
						ringFog.Pickable.POS2D += new Vec2d(1.5f, 0f);
						ringFog = pickableTree.FollowObjectPath(new ObjectPath("jewelthief_graph|simplefog@21"));
						ringFog.Pickable.POS2D -= new Vec2d(1.5f, 0f);
						var ringfrise = scene.FindPickable(a => a.USERFRIENDLY == "nemo_playground_structure_atlas");
						ringfrise.Result.POS2D += new Vec2d(1.5f, 0f);
						ringfrise = scene.FindPickable(a => a.USERFRIENDLY == "nemo_playground_structure_atlas@1");
						ringfrise.Result.POS2D -= new Vec2d(1.5f, 0f);

						// Add bonestack to stop player from entering that last room without looking
						var bonestack = await AddNewActor(scene, new Path("world/landofthedead/common/breakable/bonestack/components/bonestack3.tpl"), parentPath: "grp@5");
						bonestack.POS2D = new Vec2d(5.25f, 0f);
						bonestack.RELATIVEZ = -0.02f;
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
				case "world/rlc_nemo/harborhell/nemo_harborhell_nmi_base.isc": {
						var sceneTree = new PickableTree(scene);
						var act = sceneTree.FollowObjectPath(new ObjectPath("oceancannontest_ld|grp@13|chainrope_attach_zipline@1"));
						ZiplineToRope(oldContext, newSettings, (Actor)act.Pickable);

						// There's a toad that usually gets stuck in the floor and dies offscreen. Move it up a unit to fix it
						var disappearingToad = scene.FindActor(a => a.USERFRIENDLY == "shootingtoad@5");
						disappearingToad.Result.POS2D = disappearingToad.Result.POS2D + new Vec2d(0f, 1f);
						break;
					}
				case "world/rlc_dojo/forbiddencity/dojo_forbiddencity_exp_base.isc": {
						AllSMVToFrise(oldContext, scene);
						/* ring_hangtriggermulti */
						/*var hangHelper = await AddNewActor(scene, new Path("world/common/platform/ring/components/ring.tpl"), 
							parentPath: "forbiddencity_ld|grp@2",
							name: "ring_jumphelp", contextToLoadFrom: LegendsContext);*/
						var hangHelper = await AddNewActor(scene, new Path("world/common/gpe/ring/components/ring_hangtriggermulti.tpl"),
							parentPath: "forbiddencity_ld|grp@2",
							name: "ring_jumphelp");
						hangHelper.POS2D = new Vec2d(-8.49f, 4.19f);
						hangHelper.RELATIVEZ = 0.03f;
						break;
					}
				case "world/rlc_dojo/tothemarket/dojo_tothemarket_exp_base.isc": {
						AllSMVToFrise(oldContext, scene);
						break;
					}
				case "world/rlc_castle/ghostclusters/hauntedcastle_ghostclusters_nmi_base.isc": {
						AllSMVToFrise(oldContext, scene);
						break;
					}
				case "world/rlc_castle/hiddendoorgalore/hauntedcastle_hiddendoorgalore_exp_base.isc": {
						AllSMVToFrise(oldContext, scene);
						break;
					}
				case "world/rlc_castle/pressureplatepalace/hauntedcastle_pressureplatepalace_nmi.isc": {
						AllSMVToFrise(oldContext, scene);
						ApplySpecialRenderParamsToScene(scene);
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
				case "world/rlc_castle/towertrouble/castleexterior_towertrouble_exp_base.isc": {
						var badjacquouille = scene.FindActor(a => a.USERFRIENDLY == "Torture");
						badjacquouille.Result.POS2D += new Vec2d(-6.5f, 3f);
						var act = scene.FindActor(a => a.USERFRIENDLY == "renderparam");
						FixCastleCorridorPrimitiveParams(oldContext, newSettings, scene);
						/*var checkp = scene.FindActor(a => a.USERFRIENDLY == "checkpoint_innovisual@1").Result.GetComponent<PrefetchTargetComponent>();
						var poly = (PhysShapePolygon)checkp.ZONE.shape.obj;
						for (int i = 0; i < poly.distances.Count; i++) poly.distances[i] *= 20f;
						for (int i = 0; i < poly.Points.Count; i++) poly.Points[i] *= 20f;*/
						//act.Result.RELATIVEZ = 3;
						//ApplySpecialRenderParamsToScene(scene);
						break;
					}
				case "world/rlc_castle/roastedpigrodeo/castleexterior_roastedpigrodeo_lum_base.isc": {
						// A rabbid auto-dies here, AABB hack doesn't work... we'll delete it
						var rabbid = scene.FindActor(a => a.USERFRIENDLY == "seasonaleventenemyspawner");
						rabbid.ContainingScene.DeletePickable(rabbid.Result);


						var lk = scene.FindActor(a => a.USERFRIENDLY == "lumking@1");
						lk.ContainingScene.DeletePickable(lk.Result);
						var lkReplacement = await SpawnTeensyCage(lk.ContainingScene,
							RO2_FriendlyBTAIComponent.Prisoner.Soldier, 0, TeensyWorldType.Jungle, CageType.Flying, false, mirror: true, name: lk.Result.USERFRIENDLY);
						lkReplacement.parentBind = lk.Result.parentBind;
						lkReplacement.STARTPAUSE = lk.Result.STARTPAUSE;
						lkReplacement.RELATIVEZ = lk.Result.RELATIVEZ;
						lkReplacement.POS2D = lk.Result.POS2D;

						lk = scene.FindActor(a => a.USERFRIENDLY == "lumking" && a.POS2D.x == 0f);
						lk.ContainingScene.DeletePickable(lk.Result);
						lkReplacement = await SpawnTeensyCage(lk.ContainingScene,
							RO2_FriendlyBTAIComponent.Prisoner.Soldier, 1, TeensyWorldType.Jungle, CageType.Flying, true, mirror: true, name: lk.Result.USERFRIENDLY);
						lkReplacement.parentBind = lk.Result.parentBind;
						lkReplacement.STARTPAUSE = lk.Result.STARTPAUSE;
						lkReplacement.RELATIVEZ = lk.Result.RELATIVEZ;
						lkReplacement.POS2D = new Vec2d(-7.41f, -1.88f);//lk.Result.POS2D;

						lk = scene.FindActor(a => a.USERFRIENDLY == "lumking" && a.POS2D.x > -6f);
						lk.ContainingScene.DeletePickable(lk.Result);
						lkReplacement = await SpawnTeensyCage(lk.ContainingScene,
							RO2_FriendlyBTAIComponent.Prisoner.Soldier, 2, TeensyWorldType.Jungle, CageType.Flying, true, mirror: true, name: lk.Result.USERFRIENDLY);
						lkReplacement.parentBind = lk.Result.parentBind;
						lkReplacement.STARTPAUSE = lk.Result.STARTPAUSE;
						lkReplacement.RELATIVEZ = lk.Result.RELATIVEZ;
						lkReplacement.POS2D = lk.Result.POS2D + Vec2d.Down;
						break;
					}
				case "world/rlc_maze/bumpermaze/maze_bumpermaze_exp_base.isc": {
						UseFastCameras(scene);
						var act = scene.FindActor(a => a.USERFRIENDLY == "renderparam");
						var rp = act.Result.GetComponent<RenderParamComponent>();
						rp.Lighting.GlobalColor *= new UbiArt.Color(0.6f, 0.6f, 0.6f, 1f);
						act = scene.FindActor(a => a.USERFRIENDLY == "mobilespikes@13");
						act.ContainingScene.DeletePickable(act.Result);
						break;
					}
				case "world/rlc_castle/scaffoldingchase/castleexterior_scaffoldingchase_nmi_base.isc": {
						FixCastleCorridorPrimitiveParams(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_castle/siegeattack/castleexterior_siegeattack_nmi_base.isc": {
						var act = scene.FindActor(a => a.USERFRIENDLY == "mood1");
						var rp = act.Result.GetComponent<RenderParamComponent>();
						rp.ClearColor.ClearFrontLightColor = rp.ClearColor.ClearColor;
						//act.Result.GetComponent<RenderParamComponent>().Lighting.GlobalColor.a = 0.8f;
						FixCastleCorridorPrimitiveParams(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_castle/siegeslide/castleexterior_siegeslide_nmi.isc": {
						var act = scene.FindActor(a => a.USERFRIENDLY == "clearcolor@1");
						var rp = act.Result.GetComponent<RenderParamComponent>();
						rp.Lighting.GlobalColor.a = 0.8f;
						rp.ClearColor.ClearFrontLightColor *= new UbiArt.Color(0.5f, 0.5f, 0.5f, 1f);

						FixCastleCorridorPrimitiveParams(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_castle/tumblingtowers/castleexterior_tumblingtowers_spd_base.isc": {
						var act = scene.FindActor(a => a?.USERFRIENDLY == "clearcolor");
						var rp = act.Result.GetComponent<RenderParamComponent>();
						rp.Lighting.Enable = true;
						rp.Lighting.GlobalColor.a = 0.1f;
						//rp.ClearColor.ClearFrontLightColor *= new UbiArt.Color(0.3f, 0.3f, 0.3f, 1f);
						break;
					}
				case "world/rlc_dojo/festivalofspeed/dojo_festivalofspeed_spd_base.isc": {
						var act = scene.FindActor(a => a?.USERFRIENDLY == "renderparam@1");
						var rp = act.Result.GetComponent<RenderParamComponent>();
						rp.Lighting.GlobalColor *= new UbiArt.Color(0.8f, 0.8f, 0.8f, 0.8f);
						//ApplySpecialRenderParamsToScene(scene);
						break;
					}
				case "world/rlc_olympus/cranezone/olympus_cranezone_exp_base.isc": {
						ZiplineToRope_All(oldContext, newSettings, scene);
						break;
					}
				case "world/rlc_nemo/bumperbarrelroom/nemo_bumperbarrelroom_lum_base.isc": {
						// Set brightness of lum bubbles to 0
						var acts = scene.FindActors(a => a?.LUA?.filename?.Contains("bubbleprize") ?? false);
						foreach (var act in acts) {
							var anm = act.Result.GetComponent<AnimatedComponent>();
							if(anm?.PrimitiveParameters == null) continue;
							anm.PrimitiveParameters.FrontLightBrightness = 0f;
						}
						break;
					}
				case "world/rlc_enchantedforest/somethingsmellsfunny/enchantedforest_somethingsmellsfunny_spd_base.isc": {
						// A rabbid falls off here...
						var tree = new PickableTree(scene);
						var plat = tree.FollowObjectPath(new ObjectPath("seasonaleventenemyspawner|minotaur_flyingplatform"), throwIfNotFound: false);
						if (plat?.Pickable != null) {
							GenericAABBHack((Actor)plat.Pickable, aabbScale: 100f);
						}
						break;
					}
				case "world/rlc_beanstalk/aspiidnetwork/beanstalk_aspiidnetwork_spd_base.isc": {
						// To help with the passage that normally requires invincibility
						var act = await AddNewActor(scene, new Path("world/common/friendly/phial/components/phial.tpl"), "testmap63_aSpiidNetwork_ld", contextToLoadFrom: LegendsContext);
						act.POS2D = new Vec2d(16.95f, 13.95f);
						act.RELATIVEZ = -0.01f;
						var captain = scene.FindActor(a => a.USERFRIENDLY == "exitflag");
						captain.ContainingScene.DeletePickable(captain.Result); // Remove one of the captains
						captain = scene.FindActor(a => a.USERFRIENDLY == "exitflag@1");
						captain.Result.POS2D += Vec2d.Down * 0.3f; // Move him down a bit
						break;
					}
				case "world/rlc_hades/volcanicheist/hades_volcanicheist_nmi_base.isc": {
						// Difficult level, add a phial halfway
						var act = await AddNewActor(scene, new Path("world/common/friendly/phial/components/phial.tpl"), "testmap65_VolcanicHeist_localld|transfert", contextToLoadFrom: LegendsContext);
						act.POS2D = new Vec2d(-81.9f, -19.15839f);
						act.RELATIVEZ = 0.1378f;
						break;
					}
				case "world/rlc_hades/scaldingswim/hades_scaldingswim_spd_base.isc": {
						//ApplySpecialRenderParamsToScene(scene);
						break;
					}
				case "world/rlc_hangar/conveyorchaos/hangar_conveyorchaos_spd_base.isc": {
						async Task CreateTween(string[] children, Vec2d pos, float cycleTime = 1f) {
							var tweenPath = new Path("world/common/logicactor/tweening/tweeneditortype/components/tween_notype.tpl");
							var act = await AddNewActor(scene, tweenPath, parentPath: "hangar_conveyorchaos_spd_base_ld", contextToLoadFrom: LegendsContext);
							ConfigureOnOffTween(oldContext, act.GetComponent<TweenComponent>(), cycleTime: cycleTime, timeOn: cycleTime / 4f);
							var links = act.GetComponent<LinkComponent>();
							links.Children = new CListO<ChildEntry>(children.Select(str => new ChildEntry() { Path = new ObjectPath(str) }).ToList());
							for (int i = 1; i < 4; i++) {
								links.Children[i].AddTag(new StringID("Delay"), (cycleTime / 4f * i).ToString());
							}
							act.POS2D = pos;
							act.SCALE = new Vec2d(10, 10);
							act.RELATIVEZ = -0.02f;
						};
						await CreateTween(new string[] {
							"electricarc@10", "electricarc", "electricarc@2", "electricarc@1"
						}, new Vec2d(392.2f, -75.14f));
						await CreateTween(new string[] {
							"electricarc@3", "electricarc@4", "electricarc@6", "electricarc@5"
						}, new Vec2d(559.99f, -83.08f), cycleTime: 0.75f);
						break;
					}
				case "world_arcade/ra_challenge/ra_cha_riverstream/ra_cha_riverstream_main.isc": {
						// Delete some additional Mr Dark stuff
						var pickables = scene.FindPickables(p => p.USERFRIENDLY.StartsWith("relay_unpause_fx") || p.USERFRIENDLY.StartsWith("afxpostprocess"));
						foreach (var p in pickables) {
							p.ContainingScene.DeletePickable(p.Result);
						}

						// There's no frise or fog blending in this. Delete all backfrise and set clearcolor back to that
						var backlightColor = new UbiArt.Color(231f / 255f, 210f / 255f, 102f / 255f, 1f);
						pickables = scene.FindPickables(p => p.USERFRIENDLY.StartsWith("backfrise"));
						foreach (var p in pickables) {
							p.ContainingScene.DeletePickable(p.Result);
						}
						var moods = scene.FindActors(a => a.GetComponent<RenderParamComponent>() != null);
						foreach (var res in moods) {
							var mood = res.Result.GetComponent<RenderParamComponent>();
							mood.ClearColor.ClearBackLightColor = backlightColor;

							// and lower lighting intensity
							var factor = 0.7f;
							mood.Lighting.GlobalColor *= new UbiArt.Color(factor, factor, factor, 1f);
						}
						
						// Delete resolvemask - not necessary in this case
						var resolveMask = scene.FindActor(a => a.USERFRIENDLY == "resolvebothmask_noclear");
						resolveMask.ContainingScene.DeletePickable(resolveMask.Result);

						// Add sceneconfigs
						Path[] extraConfigs = new string[] {
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_easy.isg",
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_easy_mrdark.isg",
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_medium.isg",
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_medium_mrdark.isg",
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_hard.isg",
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_hard_mrdark.isg",
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_insane.isg",
							"world_arcade/ra_challenge/ra_cha_riverstream/bricks/challengemode_riverstream_insane_mrdark.isg",
						}.Select(s => new Path(s)).ToArray();
						foreach (var p in extraConfigs) {
							p.LoadObject(MainContext, removeCooked: true);
						}
						await MainContext.Loader.LoadLoop();
						scene.sceneConfigs.sceneConfigs = new CArrayO<Generic<SceneConfig>>(scene.sceneConfigs.sceneConfigs.Concat(extraConfigs.Select(p => new Generic<SceneConfig>(new RO2_SceneConfig_ChallengeEndurance() {
							modePath = p
						}))).ToArray());
						break;
					}
				case "world_arcade/ra_challenge/ra_cha_foliage/ra_cha_foliage_main.isc": {
						// Delete some additional Mr Dark stuff
						var pickables = scene.FindPickables(p => p.USERFRIENDLY.StartsWith("relay_unpause@") || p.USERFRIENDLY.StartsWith("afxpostprocess"));
						foreach (var p in pickables) {
							p.ContainingScene.DeletePickable(p.Result);
						}

						// There's no frise blending in this. Delete all backfrise and set clearcolor back to that
						var backlightColor = new UbiArt.Color(220f / 255f, 163f / 255f, 76f / 255f, 1f);
						pickables = scene.FindPickables(p => p.USERFRIENDLY.StartsWith("backfrise"));
						foreach (var p in pickables) {
							p.ContainingScene.DeletePickable(p.Result);
						}
						var moods = scene.FindActors(a => a.GetComponent<RenderParamComponent>() != null);
						foreach (var res in moods) {
							var mood = res.Result.GetComponent<RenderParamComponent>();
							mood.ClearColor.ClearBackLightColor = backlightColor;

							// and lower lighting intensity
							var factor = 0.8f;
							mood.Lighting.GlobalColor *= new UbiArt.Color(factor, factor, factor, 1f);
						}

						// Delete resolvemask - not necessary in this case
						var resolveMask = scene.FindActor(a => a.USERFRIENDLY == "resolvebothmask_noclear");
						resolveMask.ContainingScene.DeletePickable(resolveMask.Result);

						// Add sceneconfigs
						Path[] extraConfigs = new string[] {
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_easy.isg",
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_easy_mrdark.isg",
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_medium.isg",
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_medium_mrdark.isg",
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_hard.isg",
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_hard_mrdark.isg",
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_insane.isg",
							"world_arcade/ra_challenge/ra_cha_foliage/bricks/challengemode_foliage_insane_mrdark.isg",
						}.Select(s => new Path(s)).ToArray();
						foreach (var p in extraConfigs) {
							p.LoadObject(MainContext, removeCooked: true);
						}
						await MainContext.Loader.LoadLoop();
						scene.sceneConfigs.sceneConfigs = new CArrayO<Generic<SceneConfig>>(scene.sceneConfigs.sceneConfigs.Concat(extraConfigs.Select(p => new Generic<SceneConfig>(new RO2_SceneConfig_ChallengeEndurance() {
							modePath = p
						}))).ToArray());
						break;
					}
				case "world/challenge/run/challengerun/challenge_run_main.isc": {
						// Let's have the area become progressively darker...
						for (int i = 0; i < 5; i++) {
							var act = scene.FindActor(a => a.USERFRIENDLY == $"fog_{(i+1)}");
							var rp = act.Result.GetComponent<RenderParamComponent>();
							var factor = 1f - (i * 0.15f);
							rp.ClearColor.ClearFrontLightColor *= new UbiArt.Color(factor, factor, factor, 1f);
							rp.ClearColor.ClearColor *= new UbiArt.Color(factor, factor, factor, 1f);
						}
						break;
					}
				case "world/challenge/run/challengerun/brick/medium/runbrick_medium_75.isc": {
						// This brick has a rope (that's also inverted) that goes down too fast
						// Commented for now because I think this was only bugged because the template in Adventures is different from Legends
						//var res = scene.FindActor(a => a.USERFRIENDLY == "liana_zipline_freelength");
						//res.Result.POS2D += new Vec2d(0.71345f, 1.6302362f);
						break;
					}
				case "world/challenge/run/challengerun/brick/hard/runbrick_hard_48.isc": {
						// This brick has a forced crush attack -> ring grab combination which can't work in Legends
						// Delete "grp" and spawn a rabbid on a shield there :)
						var mast = scene.FindPickable(p => p.USERFRIENDLY == "mast_nocol@1");
						mast.ContainingScene.DeletePickable(mast.Result);
						var ring = scene.FindPickable(p => p.USERFRIENDLY == "ring@1");
						ring.ContainingScene.DeletePickable(ring.Result);

						var rabbidPath = new Path("world/rlc/common/enemy/rabbid_normal/rabbid_shield.tsc");
						if (Version == SpecialVersion.EventGoldenMarathon) {
							rabbidPath = new Path("world/rlc/common/enemy/rabbid_winter/rabbid_shield.tsc");
						}
						var rabbidSSA = await AddNewActor(ring.ContainingScene, rabbidPath, contextToLoadFrom: LegendsContext);
						rabbidSSA.xFLIPPED = false;
						rabbidSSA.POS2D = ring.Result.POS2D - new Vec2d(0f, 2.5f);
						break;
					}
				case "world/challenge/run/challengerun/brick/medium/runbrick_medium_74.isc": {
						// This brick has a forced crush attack -> ring grab combination which can't work in Legends
						// Delete "grp" and spawn a rabbid on a shield there :)
						var grp = scene.FindPickable(p => p.USERFRIENDLY == "grp");
						grp.ContainingScene.DeletePickable(grp.Result);

						var rabbidPath = new Path("world/rlc/common/enemy/rabbid_normal/rabbid_shield.tsc");
						if (Version == SpecialVersion.EventGoldenMarathon) {
							rabbidPath = new Path("world/rlc/common/enemy/rabbid_winter/rabbid_shield.tsc");
						}
						var rabbidSSA = await AddNewActor(grp.ContainingScene, rabbidPath, contextToLoadFrom: LegendsContext);
						rabbidSSA.xFLIPPED = false;
						rabbidSSA.POS2D = grp.Result.POS2D;
						break;
					}
				case "world/challenge/run/challengerun/decobrick/background/brick_back_a_01.isc":
				case "world/challenge/run/challengerun/decobrick/background/brick_back_a_02.isc":
				case "world/challenge/run/challengerun/decobrick/background/brick_back_a_03.isc":
				case "world/challenge/run/challengerun/decobrick/background/brick_back_a_04.isc": {
						if (Version == SpecialVersion.EventGoldenMarathon) {
							// Add more snow trees to compensate for smaller AABB
							var snowTree = scene.FindActor(a => a.USERFRIENDLY == "fx_snowtree_01");
							var newSnowTreeActor = (Actor)snowTree.Result.Clone("isc");
							newSnowTreeActor.POS2D += new Vec2d(40.39538f, 0f);
							snowTree.ContainingScene.AddActor(newSnowTreeActor);
							newSnowTreeActor = (Actor)snowTree.Result.Clone("isc");
							newSnowTreeActor.POS2D -= new Vec2d(40.39538f, 0f);
							snowTree.ContainingScene.AddActor(newSnowTreeActor);
							newSnowTreeActor = (Actor)snowTree.Result.Clone("isc");
							newSnowTreeActor.POS2D -= new Vec2d((40.39538f * 3/2f), 0f);
							snowTree.ContainingScene.AddActor(newSnowTreeActor);
						}
						break;
					}
				case "world/challenge/run/challengerun/brick/last_brick/last_brick_01.isc":
				case "world/challenge/run/challengerun/brick/last_brick/last_brick_02.isc": {
						if (Version == SpecialVersion.EventDesertMarathon) {
							// These haven't been egypt-ified
							var frises = scene.FindPickables(p => p is Frise f && f.ConfigName.FullPath.StartsWith("world/rlc_landofthedead/"));
							foreach (var res in frises) {
								var fr = res.Result as Frise;
								fr.ConfigName = new Path(fr.ConfigName.FullPath.Replace("world/rlc_landofthedead/", "world/rlc_egypt/"));
								fr.LUA = fr.ConfigName;
								fr.PreComputedForCook = false; // Recompute them
							}
						}
						break;
					}
				case "world/rlc_castle/rotatingplatformpanic/castleinterior_rotatingplatformpanic_spd.isc": {
						AllSMVToFrise(oldContext, scene);
						AllRotatingPlatformsToTweens(oldContext, scene, rotateTime: 1f / 3f, waitTime: 2f / 3f);
						break;
					}
				case "personal/filip/gameplaymixdemo.isc": {
						AllSMVToFrise(oldContext, scene);
						//AllRotatingPlatformsToTweens(oldContext, scene, rotateTime: 1f / 3f, waitTime: 2f / 3f);

						var rotPlat1 = scene.FindActor(a => a.USERFRIENDLY == "rotatingplatform_single");
						RotatingPlatformToTween(oldContext, rotPlat1.Result, rotateTime: 0.5f, waitTime: 1f, clockwise: true, backAndForth: true);

						var rotPlat2 = scene.FindActor(a => a.USERFRIENDLY == "rotatingplatform_tshape");
						RotatingPlatformToTween(oldContext, rotPlat2.Result, rotateTime: 0.5f, waitTime: 1f, clockwise: false, backAndForth: true);

						var rotPlat3 = scene.FindActor(a => a.USERFRIENDLY == "rotatingplatform_cross");
						RotatingPlatformToTween(oldContext, rotPlat3.Result, rotateTime: 0.5f, waitTime: 1f, clockwise: true, backAndForth: false);

						// Hack to fix disappearing torturejacqouille
						var unpauser = scene.FindActor(a => a.USERFRIENDLY == "relay_unpause@2" && a.POS2D.x < 0);
						var unpauseLinks = unpauser.Result.GetComponent<LinkComponent>();
						unpauseLinks.Children.Add(new ChildEntry() { Path = new ObjectPath("..|..|torturejacquouille@1") });
						unpauseLinks.Children.Add(new ChildEntry() { Path = new ObjectPath("..|..|teensy@1") });
						var badJacquouille = scene.FindActor(a => a.USERFRIENDLY == "torturejacquouille@1");
						badJacquouille.Result.STARTPAUSE = true;
						var badTeensy = scene.FindActor(a => a.USERFRIENDLY == "teensy@1");
						badTeensy.Result.STARTPAUSE = true;

						// But these ones, we'll just get rid of entirely.
						var badJacqouille2 = scene.FindActors(a => a.USERFRIENDLY == "shieldjacquouilleshielddown@2" || a.USERFRIENDLY == "shieldjacquouilleshieldup@1");
						foreach (var j in badJacqouille2) {
							j.ContainingScene.DeletePickable(j.Result);
						}

						// Fix cave background brightness
						var backgroundCave = (Frise)scene.FindPickable(p => p.USERFRIENDLY == "intro_background_cave").Result;
						backgroundCave.PrimitiveParameters.FrontLightBrightness = 1f;
						backgroundCave.PrimitiveParameters.FrontLightFactor = 0f;

						/*var moods = scene.FindActors(a => a.USERFRIENDLY.StartsWith("mood_")); // mood_fire, mood_exterior, ambiance_blue@2
						foreach (var mood in moods) {
							mood.Result.RELATIVEZ -= 5f;
						}*/
						var ambiance_blue = scene.FindActor(a => a.USERFRIENDLY == "ambiance_blue@2");
						ambiance_blue.Result.RELATIVEZ += 5f;
						break;
					}
				case "world/rlc_dojo/ringtraining/dojo_ringtraining_exp_base.isc": {
						// Remove rotating platform to access secret place
						var actToRemove = scene.FindActor(a => a.USERFRIENDLY == "dojo_platform_single@1");
						actToRemove.ContainingScene.DeletePickable(actToRemove.Result);
						var friseToRemove = scene.FindPickable(a => a.USERFRIENDLY == "dojo_int_ldground_woodpipe@3");
						friseToRemove.ContainingScene.DeletePickable(friseToRemove.Result);
						friseToRemove = scene.FindPickable(a => a.USERFRIENDLY == "invisibleground@3");
						friseToRemove.ContainingScene.DeletePickable(friseToRemove.Result);

						// Configure auto-rotating platforms
						var sceneTree = new PickableTree(scene);
						var act = sceneTree.FollowObjectPath(new ObjectPath("DojoProto3_ld|dojo_platform_straight@1|rotatingplatform_straight"));
						RotatingPlatformToTween(oldContext, act.Pickable as Actor, totalAngle: 180f, rotateTime: 0.65f, waitTime: 0.65f, clockwise: false);
						act = sceneTree.FollowObjectPath(new ObjectPath("DojoProto3_ld|dojo_platform_tshape@2|rotatingplatform_straight"));
						RotatingPlatformToTween(oldContext, act.Pickable as Actor, waitTime: 0.375f, rotateTime: 0.375f, clockwise: false);
						AllRotatingPlatformsToTweens(oldContext, scene, rotateTime: 0.5f, waitTime: 1f);

						// Convert all SMV to frise
						AllSMVToFrise(oldContext, scene);

						// Fix with trigger_fadeout? ---> Doesn't work
						//var tweenToCorrect = scene.FindActor(a => a.USERFRIENDLY == "tween_notype@2");
						/*var tween = tweenToCorrect.Result;
						tweenToCorrect.ContainingScene.DeletePickable(tween);

						var newActor = await AddNewActor(tweenToCorrect.ContainingScene, new Path("world/common/logicactor/trigger/components/trigger_fade_out.tpl"), name: tween.USERFRIENDLY);
						newActor.GetComponent<LinkComponent>().Children = tweenToCorrect.Result.GetComponent<LinkComponent>().Children;
						newActor.POS2D = tween.POS2D;
						newActor.ANGLE = tween.ANGLE;
						newActor.SCALE = tween.SCALE;
						newActor.RELATIVEZ = tween.RELATIVEZ;
						newActor.xFLIPPED = tween.xFLIPPED;
						newActor.parentBind = tween.parentBind;
						newActor.USERFRIENDLY = tween.USERFRIENDLY;*/

						// Fix with extra tween instructions? ---> Doesn't work
						/*var t = tweenToCorrect.Result.GetComponent<TweenComponent>();
						var tpl = t.instanceTemplate.value;
						tpl.instructionSets[1].instructions[0].obj.duration = 1f;
						var ev = ((TweenEvent_Template)tpl.instructionSets[1].instructions[0].obj)._event?.obj as EventShow;
						ev.alpha = 0f;
						ev.transitionTime = 1f;
						tpl.instructionSets[1].instructions.Add(new Generic<TweenInstruction_Template>(new TweenWait_Template() {
							duration = 1f
						}));
						t.instructionSets[1].instructions.Add(new Generic<TweenInstruction>(new TweenWait()));*/
						break;
					}
				case "world/rlc/common/enemy/rabbid/rabbid_shield.tsc": {
						// Move rabbid way higher up so it doesn't fall off.
						// Weird workaround, but this is what the Legends devs did for the minotaurs...
						//var rabbid = scene.FindActor(a => a.USERFRIENDLY == "rabbid@1");
						//rabbid.Result.POS2D += Vec2d.Up;
						break;
					}
			}

			if (scenePath.FullPath.StartsWith("world_arcade/ra_musical/")) {
				//UseFastCameras(scene);
			}
			if (scenePath.FullPath.StartsWith("world/challenge/run/challengerun/")) {
				InvertLianas_OnlyLeft(oldContext, newSettings, scene);
				FixBrokenSoundReferencesInChallenges(oldContext, newSettings, scene);

				if (Version == SpecialVersion.EventDesertMarathon || Version == SpecialVersion.EventGoldenMarathon) {
					// Color falling rock FX
					var fxPath = new Path("world/common/fx/earthquake/fx_earthquake_mo_rl.tpl");
					var fxActors = scene.FindActors(a => a.LUA == fxPath);
					foreach (var res in fxActors) {
						var act = res.Result;
						var pp = act?.GetComponent<FxBankComponent>()?.PrimitiveParameters;
						if (pp == null) continue;
						pp.useStaticFog = true;
						if (Version == SpecialVersion.EventDesertMarathon) {
							pp.colorFog = new UbiArt.Color(178f / 255f, 135f / 255f, 135f / 255f, 0.63f);
						} else if(Version == SpecialVersion.EventGoldenMarathon) {
							pp.colorFog = new UbiArt.Color(110f / 255f, 87f / 255f, 50f / 255f, 0.63f);
						}
					}
				}
			}
		}

		public async Task<Actor> AddNewActor(Scene scene, Path path,
			string parentPath = null, string name = null, Context contextToLoadFrom = null) {
			if(contextToLoadFrom == null) contextToLoadFrom = MainContext;
			path.LoadObject(contextToLoadFrom, removeCooked: true);
			await contextToLoadFrom.Loader.LoadLoop();

			Actor newActor = null;

			switch (path.GetExtension(removeCooked: true).ToLowerInvariant()) {
				case "tpl":
					var tpl = path.GetObject<GenericFile<Actor_Template>>();
					newActor = tpl?.obj?.Instantiate(path);
					break;
				case "act":
					var act = path.GetObject<ContainerFile<Actor>>();
					newActor = (Actor)(await contextToLoadFrom.Loader.Clone(act?.obj, "act"));
					newActor.USERFRIENDLY = path.GetFilenameWithoutExtension(removeCooked: true);
					break;
				case "frz":
					var frz = path.GetObject<ContainerFile<Frise>>();
					newActor = (Actor)(await contextToLoadFrom.Loader.Clone(frz?.obj, "frz"));
					newActor.USERFRIENDLY = path.GetFilenameWithoutExtension(removeCooked: true);
					break;
				case "tsc":
				case "isc":
					var tsc = path.GetObject<ContainerFile<Scene>>();
					newActor = new SubSceneActor() {
						USERFRIENDLY = path.GetFilenameWithoutExtension(removeCooked: true),
						LUA = new Path("enginedata/actortemplates/subscene.tpl"),

						EMBED_SCENE = true,
						ZFORCED = true,
						SCENE = new UbiArt.Nullable<Scene>((Scene)(await contextToLoadFrom.Loader.Clone(tsc?.obj, "isc")))
					};
					break;
			}
			MainContext.Loader.AddLoadedActor(newActor);

			var containingScene = scene;
			if (!string.IsNullOrWhiteSpace(parentPath)) {
				var pickableTree = new PickableTree(scene);
				var resultNode = pickableTree.FollowObjectPath(new ObjectPath(parentPath));
				containingScene = resultNode.Scene;
			}
			if (containingScene != null) {
				containingScene.AddActor(newActor, name ?? newActor.USERFRIENDLY);
			}

			return newActor;
		}

		public void AdjustGhostBrightness(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var ghostSkeletonPath = new Path("world/common/enemy/ghost/animation/ghost_squeleton.skl");

			var l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];
			if (actorTemplates != null) {
				foreach (var tplPair in actorTemplates) {
					var tpl = tplPair.Value as GenericFile<Actor_Template>;
					var animTPL = tpl?.obj?.GetComponent<AnimatedComponent_Template>();
					if (animTPL == null) continue;
					if (animTPL.animSet?.animPackage?.skeleton == ghostSkeletonPath) {
						/*var addColor = 1f;
						if(anim.selfIllumColor == null) anim.selfIllumColor = UbiArt.Color.Zero;
						anim.selfIllumColor = new UbiArt.Color(0.5f, 1f, 0.5f, addColor);*/
						//anim.selfIllumColor = new UbiArt.Color
						foreach (var act in l.LoadedActors.Where(a => a?.LUA?.stringID == tplPair.Key)) {
							var anim = act.GetComponent<AnimatedComponent>();
							if(anim.PrimitiveParameters == null) anim.PrimitiveParameters = new GFXPrimitiveParam();
							if (!anim.PrimitiveParameters.UseGlobalLighting) {
								//anim.PrimitiveParameters.FrontLightBrightness = 0.6f;
								//anim.PrimitiveParameters.FrontLightContrast = 0.5f;
								//anim.PrimitiveParameters.colorFactor *= new UbiArt.Color(1f,1f,1f, 0.7f);
								anim.PrimitiveParameters.FrontLightBrightness = 1f;
								anim.PrimitiveParameters.FrontLightContrast = 0f;
							}
						}
					}
				}
			}
		}

		public async Task SpawnRabbids(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var scenePath = GetScenePath(scene);
			var fullPath = scenePath.FullPath;
			var renameVersion = SpecialVersion.EventEaster; // Regular rabbids
			if (fullPath.StartsWith("world/rlc_hangar/") || fullPath.StartsWith("world/rlc_nemo/")) {
				renameVersion = SpecialVersion.EventSummer;
			} else if (fullPath.Contains("hauntedcastle_") || fullPath.Contains("castleinterior_rotatingplatformpanic")) {
				renameVersion = SpecialVersion.EventHalloween;
			} else if (fullPath.Contains("castleexterior_") || fullPath.Contains("castleinterior_") || fullPath.Contains("avatar_imonamoat")) {
				renameVersion = SpecialVersion.None; // Renaissance
			} else if (fullPath.StartsWith("world/rlc_dojo/")) {
				var snowLevels = new string[] { "spikyspinners", "dragonsspire", "ringtraining", "underconstruction", "greatwallwaterfall" };
				foreach (var snowLevel in snowLevels) {
					if (fullPath.Contains(snowLevel)) {
						renameVersion = SpecialVersion.EventWinter;
						break;
					}
				}
			} else if (fullPath.StartsWith("world/challenge/run/challengerun/") && Version == SpecialVersion.EventGoldenMarathon) {
				renameVersion = SpecialVersion.EventWinter;
			}

			var renameConversionSettings = new ConversionSettings();
			InitRabbidPathConversion(renameVersion, renameConversionSettings);

			// world/rlc/common/enemy/rabbid/
			// Go over the scene, then rename all paths starting with this (either actor.LUA or spawn component)
			var enemySpawnerPath = new Path("world/rlc/common/gpe/seasonaleventspawner/templates/seasonaleventenemyspawner.tpl");
			var spawnActors = scene.FindActors(a => a.LUA == enemySpawnerPath);
			foreach (var res in spawnActors) {
				var act = res.Result;
				var sc = act.GetComponent<RLC_SeasonalEventSpawnerComponent>();
				var scTPL = act.template.obj.GetComponent<RLC_SeasonalEventSpawnerComponent_Template>();
				res.ContainingScene.DeletePickable(act);

				var rabbidPath = new Path(scTPL.actorPaths[(int)sc.selectedPathIndex].FullPath);
				rabbidPath.ConvertPath(renameConversionSettings);
				var rabbidName = act.USERFRIENDLY;
				if (sc.triggerSpawn) {
					rabbidName += "_rabbid";
				}
				void SetToActorTransform(Actor a) {
					a.POS2D = act.POS2D;
					a.parentBind = act.parentBind;
					a.ANGLE = act.ANGLE;
					a.SCALE = act.SCALE;
					a.xFLIPPED = act.xFLIPPED;
					a.RELATIVEZ = act.RELATIVEZ;
				}
				var rabbid = await AddNewActor(res.ContainingScene, rabbidPath, name: rabbidName, contextToLoadFrom: LegendsContext);
				SetToActorTransform(rabbid);
				if (sc.triggerSpawn) {
					rabbid.STARTPAUSE = true;
					// Use same name as original
					var relay = await AddNewActor(res.ContainingScene, new Path("world/common/logicactor/trigger/relay/components/relay_unpause.tpl"), name: act.USERFRIENDLY, contextToLoadFrom: LegendsContext);
					SetToActorTransform(relay);
					var links = relay.GetComponent<LinkComponent>();
					links.Children = new CListO<ChildEntry>() {
						new ChildEntry() {
							Path = new ObjectPath(rabbid.USERFRIENDLY)
						}
					};
				}

				// Set pimitive parameters
				var gc = rabbid.GetComponent<GraphicComponent>();
				if (gc != null) {
					gc.PrimitiveParameters = (GFXPrimitiveParam)sc.GFXParam.Clone("isc");
				}
				if (rabbid is SubSceneActor ssa && ssa.SCENE?.value != null) {
					var gca = ssa.SCENE.value.FindActors(a => a.GetComponent<GraphicComponent>() != null);
					foreach (var gcRes in gca) {
						gc = gcRes.Result.GetComponent<GraphicComponent>();
						gc.PrimitiveParameters = (GFXPrimitiveParam)sc.GFXParam.Clone("isc");
					}
				}
			}
		}

		public async Task ProcessChallengeTemplates(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var structs = oldContext.Cache.Structs;

			var isgs = structs.TryGetItem(typeof(GenericFile<CSerializable>));
			if(isgs == null) return;
			foreach (var isgPair in isgs) {
				if(isgPair.Value == null) continue;
				var pathID = isgPair.Key;
				var genValue = (GenericFile<CSerializable>)isgPair.Value;
				if(genValue.obj == null || genValue.obj is not RO2_ChallengeCommon_Template chal) continue;
				var path = oldContext.Loader.Paths[pathID];
				if (chal.gameplayBricks != null) {
					foreach (var brick in chal.gameplayBricks) {
						var brickPath = brick?.obj?.path;
						if(brickPath == null || brickPath.IsNull) continue;
						var brickScene = brickPath.GetObject<ContainerFile<Scene>>();
						if (brickScene?.obj != null) {
							await ProcessScene(brickScene.obj, false);
						}
					}
				}

				if (chal.continueStartBrick != null) {
					foreach (var badBrickID in chal.continueStartBrick) {
						var badBrick = chal.gameplayBricks.FirstOrDefault(b => b?.obj?.name == badBrickID);
						if (badBrick != null) {
							chal.gameplayBricks.Remove(badBrick);
						}
					}
					chal.continueStartBrick = null;
				}

				if (chal is RO2_EnduranceMode_Template end) {
					if (path.FullPath.StartsWith("world_arcade/ra_challenge/")) {
						end.decoBrickMaxActiveCount = uint.MaxValue; // Why was this set to 1???? I spent over 10 hours debugging this only to find it was 1!
					}
					if (end.decoBricks != null) {
						foreach (var brick in end.decoBricks) {
							var brickPath = brick?.obj?.path;
							if (brickPath == null || brickPath.IsNull) continue;
							var brickScene = brickPath.GetObject<ContainerFile<Scene>>();
							if (brickScene?.obj != null) {
								await ProcessScene(brickScene.obj, false);
							}
						}
					}
					if (end.specialDecoBricks != null) {
						foreach (var brick in end.specialDecoBricks) {
							var brickPath = brick?.obj?.path;
							if (brickPath == null || brickPath.IsNull) continue;
							var brickScene = brickPath.GetObject<ContainerFile<Scene>>();
							if (brickScene?.obj != null) {
								await ProcessScene(brickScene.obj, false);
							}
						}
					}
					if (path.FullPath.StartsWith("world_arcade/ra_challenge/")) {
						chal.filterOrder = new CListO<CListP<string>>() {
							new CListP<string>() { "lums_lumsattackexpert", "lums_lumsattack", "lums_default" },
							new CListP<string>() { "tuto", "notuto" }
						};
						if (end.decoRanges != null) {
							foreach (var deco in end.decoRanges) {
								if (deco == null) continue;
								for (int i = 0; i < 10; i++) {
									if (deco.fog == new StringID($"fog_{i}")) {
										if (deco.clearColor?.IsNull ?? true) {
											deco.clearColor = new StringID($"fog_{i}");
										}
										// This is what we named the lighting frise created from the renderparam
										deco.frise = new StringID($"fog_{i}_frontlightfill");
										deco.fog = null;
									}
								}
							}
						}
					} else if (path.FullPath.StartsWith("world/challenge/run")) {
						chal.filterOrder = new CListO<CListP<string>>() {
							new CListP<string>() { "lums_lumsattackexpert", "lums_lumsattack", "lums_default" },
							new CListP<string>() { "tuto", "notuto" }
						};
						if (Version == SpecialVersion.EventGoldenMarathon) {
							chal.inGameMusic = new UbiArt.Nullable<EventPlayMusic>();
							chal.gameOverMusic = new UbiArt.Nullable<EventPlayMusic>(new EventPlayMusic() {
								nodeName = new StringID(0xE4416864),
								metronomeType = 2,
								volume = new Volume(-16),
							});
							chal.inGameMusic = new UbiArt.Nullable<EventPlayMusic>(new EventPlayMusic() {
								nodeName = new StringID(0x734ACFE7),
								metronomeType = 2,
								volume = new Volume(-11),
							});
							// TODO: Change music tree
							/*chal.difficultyChangeMusicEvents = new CListO<EventPlayMusic>() {
								new EventPlayMusic() {
									nodeName = new StringID(0x3579E6E3),
									metronomeType = 2,
									volume = new Volume(-10),
								},
								new EventPlayMusic() {
									nodeName = new StringID(0x29EFB20D),
									metronomeType = 2,
									volume = new Volume(-15),
								},
								new EventPlayMusic() {
									nodeName = new StringID(0xD4FC74B5),
									metronomeType = 2,
									volume = new Volume(-13),
								},
								new EventPlayMusic() {
									nodeName = new StringID(0x012B300D),
									metronomeType = 2,
									volume = new Volume(-13),
								},
							};*/
						} else {
							chal.inGameMusic = new UbiArt.Nullable<EventPlayMusic>(new EventPlayMusic() {
								nodeName = new StringID(0x734ACFE7),
								metronomeType = 2,
								volume = new Volume(-11),
							});
							chal.gameOverMusic = new UbiArt.Nullable<EventPlayMusic>(new EventPlayMusic() {
								nodeName = new StringID(0xE4416864),
								metronomeType = 2,
								volume = new Volume(-16),
							});
						}
						if (end.decoRanges != null) {
							foreach (var deco in end.decoRanges) {
								if (deco == null) continue;
								for (int i = 0; i < 10; i++) {
									if (deco.fog == new StringID($"fog_{i}")) {
										if (deco.clearColor?.IsNull ?? true) {
											deco.clearColor = new StringID($"fog_{i}");
										}
										if (deco.frise?.IsNull ?? true) {
											// This is what we named the lighting frise created from the renderparam
											deco.frise = new StringID($"fog_{i}_frontlightfill");
										}
										deco.fog = null;
									}
								}
							}
						}
					}
				}
				
			}
		}

		public void GenericAABBHack(Actor act, float aabbScale = 1000f) {
			if(act.template == null) return;

			var ogLUA = act.LUA;
			var ogTPL = act.template;

			if(ogTPL.obj.GetComponent<BoxInterpolatorComponent_Template>() != null) return;

			// Create tween actor template
			if (CloneTemplateIfNecessary(ogLUA, "modaabb", "MOD AABB", ogTPL, out var newTPL, act: act)) {
				newTPL.sizeOf += 0x10000;
				newTPL.obj.AddComponent<BoxInterpolatorComponent_Template>();
			}

			var box = act.AddComponent<BoxInterpolatorComponent>();
			box.innerBox = new AABB() {
				MIN = new Vec2d(-aabbScale, -aabbScale),
				MAX = new Vec2d(aabbScale, aabbScale)
			};
			box.outerBox = box.innerBox;
		}

		public async Task FixLumChainsBrightness(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var lumChainTPL = oldContext.Cache.Get<GenericFile<Actor_Template>>(new Path("world/common/friendly/lumschain/components/lumschain.tpl"));
			if(lumChainTPL == null) return;

			var lcLegends = await LoadFileLegends<GenericFile<Actor_Template>>(new Path("world/common/friendly/lumschain/components/lumschain.tpl"));
			lumChainTPL.sizeOf = lcLegends.sizeOf;
			lumChainTPL.obj = (Actor_Template)lcLegends.obj.Clone("tpl");
		}

		public async Task UseBetterEggForSoccerBall(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var l = oldContext.Loader;
			var ballTPL = oldContext.Cache.Get<GenericFile<Actor_Template>>(new Path("world/adversarial/soccerpunch/actor/soccerball/components/ball.tpl"));
			if(ballTPL == null) return;

			var fxb = ballTPL.obj.GetComponent<FxBankComponent_Template>();

			var eggIntro = await LoadFile<GenericFile<Actor_Template>>(MainContext, new Path("world/rlc/incubator/incubator/components/eggintro.tpl"));
			var eggFXB = eggIntro.obj.GetComponent<FxBankComponent_Template>();
			ReplaceFx(6, eggFXB.Fx[0]);
			ReplaceFx(7, eggFXB.Fx[1]);

			//var legendsBall = await LoadFileLegends<GenericFile<Actor_Template>>(new Path("world/jungle/level/pal/actor/components/ball.tpl"));
			//var legendsSound = legendsBall.obj.GetComponent<SoundComponent_Template>();

			//var 

			void ReplaceFx(int index, FxDescriptor_Template fx) {
				var oldName = fxb.Fx[index].name;
				fxb.Fx[index] = (FxDescriptor_Template)fx.Clone("tpl");
				fxb.Fx[index].name = oldName;
			}
			var fxc = ballTPL.obj.GetComponent<FXControllerComponent_Template>();
			fxc.feedbackTags = new CListO<StringID>() {
				new StringID("ball"),
				new StringID(0x112D8806)
			};
			foreach (var fx in fxc.fxControlList) {
				fx.sounds = new CListO<StringID>();
			}
			//fxc.fxControlList[1].fxUseActorSpeed = true;
			//fxc.fxControlList[2].fxUseActorSpeed = true;

			foreach (var act in l.LoadedActors.Where(a => a.template == ballTPL)) {
				var ball = act.GetComponent<RO2_BallComponent>();
				if(ball == null) continue;
				ball.startWithHalo = true;
			}
		}

		public class FairyNode {
			public Vec2d Position { get; set; }
			public FairyText[] Text { get; set; }

			public FairyNode(Vec2d pos, params FairyText[] text) {
				Position = pos;
				Text = text;
			}
			public FairyNode(float x, float y, params FairyText[] text) {
				Position = new Vec2d(x,y);
				Text = text;
			}

			public uint LumsCount { get; set; } = 50;
			public float SpeedMultiplier { get; set; } = 1f;

			public class FairyText {
				public string Text { get; set; }
				public LocalisationId Id { get; set; }
				public float TextSize { get; set; } = 0.5f;
				public float WaitTime { get; set; } = 0f;
				public bool FocusCam { get; set; }
				public FairyText(uint id, string text) {
					Text = text;
					Id = new LocalisationId(id);
				}
			}
		}

		public async Task CreateIntroActors(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var fairyTPLPath = new Path("cinematic/faery/faery.tpl");
			var fairyNodeTPLPath = new Path("cinematic/faery/faery_node.tpl");
			var lumspoolTPLPath = new Path("world/common/friendly/lumspool/components/lumspool.tpl");
			var ogLumPath = new Path("world/common/friendly/lums/basiclum.act");
			var customLumPath = new Path("cinematic/faery/faery_lum.act");
			var customLumTPLPath = new Path("cinematic/faery/faery_lum.tpl");

			await CreateIntroLum();
			var fairyTPL = await CreateIntroFairyTPL();

			async Task CreateIntroLum() {
				var ogLum = await LoadFileLegends<ContainerFile<Actor>>(ogLumPath);
				var ogLumTPL = ogLum.obj.template;
				var customLum = (Actor)ogLum.obj.Clone("act");

				if (CreateTemplateIfNecessary(customLumTPLPath, "INTRO LUM", out var customLumTPL, act: customLum)) {
					customLumTPL.sizeOf = ogLumTPL.sizeOf + 0x10000;
					customLumTPL.obj = (Actor_Template)ogLumTPL.obj.Clone("tpl");
					var pdTPL = customLumTPL.obj.GetComponent<PlayerDetectorComponent_Template>();
					var pdShape = pdTPL.shape.obj as PhysShapeCircle;
					pdShape.Radius *= 15f; // It moves, so it should be easier to grab
					var twnTPL = customLumTPL.obj.AddComponent<TweenComponent_Template>();
					twnTPL.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
						new TweenComponent_Template.InstructionSet() {
							name = new StringID("Set"),
							iterationCount = 1,
							triggable = true,
							instructions = new CListO<Generic<TweenInstruction_Template>>() {
								new Generic<TweenInstruction_Template>(new TweenCircle_Template() {
									duration = 0.75f,
									startSpeed = 1f,
									endSpeed = 0f,
									pivot = new Vec3d(-0.5f, -0.75f, 0f),
									cycleCount = 0.4f
								})
							},
							nextSet = new StringID("Set2")
						},
						new TweenComponent_Template.InstructionSet() {
							name = new StringID("Set2"),
							// With iterationCount = 0, this set gets stuck in the loop
							instructions = new CListO<Generic<TweenInstruction_Template>>() {
								new Generic<TweenInstruction_Template>(new TweenSine_Template() {
									duration = 1.5f,
									cycleOffset = 0.5f,
									amplitude = 0.5f
								})
							},
							triggable = false,
							interruptible = false,
							nextSet = new StringID("Set2")
						}
					};
				}
				var twn = customLum.AddComponent<TweenComponent>();
				twn.InstantiateFromTemplate(LegendsContext, customLumTPL.obj.GetComponent<TweenComponent_Template>());

				if (CreateStructNecessary<ContainerFile<Actor>>(customLumPath, "INTRO LUM", out var customLumContainer)) {
					customLumContainer.obj = customLum;
					customLumContainer.read = true;
				}
			}

			async Task<GenericFile<Actor_Template>> CreateIntroFairyTPL() {
				if (CreateTemplateIfNecessary(fairyTPLPath, "INTRO ACTOR", out var fairyTPL)) {
					var murfy = await LoadFileLegends<GenericFile<Actor_Template>>(new Path("world/common/playablecharacter/drcplayer/drcplayer.tpl"));
					var starsTrail = await LoadFileLegends<GenericFile<Actor_Template>>(new Path("world/common/fx/cinematic/fx_mrdark_starstrail_01.tpl"));

					fairyTPL.obj = (Actor_Template)murfy.obj.Clone("tpl");
					fairyTPL.sizeOf = murfy.sizeOf + 0x10000;
					fairyTPL.obj.STARTPAUSED = false;

					// Remove DRC player
					fairyTPL.obj.RemoveComponent<RO2_DRCPlayerComponent_Template>();

					// Replace animation
					var animTPL = fairyTPL.obj.GetComponent<AnimatedComponent_Template>();
					var animSet = animTPL.animSet;
					animSet.animPackage.textureBank = new CListO<TextureBankPath>() {
						new TextureBankPath() {
							id = new StringID("faery_a1"),
							patchBank = new Path("cinematic/faery/animation/faery_a1.pbk"),
							materialShader = animSet.animPackage.textureBank[0].materialShader,
							textureSet = new GFXMaterialTexturePathSet() {
								diffuse = new Path("cinematic/faery/animation/faery_a1.tga")
							}
						}
					};
					animSet.animPackage.skeleton = new Path("cinematic/faery/animation/faery_squeleton.skl");
					animSet.animPackage.animPathAABB = new CListO<AnimPathAABB>() {
						new AnimPathAABB() {
							name = "sg_stand",
							path = new Path("cinematic/faery/animation/cine_sg_stand_jungle.anm"),
							aabb = new AABB() {
								MIN = new Vec2d(-10, -10),
								MAX = new Vec2d(10, 10),
							}
						},
						new AnimPathAABB() {
							name = "sg_medi",
							path = new Path("cinematic/faery/animation/cine_sg_medi_jungle.anm"),
							aabb = new AABB() {
								MIN = new Vec2d(-10, -10),
								MAX = new Vec2d(10, 10),
							}
						}
					};
					animSet.animations = new CListO<SubAnim_Template>() {
						new SubAnim_Template() {
							friendlyName = "sg_stand",
							name = new Path("cinematic/faery/animation/cine_sg_stand_jungle.anm"),
							loop = true,
							forceZOffset = true,
							forceZOffset2 = SubAnim_Template.BOOL._true
						},
						new SubAnim_Template() {
							friendlyName = "sg_medi",
							name = new Path("cinematic/faery/animation/cine_sg_medi_jungle.anm"),
							loop = true,
							forceZOffset = true,
							forceZOffset2 = SubAnim_Template.BOOL._true
						},
					};
					animTPL.tree = new AnimTree_Template() {
						nodes = new CListO<Generic<BlendTreeNodeTemplate<AnimTreeResult>>>() {
							new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
								nodeName = "sg_stand",
								animationName = "sg_stand",
							}),
							new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
								nodeName = "sg_medi",
								animationName = "sg_medi",
							}),
						},
						nodeTransitions = new CListO<BlendTreeTransition_Template<AnimTreeResult>>() {
							new BlendTreeTransition_Template<AnimTreeResult>() {
								blend = 20,
								from = new CArrayO<StringID>() { "sg_stand" },
								to = new CArrayO<StringID>() { "sg_medi" }
							}
						}
					};

					/* 
					 * Actual Fairy animations used by FairyComponent:
					 * 0x44262f38 - FairyStand
					 * 0x5a867e38 - FairyFly
					 * 0xa4bac6e6 - FairySpeedFly
					 * 0xf811ab9c - FairyDialog_Neutral
					 * 0x41d76f6a - FairyUturn
					 * */
					animTPL.defaultAnimation = "sg_stand";
					animTPL.patchHLevel = 2;
					animTPL.patchVLevel = 2;
					animTPL.scale = Vec2d.One * 6.25f;
					animTPL.posOffset = Vec2d.Down * 1.3f;

					// Replace FX
					fairyTPL.obj.RemoveComponent<FXControllerComponent_Template>();
					fairyTPL.obj.RemoveComponent<FxBankComponent_Template>();
					fairyTPL.obj.AddComponent<FXControllerComponent_Template>((FXControllerComponent_Template)starsTrail.obj.GetComponent<FXControllerComponent_Template>().Clone("tpl"));
					fairyTPL.obj.AddComponent<FxBankComponent_Template>((FxBankComponent_Template)starsTrail.obj.GetComponent<FxBankComponent_Template>().Clone("tpl"));
					var fxb = fairyTPL.obj.GetComponent<FxBankComponent_Template>();
					var fxg = fxb.Fx[0].gen._params;
					fxg.maxParticles = 200;
					fxg.innerCircleRadius *= 3f;
					fxg.circleRadius *= 5f;
					fxg.freq /= 2f;

					var trailTPL = fairyTPL.obj.GetComponent<Trail3DComponent_Template>();
					trailTPL.trailList[0].nbFrames = 120;
					trailTPL.trailList[0].thicknessBegin = 5f;
					trailTPL.trailList[0].trailFaidingTime = 2f;

					//var fxcTPL = fairyTPL.obj.GetComponent<FXControllerComponent_Template>();
					//fxcTPL.defaultFx = new StringID(0x74AE7DEA);

					var fcTPL = fairyTPL.obj.AddComponent<RO2_FairyComponent_Template>();
					fcTPL.lumPath = customLumPath; // change to lums pool or egg?
					fcTPL.flyDist = 2f;
					fcTPL.rushDist = 1f;
					fcTPL.flySpeed = 0.65f;
					fcTPL.rushSpeed = 1f;
					fcTPL.keepRushTime = 0.25f;
					fcTPL.displayDialogStill = true; // Stop to display dialog

					fairyTPL.obj.AddComponent<LinkComponent_Template>();
					var snTPL = fairyTPL.obj.AddComponent<RO2_SnakeNetworkFollowerComponent_Template>();
					//snTPL.prevNodeCount = 1;
					snTPL.speedMultiplierMaxValue = 0f;
					snTPL.speedMultiplierMaxDistance = 15f;

					fairyTPL.obj.GetComponent<DialogActorComponent_Template>().balloon3DPath = new Path("world/common/logicactor/dialog/balloon/dialogballoon3d_character.act");

					var twnTPL = fairyTPL.obj.AddComponent<TweenComponent_Template>();
					twnTPL.autoStart = false;
					//twnTPL.applyFeedback = false;
					twnTPL.applyPosition = false;
					twnTPL.applyRotation = false;
					twnTPL.applyScale = false;
					twnTPL.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
						new TweenComponent_Template.InstructionSet() {
							name = "PlayMeditate",
							iterationCount = 1,
							triggable = false,
							instructions = new CListO<Generic<TweenInstruction_Template>>() {
								new Generic<TweenInstruction_Template>(new TweenAnim_Template() {
									duration = 0f,
									anim = "sg_medi"
								})
							},
							startEvent = new Generic<UbiArt.ITF.Event>(new EventGeneric() {
								id = "PlayMeditate"
							})
						},
						new TweenComponent_Template.InstructionSet() {
							name = "PlayStand",
							iterationCount = 1,
							triggable = false,
							instructions = new CListO<Generic<TweenInstruction_Template>>() {
								new Generic<TweenInstruction_Template>(new TweenAnim_Template() {
									duration = 0f,
									anim = "sg_stand"
								})
							},
							startEvent = new Generic<UbiArt.ITF.Event>(new EventGeneric() {
								id = "PlayStand"
							})
						},
					};
				}
				return fairyTPL;
			}

			if (CreateTemplateIfNecessary(fairyNodeTPLPath, "INTRO ACTOR", out var fairyNodeTPL)) {
				fairyNodeTPL.obj.AddComponent<LinkComponent_Template>();
				fairyNodeTPL.obj.AddComponent<RO2_FairyNodeComponent_Template>();
			}
			var fairy = fairyTPL.obj.Instantiate(fairyTPLPath);
			var fairyDialog = fairy.GetComponent<DialogActorComponent>();
			var fairyFXC = fairy.GetComponent<FXControllerComponent>();
			var fairyTween = fairy.GetComponent<TweenComponent>();
			fairyTween.autoStart = false;
			fairyFXC.defaultFx = new StringID("fx_mrdark_starstrail_01");
			//var fairyTrail = fairy.GetComponent<Trail3DComponent>();
			fairyDialog.enableDialog = true;
			fairyDialog.widthTextAreaMax = 10f;
			fairyDialog.is3D = true;
			var pathZ = 0.005f;

			MainContext.Loader.AddLoadedActor(fairy);
			scene.AddActor(fairy);

			Actor[] CreateFairyNodes(params FairyNode[] nodes) {
				var actors = new Actor[nodes.Length];
				for (int i = actors.Length - 1; i >= 0; i--) {
					var node = fairyNodeTPL.obj.Instantiate(fairyNodeTPLPath);
					node.POS2D = nodes[i].Position + Vec2d.Up * 1.3f;
					node.RELATIVEZ = pathZ; 
					scene.AddActor(node);
					actors[i] = node;
					var lc = node.GetComponent<LinkComponent>();
					if (i < actors.Length - 1) {
						lc.Children.Add(new ChildEntry() {
							Path = new ObjectPath(actors[i+1].USERFRIENDLY),
						});
					}
					var fn = node.GetComponent<RO2_FairyNodeComponent>();
					fn.lumsCount = nodes[i].LumsCount;
					fn.lumsDropStepDist = 2.5f;
					fn.data = new RO2_SnakeNetworkNodeComponent.NodeData() {
						speedMultiplier = nodes[i].SpeedMultiplier,
						//stopOnNode = true
					};

					if (nodes[i].Text != null && nodes[i].Text.Length > 0) {
						//fn.data.stopOnNode = true;
						var dialogueTPLPath = new Path($"world/custom/intro/faery_node_dialogue_{i}.tpl");
						if (CreateTemplateIfNecessary(dialogueTPLPath, "INTRO ACTOR", out var dialogueTPL)) {
							dialogueTPL.obj.AddComponent<LinkComponent_Template>();
							var d = dialogueTPL.obj.AddComponent<DialogComponent_Template>();
							d.activeOnTrigger = true;
							d.useOasis = true; // Localized
							d.replaceSpeakersByActivator = true;
							d.instructionList = new CArrayO<Generic<InstructionDialog>>();
							foreach (var l in nodes[i].Text) {
								if (l.WaitTime > 0) {
									d.instructionList.Add(new Generic<InstructionDialog>(new InstructionDialogWait() {
										time = l.WaitTime
									}));
								}
								if (l.FocusCam) {
									d.instructionList.Add(new Generic<InstructionDialog>(new InstructionDialogCam() {
										typeCamera = InstructionDialogCam.Enum_typeCamera.dialog
									}));
								}
								d.instructionList.Add(new Generic<InstructionDialog>(new InstructionDialogText() {
									actorName = fairy.USERFRIENDLY,
									mood = 4,
									sizeText = l.TextSize,
									text = l.Text,
									idLoc = l.Id,
								}));
								if (l.FocusCam) {
									d.instructionList.Add(new Generic<InstructionDialog>(new InstructionDialogCam() {
										typeCamera = InstructionDialogCam.Enum_typeCamera.engine
									}));
								}
								d.instructionList.Add(new Generic<InstructionDialog>(new InstructionDialogWait()));
							}
						}
						var dialogueActor = dialogueTPL.obj.Instantiate(dialogueTPLPath);
						dialogueActor.POS2D = node.POS2D;
						var dialogueActorD = dialogueActor.GetComponent<DialogComponent>();
						dialogueActorD.endTime_Default = 2f;
						dialogueActorD.endTime_Accel = 1.75f;
						scene.AddActor(dialogueActor);
						lc.Children.Add(new ChildEntry() { Path = new ObjectPath(dialogueActor.USERFRIENDLY) });
						dialogueActor.parentBind = new UbiArt.Nullable<Bind>(new Bind() {
							parentPath = new ObjectPath(fairy.USERFRIENDLY),
						});
					}
				}
				fairy.GetComponent<LinkComponent>().Children.Add(new ChildEntry() {
					Path = new ObjectPath(actors[0].USERFRIENDLY),
				});
				fairy.POS2D = actors[0].POS2D;
				fairy.RELATIVEZ = actors[0].RELATIVEZ;
				return actors;
			}

			var fairyNodes = CreateFairyNodes(
				new FairyNode(51.46f, 20f) {
					LumsCount = 0,
					SpeedMultiplier = 0.8f,
				},
				new FairyNode(49.09f, 17.18f,
					new FairyNode.FairyText(80000, "<INTRO_FAIRY_0>"),
					new FairyNode.FairyText(80001, "<INTRO_FAIRY_1>"),
					new FairyNode.FairyText(80002, "<INTRO_FAIRY_2>")) {
					SpeedMultiplier = 0.4f,
				},
				new FairyNode(59.25f, 16.7f) { SpeedMultiplier = 0.5f },
				new FairyNode(69.82f, 15.22f) { SpeedMultiplier = 0.7f },
				new FairyNode(80.86f, 15.76f) { SpeedMultiplier = 0.9f },
				new FairyNode(93.86f, 12.68f),

				new FairyNode(109.79f, 12.38f),
				new FairyNode(114.34f, 11.06f),
				new FairyNode(129.5232f, 9.190702f),
				new FairyNode(131.32f, 8.19f),
				new FairyNode(132.12f, 5.8f),
				new FairyNode(125.09f, 3.4f),
				new FairyNode(127.53f, 0.39f),
				new FairyNode(135.08f, -1.86f, new FairyNode.FairyText(80003, "<INTRO_FAIRY_3>")),
				new FairyNode(147.89f, -1.08f),
				new FairyNode(155.3f, -1.95f),
				new FairyNode(165.12f, -3.85f) { SpeedMultiplier = 0.8f },
				new FairyNode(176.43f, -3.85f,
					new FairyNode.FairyText(80004, "<INTRO_FAIRY_4>"),
					new FairyNode.FairyText(80005, "<INTRO_FAIRY_5>"),
					new FairyNode.FairyText(80006, "<INTRO_FAIRY_6>") { TextSize = 0.3f, WaitTime = 5f }) { LumsCount = 0, SpeedMultiplier = 0.4f },
				new FairyNode(181f, -3.85f) { LumsCount = 0, SpeedMultiplier = 0.25f },
				new FairyNode(184f, -3.85f) { LumsCount = 0, SpeedMultiplier = 0.1f },
				new FairyNode(186f, -3f) { LumsCount = 0, SpeedMultiplier = 0.05f }
				);
			var trig = await AddNewActor(scene, new Path("world/common/logicactor/trigger/components/trigger_box_once.tpl"));
			trig.POS2D = fairy.POS2D;
			trig.SCALE = new Vec2d(10,20);
			trig.GetComponent<TriggerComponent>().mode = TriggerComponent.Mode.Once;
			trig.GetComponent<LinkComponent>().Children.Add(new ChildEntry() {
				Path = new ObjectPath(fairy.USERFRIENDLY)
			});
			var tweenFairyAnimChangeActor = await AddNewActor(scene, new Path("world/common/logicactor/tweening/tweeneditortype/components/tween_notype.tpl"), contextToLoadFrom: LegendsContext);
			tweenFairyAnimChangeActor.POS2D = fairyNodes[fairyNodes.Length - 1].POS2D;
			
			fairyNodes[fairyNodes.Length - 2].GetComponent<LinkComponent>().Children.Add(new ChildEntry() {
				Path = new ObjectPath(tweenFairyAnimChangeActor.USERFRIENDLY) // Node triggers the tween
			});
			tweenFairyAnimChangeActor.GetComponent<LinkComponent>().Children.Add(new ChildEntry() {
				Path = new ObjectPath(fairy.USERFRIENDLY) // Tween affects the fairy
			});
			var tweenFairyAnimChange = tweenFairyAnimChangeActor.GetComponent<TweenComponent>();
			tweenFairyAnimChange.instanceTemplate = new UbiArt.Nullable<TweenComponent_Template>(new TweenComponent_Template() {
				autoStart = false,
				instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
					new TweenComponent_Template.InstructionSet() {
						triggable = true,
						name = "Set",
						iterationCount = 1,
						instructions = new CListO<Generic<TweenInstruction_Template>>() {
							new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
								duration = 1f,
								triggerSelf = false,
								triggerChildren = true,
								_event = new Generic<UbiArt.ITF.Event>(new EventGeneric() {
									id = "PlayMeditate"
								}),
							})
						}
					}
				}
			});
			tweenFairyAnimChange.InstantiateFromInstanceTemplate(LegendsContext);
			tweenFairyAnimChange.autoStart = false;

			await CreateTweenForCaptainHello();

			async Task CreateTweenForCaptainHello() {
				var captainQuery = scene.FindActor(a => a.USERFRIENDLY == "captain@1");
				var captain = captainQuery.Result;

				if (CloneTemplateIfNecessary(captain.LUA, "onboathello", "CAPTAIN HELLO", captain.template, out var captainTPL, act: captain)) {
					captainTPL.sizeOf += 0x10000;

					var anm = captainTPL.obj.GetComponent<AnimatedComponent_Template>();
					anm.tree.nodes[12] = new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodeSequence_Template() {
						nodeName = "onboat_hello",
						loopCount = 1,
						leafs = new CListO<Generic<BlendTreeNodeTemplate<AnimTreeResult>>>() {
							new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
								animationName = "onboat_hello",
								nodeName = "onboat_hello_1",
							}),
							new Generic<BlendTreeNodeTemplate<AnimTreeResult>>(new AnimTreeNodePlayAnim_Template() {
								animationName = "onboat",
								nodeName = "onboat_hello_2",
							}),
						}
					});
					var playAnimOnTrig = captainTPL.obj.AddComponent<PlayAnimOnTriggerComponent_Template>();
					playAnimOnTrig.triggerOnAnim = "onboat_hello";
					playAnimOnTrig.triggerOffAnim = "onboat";

					var diactTPL = captainTPL.obj.AddComponent<DialogActorComponent_Template>();
					diactTPL.balloonPath = new Path("world/common/logicactor/dialog/balloon/dialogballoon_character.act");
					diactTPL.balloon3DPath = new Path("world/common/logicactor/dialog/balloon/dialogballoon3d_character.act");
				}
				captain.AddComponent<PlayAnimOnTriggerComponent>();
				var diact = captain.AddComponent<DialogActorComponent>();
				diact.enableDialog = true;
				diact.is3D = true;
				diact.widthTextAreaMax = 5f;
				diact.offset = new Vec2d(0f, 3f);

				var trig = await AddNewActor(scene, new Path("world/common/logicactor/trigger/components/trigger_box_once.tpl"));
				trig.POS2D = new Vec2d(205.4511f, -2.026236f);
				trig.SCALE = new Vec2d(10, 20);
				trig.GetComponent<TriggerComponent>().mode = TriggerComponent.Mode.Once;
				trig.GetComponent<LinkComponent>().Children.Add(new ChildEntry() {
					Path = new ObjectPath(captainQuery.Path.FullPath)
				});

				// Add captain dialogue
				var dialogueTPLPath = new Path($"world/custom/intro/captain_dialogue.tpl");
				if (CreateTemplateIfNecessary(dialogueTPLPath, "INTRO ACTOR", out var dialogueTPL)) {
					dialogueTPL.obj.AddComponent<LinkComponent_Template>();
					var d = dialogueTPL.obj.AddComponent<DialogComponent_Template>();
					d.activeOnTrigger = true;
					d.useOasis = true; // Localized
					d.replaceSpeakersByActivator = false;
					d.instructionList = new CArrayO<Generic<InstructionDialog>>() {
						new Generic<InstructionDialog>(new InstructionDialogWait() { time = 2f }),
						new Generic<InstructionDialog>(new InstructionDialogText() {
							actorName = captain.USERFRIENDLY,
							mood = 4,
							sizeText = 0.5f,
							text = "<INTRO_CAPTAIN_1>",
							idLoc = 80007
						}),
						new Generic<InstructionDialog>(new InstructionDialogWait()),
					};
				}
				var dialogueActor = dialogueTPL.obj.Instantiate(dialogueTPLPath);
				dialogueActor.POS2D = captain.POS2D;
				var dialogueActorD = dialogueActor.GetComponent<DialogComponent>();
				dialogueActorD.endTime_Default = 2f;
				dialogueActorD.endTime_Accel = 1.75f;
				captainQuery.ContainingScene.AddActor(dialogueActor);
				dialogueActor.parentBind = new UbiArt.Nullable<Bind>(new Bind() {
					parentPath = new ObjectPath(captain.USERFRIENDLY),
				});
				var dialogueLinks = dialogueActor.GetComponent<LinkComponent>();
				dialogueLinks.Children.Add(new ChildEntry() {
					Path = new ObjectPath(captain.USERFRIENDLY),
				});
				trig.GetComponent<LinkComponent>().Children.Add(new ChildEntry() {
					Path = new ObjectPath(captainQuery.Path.FullPath.Replace(captain.USERFRIENDLY, dialogueActor.USERFRIENDLY))
				});
			};
		}

		public async Task CreateTutoActors(Context oldContext, Settings newSettings, Scene scene) {
			var legendsTutoPath = new Path("world/common/ui/drcmoves_feedbacks/templates/triggertuto.tpl");
			var legendsTutoTPL = await LoadFileLegends<GenericFile<Actor_Template>>(legendsTutoPath);
			var customTutoPath = new Path("world/common/ui/drcmoves_feedbacks/templates/rlc_triggertuto.tpl");
			if (CreateTemplateIfNecessary(customTutoPath, "CUSTOM TUTO", out var newTPL)) {
				newTPL.sizeOf = legendsTutoTPL.sizeOf;
				newTPL.obj = (Actor_Template)legendsTutoTPL.obj.Clone("tpl");
				var tutoIcon = newTPL.obj.GetComponent<RO2_DisplayTutoIconComponent_Template>();
				tutoIcon.tutos3d.tutoList.Clear();
				tutoIcon.tutos2d.tutoList.Clear();
				await CreateTuto(2, "findcaptain", 80020, "Find the captain in each level\nto continue the adventure");
				await CreateTuto(3, "egghunt", 80021, "It's an egg hunt!\nPut the 3 eggs in the basket\nto continue the adventure");

				async Task CreateTuto(uint type, string newTutoPath, uint locId, string rawText) {
					var tuto2DPath = new Path($"world/common/ui/maintuto/customtuto/{newTutoPath}2d.act");
					var tuto3DPath = new Path($"world/common/ui/maintuto/customtuto/{newTutoPath}.act");
					tutoIcon.tutos2d.tutoList.Add(new SpawnActorPathTuto() {
						tutoType = type,
						defaultActor = tuto2DPath
					});
					tutoIcon.tutos3d.tutoList.Add(new SpawnActorPathTuto() {
						tutoType = type,
						defaultActor = tuto3DPath
					});
					await CopyTuto("world/common/ui/maintuto/commontuto/bubbledreamertuto_simple", $"world/common/ui/maintuto/customtuto/{newTutoPath}");

					var tb = oldContext.Cache.Get<ContainerFile<Actor>>(tuto2DPath).obj.GetComponent<UITextBox>();
					tb.rawText = rawText;
					tb.locId = new LocalisationId(locId);
					var tb3d = oldContext.Cache.Get<ContainerFile<Actor>>(tuto3DPath).obj.GetComponent<TextBoxComponent>();
					tb3d.rawText = rawText;
					tb3d.locId = new LocalisationId(locId);
				}

				async Task CopyTuto(string ogTuto, string newTutoPath) {
					await CopyOneTuto(new Path($"{ogTuto}2d.act"), new Path($"{newTutoPath}2d.act"));
					await CopyOneTuto(new Path($"{ogTuto}.act"), new Path($"{newTutoPath}.act"));
				}
				async Task CopyOneTuto(Path ogTutoPath, Path newTutoPath) {
					var ogTuto = await LoadFileLegends<ContainerFile<Actor>>(ogTutoPath);
					if (CreateStructNecessary<ContainerFile<Actor>>(newTutoPath, "CUSTOM TUTO", out var customActContainer)) {
						customActContainer.obj = (Actor)ogTuto.obj.Clone("act");
						customActContainer.read = true;
					}
				}
			}

			async Task<Actor> CreateTutoActor(uint tutoType) {
				var tuto = await AddNewActor(scene, customTutoPath);
				tuto.SCALE = new Vec2d(10f, 10f);
				var ti = tuto.GetComponent<RO2_DisplayTutoIconComponent>();
				ti.tutoType = (RO2_DisplayTutoIconComponent.TutoType)tutoType;
				ti.tutoType2 = (RO2_DisplayTutoIconComponent.TutoType2)tutoType;
				ti.activateByTrigger = true;
				ti.scale = 0.65f;
				tuto.GetComponent<TriggerComponent>().mode = TriggerComponent.Mode.Multiple;

				return tuto;
			}


			var scenePath = GetScenePath(scene);
			switch (scenePath.FullPath) {
				case "world/rlc_enchantedforest/overgrowncastle/enchantedforest_overgrowncastle_exp_base.isc": {
						var tuto = await CreateTutoActor(2);
						tuto.POS2D = new Vec2d(31.5f, -15.7f);
						break;
					}

				case "world/rlc_enchantedforest/forestegghunt/enchantedforest_forestegghunt_exp_base.isc": {
						var tuto = await CreateTutoActor(3);
						tuto.POS2D = new Vec2d(115.47f, -95.65f);
						break;
					}
			}
		}

		public void FixCastleCorridorPrimitiveParams(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var corridors = scene.FindPickables(p => p is Frise f &&
			(f.ConfigName.FullPath == "world/music/castlesiege/playground/ldground/corridorstructure.fcg"
			|| f.ConfigName.FullPath == "world/music/castlesiege/playground/ldground/corridorbehind.fcg"
			|| f.ConfigName.FullPath == "world/music/castlesiege/playground/ldground/corridorbottom.fcg"));
			foreach (var c in corridors) {
				var f = (Frise)c.Result;
				f.UseTemplatePrimitiveParams = false;
			}
		}

		public void AddRelaysForMultipleEventTriggers(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var l = oldContext.Loader;

			var delayTag = new StringID("Delay");

			var badRelays = scene.FindActors(a =>
				a.GetComponent<RO2_MultipleEventTriggerComponent>() != null
				&& (a.GetComponent<LinkComponent>()?.Children?.Any(c => c?.HasTag(delayTag) ?? false) ?? false));

			foreach (var res in badRelays) {
				var a = res.Result;

				var links = a.GetComponent<LinkComponent>();

				var tpl = a.template;
				if (tpl?.obj == null) continue;

				var multiEvent = a.GetComponent<RO2_MultipleEventTriggerComponent>();
				var validationEvent = multiEvent.validationEvent;
				var children = links.Children;

				var ogLUA = a.LUA;
				var ogTPL = tpl;

				// Create tween actor template
				if (CloneTemplateIfNecessary(ogLUA, "tween", "MULTIPLE EVENT TWEEN", ogTPL, out var newTPL)) {
					newTPL.sizeOf += 0x10000;

					newTPL.obj.RemoveComponent<RO2_MultipleEventTriggerComponent_Template>();
					var tctpl = newTPL.obj.AddComponent<TweenComponent_Template>();
					tctpl.autoStart = false;
					newTPL.obj.AddComponent<BoxInterpolatorComponent_Template>();
				}

				// Create new tween actor
				var newTPL_path = GetClonedTemplatePath(ogLUA, "tween");
				var newTPL2 = oldContext.Cache.Get<GenericFile<Actor_Template>>(newTPL_path);
				var linkTweenAct = newTPL2.obj.Instantiate(newTPL_path);
				linkTweenAct.POS2D = a.POS2D;
				linkTweenAct.SCALE = a.SCALE;
				linkTweenAct.ANGLE = a.ANGLE;
				linkTweenAct.xFLIPPED = a.xFLIPPED;
				linkTweenAct.USERFRIENDLY = $"{a.USERFRIENDLY}_tween";
				res.ContainingScene.AddActor(linkTweenAct);
				l.AddLoadedActor(linkTweenAct);

				// Link MultiEventTrigger to the new tween actor instead
				multiEvent.validationEvent = new Generic<UbiArt.ITF.Event>(new EventTrigger() {
					activated = true
				});
				links.Children = new CListO<ChildEntry>() {
					new ChildEntry() {
						Path = new ObjectPath(linkTweenAct.USERFRIENDLY)
					}
				};

				// Configure the new tween actor
				var box = linkTweenAct.GetComponent<BoxInterpolatorComponent>();
				box.innerBox = new AABB() {
					MIN = new Vec2d(-10000, -10000),
					MAX = new Vec2d(10000, 10000)
				};
				box.outerBox = box.innerBox;
				var tc = linkTweenAct.GetComponent<TweenComponent>();
				tc.autoStart = false;
				tc.startSet = new StringID("Set");
				tc.instanceTemplate = new UbiArt.Nullable<TweenComponent_Template>(new TweenComponent_Template() {
					autoStart = false,
					startSet = new StringID("Set"),
					instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
							new TweenComponent_Template.InstructionSet() {
								name = new StringID("Set"),
								iterationCount = 1,
								triggable = true,
								instructions = new CListO<Generic<TweenInstruction_Template>>() {
									new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
										duration = 0,
										triggerSelf = false,
										triggerChildren = true,
										_event = validationEvent
									}),
								},
							}
						}
				});
				tc.InstantiateFromInstanceTemplate(oldContext);
				var newLinks = linkTweenAct.GetComponent<LinkComponent>();
				newLinks.Children = children;
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
		public void FixRabbids(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			// Fix annoying noise in idle fight animation
			var standFightAnim = oldContext.Cache.Get<AnimTrack>(new Path("world/rlc/common/enemy/rabbid/animation/fight_stand.anm"));
			if (standFightAnim != null) {
				foreach (var fr in standFightAnim.frameEvents) {
					fr.events = new CListO<AnimTrackFrameEvents.AnimMarkerEvent>(fr.events.Where(f => f.marker != new StringID(0x7027CC42) && f.marker != new StringID(0x58B5B2C1)).ToList());
				}
				standFightAnim.frameEvents = new CListO<AnimTrackFrameEvents>(standFightAnim.frameEvents.Where(fr => fr.events != null && fr.events.Any()).ToList());
			}

			//var rabbidTPL = oldContext.Cache.Get<GenericFile<Actor_Template>>(new Path("world/rlc/common/enemy/rabbid/components/rabbid.tpl"));

			var attackFrontAnim = oldContext.Cache.Get<AnimTrack>(new Path("world/rlc/common/enemy/rabbid/animation/attack_front.anm"));
			if (attackFrontAnim != null) {
				if (attackFrontAnim.frameEvents[0].events.Count == 2) {
					attackFrontAnim.frameEvents[0].events.Add(new AnimTrackFrameEvents.AnimMarkerEvent() {
						type = AnimTrackFrameEvents.AnimMarkerEvent.AnimMarkerEventType.AnimPolylineEvent,
						marker = new StringID(0xF412692B),
						posLocal = new Vec2d(3.238925f, -1.62862f),
						polyline = new StringID(0xCD8DBD3C),
						name = new StringID(),
					});
				}
			}
		}


		public void FixCaptainHelloAnimationBug(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var animPath = new Path("world/rlc/common/friendly/captain/animation/onboat_hello.anm");
			var anim = oldContext.Cache.Get<AnimTrack>(animPath);
			if (anim != null) {
				ProcessAngle(anim.bonePAS[1185]); // Bone 20
				ProcessAngle(anim.bonePAS[1186]);
				ProcessAngle(anim.bonePAS[1347]); // Bone 21
				ProcessAngle(anim.bonePAS[1348]);

				void ProcessAngle(AnimTrackBonePAS bp) {
					var floatAngle = (((bp.Rotation.EulerAngle * anim.multiplierA) % 360) + 360) % 360; // Get positive modulo
					var newA = (short)((new Angle(floatAngle, degrees: true).angle / anim.multiplierA) / 0.000030518f);
					bp.angle = newA;
				}
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

		public void UseFastCameras(Scene scene) {
			var cms = scene.FindActors(a => a?.GetComponent<CameraModifierComponent>() != null);
			foreach (var cm in cms) {
				ConvertToFastCamera(cm.Result);
			}
		}

		public void ConvertToFastCamera(Actor act) {
			if(act?.template?.obj?.GetComponent<CameraModifierComponent_Template>() == null) return;

			if (CloneTemplateIfNecessary(act.LUA, "fastcam", "FAST CAMERA", act.template, out var newTPL, act: act)) {
				var CM = newTPL?.obj?.GetComponent<CameraModifierComponent_Template>();
				if (CM != null) {
					if (CM.CM.modifierBlend == float.MaxValue) {
						CM.CM.modifierBlend = 0.006f;
						CM.CM.modifierInertie = 0.82f;
						CM.CM.constraintDelayToActivate = Vec3d.One * 0.5f;
						CM.CM.constraintDelayToDisable = Vec3d.One * 0.5f;
					}
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
					if (CM.CM.modifierBlend == float.MaxValue) {
						CM.CM.modifierBlend = 0.006f;
						CM.CM.modifierInertie = 0.82f;
						CM.CM.constraintDelayToActivate = Vec3d.One * 2f; // Sometimes this factor should be 0.5f
						CM.CM.constraintDelayToDisable = Vec3d.One * 2f;
					}
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
		public async Task FixEnemiesWithShieldUp(Context oldContext, Settings newSettings) {
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

		public void FixShapeExcluders(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;
			/*var shapeExcluderTag = new StringID(0x3ee39863);
			var l = oldContext.Loader;
			foreach (var act in l.LoadedActors) {
				var links = act?.GetComponent<LinkComponent>()?.Children;
				if(links == null) continue;
				links.RemoveAll(l => l.HasTag(shapeExcluderTag));
			}*/
			var l = oldContext.Loader;
			var path = new Path("world/common/logicactor/shape/components/editableshape.tpl");
			var tpl = l.Cache.Get<GenericFile<Actor_Template>>(path);
			if (tpl != null) {
				foreach (var act in l.LoadedActors.Where(a => a.LUA == path)) {
					act.SCALE = Vec2d.One; // Simplest solution to a difficult issue ever
					// The actors with this path have their AABB multiplied by scale in Legends, but not in Adventures/Mini.
					// This AABB is then used to block off parts from the enemies' detection range.
					// Just setting the scale to (1,1) fixes every issue!
				}
				return;
				/*tpl.obj.RemoveComponent<RO2_EditableShapeComponent_Template>();
				tpl.obj.AddComponent<BoxInterpolatorComponent_Template>();
				foreach (var act in l.LoadedActors.Where(a => a.LUA == path)) {
					var shape = act.GetComponent<RO2_EditableShapeComponent>();
					act.RemoveComponent<RO2_EditableShapeComponent>();
					var box = act.AddComponent<BoxInterpolatorComponent>();

					var minPoint = new Vec2d(0f, 0f);
					var maxPoint = new Vec2d(0f, 0f);
					if (shape?.ZONE?.shape?.obj != null) {
						switch (shape.ZONE.shape.obj) {
							case PhysShapeCircle circle:
								minPoint = Vec2d.One * -circle.Radius;
								maxPoint = Vec2d.One * circle.Radius;
								break;
							case PhysShapePolygon poly:
								minPoint = new Vec2d(poly?.Points?.Min(pt => pt.x) ?? 0f, poly?.Points?.Min(pt => pt.y) ?? 0f);
								maxPoint = new Vec2d(poly?.Points?.Max(pt => pt.x) ?? 0f, poly?.Points?.Max(pt => pt.y) ?? 0f);
								break;
						}
					}
					var scaleMultiplier = new Vec2d(
						act.SCALE.x != 0 ? (1f / act.SCALE.x) : 0f,
						act.SCALE.y != 0 ? (1f / act.SCALE.y) : 0f);
					minPoint *= scaleMultiplier;
					maxPoint *= scaleMultiplier;

					box.innerBox = new AABB() {
						MIN = minPoint,
						MAX = maxPoint
					};
					box.outerBox = box.innerBox;
				}*/
			}
		}

		public async Task FixSwimmingToads(Context oldContext, Settings newSettings) {
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

		public void AllRotatingPlatformsToTweens(Context oldContext, Scene scene, Predicate<Actor> criteria = null, float rotateTime = 0.5f, float waitTime = 1f, bool clockwise = true) {
			var acts = scene.FindActors(a => a.GetComponent<RLC_RotatingPlatformComponent>() != null);
			foreach (var act in acts) {
				RotatingPlatformToTween(oldContext, act.Result, rotateTime: rotateTime, waitTime: waitTime, clockwise: clockwise);
			}
		}
		public void RotatingPlatformToTween(Context oldContext, Actor actor, float totalAngle = 360/4f, float rotateTime = 0.5f, float waitTime = 1f, bool clockwise = true, bool backAndForth = false) {
			if(actor.GetComponent<RLC_RotatingPlatformComponent>()== null) return;
			var plat = actor.GetComponent<RLC_RotatingPlatformComponent>();
			var tplplat = actor.template.obj.GetComponent<RLC_RotatingPlatformComponent_Template>();

			if (CloneTemplateIfNecessary(actor.LUA, "rptween", "ROTPLAT -> TWEEN", actor.template, out var newTPL, actor)) {
				newTPL.sizeOf += 0x10000;
				newTPL.obj.RemoveComponent<RLC_RotatingPlatformComponent_Template>();
				newTPL.obj.AddComponent<TweenComponent_Template>();
			}
			actor.RemoveComponent<RLC_RotatingPlatformComponent>();
			var tween = actor.AddComponent<TweenComponent>();
			tween.instanceTemplate = new UbiArt.Nullable<TweenComponent_Template>(new TweenComponent_Template() {
				sync = true,
				syncOffset = 0,
				instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
					new TweenComponent_Template.InstructionSet() {
						name = new StringID("Set"),
						instructions = new CListO<Generic<TweenInstruction_Template>>() {
							new Generic<TweenInstruction_Template>(new TweenFX_Template() {
								fx = new StringID(0xe1bb334e),
								duration = 0f,
							}),
							new Generic<TweenInstruction_Template>(new TweenFX_Template() {
								fx = new StringID(0x34ab572e),
								duration = 0f,
							}),
							new Generic<TweenInstruction_Template>(new TweenCircle_Template() {
								duration = rotateTime,
								angle = new AngleAmount((clockwise ? -totalAngle : totalAngle), degrees: true),
							}),
							new Generic<TweenInstruction_Template>(new TweenFX_Template() {
								fx = new StringID(0x80fe8585),
								duration = 0f,
							}),
							new Generic<TweenInstruction_Template>(new TweenWait_Template() {
								duration = waitTime,
							}),
						}
					}
				}
			});
			if (backAndForth) {
				var set = tween.instanceTemplate.value.instructionSets[0];
				set.instructions = new CListO<Generic<TweenInstruction_Template>>(set.instructions.Concat(new List<Generic<TweenInstruction_Template>>() {
					new Generic<TweenInstruction_Template>(new TweenFX_Template() {
						fx = new StringID(0xe1bb334e),
						duration = 0f,
					}),
					new Generic<TweenInstruction_Template>(new TweenFX_Template() {
						fx = new StringID(0x34ab572e),
						duration = 0f,
					}),
					new Generic<TweenInstruction_Template>(new TweenCircle_Template() {
						duration = rotateTime,
						angle = new AngleAmount(-(clockwise ? -totalAngle : totalAngle), degrees: true),
					}),
					new Generic<TweenInstruction_Template>(new TweenFX_Template() {
						fx = new StringID(0x80fe8585),
						duration = 0f,
					}),
					new Generic<TweenInstruction_Template>(new TweenWait_Template() {
						duration = waitTime,
					}),
				}).ToList());
			}
			tween.syncOffset = 0f;
			tween.InstantiateFromInstanceTemplate(oldContext);
		}

		public void ConfigureOnOffTween(Context oldContext, TweenComponent tween, float cycleTime = 1f, float timeOn = 1f / 4f, float syncOffset = 0f) {
			var tpl = new TweenComponent_Template();
			tpl.startSet = new StringID("Set");
			tpl.autoStart = true;
			tpl.sync = true;
			tpl.syncOffset = syncOffset;
			tpl.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
				new TweenComponent_Template.InstructionSet() {
					name = new StringID("Set"),
					instructions = new CListO<Generic<TweenInstruction_Template>>() {
						new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
							duration = 0,
							triggerSelf = false,
							triggerChildren = true,
							_event = new Generic<UbiArt.ITF.Event>(new EventPause() {
								pause = true
							}),
						}),
						new Generic<TweenInstruction_Template>(new TweenWait_Template() {
							duration = cycleTime - timeOn
						}),
						new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
							duration = 0,
							triggerSelf = false,
							triggerChildren = true,
							_event = new Generic<UbiArt.ITF.Event>(new EventPause() {
								pause = false
							}),
						}),
						new Generic<TweenInstruction_Template>(new TweenWait_Template() {
							duration = timeOn
						}),
					}
				}
			};

			tween.instanceTemplate = new UbiArt.Nullable<TweenComponent_Template>(tpl);
			tween.autoStart = true;
			tween.startSet = new StringID("Set");
			tween.syncOffset = syncOffset;
			tween.InstantiateFromInstanceTemplate(oldContext);
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
					UseTemplatePrimitiveParams = false,

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

				scene.AddActor(fr);
			}




			if (containingScene != null) {
				containingScene.DeletePickable(smvActor);
				containingScene.AddActor(friseScene);
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
							// If it can only occur once, we have to abuse a TweenComponent.
							// We make sure the tweening is limited to 1 iteration and automatically goes to a next set that is a dead end.
							// Using a trigger event, we can start the TweenComponent and have it never restart again.
							var tween = relay.AddComponent<TweenComponent>();
							tween.startSet = new StringID("Set");
							tween.autoStart = false;
							tween.instructionSets = new CListO<TweenComponent.InstructionSet>() {
								new TweenComponent.InstructionSet() {
									name = new StringID("Set"),
									instructions = new CArrayO<Generic<TweenInstruction>>() {
										new Generic<TweenInstruction>(new TweenEvent())
									},
								},
								new TweenComponent.InstructionSet() {
									name = new StringID("Set2"),
									instructions = new CArrayO<Generic<TweenInstruction>>() {
										new Generic<TweenInstruction>(new TweenWait())
									},
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
								newTPL.STARTPAUSED = false;
								var tweenTPL = newTPL.AddComponent<TweenComponent_Template>();
								tweenTPL.autoStart = false;
								tweenTPL.startSet = new StringID("Set");
								tweenTPL.instructionSets = new CListO<TweenComponent_Template.InstructionSet>() {
									new TweenComponent_Template.InstructionSet() {
										name = new StringID("Set"),
										iterationCount = 1,
										triggable = true,
										instructions = new CListO<Generic<TweenInstruction_Template>>() {
											new Generic<TweenInstruction_Template>(new TweenEvent_Template() {
												triggerSelf = false,
												triggerChildren = true,
												_event = relayEvent,
											})
										},
										nextSet = new StringID("Set2")
									},
									new TweenComponent_Template.InstructionSet() {
										name = new StringID("Set2"),
										// With iterationCount = 0, this set gets stuck in the loop
										instructions = new CListO<Generic<TweenInstruction_Template>>() {
											new Generic<TweenInstruction_Template>(new TweenWait_Template() {
												duration = 1f
											})
										},
										triggable = false,
										interruptible = false,
										nextSet = new StringID("Set2")
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
							}
						}
						res.ContainingScene.AddActor(relay);

						return relay;
					}

					List<Actor> createdRelays = new List<Actor>();
					if ((hangspotTPL.hangEventTriggerOnce && hangspotTPL.onHangEvent?.obj != null)
						|| (hangspotTPL.unHangEventTriggerOnce && hangspotTPL.onUnhangEvent?.obj != null)) {
						// We use nonsensical hang events, if we use a relay (i.e. when not "once") this can be captured easily and "converted" into the actual event
						// We can't just use the original events here because Relay doesn't recognize the parameters (e.g. trigger event on/off)
						var newHangEvent = new Generic<UbiArt.ITF.Event>(new RO2_EventCommandAttackStart());
						var newUnhangEvent = new Generic<UbiArt.ITF.Event>(new RO2_EventCommandAttackStop());
						// If the event should only be sent once, we use a different approach with a TweenComponent we trigger.
						// So the hang events should become trigger events in that case.
						if (hangspotTPL.hangEventTriggerOnce)
							newHangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventTrigger() { activated = true });
						if (hangspotTPL.unHangEventTriggerOnce)
							newUnhangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventTrigger() { activated = true });

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
						if (mushroomTPL.TornadoHitMultiplier != 1f) {
							if (oldContext.Settings.Game == Game.RM) {
								// Adventures is a slower game, for Mini we prefer the faster mushrooms
								//mushroomTPL.Speed = mushroomTPL.TornadoHitMultiplier * mushroomTPL.Speed;
							}
							mushroomTPL.TornadoHitMultiplier = 1f;
							//mushroomTPL.NoHitZoneLength = 0f;
							//mushroomTPL.ExplosionExpansionCoeff = 999f;
						}
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

						res.ContainingScene.AddActor(tweenAct);

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
						res.ContainingScene.AddActor(pauseswitch);

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
					// If the event should only be sent once, we use a different approach with a TweenComponent we trigger.
					// So the hang events should become trigger events in that case.
					if (hangspotTPL.hangEventTriggerOnce)
						newHangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventTrigger() { activated = true });
					if (hangspotTPL.unHangEventTriggerOnce)
						newUnhangEvent = new Generic<UbiArt.ITF.Event>(new UbiArt.ITF.EventTrigger() { activated = true });
					
					hangspotTPL.onHangEvent = newHangEvent;
					hangspotTPL.onUnhangEvent = newUnhangEvent;
				}
			}
		}

		public enum CageType {
			Normal,
			Hanging,
			Flying
		}
		public enum TeensyWorldType {
			Jungle,
			Music,
			Food,
			Ocean,
			Mountain
		}
		public async Task<SubSceneActor> SpawnTeensyCage(Scene scene,
			RO2_FriendlyBTAIComponent.Prisoner teensyType,
			int index,
			TeensyWorldType worldType,
			CageType cageType, bool animationType, bool mirror = false, string name = null) {
			var cageSSA = (SubSceneActor)await AddNewActor(scene, new Path("enginedata/actortemplates/subscene.tpl"), name: name, contextToLoadFrom: LegendsContext);
			var cageScene = cageSSA.SCENE.value;

			string worldString = worldType switch {
				TeensyWorldType.Jungle => "",
				TeensyWorldType.Music => "music_",
				TeensyWorldType.Food => "food_",
				TeensyWorldType.Ocean => "ocean_",
				TeensyWorldType.Mountain => "mountain_",
				_ => "",
			};

			string teensyPathString = teensyType switch {
				RO2_FriendlyBTAIComponent.Prisoner.Soldier => $"world/common/friendly/bt_friendly/teensy/{worldString}teensy.act",
				RO2_FriendlyBTAIComponent.Prisoner.Baby => $"world/common/friendly/bt_friendly/teensy/{worldString}teensy_baby.act",
				RO2_FriendlyBTAIComponent.Prisoner.Fool => $"world/common/friendly/bt_friendly/teensy/{worldString}teensy_fool.act",
				RO2_FriendlyBTAIComponent.Prisoner.Princess => $"world/common/friendly/bt_friendly/teensy/{worldString}teensy_princess.act",
				RO2_FriendlyBTAIComponent.Prisoner.Prince => $"world/common/friendly/bt_friendly/teensy/{worldString}teensy_prince.act",
				RO2_FriendlyBTAIComponent.Prisoner.King => $"world/common/friendly/bt_friendly/teensy/{worldString}teensy_king.act",
				RO2_FriendlyBTAIComponent.Prisoner.Queen => $"world/common/friendly/bt_friendly/teensy/{worldString}teensy_queen.act",
				_ => throw new Exception("Invalid teensy visual type")
			};
			var teensyPath = new Path(teensyPathString);

			var teensy = await AddNewActor(cageScene, teensyPath, contextToLoadFrom: LegendsContext);
			var btai = teensy.GetComponent<RO2_FriendlyBTAIComponent>();
			btai.prisonerVisualType = teensyType;
			switch (btai.prisonerVisualType) {
				case RO2_FriendlyBTAIComponent.Prisoner.King:
					btai.prisonerIndexType = RO2_FriendlyBTAIComponent.Index.Map10;
					break;
				case RO2_FriendlyBTAIComponent.Prisoner.Queen:
					btai.prisonerIndexType = RO2_FriendlyBTAIComponent.Index.Map9;
					break;
				default:
					// TODO: verify if Baby doesn't have to be 8
					btai.prisonerIndexType = (RO2_FriendlyBTAIComponent.Index)index;
					break;
			}
			btai.prisonerType = animationType ? RO2_FriendlyBTAIComponent.Enum_prisonerType.Cage2 : RO2_FriendlyBTAIComponent.Enum_prisonerType.Cage1;
			btai.path = teensyPath;

			teensy.xFLIPPED = mirror;

			string cagePathString = cageType switch {
				CageType.Normal => "world/common/breakable/prisonercage/components/prisonercage.tpl",
				CageType.Hanging => "world/common/breakable/prisonercage/components/prisonercage_up.tpl",
				CageType.Flying => "world/common/breakable/flyingprisonercage/components/flyingprisonercage.tpl",
				_ => throw new Exception("Invalid cage type")
			};

			var cage = await AddNewActor(cageScene, new Path(cagePathString), contextToLoadFrom: LegendsContext);
			if (cageType == CageType.Flying) {
				cage.SCALE = Vec2d.One * 0.9f;
			}
			var cageLinks = cage.GetComponent<LinkComponent>();
			cageLinks.Children.Add(new ChildEntry() {
				Path = new ObjectPath(teensy.USERFRIENDLY)
			});

			return cageSSA;

		}


		public void FixBubblesFX(Context oldContext, Settings newSettings) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;
			
			var tplPaths = new string[] {
				"world/common/fx/lifeelements2/water/fx_bubbles_01.tpl",
				"world/common/fx/lifeelements2/water/fx_bubbles_02.tpl",
				"world/common/fx/lifeelements2/water/fx_bubbles_03.tpl",
				"world/common/fx/lifeelements2/water/fx_bubbles_02white.tpl",
				"world/common/fx/lifeelements2/water/fx_bubbles_03white.tpl"
			}.Select(s => new Path(s));

			CListO<FxDescriptor_Template> GetFx(Path p) {
				var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(p);
				var fxc = tpl?.obj?.GetComponent<FxBankComponent_Template>();
				return fxc?.Fx;
			}
			float GetStaticValue(ParLifeTimeCurve curve, Func<Spline.SplinePoint, float> func) {
				if (curve?.curve?.Points?.Any() ?? false) {
					return func(curve.curve.Points.LastOrDefault());
				}
				return 0f;
			}
			foreach (var p in tplPaths) {
				var fxList = GetFx(p);
				if(fxList == null) continue;
				foreach (var fx in fxList) {
					var par = fx?.gen?._params;
					//par.velNorm *= 0.5f;
					if (par?.parEmitVelocity?.curve?.Points?.Any() ?? false) {
						foreach (var pt in par.parEmitVelocity.curve.Points) {
							if(pt?.Point == null) continue;
							pt.Point = pt.Point * 0.4f;
						}
					}

					float x = 0f, y = 0f, z = 0f;

					x = GetStaticValue(par.curveAccelX, pt => pt.Point?.x ?? 0f);
					y = GetStaticValue(par.curveAccelY, pt => pt.Point?.y ?? 0f);
					z = GetStaticValue(par.curveAccelZ, pt => pt.Point?.z ?? 0f);

					if(par.acc == null) par.acc = new Vec3d();
					par.acc.x += x;
					par.acc.y += y;
					par.acc.z += z;
				}
			}
			/*var fireTPL = new Path("world/common/fx/lifeelements2/fire/fx_ashes_02.tpl");
			{
				var fxList = GetFx(fireTPL);
				if (fxList != null) {
					foreach (var fx in fxList) {
						var par = fx?.gen?._params;
						par.acc = new Vec3d(3,-3,0);
					}
				}
			}*/
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

					res.ContainingScene.AddActor(tweenAct);
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
			var musicManagerPath2 = new Path("world/common/friendly/lums/musicmanagers/junglelummusicmanager.tpl");
			var tpl = oldContext.Cache.Get<GenericFile<Actor_Template>>(musicManagerPath);
			var tpl2 = oldContext.Cache.Get<GenericFile<Actor_Template>>(musicManagerPath2);

			TreatTPL(tpl);
			TreatTPL(tpl2);

			void TreatTPL(GenericFile<Actor_Template> tpl,
				bool changeSounds = true, bool addLumKingMusic = true, bool addAABBMod = true, float aabbScale = 1000f) {
				if(tpl?.obj == null) return;
				tpl.sizeOf += 0x10000;

				var sndComponent = tpl.obj.GetComponent<SoundComponent_Template>();

				if (oldContext.Settings.Game == Game.RA && changeSounds) {

					sndComponent.soundList.RemoveAll(s => s?.name?.stringID == 0xAC205A3F);
					sndComponent.soundList.RemoveAll(s => s?.name?.stringID == 0x24204AB3);

					// Lum "ting" sound
					sndComponent.soundList.Add(new SoundDescriptor_Template() {
						sizeOf = 468,
						name = new StringID(0xAC205A3F),
						volume = new Volume(-17),
						category = new StringID(0xF03C38A1),
						limitCategory = new StringID(0x39283153),
						maxInstances = 4,

						limitMode = 1,
						limitModeEnum = LimiterDef.LimiterMode.StopOldest,
						files = new CListO<Path>(new List<Path>() {
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_01.wav"), // 0
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_02.wav"),
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_03.wav"),
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_01.wav"),
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_04.wav"),
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_05.wav"), // 5
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_06.wav"),
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_03.wav"),
							new Path("sound/200_characters/210_common/lums/sfx_lums_middleageworld_picked_lvl01_05.wav"),
						}),
						_params = new SoundParams() {
							sizeOf = 96,
							numChannels = 1,
							fadeInTime = 0.01f,
							fadeOutTime = 0.01f,
							filterQ = 1f,
							playMode = SoundParams.PlayMode.Sequence,
							playMode2 = SoundParams.PlayMode2.Sequence,
							modifiers = new CArrayO<Generic<SoundModifier>>() {
								new Generic<SoundModifier>(new SpatializedPanning() {
									sizeOf = 12,
									widthMin = 100,
									widthMax = 1000,
								}),
								new Generic<SoundModifier>(new ScreenRollOff() {
									sizeOf = 16,
									distanceMin = 100,
									distanceMax = 1000,
								}),
							},
						},
					});
					
					// Lum voice
					sndComponent.soundList.Add(new SoundDescriptor_Template() {
						sizeOf = 468,
						name = new StringID(0x24204AB3),
						volume = new Volume(-9),
						category = new StringID(0xF03C38A1),
						limitMode = 0,
						limitModeEnum = LimiterDef.LimiterMode.RejectNew,
						files = new CListO<Path>(new List<Path>() {
							new Path("sound/200_characters/210_common/lums/vox_lums_picked_01.wav"), // 0
							new Path("sound/200_characters/210_common/lums/vox_lums_picked_02.wav"),
							new Path("sound/200_characters/210_common/lums/vox_lums_picked_04.wav"),
							new Path("sound/200_characters/210_common/lums/vox_lums_picked_05.wav"),
							new Path("sound/200_characters/210_common/lums/vox_lums_picked_06.wav"),
						}),
						_params = new SoundParams() {
							sizeOf = 96,
							numChannels = 1,
							fadeInTime = 0.01f,
							fadeOutTime = 0.01f,
							playMode = SoundParams.PlayMode.RandomSequence,
							playMode2 = SoundParams.PlayMode2.RandomSequence,
							randomPitchMin = 1.2f,
							randomPitchMax = 1.2f,
							modifiers = new CArrayO<Generic<SoundModifier>>(), // No modifiers
						},
					});
				}

				if (addLumKingMusic) {
					// Lum king music
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

					// Lum king music (50fps)
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
				}
				if (addAABBMod) {
					tpl.obj.AddComponent<BoxInterpolatorComponent_Template>();
				}
				// Now that this is done, find all objects that use it in the scene and add the lummusic component
				var lumMusicActors = oldContext.Loader.LoadedActors.Where(a => a.LUA == musicManagerPath);
				foreach (var act in lumMusicActors) {
					if (addLumKingMusic) {
						if (act.GetComponent<RO2_LumMusicManagerAIComponent>() == null) {
							act.AddComponent<RO2_LumMusicManagerAIComponent>();
						}
					}
					if (addAABBMod) {
						if (act.GetComponent<BoxInterpolatorComponent>() == null) {
							var box = act.AddComponent<BoxInterpolatorComponent>();
							box.innerBox = new AABB() {
								MIN = new Vec2d(-aabbScale, -aabbScale),
								MAX = new Vec2d(aabbScale, aabbScale)
							};
							box.outerBox = box.innerBox;
						}
					}
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

			if (scene.AddActor(murfyTrigger)) {
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
			if (scene.AddActor(murfyAction)) {
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

			if (scene.AddActor(trajectoryNode)) {
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

		public void MiniHandleMRDARKScene(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RM) return;

			var mrDark = scene.FindPickable(p => p.USERFRIENDLY.ToUpperInvariant() == "MRDARK" && p is SubSceneActor);
			if (mrDark?.Result != null) {
				mrDark.ContainingScene.DeletePickable(mrDark.Result);
			}

			var scenePath = GetScenePath(scene);
			if (scenePath.FullPath.StartsWith("world_arcade/ra_musical/")) {
				var fxScenes = scene.FindPickables(p
					=> p.USERFRIENDLY.ToUpperInvariant() == "FX_1"
					|| p.USERFRIENDLY.ToUpperInvariant() == "FX_2"
					|| p.USERFRIENDLY.ToUpperInvariant() == "FX_3");
				foreach (var fx in fxScenes) {
					fx.ContainingScene.DeletePickable(fx.Result);
				}
			}
		}

		public async Task SpawnLumMusicManagerIfNecessary(Context oldContext, Settings newSettings, Scene scene) {
			var lumMusic = scene.FindActor(a => a.GetComponent<RO2_RewardEffectsPlayerComponent>() != null);
			if(lumMusic?.Result != null) return;


			var musicManagerPath = new Path("sound/common/modifiers/lums/junglelummusicmanager.tpl");
			var musicManagerPath2 = new Path("world/common/friendly/lums/musicmanagers/junglelummusicmanager.tpl");

			var spawnPoint = scene.FindActor(a => a.GetComponent<CheckpointComponent>()?.INDEX == 0);
			if (spawnPoint?.Result == null) {
				spawnPoint = scene.FindActor(a => a.GetComponent<CheckpointComponent>() != null);
			}
			if (spawnPoint?.Result != null) {
				var manager = await AddNewActor(spawnPoint.ContainingScene, musicManagerPath2);
				manager.POS2D = spawnPoint.Result.POS2D;
			} else {
				var manager = await AddNewActor(scene, musicManagerPath2);
			}
		}

		public void FixBasketNinjas(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;

			var enemies = scene.FindActors(a => a.GetComponent<RO2_EnemyBTAIComponent>() != null);
			var zjumpTag = new StringID(0x75BACA2E);
			foreach (var res in enemies) {
				var act = res.Result;
				var nmi = act.GetComponent<RO2_EnemyBTAIComponent>();
				if (nmi.appearType == RO2_EnemyBTAIComponent.Enum_appearType.Basket) {
					var lnk = act.GetComponent<LinkComponent>();
					if (lnk.Children == null) lnk.Children = new CListO<ChildEntry>();
					if (lnk.Children.Any(c => c.HasTag(zjumpTag))) continue;
					AddBounceTarget(res.ContainingScene, act);
				}
			}
			void AddBounceTarget(Scene containingScene, Actor act) {
				var bouncetarget = new Actor() {
					USERFRIENDLY = "bouncetarget",
					POS2D = act.POS2D + new Vec2d(0f, 0f), // Position difference is required!
					xFLIPPED = act.xFLIPPED,
					LUA = new Path("world/common/logicactor/bouncetarget.tpl"),
					ANGLE = act.ANGLE,
					SCALE = act.SCALE,
					RELATIVEZ = act.RELATIVEZ + 3f, // Position difference is required!
				};
				containingScene.AddActor(bouncetarget);
				var newChild = new ChildEntry() {
					Path = new ObjectPath(bouncetarget.USERFRIENDLY)
				};
				newChild.AddTag(zjumpTag, "");
				act.GetComponent<LinkComponent>().Children.Add(newChild);
			}
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
					var basket = animatedComponent.animSet.animations.FirstOrDefault(a => a.friendlyName?.stringID == 0x4224699B);
					if(basket != null) basket.loop = false;

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
		public void InvertLianas_OnlyLeft(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var lianaPath = new Path("world/jungle/common/platform/liana/liana_zipline/components/liana_zipline_freelength.tpl");
			var lianaRopePath = new Path("world/jungle/common/platform/liana/liana_zipline/components/rope_zipline_freelength.tpl");
			var ziplines = scene.FindActors(a => a.LUA == lianaPath || a.LUA == lianaRopePath);
			foreach (var z in ziplines) {
				var act = z.Result;
				var softPlat = act?.GetComponent<ProceduralSoftPlatformComponent>();
				var endPos = softPlat.endPos;
				if (endPos == Vec3d.Invalid) continue;

				var actualEndPos = new Vec3d(act.SCALE.x * (act.xFLIPPED ? -1f : 1f), act.SCALE.y, 1f) * endPos;
				if (actualEndPos.x < 0) {
					// Invert this one
					var newEndPos = Vec3d.Zero - endPos;
					var newZ = act.RELATIVEZ + endPos.z;
					var newPos = act.POS2D + new Vec2d(actualEndPos.x, actualEndPos.y).Rotate(act.ANGLE);
					act.POS2D = newPos;
					act.RELATIVEZ = newZ;
					softPlat.endPos = newEndPos;
				}
			}
		}
		public void InvertZiplines_OnlyLeft(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var ziplines = scene.FindActors(a => a.USERFRIENDLY.StartsWith("chainrope_attach_zipline") || a.USERFRIENDLY.StartsWith("zipline_freelength"));
			foreach (var z in ziplines) {
				var act = z.Result;
				var lc = act?.GetComponent<LinkComponent>();
				if(lc == null) continue;
				var end = lc.Children.FirstOrDefault(c => c.HasTag("RopeEnd"));
				if(end == null) continue;

				if (end.Path.levels != null && end.Path.levels.Count > 0) continue; // Not supported yet
				var endObject = z.ContainingScene.FindByName(end.Path.id);

				// Swap positions
				var endObjectPos = endObject.POS2D;
				var ziplinePos = z.Result.POS2D;
				if (ziplinePos.x > endObjectPos.x) {
					endObject.POS2D = ziplinePos;
					z.Result.POS2D = endObjectPos;
				}
			}
		}

		public void FixBrokenSoundReferencesInChallenges(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var scenePath = GetScenePath(scene);
			var fullPath = scenePath.FullPath;

			string[] pathsWithBadRockTweens = new string[] {
				"world/challenge/run/challengerun/brick/easy/runbrick_easy_32.isc",
				"world/challenge/run/challengerun/brick/easy/runbrick_easy_33.isc",
				"world/challenge/run/challengerun/brick/easy/subscene/ld/runbrick_easy_32_ld.isc",
				"world/challenge/run/challengerun/brick/easy/subscene/ld/runbrick_easy_33_ld.isc",
				"world/challenge/run/challengerun/brick/hard/runbrick_hard_33.isc",
				"world/challenge/run/challengerun/brick/hard/runbrick_hard_34.isc",
				"world/challenge/run/challengerun/brick/hard/runbrick_hard_65.isc",
				"world/challenge/run/challengerun/brick/hard/subscene/ld/runbrick_hard_33_ld.isc",
				"world/challenge/run/challengerun/brick/hard/subscene/ld/runbrick_hard_34_ld.isc",
				"world/challenge/run/challengerun/brick/hard/subscene/ld/runbrick_hard_65_ld.isc",
				"world/challenge/run/challengerun/brick/medium/runbrick_medium_44.isc",
				"world/challenge/run/challengerun/brick/medium/runbrick_medium_45.isc",
				"world/challenge/run/challengerun/brick/medium/subscene/ld/runbrick_medium_44_ld.isc",
				"world/challenge/run/challengerun/brick/medium/subscene/ld/runbrick_medium_45_ld.isc",
				"world/challenge/run/challengerun/brick/veryhard/runbrick_veryhard_13.isc",
				"world/challenge/run/challengerun/brick/veryhard/runbrick_veryhard_25.isc",
				"world/challenge/run/challengerun/brick/veryhard/subscene/ld/runbrick_veryhard_13_ld.isc",
				"world/challenge/run/challengerun/brick/veryhard/subscene/ld/runbrick_veryhard_25_ld.isc",
			};

			if(!pathsWithBadRockTweens.Contains(fullPath)) return;

			var rockTween = new Path("world/common/logicactor/tweening/tweeneditortype/components/tween_rocktype.tpl");
			var rockTweens = scene.FindActors(a => a.LUA == rockTween);

			foreach (var tween in rockTweens) {
				tween.Result.LUA = new Path(rockTween.FullPath);
				ConversionSettings.LockedPaths.Add(tween.Result.LUA);
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
			ziplines = scene.FindActors(a => a.USERFRIENDLY.StartsWith("zipline_freelength"));
			foreach (var z in ziplines) {
				var link = z.Result.GetComponent<LinkComponent>();
				if (link == null) continue;
				var ziplineTarget = link.Children[0].Path;

				var targetNode = pickableTree.FollowObjectPath(z.Path, ziplineTarget);
				if (targetNode.Pickable.POS2D.x < z.Result.POS2D.x) { // Zipline goes left
					ZiplineToRope_Freelength(oldContext, newSettings, z.Result);
				}
			}
		}
		public void ZiplineToRope_All(Context oldContext, Settings newSettings, Scene scene) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			var pickableTree = new PickableTree(scene);
			var ziplines = scene.FindActors(a => a.USERFRIENDLY.StartsWith("chainrope_attach_zipline"));
			foreach (var z in ziplines) {
				ZiplineToRope(oldContext, newSettings, z.Result);
				/*var link = z.Result.GetComponent<LinkComponent>();
				if (link == null) continue;
				var ziplineTarget = link.Children[0].Path;

				var targetNode = pickableTree.FollowObjectPath(z.Path, ziplineTarget);
				if (targetNode.Pickable.POS2D.x < z.Result.POS2D.x) { // Zipline goes left
					ZiplineToRope(oldContext, newSettings, z.Result);
				}*/
			}
			ziplines = scene.FindActors(a => a.USERFRIENDLY.StartsWith("zipline_freelength") || a.USERFRIENDLY.StartsWith("liana_zipline_freelength"));
			foreach (var z in ziplines) {
				ZiplineToRope_Freelength(oldContext, newSettings, z.Result);
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
				containingScene.AddActor(trigger);
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

		public void ZiplineToRope(Context oldContext, Settings newSettings, Actor act) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;
			if (!structs.ContainsKey(typeof(GenericFile<Actor_Template>)))
				structs[typeof(GenericFile<Actor_Template>)] = new Dictionary<StringID, ICSerializable>();
			var actorTemplates = structs[typeof(GenericFile<Actor_Template>)];

			if (CloneTemplateIfNecessary(act.LUA, "rope", "ROPE", act.template, out var newTPL, act: act)) {
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

					/*var colorFactor = 0.75f;
					rope.bezierRenderer.beginColor *= new UbiArt.Color(colorFactor, colorFactor, colorFactor, 1f);
					rope.bezierRenderer.endColor   *= new UbiArt.Color(colorFactor, colorFactor, colorFactor, 1f);
					rope.bezierRenderer.midColor   *= new UbiArt.Color(colorFactor, colorFactor, colorFactor, 1f);*/

					rope.beginMaterial.textureSet.diffuse = new Path("world/common/platform/rope/texture/rope_extremity_01.tga");
					rope.beginMaterial.textureSet.back_light = new Path("world/common/platform/rope/texture/rope_extremity_01_back.tga");
					rope.endMaterial.textureSet.diffuse = new Path("world/common/platform/rope/texture/rope_extremity_02.tga");
					rope.endMaterial.textureSet.back_light = new Path("world/common/platform/rope/texture/rope_extremity_02_back.tga");
				}
			}
		}

		public void ZiplineToRope_Freelength(Context oldContext, Settings newSettings, Actor act) {
			if (oldContext.Settings.Game != Game.RA && oldContext.Settings.Game != Game.RM) return;
			if (newSettings.Game == Game.RA || newSettings.Game == Game.RM) return;

			if (CloneTemplateIfNecessary(act.LUA, "rope", "ROPE", act.template, out var newTPL, act: act)) {
				var rope = newTPL.obj.GetComponent<ProceduralSoftPlatformComponent_Template>();
				if (rope != null) {
					// TODO: Change game material sound
					rope.gameMaterial = new Path("gamematerial/basicliana_h.gmt");

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
					if (soundComponent != null) {
						// Merge soundComponents
						/*var components = tpl.obj.GetComponents<SoundComponent_Template>()?.ToArray();
						if (components != null && components.Length > 1) {
							for (int i = 1; i < components.Length; i++) {
								var secondaryComponent = components[i];
								if(secondaryComponent == null) continue;

								if (secondaryComponent.soundList != null) {
									if (soundComponent.soundList == null) soundComponent.soundList = new CListO<SoundDescriptor_Template>();
									soundComponent.soundList = new CListO<SoundDescriptor_Template>(soundComponent.soundList
										.Where(s => !secondaryComponent.soundList.Any(s2 => s2.name == s.name))
										.Concat(secondaryComponent.soundList).ToList());
								}
								if(secondaryComponent.defaultSoundIsAlwaysActive) soundComponent.defaultSoundIsAlwaysActive = true;
								if(!(secondaryComponent.defaultSound?.IsNull ?? true)) soundComponent.defaultSound = secondaryComponent.defaultSound;
							}
						}*/
					}
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
							if(wwEventID == null || wwEventID.IsNull) continue;
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
						var oldCookedPath = l.CookedPaths.ContainsKey(ogPath.stringID) ? l.CookedPaths[ogPath.stringID] : ogPath.CookedPath(oldContext);
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
				if (spawnPoint != null) {
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
				}

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
				scene.AddActor(pauseswitch);

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

				Actor CreateMaskResolver(string name, string template, float z) {
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
					/*if (rp.ClearColor != null && rp.ClearColor.Enable) {
						mr.clearBackLightBuffer = true;
						mr.clearFrontLightBuffer = true;
						mr.clearBackLightColor = rp.ClearColor.ClearBackLightColor;
						mr.clearFrontLightColor = rp.ClearColor.ClearFrontLightColor;
					}*/
					if (box != null) {
						var outerAABB = box.outerBox;
						var scale = outerAABB.MAX - outerAABB.MIN;
						var center = outerAABB.MIN + (scale / 2f);
						newAct.POS2D = act.POS2D + center.Rotate(act.ANGLE ?? 0f);
						newAct.SCALE = act.SCALE * scale;
					}
					rpScene.AddActor(newAct);
					return newAct;
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

				Frise CreateFrise(string name, string template, float z = 0) {
					var fr = new Frise() {
						POS2D = act.POS2D,
						ANGLE = act.ANGLE,
						SCALE = act.SCALE,
						RELATIVEZ = act.RELATIVEZ + z,
						USERFRIENDLY = $"{act.USERFRIENDLY}_{name}",
						xFLIPPED = act.xFLIPPED,

						PreComputedForCook = true,
						ConfigName = new Path(template),
						UseTemplatePrimitiveParams = false,

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

					return fr;
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

			if (scene.AddActor(murfyTrigger)) {
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
			if (scene.AddActor(murfyAction)) {
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

			if (scene.AddActor(gyroController)) {
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
					/*Path = new ObjectPath() {
						id = parentName ?? scene.ACTORS[1].obj.USERFRIENDLY,
						levels = parentName != null ? new CListO<ObjectPath.Level>() {
							new ObjectPath.Level() {
								//name = parentName,
								parent = true,
							},
						} : null,
					},*/
					Path = new ObjectPath() {
						id = act.USERFRIENDLY,
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
		public Path GetClonedTemplatePath(Path ogPath, string suffix) => new Path(ogPath.FullPath.Replace(".tpl", $"__{suffix}.tpl"));
		public bool CloneTemplateIfNecessary(Path ogPath, string suffix, string reason, GenericFile<Actor_Template> ogTPL, out GenericFile<Actor_Template> newTPL, Actor act = null) {
			var oldContext = MainContext;
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			var newPath = GetClonedTemplatePath(ogPath, suffix);

			bool clonedTemplate = false;
			if (!structs[typeof(GenericFile<Actor_Template>)].ContainsKey(newPath.stringID)) {
				clonedTemplate = true;
				l.Context.SystemLogger?.LogInfo($"Duplicating template ({reason}): {ogPath.FullPath}");
				newTPL = new GenericFile<Actor_Template>(ogTPL.obj?.Clone("tpl"/*, context: LegendsContext*/) as Actor_Template);
				newTPL.sizeOf = ogTPL.sizeOf;

				var oldCookedPath = l.CookedPaths.ContainsKey(ogPath.stringID) ? l.CookedPaths[ogPath.stringID] : ogPath.CookedPath(oldContext);
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
				newTPL.obj.InitContext(oldContext);

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

		public bool CreateStructNecessary<T>(Path newPath, string reason, out T newStruct) where T : ICSerializable, new() {
			var oldContext = MainContext;
			Loader l = oldContext.Loader;
			var structs = l.Context.Cache.Structs;

			bool createdTemplate = false;
			if (!structs[typeof(T)].ContainsKey(newPath.stringID)) {
				createdTemplate = true;
				l.Context.SystemLogger?.LogInfo($"Creating struct ({reason}): {newPath.FullPath}");
				newStruct = new T();
				//newTPL.obj.InitContext(oldContext);

				var newCookedPath = newPath.CookedPath(oldContext);

				l.CookedPaths[newPath.stringID] = newCookedPath;
				l.Paths[newPath.stringID] = newPath;
				structs[typeof(T)][newPath.stringID] = newStruct;
			} else {
				newStruct = (T)structs[typeof(T)][newPath.stringID];
			}

			return createdTemplate;
		}

		#endregion


		#region Dispose

		public void Close() {
			StopLoadingScreen();
			LegendsContext?.Dispose();
			LegendsContextNoLockedPaths?.Dispose();
		}
		public void Dispose() {
			Close();
		}

		#endregion
	}
}
