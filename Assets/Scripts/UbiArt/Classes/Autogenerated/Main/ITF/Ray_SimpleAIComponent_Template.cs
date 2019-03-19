using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SimpleAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("genericBehavior"   )] public Generic<TemplateAIBehavior> genericBehavior;
		[Serialize("receiveHitBehavior")] public Generic<AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"     )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("allowMultiHit"     )] public int allowMultiHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(genericBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(allowMultiHit));
		}
		public override uint? ClassCRC => 0x9CD9C6E3;
	}
}

