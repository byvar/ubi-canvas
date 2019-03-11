using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TeleportPortalComponent : ActorComponent {
		[Serialize("oneWay")] public bool oneWay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(oneWay));
			}
		}
		public override uint? ClassCRC => 0x3A5A0D4E;
	}
}

