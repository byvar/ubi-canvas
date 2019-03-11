using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FishingRodComponent : ActorComponent {
		[Serialize("isDead")] public bool isDead;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(isDead));
			}
		}
		public override uint? ClassCRC => 0x5C0B28A8;
	}
}

