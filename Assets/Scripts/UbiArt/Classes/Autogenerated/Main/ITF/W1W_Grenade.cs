using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Grenade : W1W_ThrowableObject {
		public float float__0;
		public bool bool__1;
		public bool bool__2;
		public bool bool__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public float float__10_;
		public float float__11_;
		public Angle Angle__12;
		public Angle Angle__13;
		public float float__14;
		public float float__15;
		public float float__16;
		public float float__17_;
		public StringID StringID__18;
		public float float__19;
		public Vec2d Vector2__20;
		public Enum_VH_0_ Enum_VH_0__21;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
			bool__3 = s.Serialize<bool>(bool__3, name: "bool__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			float__10_ = s.Serialize<float>(float__10_, name: "float__10_");
			float__11_ = s.Serialize<float>(float__11_, name: "float__11_");
			Angle__12 = s.SerializeObject<Angle>(Angle__12, name: "Angle__12");
			Angle__13 = s.SerializeObject<Angle>(Angle__13, name: "Angle__13");
			float__14 = s.Serialize<float>(float__14, name: "float__14");
			float__15 = s.Serialize<float>(float__15, name: "float__15");
			float__16 = s.Serialize<float>(float__16, name: "float__16");
			float__17_ = s.Serialize<float>(float__17_, name: "float__17_");
			StringID__18 = s.SerializeObject<StringID>(StringID__18, name: "StringID__18");
			float__19 = s.Serialize<float>(float__19, name: "float__19");
			Vector2__20 = s.SerializeObject<Vec2d>(Vector2__20, name: "Vector2__20");
			Enum_VH_0__21 = s.Serialize<Enum_VH_0_>(Enum_VH_0__21, name: "Enum_VH_0__21");
		}
		public enum Enum_VH_0_ {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public override uint? ClassCRC => 0xB22D7F78;
	}
}

