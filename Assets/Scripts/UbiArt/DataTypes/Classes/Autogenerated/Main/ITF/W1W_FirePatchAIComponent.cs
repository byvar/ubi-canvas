using System;
namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_FirePatchAIComponent : GraphicComponent {
		public Vec3d Vector3__0;
		public float float__1;
		public float float__2;
		public Enum_VH_0 Enum_VH_0__3;
		public Enum_VH_0 Enum_VH_0__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Vector3__0 = s.SerializeObject<Vec3d>(Vector3__0, name: "Vector3__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			Enum_VH_0__3 = s.Serialize<Enum_VH_0>(Enum_VH_0__3, name: "Enum_VH_0__3");
			Enum_VH_0__4 = s.Serialize<Enum_VH_0>(Enum_VH_0__4, name: "Enum_VH_1__4");
		}
		[Flags]
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

