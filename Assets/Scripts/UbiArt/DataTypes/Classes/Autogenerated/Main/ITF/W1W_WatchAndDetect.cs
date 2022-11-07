namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_WatchAndDetect : ActorComponent {
		public float float__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public bool bool__4;
		public Generic<Event> Generic_Event__5;
		public Generic<Event> Generic_Event__6;
		public Generic<Event> Generic_Event__7;
		public Generic<Event> Generic_Event__8;
		public EventSender EventSender__9;
		public EventSender EventSender__10;
		public EventSender EventSender__11;
		public EventSender EventSender__12;
		public EventSender EventSender__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
			Generic_Event__5 = s.SerializeObject<Generic<Event>>(Generic_Event__5, name: "Generic<Event>__5");
			Generic_Event__6 = s.SerializeObject<Generic<Event>>(Generic_Event__6, name: "Generic<Event>__6");
			Generic_Event__7 = s.SerializeObject<Generic<Event>>(Generic_Event__7, name: "Generic<Event>__7");
			Generic_Event__8 = s.SerializeObject<Generic<Event>>(Generic_Event__8, name: "Generic<Event>__8");
			EventSender__9 = s.SerializeObject<EventSender>(EventSender__9, name: "EventSender__9");
			EventSender__10 = s.SerializeObject<EventSender>(EventSender__10, name: "EventSender__10");
			EventSender__11 = s.SerializeObject<EventSender>(EventSender__11, name: "EventSender__11");
			EventSender__12 = s.SerializeObject<EventSender>(EventSender__12, name: "EventSender__12");
			EventSender__13 = s.SerializeObject<EventSender>(EventSender__13, name: "EventSender__13");
		}
		public override uint? ClassCRC => 0xC139C1E6;
	}
}

