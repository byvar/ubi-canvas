using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SimpleAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("genericBehavior"   )] public Placeholder genericBehavior;
		[Serialize("receiveHitBehavior")] public Placeholder receiveHitBehavior;
		[Serialize("deathBehavior"     )] public Placeholder deathBehavior;
		[Serialize("allowMultiHit"     )] public bool allowMultiHit;
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

