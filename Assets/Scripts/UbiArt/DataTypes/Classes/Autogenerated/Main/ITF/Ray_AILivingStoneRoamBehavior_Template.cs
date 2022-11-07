namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AILivingStoneRoamBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		public Generic<AIFallAction_Template> fall;
		public Generic<AIAction_Template> defaultPause;
		public Generic<AIAction_Template> attack;
		public float uturnDelay2;
		public AABB attackRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fall = s.SerializeObject<Generic<AIFallAction_Template>>(fall, name: "fall");
			defaultPause = s.SerializeObject<Generic<AIAction_Template>>(defaultPause, name: "defaultPause");
			attack = s.SerializeObject<Generic<AIAction_Template>>(attack, name: "attack");
			uturnDelay2 = s.Serialize<float>(uturnDelay2, name: "uturnDelay2");
			attackRange = s.SerializeObject<AABB>(attackRange, name: "attackRange");
		}
		public override uint? ClassCRC => 0x7F91F03C;
	}
}

