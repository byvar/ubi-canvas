namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionMedusaTickle_Template : BTAction_Template {
		public StringID animLaugh;
		public StringID animLaugh_ToStand;
		public float laughingTime;
		public float distMinForSwipe;
		public bool disabledTweenOnTickle;
		public bool returnToRootPosition;
		public float returnToRootPositionDuration;
		public uint lumsByReward;
		public uint countMaxReward;
		public float timeBetweenRewardInSwipe;
		public float holdTimeToDoTickle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animLaugh = s.SerializeObject<StringID>(animLaugh, name: "animLaugh");
			animLaugh_ToStand = s.SerializeObject<StringID>(animLaugh_ToStand, name: "animLaugh_ToStand");
			laughingTime = s.Serialize<float>(laughingTime, name: "laughingTime");
			distMinForSwipe = s.Serialize<float>(distMinForSwipe, name: "distMinForSwipe");
			disabledTweenOnTickle = s.Serialize<bool>(disabledTweenOnTickle, name: "disabledTweenOnTickle");
			returnToRootPosition = s.Serialize<bool>(returnToRootPosition, name: "returnToRootPosition");
			returnToRootPositionDuration = s.Serialize<float>(returnToRootPositionDuration, name: "returnToRootPositionDuration");
			lumsByReward = s.Serialize<uint>(lumsByReward, name: "lumsByReward");
			countMaxReward = s.Serialize<uint>(countMaxReward, name: "countMaxReward");
			timeBetweenRewardInSwipe = s.Serialize<float>(timeBetweenRewardInSwipe, name: "timeBetweenRewardInSwipe");
			holdTimeToDoTickle = s.Serialize<float>(holdTimeToDoTickle, name: "holdTimeToDoTickle");
		}
		public override uint? ClassCRC => 0x745F2ED5;
	}
}

