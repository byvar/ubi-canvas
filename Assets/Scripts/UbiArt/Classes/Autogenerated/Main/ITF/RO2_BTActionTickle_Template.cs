using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionTickle_Template : BTAction_Template {
		[Serialize("animLaugh_level1"        )] public StringID animLaugh_level1;
		[Serialize("animLaugh_level1ToStand" )] public StringID animLaugh_level1ToStand;
		[Serialize("level1_RemainingTime"    )] public float level1_RemainingTime;
		[Serialize("animLaugh_level2"        )] public StringID animLaugh_level2;
		[Serialize("animLaugh_level2ToStand" )] public StringID animLaugh_level2ToStand;
		[Serialize("level2_RemainingTime"    )] public float level2_RemainingTime;
		[Serialize("animLaugh_level3"        )] public StringID animLaugh_level3;
		[Serialize("animLaugh_level3ToStand" )] public StringID animLaugh_level3ToStand;
		[Serialize("level3_RemainingTime"    )] public float level3_RemainingTime;
		[Serialize("timeBetweenTickle"       )] public float timeBetweenTickle;
		[Serialize("distMinForSwipe"         )] public float distMinForSwipe;
		[Serialize("phantomShapeID"          )] public StringID phantomShapeID;
		[Serialize("lumsByReward"            )] public uint lumsByReward;
		[Serialize("countMaxReward"          )] public uint countMaxReward;
		[Serialize("timeBetweenRewardInSwipe")] public float timeBetweenRewardInSwipe;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animLaugh_level1));
			SerializeField(s, nameof(animLaugh_level1ToStand));
			SerializeField(s, nameof(level1_RemainingTime));
			SerializeField(s, nameof(animLaugh_level2));
			SerializeField(s, nameof(animLaugh_level2ToStand));
			SerializeField(s, nameof(level2_RemainingTime));
			SerializeField(s, nameof(animLaugh_level3));
			SerializeField(s, nameof(animLaugh_level3ToStand));
			SerializeField(s, nameof(level3_RemainingTime));
			SerializeField(s, nameof(timeBetweenTickle));
			SerializeField(s, nameof(distMinForSwipe));
			SerializeField(s, nameof(phantomShapeID));
			SerializeField(s, nameof(lumsByReward));
			SerializeField(s, nameof(countMaxReward));
			SerializeField(s, nameof(timeBetweenRewardInSwipe));
		}
		public override uint? ClassCRC => 0x7DD767E3;
	}
}

