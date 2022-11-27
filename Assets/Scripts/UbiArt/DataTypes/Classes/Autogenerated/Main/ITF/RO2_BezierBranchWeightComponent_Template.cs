namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class RO2_BezierBranchWeightComponent_Template : RO2_BezierBranchComponent_Template {
		public Angle minAngle;
		public Angle maxAngle = 0.1745329f;
		public float bendingSpeed = 5f;
		public float weightInfluence = 1f;
		public float weightMinValue;
		public float weightMaxValue = 0.5f;
		public float forceInfluence = 1f;
		public float forceDuration = 0.25f;
		public float forceMinSpeed;
		public float forceMaxSpeed = 5f;
		public bool exclusiveForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			bendingSpeed = s.Serialize<float>(bendingSpeed, name: "bendingSpeed");
			weightInfluence = s.Serialize<float>(weightInfluence, name: "weightInfluence");
			weightMinValue = s.Serialize<float>(weightMinValue, name: "weightMinValue");
			weightMaxValue = s.Serialize<float>(weightMaxValue, name: "weightMaxValue");
			forceInfluence = s.Serialize<float>(forceInfluence, name: "forceInfluence");
			forceDuration = s.Serialize<float>(forceDuration, name: "forceDuration");
			forceMinSpeed = s.Serialize<float>(forceMinSpeed, name: "forceMinSpeed");
			forceMaxSpeed = s.Serialize<float>(forceMaxSpeed, name: "forceMaxSpeed");
			exclusiveForce = s.Serialize<bool>(exclusiveForce, name: "exclusiveForce");
		}
		public override uint? ClassCRC => 0xC7EDC0CE;
	}
}

