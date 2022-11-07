namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FeedbackHUD : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8B4150A6;
	}
}

