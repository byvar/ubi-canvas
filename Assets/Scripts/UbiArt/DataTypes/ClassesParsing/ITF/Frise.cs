using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace UbiArt.ITF {
	public partial class Frise {
		public GenericFile<FriseConfig> config;
		public FriseOrigins.FriseConfigOrigins configOrigins;
		public GenericFile<GFXMaterialShader_Template> shader;

		protected override void OnPostSerialize(CSerializerObject s) {
			base.OnPostSerialize(s);
			if (IsFirstLoad) {
				Loader l = s.Context.Loader;

				l.LoadFile<GenericFile<GFXMaterialShader_Template>>(MatShader, result => shader = result);

				if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
					l.LoadFile<GenericFile<FriseConfig>>(ConfigName, result => {
						config = result;
						if (config != null)
							templatePickable = config.obj;
					});
				} else {
					l.LoadFile<FriseOrigins.FriseConfigOrigins>(ConfigName, result => {
						configOrigins = result;
					});
				}
			}
		}

		protected override void Reinit(Context c, Settings settings) {
			if (previousSettings != null) {
				if (previousSettings.game != settings.game) {
					if ((previousSettings.game == Settings.Game.RA || previousSettings.game == Settings.Game.RM) &&
						!(settings.game == Settings.Game.RA || settings.game == Settings.Game.RM)) {
						// Check components
						if (COMPONENTS != null && COMPONENTS.Count > 0) {
							c.SystemLogger?.LogWarning($"Frise with components: {USERFRIENDLY}");
						}
						// Check parentBind
						if (parentBind != null && !parentBind.IsNull) {
							c.SystemLogger?.LogWarning($"Frise with parentBind: {USERFRIENDLY}");
						}
					}
				}
			}
			base.Reinit(c, settings);
		}

		public SubSceneActor CreateParentActor() {
			var parent = Merger.Merge<SubSceneActor>(this);
			parent.LUA = new Path(SubSceneActor.DefaultPath);
			parent.EMBED_SCENE = true;
			parent.SCENE = new Nullable<Scene>() {
				read = true,
				value = new Scene() {
					FRISE = new CListO<Frise>()
				}
			};
			parent.SCENE.value.FRISE.Add(this);
			//parent.USERFRIENDLY = $"{USERFRIENDLY}__friseparent";
			//parent.ZFORCED = true;
			//parent.IS_SINGLE_PIECE = true;
			//parent.DIRECT_PICKING = false;

			// Reset transform as it has been assigned to the subsceneactor
			parentBind = null;
			isEnabled = true;
			xFLIPPED = false;
			POS2D = null;
			SCALE = Vec2d.One;
			RELATIVEZ = 0;
			ANGLE = null;

			return parent;
		}
		public bool ShouldCreateParentActor(Settings settings) {
			if (!(settings.game == Settings.Game.RA || settings.game == Settings.Game.RM)) {
				if(parentBind != null && parentBind.read == true)
					return true;
			}
			return false;
		}

		protected void RecomputeLineData() {
			PointsList?.CheckLoop();
			PointsList?.RecomputeData();
		}

		public void Recompute() {
			RecomputeLineData();
			if(config?.obj == null) return;
			var friseConfig = config?.obj;

			// Init datas
			RecomputeData recomputeData = new RecomputeData(this);

			var method = (FriseMethode)friseConfig.methode;
			// TODO
			switch (method) {
				case FriseMethode.Generic:
					break;
			}
		}

		private void BuildFrieze_InGeneric(RecomputeData recomputeData) {
			recomputeData.CopyEdgesFromPolyline();
			// TODO:
		}

		public enum FriseMethode : uint {
			 Roundness = 0,
			 Generic,
			 Extremity,
			 Archi,
			 Fluid,
			 Pipe,
			 ExtremitySimple,
			 String,
			 Atlas,
			 Overlay,
			 Frame,
			 ArchiSimple,
			 PipePatchSimple,
			 Extremity13,
			 Bezier3D,
		}
	}
}
