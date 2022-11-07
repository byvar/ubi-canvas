namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_ActiveProfileMenu : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDB1BA4A8;
	}
}

