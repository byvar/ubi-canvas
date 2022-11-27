namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionCornFloat_Template : BTAction_Template {
		public StringID anim;
		public float floatIntervalMin = 1f;
		public float floatIntervalMax = 2f;
		public float floatHeightMin = 1f;
		public float floatHeightMax = 2f;
		public float springConstant = 1f;
		public float frictionConstant = 1f;
		public float weightThreshold = 1f;
		public float lowerSpringConstant = 1f;
		public float lowerFrictionConstant = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
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
		public override uint? ClassCRC => 0x6734201F;
	}
}

