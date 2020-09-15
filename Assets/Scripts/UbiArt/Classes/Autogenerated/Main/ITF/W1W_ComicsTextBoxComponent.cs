using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ComicsTextBoxComponent : UIComponent {
		[Serialize("uint__0"          )] public uint uint__0;
		[Serialize("Vector2__1"       )] public Vec2d Vector2__1;
		[Serialize("Vector2__2"       )] public Vec2d Vector2__2;
		[Serialize("Vector2__3"       )] public Vec2d Vector2__3;
		[Serialize("float__4"         )] public float float__4;
		[Serialize("string__5"        )] public string string__5;
		[Serialize("LocalisationId__6")] public LocalisationId LocalisationId__6;
		[Serialize("Enum_VH_0__7"     )] public Enum_VH_0 Enum_VH_0__7;
		[Serialize("float__8"         )] public float float__8_;
		[Serialize("float__9"         )] public float float__9;
		[Serialize("Color__10"        )] public Color Color__10;
		[Serialize("Enum_VH_1__11"    )] public Enum_VH_1 Enum_VH_1__11;
		[Serialize("Enum_VH_2__12"    )] public Enum_VH_2 Enum_VH_2__12;
		[Serialize("float__13"        )] public float float__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(Vector2__1));
				SerializeField(s, nameof(Vector2__2));
				SerializeField(s, nameof(Vector2__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(string__5));
				SerializeField(s, nameof(LocalisationId__6));
				SerializeField(s, nameof(Enum_VH_0__7));
				SerializeField(s, nameof(float__8_));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(Color__10));
				SerializeField(s, nameof(Enum_VH_1__11));
				SerializeField(s, nameof(Enum_VH_2__12));
				SerializeField(s, nameof(float__13));
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

