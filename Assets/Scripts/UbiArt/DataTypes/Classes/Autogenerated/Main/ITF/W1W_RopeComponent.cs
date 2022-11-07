namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_RopeComponent : RopeComponent {
		public float float__0;
		public float float__1;
		public float float__2;
		public StringID StringID__3;
		public float float__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
			}
		}
		public override uint? ClassCRC => 0xD79EDA16;
	}
}

