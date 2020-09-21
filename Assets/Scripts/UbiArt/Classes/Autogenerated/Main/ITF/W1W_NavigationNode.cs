using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_NavigationNode : TrajectoryNodeComponent {
		public StringID StringID__0;
		public float float__1;
		public bool bool__2;
		public bool bool__3;
		public StringID StringID__4;
		public Enum_VH_0 Enum_VH_0__5;
		public CArrayO<EventSender> CArray_EventSender__6;
		public CArrayO<EventSender> CArray_EventSender__7;
		public Generic<Event> Generic_Event__8;
		public StringID StringID__9;
		public bool bool__10;
		public Enum_VH_1 Enum_VH_1__11;
		public Enum_VH_2 Enum_VH_2__12;
		public StringID StringID__13;
		public StringID StringID__14;
		public bool bool__15;
		public bool bool__16;
		public float float__17;
		public float float__18;
		public StringID StringID__19;
		public Enum_VH_1 Enum_VH_1__20;
		public float float__21;
		public StringID StringID__22;
		public Generic<Event> Generic_Event__23;
		public bool bool__24;
		public bool bool__25;
		public bool bool__26;
		public Path Path__27;
		public bool bool__28;
		public Color Color__29;
		public float float__30;
		public bool bool__31;
		public Color Color__32;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			StringID__4 = s.SerializeObject<StringID>(StringID__4, name: "StringID__4");
			Enum_VH_0__5 = s.Serialize<Enum_VH_0>(Enum_VH_0__5, name: "Enum_VH_0__5");
			CArray_EventSender__6 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__6, name: "CArray_EventSender__6");
			CArray_EventSender__7 = s.SerializeObject<CArrayO<EventSender>>(CArray_EventSender__7, name: "CArray_EventSender__7");
			Generic_Event__8 = s.SerializeObject<Generic<Event>>(Generic_Event__8, name: "Generic_Event__8");
			StringID__9 = s.SerializeObject<StringID>(StringID__9, name: "StringID__9");
			bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
			Enum_VH_1__11 = s.Serialize<Enum_VH_1>(Enum_VH_1__11, name: "Enum_VH_1__11");
			Enum_VH_2__12 = s.Serialize<Enum_VH_2>(Enum_VH_2__12, name: "Enum_VH_2__12");
			StringID__13 = s.SerializeObject<StringID>(StringID__13, name: "StringID__13");
			StringID__14 = s.SerializeObject<StringID>(StringID__14, name: "StringID__14");
			bool__15 = s.Serialize<bool>(bool__15, name: "bool__15");
			bool__16 = s.Serialize<bool>(bool__16, name: "bool__16");
			float__17 = s.Serialize<float>(float__17, name: "float__17");
			float__18 = s.Serialize<float>(float__18, name: "float__18");
			StringID__19 = s.SerializeObject<StringID>(StringID__19, name: "StringID__19");
			Enum_VH_1__20 = s.Serialize<Enum_VH_1>(Enum_VH_1__20, name: "Enum_VH_1__20");
			float__21 = s.Serialize<float>(float__21, name: "float__21");
			StringID__22 = s.SerializeObject<StringID>(StringID__22, name: "StringID__22");
			Generic_Event__23 = s.SerializeObject<Generic<Event>>(Generic_Event__23, name: "Generic_Event__23");
			bool__24 = s.Serialize<bool>(bool__24, name: "bool__24");
			bool__25 = s.Serialize<bool>(bool__25, name: "bool__25");
			bool__26 = s.Serialize<bool>(bool__26, name: "bool__26");
			Path__27 = s.SerializeObject<Path>(Path__27, name: "Path__27");
			bool__28 = s.Serialize<bool>(bool__28, name: "bool__28");
			Color__29 = s.SerializeObject<Color>(Color__29, name: "Color__29");
			float__30 = s.Serialize<float>(float__30, name: "float__30");
			bool__31 = s.Serialize<bool>(bool__31, name: "bool__31");
			Color__32 = s.SerializeObject<Color>(Color__32, name: "Color__32");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		[Flags]
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_2 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x51B409B1;
	}
}

