using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.Animation;
using UbiArt.ITF;
using UbiCanvas.Conversion.Json;
using UbiCanvas.Helpers;

namespace UbiCanvas.Conversion {
	public class CostumeActorsBuilder : ProjectBuilder {

		public CostumeActorsBuilder(string projectPath) : base(projectPath) { }

		public override string ID => "costumes";

		public List<JSON_CostumeInfo> Costumes { get; set; } = new List<JSON_CostumeInfo>();

		public Dictionary<string, string> SpecialActors { get; set; } = new Dictionary<string, string>() {
			["lividstone"] = "world/common/enemy/lividstone/lividstone_drag.act",
			["toad"] = "world/mountain/level/mo_rl_1_flyingshield_inv/page/subscene/ld/actors/basictoad_parachute_startleft.act",
			["alinferno"] = "world/food/common/enemy/alinferno/alinferno_drag.act",
			["mexicanskeleton"] = "world/food/common/enemy/mexicanskeleton/mexicanskeleton_drag.act",
			["stoneman"] = "world/mountain/common/enemy/stoneman/stoneman_drag.act",
			["minotaur"] = "world/mountain/common/enemy/minotaur/minotaur_grab.act",
			["darktoon"] = "custom/darktoon_basic.act"
		};

		protected override async Task BuildInternal() {
			//await BuildGloToad();
			foreach(var c in Costumes) await BuildCostume(c);
		}


		async Task BuildCostume(JSON_CostumeInfo costume) {
			if(SpecialActors.ContainsKey(costume.CostumeID.ToLowerInvariant())) {
				await BuildCostumeSpecial(costume);
				return;
			}
			var family = costume.Family.ToLowerInvariant();

			if (costume.TrailColor == null && costume.DeathBubbleColor != null) {
				var c = costume.DeathBubbleColor;
				costume.TrailColor = new UbiArt.Color(c.r, c.g, c.b, 0.5019608f);
			}
			var textureBanksDict = costume.TextureBanks?.ToDictionary(kv => new StringID(kv.Key));
			foreach (var bnk in costume.TextureBanks) {
				bnk.Value.ID = bnk.Key;
			}
			Dictionary<string, List<RedirectSymmetryPatch>> redirectSymmetryPatchesDict = new Dictionary<string, List<RedirectSymmetryPatch>>();

			string GetRedirectSymmetryPatchesPath(string key, string fallback = null) {
				if (costume.RedirectSymmetryPatches != null) {
					if (costume.RedirectSymmetryPatches.ContainsKey(key))
						return costume.RedirectSymmetryPatches[key];
					if (fallback != null) {
						if (costume.RedirectSymmetryPatches.ContainsKey(fallback))
							return costume.RedirectSymmetryPatches[fallback];
					}
					if (costume.RedirectSymmetryPatches.ContainsKey("all"))
						return costume.RedirectSymmetryPatches["all"];
				}
				return null;
			}
			List<RedirectSymmetryPatch> GetRedirectSymmetryPatches(string key, string fallback = null) {
				var path = GetRedirectSymmetryPatchesPath(key, fallback: fallback);
				if (path != null) {
					if (!redirectSymmetryPatchesDict.ContainsKey(path)) {
						var absolutePath = System.IO.Path.Combine(ProjectPath, "redirectsymmetry", path);
						if (System.IO.File.Exists(absolutePath)) {
							var fileBytes = System.IO.File.ReadAllBytes(absolutePath);
							using var ms = new System.IO.MemoryStream(fileBytes);
							using var r = new Reader(ms, false);
							var patches = new List<RedirectSymmetryPatch>();
							for( int i = 0; i < r.BaseStream.Length / 12; i++) {
								var p = new RedirectSymmetryPatch();
								p.mainPatch = new StringID(r.ReadUInt32());
								p.boneName = new StringID(r.ReadUInt32());
								p.symmetryPatch = new StringID(r.ReadUInt32());
								patches.Add(p);
							}
							redirectSymmetryPatchesDict[path] = patches;
						}
					}
					return redirectSymmetryPatchesDict.TryGetItem(path);
				}
				return null;
			}

			JSON_CostumeInfo.JSON_TextureBank GetBankByID(StringID sid, string fallback = null) {
				// Try to get specific bank from dictionary first.
				if (costume.TextureBanks != null) {
					if (textureBanksDict.ContainsKey(sid)) {
						return textureBanksDict[sid].Value;
					}
					if (fallback != null) {
						if (costume.TextureBanks.ContainsKey(fallback))
							return costume.TextureBanks[fallback];
					}
					if (costume.TextureBanks.ContainsKey("pack"))
						return costume.TextureBanks["pack"];
				}
				return null;
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Main)) {
				var cookedPath = new Path(costume.ActorPath_Main).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/playablecharacter/{family}/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}teensy_classicking.act",
						_ => $"{basePath}{family}.act"
					};
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					// Load template too
					originalActor.obj.LUA.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();
					var originalActorTPL = originalActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();

					var mainPlayerControllerComponent = newActor.GetComponent<RO2_PlayerControllerComponent>();
					var mainAnimatedComponent = newActor.GetComponent<AnimatedComponent>();
					var tplAnimatedComponent = originalActorTPL.obj.GetComponent<AnimatedComponent_Template>();

					// Set scale
					if(costume.Scale.HasValue) newActor.SCALE = Vec2d.One * costume.Scale.Value;

					// Set skeleton (only used by some special actors!)
					//if(!string.IsNullOrWhiteSpace(costume.SkeletonPath))
					//	mainAnimatedComponent.subAnimInfo.animPackage.skeleton = new Path(costume.SkeletonPath);

					mainPlayerControllerComponent.trailPath = new Path(costume.TemplatePath_Trail);
					mainAnimatedComponent.subSkeleton = new StringID(costume.SubSkeleton);
					foreach (var tpl_b in tplAnimatedComponent.animSet.animPackage.textureBank) {
						if (!mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Any(act_b => act_b.id == tpl_b.id)) {
							mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Add(new TextureBankPath() {
								sizeOf = 1340,
								id = tpl_b.id,
								materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
								patchBank = new Path(tpl_b.patchBank),
								textureSet = new GFXMaterialTexturePathSet() {
									diffuse = new Path(tpl_b.textureSet.diffuse),
									back_light = new Path(tpl_b.textureSet.back_light),
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

					var redirectPatches = GetRedirectSymmetryPatches("main");
					if (redirectPatches != null) {
						mainAnimatedComponent.subAnimInfo.redirectSymmetryPatches = new CListO<RedirectSymmetryPatch>(redirectPatches);
					}

					/*var scoreActor = player.defaultGameScreenInfo.actors[1].file.GetObject<ContainerFile<UbiArt.ITF.Actor>>();
					scoreActor.obj.GetComponent<RO2_PlayerHudScoreComponent>().characterMaterial.textureSet.diffuse = player.iconTexturePath;*/


					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Moskito)) {
				var cookedPath = new Path(costume.ActorPath_Moskito).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
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
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					// Load template too
					originalActor.obj.LUA.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();
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
								patchBank = new Path(tpl_b.patchBank),
								textureSet = new GFXMaterialTexturePathSet() {
									diffuse = new Path(tpl_b.textureSet.diffuse),
									back_light = new Path(tpl_b.textureSet.back_light),
									sizeOf = 1036,
								},

							});
						}
					}
					if (!costume.TextureBanks.ContainsKey("pack_shootermoskito") && costume.TextureBanks.ContainsKey("pack")) {
						// Only works for rayman, teensy & barbara!!!
						if (family == "globox") {
							// TODO: Find solution for Globox
						} else {
							var newPBK = await LoadFileFromPatchData<AnimPatchBank>(TargetContext, costume.TextureBanks["pack"].PBK);

							costume.TextureBanks["pack_shootermoskito"] = new JSON_CostumeInfo.JSON_TextureBank() {
								ID = "pack_shootermoskito",
								Diffuse = costume.TextureBanks["pack"].Diffuse,
								Backlight = costume.TextureBanks["pack"].Backlight,
								PBK = costume.TextureBanks["pack"].PBK.Replace(".pbk", "_shootermoskito.pbk")
							};
							textureBanksDict[new StringID("pack_shootermoskito")] = new KeyValuePair<string, JSON_CostumeInfo.JSON_TextureBank>("pack_shootermoskito", costume.TextureBanks["pack_shootermoskito"]);

							// Load moskito skeleton
							tplAnimatedComponent.animSet.animPackage.skeleton.LoadObject(TargetContext);
							await TargetContext.Loader.LoadLoop();
							var moskitoSkeleton = tplAnimatedComponent.animSet.animPackage.skeleton.GetObject<AnimSkeleton>();

							Bundle.AddFile(new Path(costume.TextureBanks["pack_shootermoskito"].PBK).CookedPath(TargetContext), newPBK);
						}
						// Iterate over PBK
						/*for (int i = 0; i < newPBK.templates.Count; i++) {
							var t_key = newPBK.templateKeys.keysLegends[i];
							var t = newPBK.templates[i];
							foreach (var bk in t.boneKeys.keysLegends) {
								if (!moskitoSkeleton.boneTags.Contains(bk)) {
									rlContextExt?.SystemLogger?.LogWarning($"B: {family} - {bk}");
								}
							}
						}*/

						// Load main shootermoskito pbk
						/*var moskitoPackBank = mainAnimatedComponent.subAnimInfo.animPackage.textureBank.FirstOrDefault(tb => tb.id != new StringID("shootermoskitodeath")
								&& tb.id != new StringID($"shootermoskitoray_a") && tb.id != new StringID($"shootermoskitoglob_a"));
						moskitoPackBank.patchBank.LoadObject(rlContextExt);
						var mainPBKPath = new Path($"world/common/playablecharacter/{family}/animation/{family}_pack_basic_001.pbk");
						mainPBKPath.LoadObject(rlContextExt);
						mainAnimatedComponent.subAnimInfo.animPackage.skeleton.LoadObject(rlContextExt);

						await rlContextExt.Loader.LoadLoop();

						var pack_shootermoskito_pbk = moskitoPackBank.patchBank.GetObject<AnimPatchBank>();
						var pack_main_pbk = mainPBKPath.GetObject<AnimPatchBank>();
						var moskitoSkeleton = mainAnimatedComponent.subAnimInfo.animPackage.skeleton.GetObject<AnimSkeleton>();*/

						/*for (int i = 0; i < pack_shootermoskito_pbk.templates.Count; i++) {
							var t_key = pack_shootermoskito_pbk.templateKeys.keysLegends[i];
							if(!newPBK.templateKeys.keysLegends.Contains(t_key))
								rlContextExt?.SystemLogger?.LogWarning($"T: {family} - {t_key}");
							var t = pack_shootermoskito_pbk.templates[i];
							foreach (var bk in t.boneKeys.keysLegends) {
								if (!newPBK.templates.Any(t => t.boneKeys.keysLegends.Contains(bk)))
									rlContextExt?.SystemLogger?.LogWarning($"B: {family} - {bk}");
							}
						}*/
						//var pack_main_pbk;

					}
					foreach (var tb in mainAnimatedComponent.subAnimInfo.animPackage.textureBank) {
						var jsonb = GetBankByID(tb.id, fallback: "pack_shootermoskito");

						if (jsonb.ID != "pack" && jsonb.ID != "pack_shootermoskito") {
							// Source is a version that has Moskito sprites. Use this patchbank regardless
							tb.patchBank = new Path(jsonb.PBK);

							// To allow for easier json editing, allow leaving moskito sprite blank
							if (jsonb.Diffuse != null || (tb.id != new StringID("shootermoskitodeath") && tb.id != new StringID("shootermoskitoray_a"))) { // Moskito bodies
								//UnityEngine.Debug.Log($"{costume.CostumeID}: {tb.id} - {jsonb.ID}");
								tb.textureSet.diffuse = new Path(jsonb.Diffuse);
								tb.textureSet.back_light = new Path(jsonb.Backlight);
							}
						} else if (jsonb.ID == "pack_shootermoskito") {
							if (tb.id == new StringID("shootermoskitodeath") || tb.id == new StringID("shootermoskitoray_a")) {
								// Don't change PBK or texture for these
							} else {
								tb.patchBank = new Path(jsonb.PBK);
								tb.textureSet.diffuse = new Path(jsonb.Diffuse);
								tb.textureSet.back_light = new Path(jsonb.Backlight);
							}
						}

						// DISABLED: Using "pack" PBK does not work for any family, when duplicated it works for all families except Globox.
						/*else {
							// Source is the main packed sprite sheet. No Moskito sprites in this, so use the default PBK for those instead.
							if (tb.id != new StringID("shootermoskitodeath")
								&& tb.id != new StringID($"shootermoskitoray_a") // Used for teensy & barbara too
								&& tb.id != new StringID($"shootermoskitoglob_a") // Only Globox has his own bank
							) {
								tb.patchBank = new Path(jsonb.PBK);

								tb.textureSet.diffuse = new Path(jsonb.Diffuse);
								tb.textureSet.back_light = new Path(jsonb.Backlight);
							}
						}*/
					}
					var redirectPatches = GetRedirectSymmetryPatches("shootermoskito");
					if (redirectPatches != null) {
						mainAnimatedComponent.subAnimInfo.redirectSymmetryPatches = new CListO<RedirectSymmetryPatch>(redirectPatches);
					}

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Duck)) {
				var cookedPath = new Path(costume.ActorPath_Duck).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/playablecharacter/duck/";
					var actorToClone = $"{basePath}duck_{family}.act";
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					// Load template too
					originalActor.obj.LUA.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();
					var originalActorTPL = originalActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();

					var mainAnimatedComponent = newActor.GetComponent<AnimatedComponent>();
					var tplAnimatedComponent = originalActorTPL.obj.GetComponent<AnimatedComponent_Template>();

					// The subskeleton for the duck actor is the family name
					mainAnimatedComponent.subSkeleton = new StringID(costume.Family);

					foreach (var tpl_b in tplAnimatedComponent.animSet.animPackage.textureBank) {
						if (!mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Any(act_b => act_b.id == tpl_b.id)) {
							mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Add(new TextureBankPath() {
								sizeOf = 1340,
								id = tpl_b.id,
								materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
								patchBank = new Path(tpl_b.patchBank),
								textureSet = new GFXMaterialTexturePathSet() {
									diffuse = new Path(tpl_b.textureSet.diffuse),
									back_light = new Path(tpl_b.textureSet.back_light),
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
							} else if(jsonb.ID != "pack") {
								tb.patchBank = new Path(jsonb.PBK);
								tb.textureSet.diffuse = new Path(jsonb.Diffuse);
								tb.textureSet.back_light = new Path(jsonb.Backlight);
							}
							// If only "pack" is present, we don't adjust anything.
						}
					}
					var redirectPatches = GetRedirectSymmetryPatches("duck");
					if (redirectPatches != null) {
						mainAnimatedComponent.subAnimInfo.redirectSymmetryPatches = new CListO<RedirectSymmetryPatch>(redirectPatches);
					}

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_ScoreHUD)) {
				var cookedPath = new Path(costume.ActorPath_ScoreHUD).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/ui/common/playerscore/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}scorehud_teensyclassicking.act",
						_ => $"{basePath}scorehud_{family}.act"
					};
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					newActor.GetComponent<RO2_PlayerHudScoreComponent>().characterMaterial.textureSet.diffuse = new Path(costume.IconPath);

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Painting)) {
				var cookedPath = new Path(costume.ActorPath_Painting).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/home/actor/costumes/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}costumeteensy_classicking.act",
						"barbara" => $"{basePath}costumebarbara_mainroom.act",
						_ => $"{basePath}costume{family}.act"
					};
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					newActor.LUA = new Path(costume.TemplatePath_Painting);

					var costumeComponent = newActor.GetComponent<RO2_PlayerCostumeComponent>();
					costumeComponent.costumeId = new StringID(costume.CostumeID);
					costumeComponent.nameLocId = new LocalisationId(costume.NameID);
					costumeComponent.descriptionLocId = new LocalisationId(costume.DescriptionID);


					var redirectPatches = GetRedirectSymmetryPatches("costume");
					if (redirectPatches != null) {
						var animComponent = newActor.GetComponent<AnimLightComponent>();
						animComponent.subAnimInfo.redirectSymmetryPatches = new CListO<RedirectSymmetryPatch>(redirectPatches);
					}

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.TemplatePath_Painting)) {
				var cookedPath = new Path(costume.TemplatePath_Painting).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/home/actor/costumes/components/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}costumeteensy_classicking.tpl",
						_ => $"{basePath}costume{family}.tpl"
					};
					var pOriginalActor = new Path(actorToClone);
					var animPath = new Path($"world/common/playablecharacter/{family}/animation/{costume.Painting.Animation}.anm");
					pOriginalActor.LoadObject(TargetContext);
					animPath.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var paintingAnim = animPath.GetObject<AnimTrack>();
					var originalTPL = pOriginalActor.GetObject<GenericFile<Actor_Template>>();
					var newTPL = (Actor_Template)(await TargetContext.Loader.Clone(originalTPL.obj, "tpl"));
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
					//TargetContext?.SystemLogger?.LogInfo($"{aabb.aabb.MIN} - {aabb.aabb.MAX}");


					// TODO: Also adjust aabb.aabb here. Seems to do nothing though.
					// AABB taken from barbara_mexicandark (ninja animation that goes outside of each painting boundary)
					//aabb.aabb.MIN = new Vec2d(-2.321101f, -5.283033f);
					//aabb.aabb.MAX = new Vec2d(3.221961f, 0.642587f);
					//aabb.aabb.MIN = new Vec2d(10000f, 10000f);
					//aabb.aabb.MAX = new Vec2d(-10000f, -10000f);

					if (costume.Painting.FlipX) animComponent.flip = !animComponent.flip;

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

					Bundle.AddFile(cookedPath, newTPLContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.TemplatePath_Trail)) {
				var cookedPath = new Path(costume.TemplatePath_Trail).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/fx/actors/trails/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}teleporttrail_teensyclassicking.tpl",
						_ => $"{basePath}teleporttrail_{family}.tpl"
					};
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalTPL = pOriginalActor.GetObject<GenericFile<Actor_Template>>();
					var newTPL = (Actor_Template)(await TargetContext.Loader.Clone(originalTPL.obj, "tpl"));
					var newTPLContainer = new GenericFile<Actor_Template>(newTPL) {
						sizeOf = originalTPL.sizeOf
					};

					// The trail color is set in 3 places:
					newTPL.GetComponent<TextureGraphicComponent_Template>().defaultColor = costume.TrailColor;

					var t3dc = newTPL.GetComponent<Trail3DComponent_Template>();
					foreach (var trail in t3dc.trailList) trail.color = costume.TrailColor;

					var fxc = newTPL.GetComponent<FxBankComponent_Template>();
					fxc.Fx[0].gen._params.defaultColor = costume.TrailColor;

					Bundle.AddFile(cookedPath, newTPLContainer);
				}
			}

		}


		async Task BuildCostumeSpecial(JSON_CostumeInfo costume) {
			var family = costume.Family.ToLowerInvariant();

			if (costume.TrailColor == null && costume.DeathBubbleColor != null) {
				var c = costume.DeathBubbleColor;
				costume.TrailColor = new UbiArt.Color(c.r, c.g, c.b, 0.5019608f);
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Main)) {
				var cookedPath = new Path(costume.ActorPath_Main).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/playablecharacter/{family}/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}teensy_classicking.act",
						_ => $"{basePath}{family}.act"
					};
					var specialActorToClone = SpecialActors[costume.CostumeID.ToLowerInvariant()];
					var pOriginalActor = new Path(actorToClone);
					var pSpecialActor = new Path(specialActorToClone);
					pOriginalActor.LoadObject(TargetContext);
					pSpecialActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var specialActor = pSpecialActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					// Load template too
					originalActor.obj.LUA.LoadObject(TargetContext);
					specialActor.obj.LUA.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();
					var originalActorTPL = originalActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();
					var specialActorTPL = specialActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();

					var newActorTPL = (Actor_Template)(await TargetContext.Loader.Clone(originalActorTPL.obj, "tpl"));
					var newActorTPLContainer = new GenericFile<Actor_Template>(newActorTPL) {
						sizeOf = originalActorTPL.sizeOf
					};
					var pNewTPL = new Path(newActor.LUA.folder, $"{costume.CostumeID.ToLowerInvariant()}.tpl");
					newActor.LUA = pNewTPL;

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
								patchBank = new Path(tpl_b.patchBank),
								textureSet = new GFXMaterialTexturePathSet() {
									diffuse = new Path(tpl_b.textureSet.diffuse),
									back_light = new Path(tpl_b.textureSet.back_light),
									sizeOf = 1036,
								},

							});
						}
					}

					/*var scoreActor = player.defaultGameScreenInfo.actors[1].file.GetObject<ContainerFile<UbiArt.ITF.Actor>>();
					scoreActor.obj.GetComponent<RO2_PlayerHudScoreComponent>().characterMaterial.textureSet.diffuse = player.iconTexturePath;*/

					var animComponents = newActor.COMPONENTS.Where(c => c.obj is AnimatedComponent).ToList();
					var animComponentsTPL = newActorTPL.COMPONENTS.Where(c => c.obj is AnimatedComponent_Template).ToList();
					newActor.COMPONENTS.Remove(animComponents.First());
					newActorTPL.COMPONENTS.Remove(animComponentsTPL.First());
					newActor.AddComponent<AnimatedComponent>(specialActor.obj.GetComponent<AnimatedComponent>());
					newActorTPL.AddComponent<AnimatedComponent_Template>(specialActorTPL.obj.GetComponent<AnimatedComponent_Template>());

					Bundle.AddFile(cookedPath, newActorContainer);
					Bundle.AddFile(pNewTPL.CookedPath(TargetContext), newActorTPLContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Moskito)) {
				var cookedPath = new Path(costume.ActorPath_Moskito).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
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
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					// Load template too
					originalActor.obj.LUA.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();
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
								patchBank = new Path(tpl_b.patchBank),
								textureSet = new GFXMaterialTexturePathSet() {
									diffuse = new Path(tpl_b.textureSet.diffuse),
									back_light = new Path(tpl_b.textureSet.back_light),
									sizeOf = 1036,
								},

							});
						}
					}

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Duck)) {
				var cookedPath = new Path(costume.ActorPath_Duck).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/playablecharacter/duck/";
					var actorToClone = $"{basePath}duck_{family}.act";
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					// Load template too
					originalActor.obj.LUA.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();
					var originalActorTPL = originalActor.obj.LUA.GetObject<GenericFile<Actor_Template>>();

					var mainAnimatedComponent = newActor.GetComponent<AnimatedComponent>();
					var tplAnimatedComponent = originalActorTPL.obj.GetComponent<AnimatedComponent_Template>();

					// The subskeleton for the duck actor is the family name
					mainAnimatedComponent.subSkeleton = new StringID(costume.Family);

					foreach (var tpl_b in tplAnimatedComponent.animSet.animPackage.textureBank) {
						if (!mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Any(act_b => act_b.id == tpl_b.id)) {
							mainAnimatedComponent.subAnimInfo.animPackage.textureBank.Add(new TextureBankPath() {
								sizeOf = 1340,
								id = tpl_b.id,
								materialShader = new Path("world/common/matshader/regularbuffer/backlighted.msh"),
								patchBank = new Path(tpl_b.patchBank),
								textureSet = new GFXMaterialTexturePathSet() {
									diffuse = new Path(tpl_b.textureSet.diffuse),
									back_light = new Path(tpl_b.textureSet.back_light),
									sizeOf = 1036,
								},

							});
						}
					}

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_ScoreHUD)) {
				var cookedPath = new Path(costume.ActorPath_ScoreHUD).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/ui/common/playerscore/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}scorehud_teensyclassicking.act",
						_ => $"{basePath}scorehud_{family}.act"
					};
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					newActor.GetComponent<RO2_PlayerHudScoreComponent>().characterMaterial.textureSet.diffuse = new Path(costume.IconPath);

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.ActorPath_Painting)) {
				var cookedPath = new Path(costume.ActorPath_Painting).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/home/actor/costumes/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}costumeteensy_classicking.act",
						"barbara" => $"{basePath}costumebarbara_mainroom.act",
						_ => $"{basePath}costume{family}.act"
					};
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalActor = pOriginalActor.GetObject<ContainerFile<Actor>>();
					var newActor = (Actor)(await TargetContext.Loader.Clone(originalActor.obj, "act"));
					var newActorContainer = new ContainerFile<Actor>() {
						read = true,
						obj = newActor
					};

					newActor.LUA = new Path(costume.TemplatePath_Painting);

					var costumeComponent = newActor.GetComponent<RO2_PlayerCostumeComponent>();
					costumeComponent.costumeId = new StringID(costume.CostumeID);
					costumeComponent.nameLocId = new LocalisationId(costume.NameID);
					costumeComponent.descriptionLocId = new LocalisationId(costume.DescriptionID);

					Bundle.AddFile(cookedPath, newActorContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.TemplatePath_Painting)) {
				var cookedPath = new Path(costume.TemplatePath_Painting).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/home/actor/costumes/components/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}costumeteensy_classicking.tpl",
						_ => $"{basePath}costume{family}.tpl"
					};
					var pOriginalActor = new Path(actorToClone);
					var animPath = new Path($"world/common/playablecharacter/{family}/animation/{costume.Painting.Animation}.anm");
					pOriginalActor.LoadObject(TargetContext);
					animPath.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var paintingAnim = animPath.GetObject<AnimTrack>();
					var originalTPL = pOriginalActor.GetObject<GenericFile<Actor_Template>>();
					var newTPL = (Actor_Template)(await TargetContext.Loader.Clone(originalTPL.obj, "tpl"));
					var newTPLContainer = new GenericFile<Actor_Template>(newTPL) {
						sizeOf = originalTPL.sizeOf
					};

					/*var animComponent = newTPL.GetComponent<AnimLightComponent_Template>();
					var subAnim = animComponent.animSet.animations.FirstOrDefault(a => a.friendlyName == new StringID("Available"));
					var ogAnimPath = subAnim.name;
					subAnim.name = animPath;
					var aabb = animComponent.animSet.animPackage.animPathAABB.FirstOrDefault(a => a.path == ogAnimPath);
					aabb.path = animPath;
					aabb.name = new StringID(costume.Painting.Animation);*/
					// TODO: Also adjust aabb.aabb here

					Bundle.AddFile(cookedPath, newTPLContainer);
				}
			}

			if (!string.IsNullOrWhiteSpace(costume.TemplatePath_Trail)) {
				var cookedPath = new Path(costume.TemplatePath_Trail).CookedPath(TargetContext);
				if (!FileIsAlreadyBuilt(cookedPath)) {
					var basePath = $"world/common/fx/actors/trails/";
					var actorToClone = family switch {
						"teensy" => $"{basePath}teleporttrail_teensyclassicking.tpl",
						_ => $"{basePath}teleporttrail_{family}.tpl"
					};
					var pOriginalActor = new Path(actorToClone);
					pOriginalActor.LoadObject(TargetContext);
					await TargetContext.Loader.LoadLoop();

					var originalTPL = pOriginalActor.GetObject<GenericFile<Actor_Template>>();
					var newTPL = (Actor_Template)(await TargetContext.Loader.Clone(originalTPL.obj, "tpl"));
					var newTPLContainer = new GenericFile<Actor_Template>(newTPL) {
						sizeOf = originalTPL.sizeOf
					};

					// The trail color is set in 3 places:
					newTPL.GetComponent<TextureGraphicComponent_Template>().defaultColor = costume.TrailColor;

					var t3dc = newTPL.GetComponent<Trail3DComponent_Template>();
					foreach (var trail in t3dc.trailList) trail.color = costume.TrailColor;

					var fxc = newTPL.GetComponent<FxBankComponent_Template>();
					fxc.Fx[0].gen._params.defaultColor = costume.TrailColor;

					Bundle.AddFile(cookedPath, newTPLContainer);
				}
			}

		}


		async Task BuildGloToad() {
			Path pBasicToad = new Path("world/common/enemy/toad/basictoad/components/basictoad.tpl");
			Path pGloToad = new Path("personal/jim/glotoad/glotoad.tpl");
			var gloToad = await LoadFileFromPatchData<GenericFile<Actor_Template>>(TargetContext, pGloToad.FullPath);
			var basicToad = await LoadFileFromPatchData<GenericFile<Actor_Template>>(TargetContext, pBasicToad.FullPath);

			var newAnimComponent = gloToad.obj.GetComponent<AnimatedComponent_Template>();

			var cContainer = basicToad.obj.COMPONENTS.FirstOrDefault(c => c.obj is AnimatedComponent_Template);
			cContainer.obj = newAnimComponent;
			Bundle.AddFile(pBasicToad.CookedPath(TargetContext), basicToad);
		}
	}
}
