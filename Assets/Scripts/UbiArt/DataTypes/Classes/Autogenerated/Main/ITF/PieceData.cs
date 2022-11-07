namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class PieceData : CSerializable {
		public Path Path__0;
		public StringID StringID__1;
		public int int__2;
		public int int__3;
		public StringID StringID__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			int__2 = s.Serialize<int>(int__2, name: "int__2");
			int__3 = s.Serialize<int>(int__3, name: "int__3");
			StringID__4 = s.SerializeObject<StringID>(StringID__4, name: "StringID__4");
		}
	}
}

