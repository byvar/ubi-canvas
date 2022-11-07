namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class EventPolylineChanged : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1EEC7477;
	}
}

