namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionTickle_Template : BTAction_Template {
		public StringID animLaugh_level1;
		public StringID animLaugh_level1ToStand;
		public float level1_RemainingTime = 2f;
		public StringID animLaugh_level2;
		public StringID animLaugh_level2ToStand;
		public float level2_RemainingTime = 2f;
		public StringID animLaugh_level3;
		public StringID animLaugh_level3ToStand;
		public float level3_RemainingTime = 2f;
		public float timeBetweenTickle = 0.1f;
		public float distMinForSwipe = 0.5f;
		public StringID phantomShapeID;
		public uint lumsByReward = 1;
		public uint countMaxReward = 3;
		public float timeBetweenRewardInSwipe = 0.8f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animLaugh_level1 = s.SerializeObject<StringID>(animLaugh_level1, name: "animLaugh_level1");
			animLaugh_level1ToStand = s.SerializeObject<StringID>(animLaugh_level1ToStand, name: "animLaugh_level1ToStand");
			level1_RemainingTime = s.Serialize<float>(level1_RemainingTime, name: "level1_RemainingTime");
			animLaugh_level2 = s.SerializeObject<StringID>(animLaugh_level2, name: "animLaugh_level2");
			animLaugh_level2ToStand = s.SerializeObject<StringID>(animLaugh_level2ToStand, name: "animLaugh_level2ToStand");
			level2_RemainingTime = s.Serialize<float>(level2_RemainingTime, name: "level2_RemainingTime");
			animLaugh_level3 = s.SerializeObject<StringID>(animLaugh_level3, name: "animLaugh_level3");
			animLaugh_level3ToStand = s.SerializeObject<StringID>(animLaugh_level3ToStand, name: "animLaugh_level3ToStand");
			level3_RemainingTime = s.Serialize<float>(level3_RemainingTime, name: "level3_RemainingTime");
			timeBetweenTickle = s.Serialize<float>(timeBetweenTickle, name: "timeBetweenTickle");
			distMinForSwipe = s.Serialize<float>(distMinForSwipe, name: "distMinForSwipe");
			phantomShapeID = s.SerializeObject<StringID>(phantomShapeID, name: "phantomShapeID");
			lumsByReward = s.Serialize<uint>(lumsByReward, name: "lumsByReward");
			countMaxReward = s.Serialize<uint>(countMaxReward, name: "countMaxReward");
			timeBetweenRewardInSwipe = s.Serialize<float>(timeBetweenRewardInSwipe, name: "timeBetweenRewardInSwipe");
		}
		public override uint? ClassCRC => 0x7DD767E3;
	}
}

