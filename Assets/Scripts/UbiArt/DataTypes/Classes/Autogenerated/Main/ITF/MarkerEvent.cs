namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class MarkerEvent : CSerializable {
		public StringID marker;
		public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			marker = s.SerializeObject<StringID>(marker, name: "marker");
			_event = s.SerializeObject<Generic<Event>>(_event, name: "event");
		}
	}
}

