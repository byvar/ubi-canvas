namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_MoteurVentilateur : ActorComponent {
		public bool bool__0;
		public float float__1;
		public float float__2;
		public StringID StringID__3;
		public StringID StringID__4;
		public StringID StringID__5;
		public float float__6;
		public float float__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
			StringID__4 = s.SerializeObject<StringID>(StringID__4, name: "StringID__4");
			StringID__5 = s.SerializeObject<StringID>(StringID__5, name: "StringID__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
		}
		public override uint? ClassCRC => 0x9342C7BD;
	}
}

