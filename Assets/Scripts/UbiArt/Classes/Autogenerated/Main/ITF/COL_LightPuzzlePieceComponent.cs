using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightPuzzlePieceComponent : CSerializable {
		[Serialize("shadowActivationRadius")] public float shadowActivationRadius;
		[Serialize("distanceFactor"        )] public float distanceFactor;
		[Serialize("receptorRadius"        )] public float receptorRadius;
		[Serialize("fxSolved"              )] public StringID fxSolved;
		[Serialize("fxFailed"              )] public StringID fxFailed;
		[Serialize("fxReset"               )] public StringID fxReset;
		[Serialize("fxCasterIlluminated"   )] public StringID fxCasterIlluminated;
		[Serialize("objectState"           )] public StringID objectState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(shadowActivationRadius));
				SerializeField(s, nameof(distanceFactor));
				SerializeField(s, nameof(receptorRadius));
				SerializeField(s, nameof(fxSolved));
				SerializeField(s, nameof(fxFailed));
				SerializeField(s, nameof(fxReset));
				SerializeField(s, nameof(fxCasterIlluminated));
				SerializeField(s, nameof(objectState));
			}
		}
		public override uint? ClassCRC => 0xB5B66226;
	}
}

