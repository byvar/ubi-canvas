using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class BossComponent : ActorComponent {
		public Enum_VH_0 Enum_VH_0__0;
		public Enum_VH_1 Enum_VH_1__1;
		public CArrayO<PhaseData> CArray_PhaseData__2;
		public Path Path__3;
		public Path Path__4;
		public Path Path__5;
		public Path Path__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			Enum_VH_1__1 = s.Serialize<Enum_VH_1>(Enum_VH_1__1, name: "Enum_VH_1__1");
			CArray_PhaseData__2 = s.SerializeObject<CArrayO<PhaseData>>(CArray_PhaseData__2, name: "CArray<PhaseData>__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			Path__4 = s.SerializeObject<Path>(Path__4, name: "Path__4");
			Path__5 = s.SerializeObject<Path>(Path__5, name: "Path__5");
			Path__6 = s.SerializeObject<Path>(Path__6, name: "Path__6");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_9" )] Value_9 = 9,
			[Serialize("Value_10")] Value_10 = 10,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_5" )] Value_5 = 5,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_11")] Value_11 = 11,
			[Serialize("Value_12")] Value_12 = 12,
			[Serialize("Value_13")] Value_13 = 13,
			[Serialize("Value_7" )] Value_7 = 7,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xCBEB4E68;
	}
}

