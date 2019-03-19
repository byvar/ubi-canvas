using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventHUDDisplay : CSerializable {
		[Serialize("sender" )] public uint sender;
		[Serialize("display")] public bool display;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(display), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x0CDC5F75;
	}
}

