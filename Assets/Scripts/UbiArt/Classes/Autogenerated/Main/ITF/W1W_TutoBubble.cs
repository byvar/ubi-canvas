using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TutoBubble : ActorComponent {
		public Enum_VH_0 Enum_VH_0__0;
		public bool bool__1;
		public float float__2;
		public float float__3;
		public bool bool__4;
		public bool bool__5;
		public bool bool__6;
		public Vec2d Vector2__7;
		public Vec3d Vector3__8;
		public Vec3d Vector3__9;
		public bool bool__10;
		public Enum_VH_1 Enum_VH_1__11;
		public Generic<Event> Generic_Event__12;
		public Generic<Event> Generic_Event__13;
		public Generic<Event> Generic_Event__14;
		public Generic<Event> Generic_Event__15;
		public bool bool__16;
		public StringID StringID__17;
		public StringID StringID__18;
		public StringID StringID__19;
		public StringID StringID__20;
		public bool bool__21;
		public bool bool__22;
		public Margin Margin__23;
		public float float__24;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				bool__4 = s.Serialize<bool>(bool__4, name: "bool__4");
				bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
				bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
				Vector2__7 = s.SerializeObject<Vec2d>(Vector2__7, name: "Vector2__7");
				Vector3__8 = s.SerializeObject<Vec3d>(Vector3__8, name: "Vector3__8");
				Vector3__9 = s.SerializeObject<Vec3d>(Vector3__9, name: "Vector3__9");
				bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
				Enum_VH_1__11 = s.Serialize<Enum_VH_1>(Enum_VH_1__11, name: "Enum_VH_1__11");
				Generic_Event__12 = s.SerializeObject<Generic<Event>>(Generic_Event__12, name: "Generic_Event__12");
				Generic_Event__13 = s.SerializeObject<Generic<Event>>(Generic_Event__13, name: "Generic_Event__13");
				Generic_Event__14 = s.SerializeObject<Generic<Event>>(Generic_Event__14, name: "Generic_Event__14");
				Generic_Event__15 = s.SerializeObject<Generic<Event>>(Generic_Event__15, name: "Generic_Event__15");
				bool__16 = s.Serialize<bool>(bool__16, name: "bool__16");
				StringID__17 = s.SerializeObject<StringID>(StringID__17, name: "StringID__17");
				StringID__18 = s.SerializeObject<StringID>(StringID__18, name: "StringID__18");
				StringID__19 = s.SerializeObject<StringID>(StringID__19, name: "StringID__19");
				StringID__20 = s.SerializeObject<StringID>(StringID__20, name: "StringID__20");
				bool__21 = s.Serialize<bool>(bool__21, name: "bool__21");
				bool__22 = s.Serialize<bool>(bool__22, name: "bool__22");
				Margin__23 = s.SerializeObject<Margin>(Margin__23, name: "Margin__23");
				float__24 = s.Serialize<float>(float__24, name: "float__24");
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xC019AF6A;
	}
}

