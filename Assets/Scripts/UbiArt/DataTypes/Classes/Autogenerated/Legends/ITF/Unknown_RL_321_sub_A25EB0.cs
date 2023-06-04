namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class TeleporterVisualTrailData : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4A1B8350;
	}
}

