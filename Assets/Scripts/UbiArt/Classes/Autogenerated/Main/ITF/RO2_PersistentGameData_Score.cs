using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PersistentGameData_Score : CSerializable {
		public CList<uint> playersLumCount;
		public CList<uint> treasuresLumCount;
		public int localLumsCount;
		public int pendingLumsCount;
		public int tempLumsCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playersLumCount = s.SerializeObject<CList<uint>>(playersLumCount, name: "playersLumCount");
			treasuresLumCount = s.SerializeObject<CList<uint>>(treasuresLumCount, name: "treasuresLumCount");
			localLumsCount = s.Serialize<int>(localLumsCount, name: "localLumsCount");
			pendingLumsCount = s.Serialize<int>(pendingLumsCount, name: "pendingLumsCount");
			tempLumsCount = s.Serialize<int>(tempLumsCount, name: "tempLumsCount");
		}
	}
}

