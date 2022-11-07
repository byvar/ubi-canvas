namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_BeatboxDataList : CSerializable {
		public CListO<RLC_BeatboxData> BeatboxDataList;
		public uint Day;
		public uint Month;
		public uint Year;
		public bool FavoriteTrack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BeatboxDataList = s.SerializeObject<CListO<RLC_BeatboxData>>(BeatboxDataList, name: "BeatboxDataList");
			Day = s.Serialize<uint>(Day, name: "Day");
			Month = s.Serialize<uint>(Month, name: "Month");
			Year = s.Serialize<uint>(Year, name: "Year");
			FavoriteTrack = s.Serialize<bool>(FavoriteTrack, name: "FavoriteTrack");
		}
	}
}

