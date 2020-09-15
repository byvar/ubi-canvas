using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EventDisableAIOrderBT : Event {
		public bool disable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			disable = s.Serialize<bool>(disable, name: "disable");
		}
		public override uint? ClassCRC => 0x412CEF32;
	}
}

