using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class SaveInfo : CSerializable {
		[Serialize("pid"                  )] public string pid;
		[Serialize("slot"                 )] public uint slot;
		[Serialize("saveUniqueId"         )] public uint saveUniqueId;
		[Serialize("forceNewGame"         )] public bool forceNewGame;
		[Serialize("save"                 )] public string save;
		[Serialize("msdkData"             )] public string msdkData;
		[Serialize("saveGameVersionFormat")] public uint saveGameVersionFormat;
		[Serialize("populations"          )] public CMap<StringID, StringID> populations;
		[Serialize("iap"                  )] public bool iap;
		[Serialize("iapPrediction"        )] public float iapPrediction;
		[Serialize("reco"                 )] public CArray<string> reco;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pid));
			SerializeField(s, nameof(slot));
			SerializeField(s, nameof(saveUniqueId));
			SerializeField(s, nameof(forceNewGame));
			SerializeField(s, nameof(save));
			SerializeField(s, nameof(msdkData));
			SerializeField(s, nameof(saveGameVersionFormat));
			SerializeField(s, nameof(populations));
			SerializeField(s, nameof(iap));
			SerializeField(s, nameof(iapPrediction));
			SerializeField(s, nameof(reco));
			SerializeField(s, nameof(reco));
		}
	}
}

