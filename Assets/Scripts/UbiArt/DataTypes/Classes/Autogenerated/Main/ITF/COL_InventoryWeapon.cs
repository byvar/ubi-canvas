namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryWeapon : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x81D58F48;
	}
}

