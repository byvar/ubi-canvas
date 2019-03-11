using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventHUDDisplayElem : Event {
		[Serialize("index")] public uint index;
		[Serialize("bShow")] public bool bShow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(index));
			SerializeField(s, nameof(bShow));
		}
		public override uint? ClassCRC => 0x993EE599;
	}
}

