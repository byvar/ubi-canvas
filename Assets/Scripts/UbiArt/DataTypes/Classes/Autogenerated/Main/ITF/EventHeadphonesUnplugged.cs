namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventHeadphonesUnplugged : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC41915FE;
	}
}

