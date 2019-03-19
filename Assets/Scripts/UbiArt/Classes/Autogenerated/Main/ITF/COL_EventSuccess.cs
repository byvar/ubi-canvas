using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventSuccess : CSerializable {
		[Serialize("sender")] public uint sender;
		[Serialize("index" )] public uint index;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(index));
		}
		public override uint? ClassCRC => 0x8A276CA1;
	}
}

