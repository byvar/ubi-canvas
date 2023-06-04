namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class TeleporterSimpleTrailData : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCBF6527B;
	}
}

