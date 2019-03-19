using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_JanodAIComponent_Template : Ray_FixedAIComponent_Template {
		[Serialize("receiveHitBehavior"     )] public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"          )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("crushedBehavior"        )] public Generic<TemplateAIBehavior> crushedBehavior;
		[Serialize("squashPenetrationRadius")] public float squashPenetrationRadius;
		[Serialize("canRehit"               )] public int canRehit;
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

