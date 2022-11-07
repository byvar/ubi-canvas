namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryMenu : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8B75D7BE;
	}
}

