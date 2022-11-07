namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_RopeHookComponent : ActorComponent {
		public RO2_TouchHandler touchHandler;
		public float torqueFriction;
		public float attachmentDetectionRadius;
		public float hookingSmoothFactor;
		public Vec2d hookOffset;
		public Angle angleOffset;
		public float angleSmoothingFactor;
		public float snapDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			touchHandler = s.SerializeObject<RO2_TouchHandler>(touchHandler, name: "touchHandler");
			torqueFriction = s.Serialize<float>(torqueFriction, name: "torqueFriction");
			attachmentDetectionRadius = s.Serialize<float>(attachmentDetectionRadius, name: "attachmentDetectionRadius");
			hookingSmoothFactor = s.Serialize<float>(hookingSmoothFactor, name: "hookingSmoothFactor");
			hookOffset = s.SerializeObject<Vec2d>(hookOffset, name: "hookOffset");
			angleOffset = s.SerializeObject<Angle>(angleOffset, name: "angleOffset");
			angleSmoothingFactor = s.Serialize<float>(angleSmoothingFactor, name: "angleSmoothingFactor");
			snapDist = s.Serialize<float>(snapDist, name: "snapDist");
		}
		public override uint? ClassCRC => 0x3DCA3879;
	}
}

