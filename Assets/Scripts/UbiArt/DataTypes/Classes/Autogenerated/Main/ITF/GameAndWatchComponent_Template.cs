namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GameAndWatchComponent_Template : ActorComponent_Template {
		public Curve2D Curve2D__0;
		public Curve2D Curve2D__1;
		public float float__2;
		public Color Color__3;
		public float float__4;
		public uint uint__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Curve2D__0 = s.SerializeObject<Curve2D>(Curve2D__0, name: "Curve2D__0");
			Curve2D__1 = s.SerializeObject<Curve2D>(Curve2D__1, name: "Curve2D__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			Color__3 = s.SerializeObject<Color>(Color__3, name: "Color__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			uint__5 = s.Serialize<uint>(uint__5, name: "uint__5");
		}
		public override uint? ClassCRC => 0x0AAB0AF8;
	}
}

