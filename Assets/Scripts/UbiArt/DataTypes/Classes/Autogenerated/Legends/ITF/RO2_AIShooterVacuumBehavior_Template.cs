namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIShooterVacuumBehavior_Template : TemplateAIBehavior {
		public VacuumSkill_Template vacuumSkill;
		public Generic<AIAction_Template> waitAction;
		public Generic<AIAction_Template> vacuumAction;
		public Generic<AIAction_Template> spitAction;
		public StringID spitMarker;
		public StringID spitBoneName;
		public Vec2d spitForce;
		public StringID startVacuumMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			vacuumSkill = s.SerializeObject<VacuumSkill_Template>(vacuumSkill, name: "vacuumSkill");
			waitAction = s.SerializeObject<Generic<AIAction_Template>>(waitAction, name: "waitAction");
			vacuumAction = s.SerializeObject<Generic<AIAction_Template>>(vacuumAction, name: "vacuumAction");
			spitAction = s.SerializeObject<Generic<AIAction_Template>>(spitAction, name: "spitAction");
			spitMarker = s.SerializeObject<StringID>(spitMarker, name: "spitMarker");
			spitBoneName = s.SerializeObject<StringID>(spitBoneName, name: "spitBoneName");
			spitForce = s.SerializeObject<Vec2d>(spitForce, name: "spitForce");
			startVacuumMarker = s.SerializeObject<StringID>(startVacuumMarker, name: "startVacuumMarker");
		}
		public override uint? ClassCRC => 0x61CB6C6F;
	}
}

