using ITF.ActorComponents;
using ITF.RO2.Bezier.BranchComponents;
using ITF.TweenInstructions;
using ITF.TweenInstructions.Template;
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
			{ 0x79F05C50, typeof(RO2_MultipassTreeRendererComponent) },
			{ 0xADE95483, typeof(RO2_WaterPerturbationComponent) },
			{ 0xB5A9E174, typeof(TweenComponent) },
			{ 0x4890020D, typeof(RO2_GeyserPlatformAIComponent) },
			{ 0x0C928FA3, typeof(RO2_KuyALumsComponent) },
			{ 0x8F11DEDF, typeof(TouchScreenInputComponent) },
			{ 0x2B541820, typeof(PhantomComponent) },
			{ 0x62A12110, typeof(AnimatedComponent) },
			{ 0xFF243AF5, typeof(PolylineComponent) },
			{ 0x2FBA13A8, typeof(RO2_FriendlyBTAIComponent) },
			{ 0x83646F14, typeof(RO2_GroundAIControllerComponent) },
			{ 0xB820D559, typeof(StickToPolylinePhysComponent) },
			{ 0x8401614A, typeof(RO2_PrisonerPostComponent) },
			{ 0xF2DC9CA7, typeof(RO2_BreakablePropsManagerComponent) },
			{ 0x9A275982, typeof(FactionComponent) },
			{ 0xCCD6E553, typeof(RO2_DisplayTutoIconComponent) },
			{ 0xC509F8EE, typeof(RO2_PrisonerCageComponent) },
			{ 0x8A711C28, typeof(RO2_FixedAIComponent) },
			{ 0xAA03F900, typeof(TrajectoryFollowerComponent) },
			{ 0x4E67A312, typeof(RO2_DiggingRegenerationComponent) },
			{ 0x75D611DC, typeof(TrajectoryNodeComponent) },
			{ 0x7A3F8663, typeof(RO2_LumsChainComponent) },
			{ 0x5534CAE2, typeof(CheckpointComponent) },
			{ 0x9EF331FE, typeof(PrefetchTargetComponent) },
			{ 0x35F701E3, typeof(RO2_LeafScrewComponent) },

			// RO2_BezierBranchComponents
			{ 0x19972229, typeof(RO2_BezierBranchGrowComponent) },
			{ 0x12A94E0A, typeof(RO2_BezierBranchFxComponent) },
			{ 0x47D2DED3, typeof(RO2_BezierBranchPolylineComponent) },
			{ 0xCF0F3EF7, typeof(RO2_BezierBranchRendererComponent) },
			{ 0x3BED84D3, typeof(RO2_BezierBranchBoneComponent) },
			{ 0xB3D2DBF2, typeof(RO2_MultipassBranchRendererComponent) },
			{ 0xDB9C4247, typeof(RO2_FlexMeshBranchComponent) },
			{ 0xE40683D3, typeof(RO2_BezierBranchLumsChainLinkRendererComponent) },

			// PhysShape
			{ 0xD1DD9FA9, typeof(PhysShapeBox) },

			// TweenInstruction
			{ 0xC32163AC, typeof(TweenLine) },

			// TweenInstruction_Template
			{ 0x6A97A07E, typeof(TweenLine_Template) },

			// Other
			{ 0xE6A935E1, typeof(GFXMaterialShader_Template) },

			// Unknown
			{ 0x047CADF9, typeof(UnknownComponent1) },
			{ 0xC3233699, typeof(UnknownComponent2) }, // Deprecated in Adventures 3.5.0. Maybe exists before that
			{ 0x68DA00B7, typeof(UnknownDRCComponent) },
		};
	}
}
