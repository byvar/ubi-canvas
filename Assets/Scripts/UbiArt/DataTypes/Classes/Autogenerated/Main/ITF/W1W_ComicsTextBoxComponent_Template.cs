namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ComicsTextBoxComponent_Template : UIComponent_Template {
		public CArrayO<FontTextArea.Style> CArray_FontTextArea_Style__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			CArray_FontTextArea_Style__0 = s.SerializeObject<CArrayO<FontTextArea.Style>>(CArray_FontTextArea_Style__0, name: "CArray<FontTextArea.Style>__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0x8D0FE2DD;
	}
}

