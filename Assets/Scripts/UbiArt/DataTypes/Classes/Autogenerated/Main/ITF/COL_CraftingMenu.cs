namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CraftingMenu : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAB5C1FEB;
	}
}

