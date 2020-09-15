using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIBTOrderComponent : ActorComponent {
		public bool enabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enabled = s.Serialize<bool>(enabled, name: "enabled");
		}
		public override uint? ClassCRC => 0x3B9C29D8;
	}
}

