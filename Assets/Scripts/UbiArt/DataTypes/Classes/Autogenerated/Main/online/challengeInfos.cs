using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class challengeInfos : CSerializable {
		public uint seed;
		public float timeLeft;
		public string mapPath;
		public string configPath;
		public bool canCollect;
		public uint challengeRank;
		public string challengeDate;
		public uint challengeTotalPlayers;
		public CArrayP<string> disabledBricks;
		public uint tokenCount;
		public uint tokenRechargeTimer;
		public float eventTimeLeft;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			seed = s.Serialize<uint>(seed, name: "seed");
			timeLeft = s.Serialize<float>(timeLeft, name: "timeLeft");
			mapPath = s.Serialize<string>(mapPath, name: "mapPath");
			configPath = s.Serialize<string>(configPath, name: "configPath");
			canCollect = s.Serialize<bool>(canCollect, name: "canCollect");
			challengeRank = s.Serialize<uint>(challengeRank, name: "challengeRank");
			challengeDate = s.Serialize<string>(challengeDate, name: "challengeDate");
			challengeTotalPlayers = s.Serialize<uint>(challengeTotalPlayers, name: "challengeTotalPlayers");
			disabledBricks = s.SerializeObject<CArrayP<string>>(disabledBricks, name: "disabledBricks");
			tokenCount = s.Serialize<uint>(tokenCount, name: "tokenCount");
			tokenRechargeTimer = s.Serialize<uint>(tokenRechargeTimer, name: "tokenRechargeTimer");
			eventTimeLeft = s.Serialize<float>(eventTimeLeft, name: "eventTimeLeft");
		}
	}
}

