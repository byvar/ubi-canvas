namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventConvertRoot : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x89A0422B;
	}
}

