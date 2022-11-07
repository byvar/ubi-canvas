namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_BasculePlatformComponent_Template : ActorComponent_Template {
		public StringID StringID__0;
		public StringID StringID__1;
		public Angle Angle__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public StringID StringID__9;
		public StringID StringID__10;
		public StringID StringID__11;
		public StringID StringID__12;
		public Angle Angle__13;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			Angle__2 = s.SerializeObject<Angle>(Angle__2, name: "Angle__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			StringID__9 = s.SerializeObject<StringID>(StringID__9, name: "StringID__9");
			StringID__10 = s.SerializeObject<StringID>(StringID__10, name: "StringID__10");
			StringID__11 = s.SerializeObject<StringID>(StringID__11, name: "StringID__11");
			StringID__12 = s.SerializeObject<StringID>(StringID__12, name: "StringID__12");
			Angle__13 = s.SerializeObject<Angle>(Angle__13, name: "Angle__13");
		}
		public override uint? ClassCRC => 0xB91AC03E;
	}
}

