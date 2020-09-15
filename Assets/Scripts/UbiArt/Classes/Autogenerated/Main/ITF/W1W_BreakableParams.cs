using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BreakableParams : CSerializable {
		public Enum_VH_0 Enum_VH_0__0;
		public StringID StringID__1;
		public CArray<Generic<Event>> CArray_Generic_Event__2;
		public float float__3;
		public Enum_VH_1 Enum_VH_1__4;
		public Enum_VH_2 Enum_VH_2__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			CArray_Generic_Event__2 = s.SerializeObject<CArray<Generic<Event>>>(CArray_Generic_Event__2, name: "CArray_Generic_Event__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			Enum_VH_1__4 = s.Serialize<Enum_VH_1>(Enum_VH_1__4, name: "Enum_VH_1__4");
			Enum_VH_2__5 = s.Serialize<Enum_VH_2>(Enum_VH_2__5, name: "Enum_VH_2__5");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0"  )] Value_0 = 0,
			[Serialize("Value_1"  )] Value_1 = 1,
			[Serialize("Value_2"  )] Value_2 = 2,
			[Serialize("Value_4"  )] Value_4 = 4,
			[Serialize("Value_8"  )] Value_8 = 8,
			[Serialize("Value_12" )] Value_12 = 12,
			[Serialize("Value_14" )] Value_14 = 14,
			[Serialize("Value_16" )] Value_16 = 16,
			[Serialize("Value_32" )] Value_32 = 32,
			[Serialize("Value_33" )] Value_33 = 33,
			[Serialize("Value_64" )] Value_64 = 64,
			[Serialize("Value_128")] Value_128 = 128,
			[Serialize("Value__1" )] Value__1 = -1,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_VH_2 {
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
	}
}

