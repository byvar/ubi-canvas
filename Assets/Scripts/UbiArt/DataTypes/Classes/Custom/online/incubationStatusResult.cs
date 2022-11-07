namespace UbiArt.online {
	public partial class incubationStatusResult : CSerializable {
		public DateTime hatchingEnd;
		public float timeLeft;
		public StringID creatureId;
		public uint eggAdventureSequence;
		public uint eggAdventureRegion;
		public bool autoHatch;
		public uint decoyRewardType;
		public ITF.RLC_LuckyTicketReward decoyReward;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hatchingEnd = s.SerializeObject<DateTime>(hatchingEnd, name: "hatchingEnd");
			timeLeft = s.Serialize<float>(timeLeft, name: "timeLeft");
			creatureId = s.SerializeObject<StringID>(creatureId, name: "creatureId");
			eggAdventureSequence = s.Serialize<uint>(eggAdventureSequence, name: "eggAdventureSequence");
			eggAdventureRegion = s.Serialize<uint>(eggAdventureRegion, name: "eggAdventureRegion");
			autoHatch = s.Serialize<bool>(autoHatch, name: "autoHatch");
			decoyRewardType = s.Serialize<uint>(decoyRewardType, name: "decoyRewardType");
		}
	}
}

