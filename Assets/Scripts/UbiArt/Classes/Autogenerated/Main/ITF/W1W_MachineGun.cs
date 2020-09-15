using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_MachineGun : ActorComponent {
		public bool bool__0;
		public float float__1;
		public float float__2;
		public Path Path__3;
		public Vec2d Vector2__4;
		public Vec2d Vector2__5;
		public StringID StringID__6;
		public Generic<Event> Generic_Event__7;
		public Generic<Event> Generic_Event__8;
		public Generic<Event> Generic_Event__9;
		public Generic<Event> Generic_Event__10;
		public EventSender EventSender__11;
		public EventSender EventSender__12;
		public bool bool__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			Vector2__4 = s.SerializeObject<Vec2d>(Vector2__4, name: "Vector2__4");
			Vector2__5 = s.SerializeObject<Vec2d>(Vector2__5, name: "Vector2__5");
			StringID__6 = s.SerializeObject<StringID>(StringID__6, name: "StringID__6");
			Generic_Event__7 = s.SerializeObject<Generic<Event>>(Generic_Event__7, name: "Generic_Event__7");
			Generic_Event__8 = s.SerializeObject<Generic<Event>>(Generic_Event__8, name: "Generic_Event__8");
			Generic_Event__9 = s.SerializeObject<Generic<Event>>(Generic_Event__9, name: "Generic_Event__9");
			Generic_Event__10 = s.SerializeObject<Generic<Event>>(Generic_Event__10, name: "Generic_Event__10");
			EventSender__11 = s.SerializeObject<EventSender>(EventSender__11, name: "EventSender__11");
			EventSender__12 = s.SerializeObject<EventSender>(EventSender__12, name: "EventSender__12");
			bool__13 = s.Serialize<bool>(bool__13, name: "bool__13");
		}
		public override uint? ClassCRC => 0x71358457;
	}
}

