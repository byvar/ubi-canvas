namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_GyroSpikyComponent_Template : RO2_RailComponent_Template {
		public float acceleration = 1f;
		public float drcAcceleration = 1f;
		public bool gyroMode = true;
		public bool drcMode;
		public float frictionMin = 1f;
		public float frictionMax = 1f;
		public Angle angleFrictionMax;
		public Angle angleFrictionMin = 0.7853982f;
		public float drcSwipeValidationSpeed = 30f;
		public Angle drcSwipeValidationAngle = 0.7853982f;
		public float drcStiffness = 20f;
		public float drcDamping = 12f;
		public float oneShotValidationTime = 0.3f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			acceleration = s.Serialize<float>(acceleration, name: "acceleration");
			drcAcceleration = s.Serialize<float>(drcAcceleration, name: "drcAcceleration");
			gyroMode = s.Serialize<bool>(gyroMode, name: "gyroMode");
			drcMode = s.Serialize<bool>(drcMode, name: "drcMode");
			frictionMin = s.Serialize<float>(frictionMin, name: "frictionMin");
			frictionMax = s.Serialize<float>(frictionMax, name: "frictionMax");
			angleFrictionMax = s.SerializeObject<Angle>(angleFrictionMax, name: "angleFrictionMax");
			angleFrictionMin = s.SerializeObject<Angle>(angleFrictionMin, name: "angleFrictionMin");
			drcSwipeValidationSpeed = s.Serialize<float>(drcSwipeValidationSpeed, name: "drcSwipeValidationSpeed");
			drcSwipeValidationAngle = s.SerializeObject<Angle>(drcSwipeValidationAngle, name: "drcSwipeValidationAngle");
			drcStiffness = s.Serialize<float>(drcStiffness, name: "drcStiffness");
			drcDamping = s.Serialize<float>(drcDamping, name: "drcDamping");
			oneShotValidationTime = s.Serialize<float>(oneShotValidationTime, name: "oneShotValidationTime");
		}
		public override uint? ClassCRC => 0x3EC5A53C;
	}
}

