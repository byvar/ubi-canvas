using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_JanodAIComponent_Template : Ray_FixedAIComponent_Template {
		[Serialize("receiveHitBehavior"     )] public Placeholder receiveHitBehavior;
		[Serialize("deathBehavior"          )] public Placeholder deathBehavior;
		[Serialize("crushedBehavior"        )] public Placeholder crushedBehavior;
		[Serialize("squashPenetrationRadius")] public float squashPenetrationRadius;
		[Serialize("canRehit"               )] public bool canRehit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(crushedBehavior));
			SerializeField(s, nameof(squashPenetrationRadius));
			SerializeField(s, nameof(canRehit));
		}
		public override uint? ClassCRC => 0xF6483F0B;
	}
}

