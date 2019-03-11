using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionMedusaTickle_Template : BTAction_Template {
		[Serialize("animLaugh"                   )] public StringID animLaugh;
		[Serialize("animLaugh_ToStand"           )] public StringID animLaugh_ToStand;
		[Serialize("laughingTime"                )] public float laughingTime;
		[Serialize("distMinForSwipe"             )] public float distMinForSwipe;
		[Serialize("disabledTweenOnTickle"       )] public bool disabledTweenOnTickle;
		[Serialize("returnToRootPosition"        )] public bool returnToRootPosition;
		[Serialize("returnToRootPositionDuration")] public float returnToRootPositionDuration;
		[Serialize("lumsByReward"                )] public uint lumsByReward;
		[Serialize("countMaxReward"              )] public uint countMaxReward;
		[Serialize("timeBetweenRewardInSwipe"    )] public float timeBetweenRewardInSwipe;
		[Serialize("holdTimeToDoTickle"          )] public float holdTimeToDoTickle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
			SerializeField(s, nameof(holdTimeToDoTickle));
		}
		public override uint? ClassCRC => 0x745F2ED5;
	}
}

