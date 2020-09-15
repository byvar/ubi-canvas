using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventPlayMovie : Event {
		public bool play;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			play = s.Serialize<bool>(play, name: "play");
		}
		public override uint? ClassCRC => 0x2F8DA1FF;
	}
}

