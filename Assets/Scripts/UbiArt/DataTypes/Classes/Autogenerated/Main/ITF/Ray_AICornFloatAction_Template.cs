namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_AICornFloatAction_Template : AIAction_Template {
		public float floatHeightMin;
		public float floatIntervalMin;
		public float floatIntervalMax;
		public float floatHeightMax;
		public float springConstant;
		public float frictionConstant;
		public float weightThreshold;
		public float lowerSpringConstant;
		public float lowerFrictionConstant;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			floatHeightMin = s.Serialize<float>(floatHeightMin, name: "floatHeightMin");
			floatIntervalMin = s.Serialize<float>(floatIntervalMin, name: "floatIntervalMin");
			floatIntervalMax = s.Serialize<float>(floatIntervalMax, name: "floatIntervalMax");
			floatHeightMin = s.Serialize<float>(floatHeightMin, name: "floatHeightMin");
			floatHeightMax = s.Serialize<float>(floatHeightMax, name: "floatHeightMax");
			springConstant = s.Serialize<float>(springConstant, name: "springConstant");
			frictionConstant = s.Serialize<float>(frictionConstant, name: "frictionConstant");
			weightThreshold = s.Serialize<float>(weightThreshold, name: "weightThreshold");
			lowerSpringConstant = s.Serialize<float>(lowerSpringConstant, name: "lowerSpringConstant");
			lowerFrictionConstant = s.Serialize<float>(lowerFrictionConstant, name: "lowerFrictionConstant");
		}
		public override uint? ClassCRC => 0xD988E29B;
	}
}

