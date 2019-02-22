using ITF.ActorComponents;
using ITF.RO2.Bezier.BranchComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITF {
	public class ClassCRC {
		public static Dictionary<uint, Type> classes = new Dictionary<uint, Type> {
			// Actors
			{ 0x97CA628B, typeof(Actor) },
			{ 0x4FA40F09, typeof(SubSceneActor) },

			// Frise
			{ 0xFEEFD98D, typeof(FriseConfig) },

			// ActorComponents
			{ 0x28C01093, typeof(PlayerDetectorComponent) },
			{ 0x5E302A40, typeof(TriggerComponent) },
			{ 0x8D4FFFB6, typeof(FXControllerComponent) },
			{ 0x7DD8643C, typeof(SoundComponent) },
			{ 0x44376F1B, typeof(LinkComponent) },
			{ 0x93D66A6E, typeof(MaskResolverComponent) },
			{ 0xA466E579, typeof(FogBoxComponent) },
			{ 0x966B519D, typeof(FxBankComponent) },
			{ 0xF51360DA, typeof(BoxInterpolatorComponent) },
			{ 0x2B349E69, typeof(AFXPostProcessComponent) },
			{ 0xAEBB218B, typeof(ClearColorComponent) },
			{ 0x9189C777, typeof(ProceduralBoneComponent) },
			{ 0x760B164E, typeof(RO2_BezierTreeComponent) },

			// RO2_BezierBranchComponents
			{ 0x19972229, typeof(RO2_BezierBranchGrowComponent) },
			{ 0x12A94E0A, typeof(RO2_BezierBranchFxComponent) },

			// Other
			{ 0xE6A935E1, typeof(GFXMaterialShader_Template) },

			// Unknown
			{ 0x047CADF9, typeof(UnknownComponent1) },
		};
	}
}
