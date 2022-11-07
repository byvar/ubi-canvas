namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class BodyPartActorRenderer_Template : CSerializable {
		public Path Path__0;
		public StringID StringID__1;
		public StringID StringID__2;
		public StringID StringID__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
			StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
		}
	}
}

