using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class PlayerCreatureList : CSerializable {
		public CList<ITF.RO2_PersistentGameData_Universe.RLC_CreatureData> creatures;
		public incubationStatusResult incubationData;
		public string profileId;
		public uint iapScore;
		public online.DateTime joinDate;
		public bool devTeam;
		public bool onBoardingFinished;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			creatures = s.SerializeObject<CList<ITF.RO2_PersistentGameData_Universe.RLC_CreatureData>>(creatures, name: "creatures");
			incubationData = s.SerializeObject<incubationStatusResult>(incubationData, name: "incubationData");
			profileId = s.Serialize<string>(profileId, name: "profileId");
			iapScore = s.Serialize<uint>(iapScore, name: "iapScore");
			joinDate = s.SerializeObject<online.DateTime>(joinDate, name: "joinDate");
			devTeam = s.Serialize<bool>(devTeam, name: "devTeam");
			onBoardingFinished = s.Serialize<bool>(onBoardingFinished, name: "onBoardingFinished");
		}
	}
}

