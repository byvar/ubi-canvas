using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ComicsTextBoxComponent : UIComponent {
		public uint uint__0;
		public Vec2d Vector2__1;
		public Vec2d Vector2__2;
		public Vec2d Vector2__3;
		public float float__4;
		public string string__5;
		public LocalisationId LocalisationId__6;
		public Enum_VH_0 Enum_VH_0__7;
		public float float__8_;
		public float float__9;
		public Color Color__10;
		public Enum_VH_1 Enum_VH_1__11;
		public Enum_VH_2 Enum_VH_2__12;
		public float float__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				Vector2__1 = s.SerializeObject<Vec2d>(Vector2__1, name: "Vector2__1");
				Vector2__2 = s.SerializeObject<Vec2d>(Vector2__2, name: "Vector2__2");
				Vector2__3 = s.SerializeObject<Vec2d>(Vector2__3, name: "Vector2__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				string__5 = s.Serialize<string>(string__5, name: "string__5");
				LocalisationId__6 = s.SerializeObject<LocalisationId>(LocalisationId__6, name: "LocalisationId__6");
				Enum_VH_0__7 = s.Serialize<Enum_VH_0>(Enum_VH_0__7, name: "Enum_VH_0__7");
				float__8_ = s.Serialize<float>(float__8_, name: "float__8");
				float__9 = s.Serialize<float>(float__9, name: "float__9");
				Color__10 = s.SerializeObject<Color>(Color__10, name: "Color__10");
				Enum_VH_1__11 = s.Serialize<Enum_VH_1>(Enum_VH_1__11, name: "Enum_VH_1__11");
				Enum_VH_2__12 = s.Serialize<Enum_VH_2>(Enum_VH_2__12, name: "Enum_VH_2__12");
				float__13 = s.Serialize<float>(float__13, name: "float__13");
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_VH_1 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
		}
		public enum Enum_VH_2 {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x5DEA78B0;
	}
}

