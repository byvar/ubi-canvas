using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventTeleport : Event {
		public bool applyPosAndAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			applyPosAndAngle = s.Serialize<bool>(applyPosAndAngle, name: "applyPosAndAngle");
		}
		public override uint? ClassCRC => 0x4017E956;
	}
}

