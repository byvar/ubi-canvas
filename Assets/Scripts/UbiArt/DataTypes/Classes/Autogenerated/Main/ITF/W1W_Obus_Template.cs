namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Obus_Template : ActorComponent_Template {
		public Path Path__0;
		public float float__1;
		public GFXMaterialSerializable GFXMaterialSerializable__2;
		public Curve2D Curve2D__3;
		public Curve2D Curve2D__4;
		public bool bool__5;
		public float float__6;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			}
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			GFXMaterialSerializable__2 = s.SerializeObject<GFXMaterialSerializable>(GFXMaterialSerializable__2, name: "GFXMaterialSerializable__2");
			Curve2D__3 = s.SerializeObject<Curve2D>(Curve2D__3, name: "Curve2D__3");
			Curve2D__4 = s.SerializeObject<Curve2D>(Curve2D__4, name: "Curve2D__4");
			bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
		}
		public override uint? ClassCRC => 0x15EADA71;
	}
}

