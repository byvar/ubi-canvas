using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIWaterFloatAction_Template : AIPlayAnimAction_Template {
		public float floatForceDistMultiplier;
		public float floatForceSpeedMultiplier;
		public float orientForceDistMultiplier;
		public float orientForceSpeedMultiplier;
		public float weightMultiplier;
		public float speedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			floatForceDistMultiplier = s.Serialize<float>(floatForceDistMultiplier, name: "floatForceDistMultiplier");
			floatForceSpeedMultiplier = s.Serialize<float>(floatForceSpeedMultiplier, name: "floatForceSpeedMultiplier");
			orientForceDistMultiplier = s.Serialize<float>(orientForceDistMultiplier, name: "orientForceDistMultiplier");
			orientForceSpeedMultiplier = s.Serialize<float>(orientForceSpeedMultiplier, name: "orientForceSpeedMultiplier");
			weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
			speedMultiplier = s.Serialize<float>(speedMultiplier, name: "speedMultiplier");
		}
		public override uint? ClassCRC => 0x40F45740;
	}
}

