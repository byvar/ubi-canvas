namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_JanodAIComponent_Template : Ray_FixedAIComponent_Template {
		public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		public Generic<TemplateAIBehavior> deathBehavior;
		public Generic<TemplateAIBehavior> crushedBehavior;
		public float squashPenetrationRadius;
		public int canRehit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			receiveHitBehavior = s.SerializeObject<Generic<Ray_AIReceiveHitBehavior_Template>>(receiveHitBehavior, name: "receiveHitBehavior");
			deathBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(deathBehavior, name: "deathBehavior");
			crushedBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(crushedBehavior, name: "crushedBehavior");
			squashPenetrationRadius = s.Serialize<float>(squashPenetrationRadius, name: "squashPenetrationRadius");
			canRehit = s.Serialize<int>(canRehit, name: "canRehit");
		}
		public override uint? ClassCRC => 0xF6483F0B;
	}
}

