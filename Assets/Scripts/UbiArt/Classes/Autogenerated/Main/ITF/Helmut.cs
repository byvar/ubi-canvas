using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Helmut : Npc {
		public bool bool__0_;
		public bool bool__1;
		public Enum_VH_0_ Enum_VH_0__2;
		public bool bool__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public Path Path__9;
		public bool bool__10;
		public bool bool__11;
		public float float__12;
		public StringID StringID__13;
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
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				Enum_VH_0__2 = s.Serialize<Enum_VH_0_>(Enum_VH_0__2, name: "Enum_VH_0__2");
				bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				Path__9 = s.SerializeObject<Path>(Path__9, name: "Path__9");
				bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
				bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
				float__12 = s.Serialize<float>(float__12, name: "float__12");
				StringID__13 = s.SerializeObject<StringID>(StringID__13, name: "StringID__13");
				Generic_Event__14 = s.SerializeObject<Generic<Event>>(Generic_Event__14, name: "Generic_Event__14");
				Generic_Event__15 = s.SerializeObject<Generic<Event>>(Generic_Event__15, name: "Generic_Event__15");
				Generic_Event__16 = s.SerializeObject<Generic<Event>>(Generic_Event__16, name: "Generic_Event__16");
				Generic_Event__17 = s.SerializeObject<Generic<Event>>(Generic_Event__17, name: "Generic_Event__17");
				Generic_Event__18 = s.SerializeObject<Generic<Event>>(Generic_Event__18, name: "Generic_Event__18");
				Generic_Event__19 = s.SerializeObject<Generic<Event>>(Generic_Event__19, name: "Generic_Event__19");
				Generic_Event__20 = s.SerializeObject<Generic<Event>>(Generic_Event__20, name: "Generic_Event__20");
				Generic_Event__21 = s.SerializeObject<Generic<Event>>(Generic_Event__21, name: "Generic_Event__21");
				Generic_Event__22 = s.SerializeObject<Generic<Event>>(Generic_Event__22, name: "Generic_Event__22");
				Generic_Event__23 = s.SerializeObject<Generic<Event>>(Generic_Event__23, name: "Generic_Event__23");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				bool__0_ = s.Serialize<bool>(bool__0_, name: "bool__0_");
			}
		}
		public enum Enum_VH_0_ {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public override uint? ClassCRC => 0x677C4A14;
	}
}

