using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventShowScoreboard : Event {
		[Serialize("display")] public int display;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(display));
		}
		public override uint? ClassCRC => 0xF87620F8;
	}
}

