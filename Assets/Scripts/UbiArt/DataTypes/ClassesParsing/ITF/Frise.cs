using System.Collections.Generic;

namespace UbiArt.ITF {
	public partial class Frise {
		public GenericFile<FriseConfig> config;
		public FriseOrigins.FriseConfigOrigins configOrigins;
		public GenericFile<GFXMaterialShader_Template> shader;

		public Frise() {
			Thickness = 1f;
			lockTexture = LockTexture.None;
			animSpeedFactor = 1f;
			animAmplitudeFactor = 1f;
			highlightFrontLightBrightness = 1.5f;
			highlightOutlineWidth = 4f;
			highlightPeriod = 1f;
			highlightAmplitude = 0.21f;
			highlightOutlineColor = Color.White;
			XfForCook = new Transform2d() {
				Rot = new matrix2d() {
					Col1 = new Vec2d(1f, 0f),
					Col2 = new Vec2d(0f, 1f)
				}
			};
			UseTemplatePrimitiveParams = true;
			uvY_Tile = 1f;

		}

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
