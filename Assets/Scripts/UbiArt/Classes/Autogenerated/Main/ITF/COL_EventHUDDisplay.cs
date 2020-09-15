using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventHUDDisplay : Event {
		public bool display;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			display = s.Serialize<bool>(display, name: "display", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x0CDC5F75;
	}
}

