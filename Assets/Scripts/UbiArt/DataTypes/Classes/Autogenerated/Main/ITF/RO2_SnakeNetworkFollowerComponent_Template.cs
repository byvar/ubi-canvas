using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SnakeNetworkFollowerComponent_Template : ActorComponent_Template {
		public uint prevNodeCount;
		public float speedMultiplierMinValue;
		public float speedMultiplierMaxValue;
		public float speedMultiplierMinDistance;
		public float speedMultiplierMaxDistance;
		public Vec2d targetEvaluationOffset;
		public float brakeValue;
		public bool DBG_speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				prevNodeCount = s.Serialize<uint>(prevNodeCount, name: "prevNodeCount");
				speedMultiplierMinValue = s.Serialize<float>(speedMultiplierMinValue, name: "speedMultiplierMinValue");
				speedMultiplierMaxValue = s.Serialize<float>(speedMultiplierMaxValue, name: "speedMultiplierMaxValue");
				speedMultiplierMinDistance = s.Serialize<float>(speedMultiplierMinDistance, name: "speedMultiplierMinDistance");
				speedMultiplierMaxDistance = s.Serialize<float>(speedMultiplierMaxDistance, name: "speedMultiplierMaxDistance");
				targetEvaluationOffset = s.SerializeObject<Vec2d>(targetEvaluationOffset, name: "targetEvaluationOffset");
			} else {
				prevNodeCount = s.Serialize<uint>(prevNodeCount, name: "prevNodeCount");
				speedMultiplierMinValue = s.Serialize<float>(speedMultiplierMinValue, name: "speedMultiplierMinValue");
				speedMultiplierMaxValue = s.Serialize<float>(speedMultiplierMaxValue, name: "speedMultiplierMaxValue");
				speedMultiplierMinDistance = s.Serialize<float>(speedMultiplierMinDistance, name: "speedMultiplierMinDistance");
				speedMultiplierMaxDistance = s.Serialize<float>(speedMultiplierMaxDistance, name: "speedMultiplierMaxDistance");
				targetEvaluationOffset = s.SerializeObject<Vec2d>(targetEvaluationOffset, name: "targetEvaluationOffset");
				brakeValue = s.Serialize<float>(brakeValue, name: "brakeValue");
				DBG_speed = s.Serialize<bool>(DBG_speed, name: "DBG_speed");
			}
		}
		public override uint? ClassCRC => 0x8EDB09D0;
	}
}

