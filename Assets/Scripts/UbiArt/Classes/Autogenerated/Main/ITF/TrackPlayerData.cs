using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class TrackPlayerData : CSerializable {
		[Serialize("Enum_RFR_0__0")] public Enum_RFR_0 Enum_RFR_0__0;
		[Serialize("int__1"       )] public int int__1;
		[Serialize("int__2"       )] public int int__2;
		[Serialize("Vector3__3"   )] public Vec3d Vector3__3;
		[Serialize("float__4"     )] public float float__4;
		[Serialize("float__5"     )] public float float__5;
		[Serialize("Vector3__6"   )] public Vec3d Vector3__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_RFR_0__0));
			SerializeField(s, nameof(int__1));
			SerializeField(s, nameof(int__2));
			SerializeField(s, nameof(Vector3__3));
			SerializeField(s, nameof(float__4));
			SerializeField(s, nameof(float__5));
			SerializeField(s, nameof(Vector3__6));
		}
		public enum Enum_RFR_0 {
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
			[Serialize("Value_15")] Value_15 = 15,
			[Serialize("Value_16")] Value_16 = 16,
			[Serialize("Value_17")] Value_17 = 17,
			[Serialize("Value_18")] Value_18 = 18,
		}
	}
}

