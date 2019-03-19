using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SimpleAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("genericBehavior"   )] public Generic<TemplateAIBehavior> genericBehavior;
		[Serialize("receiveHitBehavior")] public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"     )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("allowMultiHit"     )] public bool allowMultiHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(genericBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(allowMultiHit));
		}
		public override uint? ClassCRC => 0x18121265;
	}
}

