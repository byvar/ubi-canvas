using UnityEngine;

namespace UbiArt.online {
	public partial class incubationStatusResult : CSerializable {
		[Serialize("hatchingEnd")] public DateTime hatchingEnd;
		[Serialize("timeLeft")] public float timeLeft;
		[Serialize("creatureId")] public StringID creatureId;
		[Serialize("eggAdventureSequence")] public uint eggAdventureSequence;
		[Serialize("eggAdventureRegion")] public uint eggAdventureRegion;
		[Serialize("autoHatch")] public bool autoHatch;
		[Serialize("decoyRewardType")] public uint decoyRewardType;
		[Serialize("decoyReward")] public ITF.RLC_LuckyTicketReward decoyReward;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hatchingEnd));
			SerializeField(s, nameof(timeLeft));
			SerializeField(s, nameof(creatureId));
			SerializeField(s, nameof(eggAdventureSequence));
			SerializeField(s, nameof(eggAdventureRegion));
			SerializeField(s, nameof(autoHatch));
			SerializeField(s, nameof(decoyRewardType));
		}
	}
}

