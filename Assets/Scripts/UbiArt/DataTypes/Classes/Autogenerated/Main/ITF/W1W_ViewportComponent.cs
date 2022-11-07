namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_ViewportComponent : ViewportUIComponent {
		public Enum_VH_0 Enum_VH_0__0;
		public Vec3d Vector3__1;
		public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			Vector3__1 = s.SerializeObject<Vec3d>(Vector3__1, name: "Vector3__1");
			bool__2 = s.Serialize<bool>(bool__2, name: "bool__2");
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x0EC4EFCD;
	}
}

