namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryArmor : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1BDC2A8D;
	}
}

