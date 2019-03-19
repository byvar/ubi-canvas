using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_FirePatchAIComponent : GraphicComponent {
		[Serialize("Vector3__0"  )] public Vector3 Vector3__0;
		[Serialize("float__1"    )] public float float__1;
		[Serialize("float__2"    )] public float float__2;
		[Serialize("Enum_VH_0__3")] public Enum_VH_0 Enum_VH_0__3;
		[Serialize("Enum_VH_1__4")] public Enum_VH_1 Enum_VH_1__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Vector3__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
			SerializeField(s, nameof(Enum_VH_0__3));
			SerializeField(s, nameof(Enum_VH_1__4));
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
		public override uint? ClassCRC => 0x0A890704;
	}
}

