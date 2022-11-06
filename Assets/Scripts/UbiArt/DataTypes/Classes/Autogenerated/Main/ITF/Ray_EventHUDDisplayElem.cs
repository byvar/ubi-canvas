using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventHUDDisplayElem : Event {
		public uint index;
		public int bShow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			index = s.Serialize<uint>(index, name: "index");
			bShow = s.Serialize<int>(bShow, name: "bShow");
		}
		public override uint? ClassCRC => 0x993EE599;
	}
}

