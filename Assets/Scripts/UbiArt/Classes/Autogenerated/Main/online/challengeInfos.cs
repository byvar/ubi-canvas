using UnityEngine;

namespace UbiArt.online {
	public partial class challengeInfos : CSerializable {
		[Serialize("seed"                 )] public uint seed;
		[Serialize("timeLeft"             )] public float timeLeft;
		[Serialize("mapPath"              )] public string mapPath;
		[Serialize("configPath"           )] public string configPath;
		[Serialize("canCollect"           )] public bool canCollect;
		[Serialize("challengeRank"        )] public uint challengeRank;
		[Serialize("challengeDate"        )] public string challengeDate;
		[Serialize("challengeTotalPlayers")] public uint challengeTotalPlayers;
		[Serialize("disabledBricks"       )] public CArray<string> disabledBricks;
		[Serialize("tokenCount"           )] public uint tokenCount;
		[Serialize("tokenRechargeTimer"   )] public uint tokenRechargeTimer;
		[Serialize("eventTimeLeft"        )] public float eventTimeLeft;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(seed));
			SerializeField(s, nameof(timeLeft));
			SerializeField(s, nameof(mapPath));
			SerializeField(s, nameof(configPath));
			SerializeField(s, nameof(canCollect));
			SerializeField(s, nameof(challengeRank));
			SerializeField(s, nameof(challengeDate));
			SerializeField(s, nameof(challengeTotalPlayers));
			SerializeField(s, nameof(disabledBricks));
			SerializeField(s, nameof(tokenCount));
			SerializeField(s, nameof(tokenRechargeTimer));
			SerializeField(s, nameof(eventTimeLeft));
		}
	}
}

