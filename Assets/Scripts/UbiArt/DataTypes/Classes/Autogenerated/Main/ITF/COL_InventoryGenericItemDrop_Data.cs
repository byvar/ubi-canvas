namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryGenericItemDrop_Data : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA01B6831;
	}
}

