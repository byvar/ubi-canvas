namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionTickleGeneric_Template : BTAction_Template {
		public StringID animLaugh;
		public StringID animLaugh_ToStand;
		public float distMinForSwipe = 0.5f;
		public bool disabledTweenOnTickle;
		public bool returnToRootPosition;
		public float returnToRootPositionDuration = 1f;
		public uint lumsByReward = 1;
		public uint countMaxReward = 3;
		public float timeBetweenRewardInSwipe = 0.8f;
		public float laughingTime = 0.1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
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
			} else {
				animLaugh = s.SerializeObject<StringID>(animLaugh, name: "animLaugh");
				animLaugh_ToStand = s.SerializeObject<StringID>(animLaugh_ToStand, name: "animLaugh_ToStand");
				distMinForSwipe = s.Serialize<float>(distMinForSwipe, name: "distMinForSwipe");
				disabledTweenOnTickle = s.Serialize<bool>(disabledTweenOnTickle, name: "disabledTweenOnTickle");
				returnToRootPosition = s.Serialize<bool>(returnToRootPosition, name: "returnToRootPosition");
				returnToRootPositionDuration = s.Serialize<float>(returnToRootPositionDuration, name: "returnToRootPositionDuration");
				lumsByReward = s.Serialize<uint>(lumsByReward, name: "lumsByReward");
				countMaxReward = s.Serialize<uint>(countMaxReward, name: "countMaxReward");
				timeBetweenRewardInSwipe = s.Serialize<float>(timeBetweenRewardInSwipe, name: "timeBetweenRewardInSwipe");
			}
		}
		public override uint? ClassCRC => 0xA8DF0D8F;
	}
}

