using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WaterHandsAIComponent : Ray_AIComponent {
		[Serialize("rangeMaxDetect")] public float rangeMaxDetect;
		[Serialize("isDead"        )] public int isDead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(rangeMaxDetect));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isDead));
			}
		}
		public override uint? ClassCRC => 0x28FBB2C1;
	}
}

