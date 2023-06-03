namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class TeleporterVisualTrail : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x02520B9C;
	}
}

