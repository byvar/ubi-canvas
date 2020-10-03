using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ScopeFireOrder : ActorComponent {
		public uint uint__0;
		public Enum_VH_0 Enum_VH_0__1;
		public float float__2;
		public float float__3;
		public Generic<Event> Generic_Event__4;
		public Generic<Event> Generic_Event__5;
		public Generic<Event> Generic_Event__6;
		public Generic<Event> Generic_Event__7;
		public Generic<Event> Generic_Event__8;
		public Generic<Event> Generic_Event__9;
		public Generic<Event> Generic_Event__10;
		public Generic<Event> Generic_Event__11;
		public Generic<Event> Generic_Event__12;
		public Generic<Event> Generic_Event__13;
		public Generic<Event> Generic_Event__14;
		public Generic<Event> Generic_Event__15;
		public Generic<Event> Generic_Event__16;
		public Generic<Event> Generic_Event__17;
		public Generic<Event> Generic_Event__18;
		public Generic<Event> Generic_Event__19;
		public Generic<Event> Generic_Event__20;
		public Generic<Event> Generic_Event__21;
		public Generic<Event> Generic_Event__22;
		public Generic<Event> Generic_Event__23;
		public Generic<Event> Generic_Event__24;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			Generic_Event__4 = s.SerializeObject<Generic<Event>>(Generic_Event__4, name: "Generic<Event>__4");
			Generic_Event__5 = s.SerializeObject<Generic<Event>>(Generic_Event__5, name: "Generic<Event>__5");
			Generic_Event__6 = s.SerializeObject<Generic<Event>>(Generic_Event__6, name: "Generic<Event>__6");
			Generic_Event__7 = s.SerializeObject<Generic<Event>>(Generic_Event__7, name: "Generic<Event>__7");
			Generic_Event__8 = s.SerializeObject<Generic<Event>>(Generic_Event__8, name: "Generic<Event>__8");
			Generic_Event__9 = s.SerializeObject<Generic<Event>>(Generic_Event__9, name: "Generic<Event>__9");
			Generic_Event__10 = s.SerializeObject<Generic<Event>>(Generic_Event__10, name: "Generic<Event>__10");
			Generic_Event__11 = s.SerializeObject<Generic<Event>>(Generic_Event__11, name: "Generic<Event>__11");
			Generic_Event__12 = s.SerializeObject<Generic<Event>>(Generic_Event__12, name: "Generic<Event>__12");
			Generic_Event__13 = s.SerializeObject<Generic<Event>>(Generic_Event__13, name: "Generic<Event>__13");
			Generic_Event__14 = s.SerializeObject<Generic<Event>>(Generic_Event__14, name: "Generic<Event>__14");
			Generic_Event__15 = s.SerializeObject<Generic<Event>>(Generic_Event__15, name: "Generic<Event>__15");
			Generic_Event__16 = s.SerializeObject<Generic<Event>>(Generic_Event__16, name: "Generic<Event>__16");
			Generic_Event__17 = s.SerializeObject<Generic<Event>>(Generic_Event__17, name: "Generic<Event>__17");
			Generic_Event__18 = s.SerializeObject<Generic<Event>>(Generic_Event__18, name: "Generic<Event>__18");
			Generic_Event__19 = s.SerializeObject<Generic<Event>>(Generic_Event__19, name: "Generic<Event>__19");
			Generic_Event__20 = s.SerializeObject<Generic<Event>>(Generic_Event__20, name: "Generic<Event>__20");
			Generic_Event__21 = s.SerializeObject<Generic<Event>>(Generic_Event__21, name: "Generic<Event>__21");
			Generic_Event__22 = s.SerializeObject<Generic<Event>>(Generic_Event__22, name: "Generic<Event>__22");
			Generic_Event__23 = s.SerializeObject<Generic<Event>>(Generic_Event__23, name: "Generic<Event>__23");
			Generic_Event__24 = s.SerializeObject<Generic<Event>>(Generic_Event__24, name: "Generic<Event>__24");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xB4C3A986;
	}
}

