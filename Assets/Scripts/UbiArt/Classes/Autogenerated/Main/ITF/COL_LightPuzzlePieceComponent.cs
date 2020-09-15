using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightPuzzlePieceComponent : CSerializable {
		public float shadowActivationRadius;
		public float distanceFactor;
		public float receptorRadius;
		public StringID fxSolved;
		public StringID fxFailed;
		public StringID fxReset;
		public StringID fxCasterIlluminated;
		public StringID objectState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				shadowActivationRadius = s.Serialize<float>(shadowActivationRadius, name: "shadowActivationRadius");
				distanceFactor = s.Serialize<float>(distanceFactor, name: "distanceFactor");
				receptorRadius = s.Serialize<float>(receptorRadius, name: "receptorRadius");
				fxSolved = s.SerializeObject<StringID>(fxSolved, name: "fxSolved");
				fxFailed = s.SerializeObject<StringID>(fxFailed, name: "fxFailed");
				fxReset = s.SerializeObject<StringID>(fxReset, name: "fxReset");
				fxCasterIlluminated = s.SerializeObject<StringID>(fxCasterIlluminated, name: "fxCasterIlluminated");
				objectState = s.SerializeObject<StringID>(objectState, name: "objectState");
			}
		}
		public override uint? ClassCRC => 0xB5B66226;
	}
}

