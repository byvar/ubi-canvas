using UnityEngine;

namespace UbiArt.online {
	public partial class PlayerCreatureList : CSerializable {
		[Serialize("creatures"         )] public CList<ITF.RO2_PersistentGameData_Universe.RLC_CreatureData> creatures;
		[Serialize("incubationData"    )] public incubationStatusResult incubationData;
		[Serialize("profileId"         )] public string profileId;
		[Serialize("iapScore"          )] public uint iapScore;
		[Serialize("joinDate"          )] public online.DateTime joinDate;
		[Serialize("devTeam"           )] public bool devTeam;
		[Serialize("onBoardingFinished")] public bool onBoardingFinished;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(creatures));
			SerializeField(s, nameof(incubationData));
			SerializeField(s, nameof(profileId));
			SerializeField(s, nameof(iapScore));
			SerializeField(s, nameof(joinDate));
			SerializeField(s, nameof(devTeam));
			SerializeField(s, nameof(onBoardingFinished));
		}
	}
}

