using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_5_sub_7925D0 : CSerializable {
		public uint sender;
		public uint setIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
			setIndex = s.Serialize<uint>(setIndex, name: "setIndex");
		}
		public override uint? ClassCRC => 0x572F2AD6;
	}
}

