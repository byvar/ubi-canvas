namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PlayerIDInfo : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3A93E76C;
	}
}

