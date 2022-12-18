namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIShooterVacuumBehavior_Template : CSerializable {
		public Placeholder vacuumSkill;
		public Placeholder waitAction;
		public Placeholder vacuumAction;
		public Placeholder spitAction;
		public StringID spitMarker;
		public StringID spitBoneName;
		public Vec2d spitForce;
		public StringID startVacuumMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			vacuumSkill = s.SerializeObject<Placeholder>(vacuumSkill, name: "vacuumSkill");
			waitAction = s.SerializeObject<Placeholder>(waitAction, name: "waitAction");
			vacuumAction = s.SerializeObject<Placeholder>(vacuumAction, name: "vacuumAction");
			spitAction = s.SerializeObject<Placeholder>(spitAction, name: "spitAction");
			spitMarker = s.SerializeObject<StringID>(spitMarker, name: "spitMarker");
			spitBoneName = s.SerializeObject<StringID>(spitBoneName, name: "spitBoneName");
			spitForce = s.SerializeObject<Vec2d>(spitForce, name: "spitForce");
			startVacuumMarker = s.SerializeObject<StringID>(startVacuumMarker, name: "startVacuumMarker");
		}
		public override uint? ClassCRC => 0x61CB6C6F;
	}
}

