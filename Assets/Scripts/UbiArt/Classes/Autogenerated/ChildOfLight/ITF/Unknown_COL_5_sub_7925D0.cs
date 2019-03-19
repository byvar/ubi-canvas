using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_5_sub_7925D0 : CSerializable {
		[Serialize("sender"  )] public uint sender;
		[Serialize("setIndex")] public uint setIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(setIndex));
		}
		public override uint? ClassCRC => 0x572F2AD6;
	}
}

