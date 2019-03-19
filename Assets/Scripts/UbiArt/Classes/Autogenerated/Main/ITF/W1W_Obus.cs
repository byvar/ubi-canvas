using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Obus : ActorComponent {
		[Serialize("float__0"     )] public float float__0;
		[Serialize("float__1"     )] public float float__1;
		[Serialize("float__2"     )] public float float__2;
		[Serialize("float__3"     )] public float float__3;
		[Serialize("float__4"     )] public float float__4;
		[Serialize("float__5"     )] public float float__5;
		[Serialize("float__6"     )] public float float__6;
		[Serialize("bool__7"      )] public bool bool__7;
		[Serialize("float__8"     )] public float float__8;
		[Serialize("float__9"     )] public float float__9;
		[Serialize("Path__10"     )] public Path Path__10;
		[Serialize("bool__11"     )] public bool bool__11;
		[Serialize("bool__12"     )] public bool bool__12;
		[Serialize("float__13"    )] public float float__13;
		[Serialize("float__14"    )] public float float__14;
		[Serialize("Angle__15"    )] public Angle Angle__15;
		[Serialize("float__16"    )] public float float__16;
		[Serialize("float__17"    )] public float float__17;
		[Serialize("float__18"    )] public float float__18;
		[Serialize("Vector2__19"  )] public Vector2 Vector2__19;
		[Serialize("Vector2__20"  )] public Vector2 Vector2__20;
		[Serialize("Enum_VH_0__21")] public Enum_VH_0 Enum_VH_0__21;
		[Serialize("Enum_VH_1__22")] public Enum_VH_1 Enum_VH_1__22;
		[Serialize("Enum_VH_2__23")] public Enum_VH_2 Enum_VH_2__23;
		[Serialize("StringID__24" )] public StringID StringID__24;
		[Serialize("bool__25"     )] public bool bool__25;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(bool__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(Path__10));
				SerializeField(s, nameof(bool__11));
				SerializeField(s, nameof(bool__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(Angle__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(float__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(Vector2__19));
				SerializeField(s, nameof(Vector2__20));
				SerializeField(s, nameof(Enum_VH_0__21));
				SerializeField(s, nameof(Enum_VH_1__22));
				SerializeField(s, nameof(Enum_VH_2__23));
				SerializeField(s, nameof(StringID__24));
				SerializeField(s, nameof(bool__25));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_7" )] Value_7 = 7,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_14")] Value_14 = 14,
		}
		public enum Enum_VH_2 {
			[Serialize("Value_0"   )] Value_0 = 0,
			[Serialize("Value_1038")] Value_1038 = 1038,
			[Serialize("Value_4"   )] Value_4 = 4,
			[Serialize("Value_2"   )] Value_2 = 2,
			[Serialize("Value_8"   )] Value_8 = 8,
		}
		public override uint? ClassCRC => 0xFB548025;
	}
}

