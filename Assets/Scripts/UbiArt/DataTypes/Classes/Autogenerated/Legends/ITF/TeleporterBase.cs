namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class TeleporterBase : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB9C127BE;
	}
}

