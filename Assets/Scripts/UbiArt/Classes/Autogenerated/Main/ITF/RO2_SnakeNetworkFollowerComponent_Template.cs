using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeNetworkFollowerComponent_Template : ActorComponent_Template {
		[Serialize("prevNodeCount"             )] public uint prevNodeCount;
		[Serialize("speedMultiplierMinValue"   )] public float speedMultiplierMinValue;
		[Serialize("speedMultiplierMaxValue"   )] public float speedMultiplierMaxValue;
		[Serialize("speedMultiplierMinDistance")] public float speedMultiplierMinDistance;
		[Serialize("speedMultiplierMaxDistance")] public float speedMultiplierMaxDistance;
		[Serialize("targetEvaluationOffset"    )] public Vec2d targetEvaluationOffset;
		[Serialize("brakeValue"                )] public float brakeValue;
		[Serialize("DBG_speed"                 )] public bool DBG_speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(prevNodeCount));
				SerializeField(s, nameof(speedMultiplierMinValue));
				SerializeField(s, nameof(speedMultiplierMaxValue));
				SerializeField(s, nameof(speedMultiplierMinDistance));
				SerializeField(s, nameof(speedMultiplierMaxDistance));
				SerializeField(s, nameof(targetEvaluationOffset));
			} else {
				SerializeField(s, nameof(prevNodeCount));
				SerializeField(s, nameof(speedMultiplierMinValue));
				SerializeField(s, nameof(speedMultiplierMaxValue));
				SerializeField(s, nameof(speedMultiplierMinDistance));
				SerializeField(s, nameof(speedMultiplierMaxDistance));
				SerializeField(s, nameof(targetEvaluationOffset));
				SerializeField(s, nameof(brakeValue));
				SerializeField(s, nameof(DBG_speed));
			}
		}
		public override uint? ClassCRC => 0x8EDB09D0;
	}
}

