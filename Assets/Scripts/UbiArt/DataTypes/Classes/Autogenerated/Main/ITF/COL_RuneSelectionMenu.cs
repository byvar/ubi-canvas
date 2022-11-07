namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_RuneSelectionMenu : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAFD86CAB;
	}
}

