using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIItemCheck : UIItemBasic {
		public uint isChecked;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isChecked = s.Serialize<uint>(isChecked, name: "isChecked");
		}
		public override uint? ClassCRC => 0x95681E9B;
	}
}

