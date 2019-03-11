using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIItemCheck : UIItemBasic {
		[Serialize("isChecked")] public uint isChecked;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isChecked));
		}
		public override uint? ClassCRC => 0x95681E9B;
	}
}

