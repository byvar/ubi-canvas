namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TriggerEventCountComponent_Template : ActorComponent_Template {
		public Generic<Event> eventToCount;
		public Generic<Event> eventToSend;
		public bool useGenerics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				eventToCount = s.SerializeObject<Generic<Event>>(eventToCount, name: "eventToCount");
				eventToSend = s.SerializeObject<Generic<Event>>(eventToSend, name: "eventToSend");
				useGenerics = s.Serialize<bool>(useGenerics, name: "useGenerics", options: CSerializerObject.Options.BoolAsByte);
			} else {
				eventToCount = s.SerializeObject<Generic<Event>>(eventToCount, name: "eventToCount");
				eventToSend = s.SerializeObject<Generic<Event>>(eventToSend, name: "eventToSend");
			}
		}
		public override uint? ClassCRC => 0x609B3DB2;
	}
}

