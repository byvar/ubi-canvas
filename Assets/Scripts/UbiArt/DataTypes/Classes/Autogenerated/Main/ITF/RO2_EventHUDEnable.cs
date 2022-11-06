using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventHUDEnable : Event {
		public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enable = s.Serialize<bool>(enable, name: "enable");
		}
		public override uint? ClassCRC => 0xABC011F0;
	}
}

