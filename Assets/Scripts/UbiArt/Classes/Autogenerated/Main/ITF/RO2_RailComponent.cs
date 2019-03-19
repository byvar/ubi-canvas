using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RailComponent : ActorComponent {
		[Serialize("limitLeft"           )] public float limitLeft;
		[Serialize("limitRight"          )] public float limitRight;
		[Serialize("extremityLeftOffset" )] public float extremityLeftOffset;
		[Serialize("extremityRightOffset")] public float extremityRightOffset;
		[Serialize("initPos"             )] public float initPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(limitLeft));
				SerializeField(s, nameof(limitRight));
				SerializeField(s, nameof(extremityLeftOffset));
				SerializeField(s, nameof(extremityRightOffset));
				SerializeField(s, nameof(initPos));
			}
		}
		public override uint? ClassCRC => 0x278C80D1;
	}
}

