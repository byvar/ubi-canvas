namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SnakeNetworkFollowerComponent_Template : ActorComponent_Template {
		public uint prevNodeCount;
		public float speedMultiplierMinValue = 1f;
		public float speedMultiplierMaxValue = 1f;
		public float speedMultiplierMinDistance = 5f;
		public float speedMultiplierMaxDistance = 10f;
		public Vec2d targetEvaluationOffset;
		public float brakeValue = 3f;
		public bool DBG_speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
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

