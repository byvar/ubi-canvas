namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_SpawnFxRand : ShapeComponent {
		public StringID StringID__0;
		public float float__1;
		public float float__2;
		public Path Path__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
		}
		public override uint? ClassCRC => 0x9614DB43;
	}
}

