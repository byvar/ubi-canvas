namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PersistentGameData_Universe : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5B2CDE55;
	}
}

