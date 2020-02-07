using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PersistentGameData_BubbleDreamerData : CSerializable {
		[Serialize("hasMet"              )] public bool hasMet;
		[Serialize("updateRequested"     )] public bool updateRequested;
		[Serialize("hasWonPetCup"        )] public bool hasWonPetCup;
		[Serialize("teensyLocksOpened"   )] public uint teensyLocksOpened;
		[Serialize("challengeLocksOpened")] public uint challengeLocksOpened;
		[Serialize("tutoCount"           )] public uint tutoCount;
		[Serialize("DisplayQuoteStates"  )] public CArray<bool> DisplayQuoteStates;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hasMet));
			SerializeField(s, nameof(updateRequested));
			SerializeField(s, nameof(hasWonPetCup));
			SerializeField(s, nameof(teensyLocksOpened));
			SerializeField(s, nameof(challengeLocksOpened));
			SerializeField(s, nameof(tutoCount));
			SerializeField(s, nameof(DisplayQuoteStates));
		}
	}
}

