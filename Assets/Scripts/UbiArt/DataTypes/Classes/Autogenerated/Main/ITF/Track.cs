namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class Track : CSerializable {
		public uint uint__0;
		public CString CString__1;
		public Path Path__2;
		public int int__3;
		public uint uint__4;
		public CListO<TrackPlayerData> CList_TrackPlayerData__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			CString__1 = s.Serialize<CString>(CString__1, name: "CString__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			int__3 = s.Serialize<int>(int__3, name: "int__3");
			uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
			CList_TrackPlayerData__5 = s.SerializeObject<CListO<TrackPlayerData>>(CList_TrackPlayerData__5, name: "CList_TrackPlayerData__5");
		}
		public override uint? ClassCRC => 0xFF1D5160;
	}
}

