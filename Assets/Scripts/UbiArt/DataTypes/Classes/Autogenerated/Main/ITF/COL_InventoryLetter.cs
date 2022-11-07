namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_InventoryLetter : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE0C11985;
	}
}

