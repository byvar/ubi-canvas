using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventDisplayText : CSerializable {
		[Serialize("lineId")] public uint lineId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lineId));
		}
		public override uint? ClassCRC => 0xB8F76BD8;
	}
}

