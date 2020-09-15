using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class EventPlayerModeChanged : EventTrigger {
		public uint mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mode = s.Serialize<uint>(mode, name: "mode");
		}
		public override uint? ClassCRC => 0x4FAB9E6B;
	}
}

