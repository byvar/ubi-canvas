using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_GunShot : ActorComponent {
		[Serialize("bool__0"     )] public bool bool__0;
		[Serialize("Path__1"     )] public Path Path__1;
		[Serialize("Enum_VH_0__2")] public Enum_VH_0 Enum_VH_0__2;
		[Serialize("uint__3"     )] public uint uint__3;
		[Serialize("uint__4"     )] public uint uint__4;
		[Serialize("float__5"    )] public float float__5;
		[Serialize("float__6"    )] public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(Path__1));
				SerializeField(s, nameof(Enum_VH_0__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(uint__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
			}
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
		public override uint? ClassCRC => 0xCCECE843;
	}
}

