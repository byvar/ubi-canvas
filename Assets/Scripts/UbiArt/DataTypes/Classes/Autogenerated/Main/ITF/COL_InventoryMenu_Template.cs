namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryMenu_Template : CSerializable {
		public StringID openLetterFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			openLetterFX = s.SerializeObject<StringID>(openLetterFX, name: "openLetterFX");
		}
		public override uint? ClassCRC => 0x0E6D7F2A;
	}
}

