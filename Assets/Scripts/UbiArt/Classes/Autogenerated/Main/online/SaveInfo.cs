using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SaveInfo : CSerializable {
		public string pid;
		public uint slot;
		public uint saveUniqueId;
		public bool forceNewGame;
		public string save;
		public string msdkData;
		public uint saveGameVersionFormat;
		public CMap<StringID, StringID> populations;
		public bool iap;
		public float iapPrediction;
		public CArray<string> reco;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pid = s.Serialize<string>(pid, name: "pid");
			slot = s.Serialize<uint>(slot, name: "slot");
			saveUniqueId = s.Serialize<uint>(saveUniqueId, name: "saveUniqueId");
			forceNewGame = s.Serialize<bool>(forceNewGame, name: "forceNewGame");
			save = s.Serialize<string>(save, name: "save");
			msdkData = s.Serialize<string>(msdkData, name: "msdkData");
			saveGameVersionFormat = s.Serialize<uint>(saveGameVersionFormat, name: "saveGameVersionFormat");
			populations = s.SerializeObject<CMap<StringID, StringID>>(populations, name: "populations");
			iap = s.Serialize<bool>(iap, name: "iap");
			iapPrediction = s.Serialize<float>(iapPrediction, name: "iapPrediction");
			reco = s.SerializeObject<CArray<string>>(reco, name: "reco");
			reco = s.SerializeObject<CArray<string>>(reco, name: "reco");
		}
	}
}

