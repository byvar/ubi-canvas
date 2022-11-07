namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AlliesMenu : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD1D0EDB5;
	}
}

