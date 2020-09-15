using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PersistentGameData_BubbleDreamerData : CSerializable {
		public bool hasMet;
		public bool updateRequested;
		public bool hasWonPetCup;
		public uint teensyLocksOpened;
		public uint challengeLocksOpened;
		public uint tutoCount;
		public CArray<bool> DisplayQuoteStates;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hasMet = s.Serialize<bool>(hasMet, name: "hasMet");
			updateRequested = s.Serialize<bool>(updateRequested, name: "updateRequested");
			hasWonPetCup = s.Serialize<bool>(hasWonPetCup, name: "hasWonPetCup");
			teensyLocksOpened = s.Serialize<uint>(teensyLocksOpened, name: "teensyLocksOpened");
			challengeLocksOpened = s.Serialize<uint>(challengeLocksOpened, name: "challengeLocksOpened");
			tutoCount = s.Serialize<uint>(tutoCount, name: "tutoCount");
			DisplayQuoteStates = s.SerializeObject<CArray<bool>>(DisplayQuoteStates, name: "DisplayQuoteStates");
		}
	}
}

