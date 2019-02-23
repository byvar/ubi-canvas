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
			{ 0x5F5A7A5B, typeof(RO2_BezierTreeRendererComponent) },
			{ 0xA6E4EFBA, typeof(AnimLightComponent) },
			{ 0x97C46CE1, typeof(AnimMeshVertexComponent) },
			{ 0xFBF865C3, typeof(RO2_AnimMeshVertexManagerComponent) },
			{ 0xB0493A6E, typeof(DummyComponent) },
			{ 0x6C8DD66E, typeof(CameraModifierComponent) },
			{ 0xB227E11E, typeof(RO2_CameraLimiterComponent) },
			{ 0x13E9D108, typeof(TextBoxComponent) },

			// RO2_BezierBranchComponents
			{ 0x19972229, typeof(RO2_BezierBranchGrowComponent) },
			{ 0x12A94E0A, typeof(RO2_BezierBranchFxComponent) },
			{ 0x47D2DED3, typeof(RO2_BezierBranchPolylineComponent) },
			{ 0xCF0F3EF7, typeof(RO2_BezierBranchRendererComponent) },
			{ 0x3BED84D3, typeof(RO2_BezierBranchBoneComponent) },

			// Other
			{ 0xE6A935E1, typeof(GFXMaterialShader_Template) },

			// Unknown
			{ 0x047CADF9, typeof(UnknownComponent1) },
			{ 0x68DA00B7, typeof(UnknownDRCComponent) },
		};
	}
}
