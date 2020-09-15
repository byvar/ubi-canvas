using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RewardAIComponent_Template : AIComponent_Template {
		public Generic<TemplateAIBehavior> idleBehavior;
		public Generic<TemplateAIBehavior> carriedBehavior;
		public Generic<TemplateAIBehavior> pickupBehavior;
		public Generic<TemplateAIBehavior> snapBehavior;
		public Generic<RO2_EventSpawnReward> fallbackReward;
		public uint addHp;
		public uint addMaxHp;
		public float snapFactor;
		public float snapMinDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idleBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(idleBehavior, name: "idleBehavior");
			carriedBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(carriedBehavior, name: "carriedBehavior");
			pickupBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(pickupBehavior, name: "pickupBehavior");
			snapBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(snapBehavior, name: "snapBehavior");
			fallbackReward = s.SerializeObject<Generic<RO2_EventSpawnReward>>(fallbackReward, name: "fallbackReward");
			addHp = s.Serialize<uint>(addHp, name: "addHp");
			addMaxHp = s.Serialize<uint>(addMaxHp, name: "addMaxHp");
			snapFactor = s.Serialize<float>(snapFactor, name: "snapFactor");
			snapMinDistance = s.Serialize<float>(snapMinDistance, name: "snapMinDistance");
		}
		public override uint? ClassCRC => 0x769825D4;
	}
}

