using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_SimpleAIComponent_Template : Ray_AIComponent_Template {
		public Generic<TemplateAIBehavior> genericBehavior;
		public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public int allowMultiHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			genericBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(genericBehavior, name: "genericBehavior");
			receiveHitBehavior = s.SerializeObject<Generic<AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			allowMultiHit = s.Serialize<int>(allowMultiHit, name: "allowMultiHit");
		}
		public override uint? ClassCRC => 0x9CD9C6E3;
	}
}

