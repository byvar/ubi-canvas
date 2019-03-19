using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionTickleGeneric_Template : BTAction_Template {
		[Serialize("animLaugh"                   )] public StringID animLaugh;
		[Serialize("animLaugh_ToStand"           )] public StringID animLaugh_ToStand;
		[Serialize("distMinForSwipe"             )] public float distMinForSwipe;
		[Serialize("disabledTweenOnTickle"       )] public bool disabledTweenOnTickle;
		[Serialize("returnToRootPosition"        )] public bool returnToRootPosition;
		[Serialize("returnToRootPositionDuration")] public float returnToRootPositionDuration;
		[Serialize("lumsByReward"                )] public uint lumsByReward;
		[Serialize("countMaxReward"              )] public uint countMaxReward;
		[Serialize("timeBetweenRewardInSwipe"    )] public float timeBetweenRewardInSwipe;
		[Serialize("laughingTime"                )] public float laughingTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(animLaugh));
				SerializeField(s, nameof(animLaugh_ToStand));
				SerializeField(s, nameof(laughingTime));
				SerializeField(s, nameof(distMinForSwipe));
				SerializeField(s, nameof(disabledTweenOnTickle));
				SerializeField(s, nameof(returnToRootPosition));
				SerializeField(s, nameof(returnToRootPositionDuration));
				SerializeField(s, nameof(lumsByReward));
				SerializeField(s, nameof(countMaxReward));
				SerializeField(s, nameof(timeBetweenRewardInSwipe));
			} else {
				SerializeField(s, nameof(animLaugh));
				SerializeField(s, nameof(animLaugh_ToStand));
				SerializeField(s, nameof(distMinForSwipe));
				SerializeField(s, nameof(disabledTweenOnTickle));
				SerializeField(s, nameof(returnToRootPosition));
				SerializeField(s, nameof(returnToRootPositionDuration));
				SerializeField(s, nameof(lumsByReward));
				SerializeField(s, nameof(countMaxReward));
				SerializeField(s, nameof(timeBetweenRewardInSwipe));
			}
		}
		public override uint? ClassCRC => 0xA8DF0D8F;
	}
}

