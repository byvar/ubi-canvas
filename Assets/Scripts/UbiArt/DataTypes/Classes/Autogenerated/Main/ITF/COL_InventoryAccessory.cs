namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryAccessory : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD8A5D06B;
	}
}

