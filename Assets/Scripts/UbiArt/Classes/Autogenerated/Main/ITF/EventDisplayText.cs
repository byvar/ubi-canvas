using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class EventDisplayText : Event {
		[Serialize("lineId")] public uint lineId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lineId));
		}
		public override uint? ClassCRC => 0xB8F76BD8;
	}
}

