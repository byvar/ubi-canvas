using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LeafsComponent : ActorComponent {
		public bool triggered;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				triggered = s.Serialize<bool>(triggered, name: "triggered");
			}
		}
		public override uint? ClassCRC => 0x6B0FCCDB;
	}
}

