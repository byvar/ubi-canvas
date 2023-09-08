namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class AnimMarkerTriggerComponent_Template : TriggerComponent_Template {
		public CListO<MarkerEvent> markerEvents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
			} else {
				markerEvents = s.SerializeObject<CListO<MarkerEvent>>(markerEvents, name: "markerEvents");
			}
		}
		public override uint? ClassCRC => 0x5D8DDF58;
	}
}

