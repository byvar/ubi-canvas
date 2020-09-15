using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventPause : Event {
		public bool pause;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pause = s.Serialize<bool>(pause, name: "pause");
		}
		public override uint? ClassCRC => 0x31779023;
	}
}

