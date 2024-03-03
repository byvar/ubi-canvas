namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRedWizardWaterSwimBehavior_Template : TemplateAIBehavior {
		public float minSpeed;
		public float maxSpeed;
		public float minForce;
		public float maxForce;
		public float moveForce;
		public Generic<AIAction_Template> swim;
		public Generic<AIAction_Template> jump;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			minForce = s.Serialize<float>(minForce, name: "minForce");
			maxForce = s.Serialize<float>(maxForce, name: "maxForce");
			moveForce = s.Serialize<float>(moveForce, name: "moveForce");
			swim = s.SerializeObject<Generic<AIAction_Template>>(swim, name: "swim");
			jump = s.SerializeObject<Generic<AIAction_Template>>(jump, name: "jump");
		}
		public override uint? ClassCRC => 0xC105379D;
	}
}

