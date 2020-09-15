using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventStopPlayer : Event {
		public int stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stop = s.Serialize<int>(stop, name: "stop");
		}
		public override uint? ClassCRC => 0xC8D691F9;
	}
}

