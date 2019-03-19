using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Weapon : W1W_InteractiveGenComponent {
		[Serialize("bool__0"      )] public bool bool__0;
		[Serialize("bool__1"      )] public bool bool__1;
		[Serialize("float__2"     )] public float float__2;
		[Serialize("float__3"     )] public float float__3;
		[Serialize("float__4"     )] public float float__4;
		[Serialize("float__5"     )] public float float__5;
		[Serialize("Path__6"      )] public Path Path__6;
		[Serialize("Path__7"      )] public Path Path__7;
		[Serialize("float__8"     )] public float float__8;
		[Serialize("Enum_VH_0__9" )] public Enum_VH_0 Enum_VH_0__9;
		[Serialize("Enum_VH_1__10")] public Enum_VH_1 Enum_VH_1__10;
		[Serialize("bool__11"     )] public bool bool__11;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(Path__6));
				SerializeField(s, nameof(Path__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(Enum_VH_0__9));
				SerializeField(s, nameof(Enum_VH_1__10));
				SerializeField(s, nameof(bool__11));
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
		public override uint? ClassCRC => 0xBAB6B8D2;
	}
}

