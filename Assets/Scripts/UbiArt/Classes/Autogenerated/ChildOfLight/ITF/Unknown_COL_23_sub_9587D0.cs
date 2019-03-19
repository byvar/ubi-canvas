using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_23_sub_9587D0 : CSerializable {
		[Serialize("zoffset")] public float zoffset;
		[Serialize("index"  )] public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(zoffset));
			SerializeField(s, nameof(index));
		}
		public override uint? ClassCRC => 0x9C7EABBB;
	}
}

