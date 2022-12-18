namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_EventConvertRoot : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4E0EFE1D;
	}
}

