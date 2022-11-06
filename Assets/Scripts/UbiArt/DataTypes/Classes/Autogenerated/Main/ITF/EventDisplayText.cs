using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventDisplayText : Event {
		public uint lineId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lineId = s.Serialize<uint>(lineId, name: "lineId");
		}
		public override uint? ClassCRC => 0xB8F76BD8;
	}
}

