using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_OnlineEventChangeVisual : Event {
		public char colorID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			colorID = s.Serialize<char>(colorID, name: "colorID");
		}
		public override uint? ClassCRC => 0x6D646F31;
	}
}

