namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class TeleporterPlayerTransformation : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x10C542B6;
	}
}

