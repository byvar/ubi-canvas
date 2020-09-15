using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_12_sub_5EF500 : CSerializable {
		public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0xA9771495;
	}
}

