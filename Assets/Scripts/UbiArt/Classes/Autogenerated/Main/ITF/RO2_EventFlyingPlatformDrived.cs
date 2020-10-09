using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventFlyingPlatformDrived : Event {
		public bool isDrived;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isDrived = s.Serialize<bool>(isDrived, name: "isDrived");
		}
		public override uint? ClassCRC => 0x7CA504A9;
	}
}

