using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SimpleAIComponent_Template : RO2_AIComponent_Template {
		public Generic<TemplateAIBehavior> genericBehavior;
		public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public bool allowMultiHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			genericBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(genericBehavior, name: "genericBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			allowMultiHit = s.Serialize<bool>(allowMultiHit, name: "allowMultiHit");
		}
		public override uint? ClassCRC => 0x18121265;
	}
}

