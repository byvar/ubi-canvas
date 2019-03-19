using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventStartCinematicDialog : CSerializable {
		[Serialize("sender")] public uint sender;
		[Serialize("data"  )] public Placeholder data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(data));
		}
		public override uint? ClassCRC => 0x8E0A0EFF;
	}
}

