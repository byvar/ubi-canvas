using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ComicsTextBoxComponent_Template : UIComponent_Template {
		[Serialize("CArray<FontTextArea.Style>__0")] public CArray<FontTextArea.Style> CArray_FontTextArea_Style__0;
		[Serialize("float__1"                     )] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CArray_FontTextArea_Style__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0x8D0FE2DD;
	}
}

