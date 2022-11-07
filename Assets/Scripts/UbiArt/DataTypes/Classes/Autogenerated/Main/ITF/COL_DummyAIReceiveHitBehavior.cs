namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DummyAIReceiveHitBehavior : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x55A4A0C5;
	}
}

