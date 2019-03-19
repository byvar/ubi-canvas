using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class BossComponent : ActorComponent {
		[Serialize("Enum_VH_0__0"        )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("Enum_VH_1__1"        )] public Enum_VH_1 Enum_VH_1__1;
		[Serialize("CArray<PhaseData>__2")] public CArray<PhaseData> CArray_PhaseData__2;
		[Serialize("Path__3"             )] public Path Path__3;
		[Serialize("Path__4"             )] public Path Path__4;
		[Serialize("Path__5"             )] public Path Path__5;
		[Serialize("Path__6"             )] public Path Path__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Enum_VH_0__0));
			SerializeField(s, nameof(Enum_VH_1__1));
			SerializeField(s, nameof(CArray_PhaseData__2));
			SerializeField(s, nameof(Path__3));
			SerializeField(s, nameof(Path__4));
			SerializeField(s, nameof(Path__5));
			SerializeField(s, nameof(Path__6));
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

