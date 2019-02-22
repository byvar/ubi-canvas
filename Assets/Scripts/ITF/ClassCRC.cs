using ITF.ActorComponents;
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

			// Unknown
			{ 0x047CADF9, typeof(UnknownComponent1) },
		};
	}
}
