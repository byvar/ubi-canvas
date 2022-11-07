namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PlayerControllerComponent_Template : CSerializable {
		public float clothWindForceMultiplier;
		public float clothWindEnvironmentalDensity;
		public float clothWindMaterialDensity;
		public float poisonInvincibilityDuration;
		public float maxWindForceForAnim;
		public float gotoPositionThreshold;
		public float gotoPositionTimeout;
		public float blockingMovablesCheckExtraRadius;
		public Vec2d flyingClampMargin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			clothWindForceMultiplier = s.Serialize<float>(clothWindForceMultiplier, name: "clothWindForceMultiplier");
			clothWindEnvironmentalDensity = s.Serialize<float>(clothWindEnvironmentalDensity, name: "clothWindEnvironmentalDensity");
			clothWindMaterialDensity = s.Serialize<float>(clothWindMaterialDensity, name: "clothWindMaterialDensity");
			poisonInvincibilityDuration = s.Serialize<float>(poisonInvincibilityDuration, name: "poisonInvincibilityDuration");
			maxWindForceForAnim = s.Serialize<float>(maxWindForceForAnim, name: "maxWindForceForAnim");
			gotoPositionThreshold = s.Serialize<float>(gotoPositionThreshold, name: "gotoPositionThreshold");
			gotoPositionTimeout = s.Serialize<float>(gotoPositionTimeout, name: "gotoPositionTimeout");
			blockingMovablesCheckExtraRadius = s.Serialize<float>(blockingMovablesCheckExtraRadius, name: "blockingMovablesCheckExtraRadius");
			flyingClampMargin = s.SerializeObject<Vec2d>(flyingClampMargin, name: "flyingClampMargin");
		}
		public override uint? ClassCRC => 0xDB87F624;
	}
}

