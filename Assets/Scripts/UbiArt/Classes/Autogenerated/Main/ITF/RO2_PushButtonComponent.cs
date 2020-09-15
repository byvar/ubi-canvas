using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PushButtonComponent : ActorComponent {
		public bool triggerOnStick;
		public bool triggerOnHit;
		public bool triggerOnDRC;
		public uint triggerCount;
		public uint activator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					triggerOnStick = s.Serialize<bool>(triggerOnStick, name: "triggerOnStick");
					triggerOnHit = s.Serialize<bool>(triggerOnHit, name: "triggerOnHit");
					triggerOnDRC = s.Serialize<bool>(triggerOnDRC, name: "triggerOnDRC");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					activator = s.Serialize<uint>(activator, name: "activator");
					triggerCount = s.Serialize<uint>(triggerCount, name: "triggerCount");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					triggerOnStick = s.Serialize<bool>(triggerOnStick, name: "triggerOnStick");
					triggerOnHit = s.Serialize<bool>(triggerOnHit, name: "triggerOnHit");
					triggerOnDRC = s.Serialize<bool>(triggerOnDRC, name: "triggerOnDRC");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					triggerCount = s.Serialize<uint>(triggerCount, name: "triggerCount");
				}
			}
		}
		public override uint? ClassCRC => 0xA841D201;
	}
}

