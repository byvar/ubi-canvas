namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PersistentGameData_Score : CSerializable {
		public CListP<uint> playersLumCount;
		public CListP<uint> treasuresLumCount;
		public int localLumsCount;
		public int pendingLumsCount;
		public int tempLumsCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playersLumCount = s.SerializeObject<CListP<uint>>(playersLumCount, name: "playersLumCount");
			treasuresLumCount = s.SerializeObject<CListP<uint>>(treasuresLumCount, name: "treasuresLumCount");
			localLumsCount = s.Serialize<int>(localLumsCount, name: "localLumsCount");
			pendingLumsCount = s.Serialize<int>(pendingLumsCount, name: "pendingLumsCount");
			tempLumsCount = s.Serialize<int>(tempLumsCount, name: "tempLumsCount");
		}
	}
}

