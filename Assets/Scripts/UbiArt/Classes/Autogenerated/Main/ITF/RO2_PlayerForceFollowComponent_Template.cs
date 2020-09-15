using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerForceFollowComponent_Template : ActorComponent_Template {
		[Serialize("sprintDistance"                    )] public float sprintDistance;
		[Serialize("sprintDistanceHysteresis"          )] public float sprintDistanceHysteresis;
		[Serialize("offset"                            )] public Vec2d offset;
		[Serialize("forcePositionMode"                 )] public bool forcePositionMode;
		[Serialize("forcePositionModeDistanceThreshold")] public float forcePositionModeDistanceThreshold;
		[Serialize("forcePositionModeSprintThreshold"  )] public float forcePositionModeSprintThreshold;
		[Serialize("forcePositionModeBlendFactor"      )] public float forcePositionModeBlendFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sprintDistance));
			SerializeField(s, nameof(sprintDistanceHysteresis));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(forcePositionMode));
			SerializeField(s, nameof(forcePositionModeDistanceThreshold));
			SerializeField(s, nameof(forcePositionModeSprintThreshold));
			SerializeField(s, nameof(forcePositionModeBlendFactor));
		}
		public override uint? ClassCRC => 0x2932FAAA;
	}
}

