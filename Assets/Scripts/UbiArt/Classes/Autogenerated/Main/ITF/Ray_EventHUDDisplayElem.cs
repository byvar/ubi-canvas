using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventHUDDisplayElem : Event {
		[Serialize("index")] public uint index;
		[Serialize("bShow")] public int bShow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(index));
			SerializeField(s, nameof(bShow));
		}
		public override uint? ClassCRC => 0x993EE599;
	}
}

