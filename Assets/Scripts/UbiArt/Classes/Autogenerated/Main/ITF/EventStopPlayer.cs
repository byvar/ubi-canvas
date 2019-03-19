using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventStopPlayer : Event {
		[Serialize("stop")] public int stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stop));
		}
		public override uint? ClassCRC => 0xC8D691F9;
	}
}

