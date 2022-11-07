namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PendulumComponent : CSerializable {
		public float phantomHitMultiplier;
		public Enum_collisionFilter collisionFilter;
		public int useFixedLength;
		public float length;
		public float maxLength;
		public float minLength;
		public int shouldLimitAngle;
		public float minAngle;
		public float maxAngle;
		public float stiffness;
		public float damping;
		public Enum_constraintPrecision constraintPrecision;
		public float delayBetweenOnHitFx;
		public float playOnHitForceThreshold;
		public float playOnStartMoveSpeedThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			phantomHitMultiplier = s.Serialize<float>(phantomHitMultiplier, name: "phantomHitMultiplier");
			collisionFilter = s.Serialize<Enum_collisionFilter>(collisionFilter, name: "collisionFilter");
			useFixedLength = s.Serialize<int>(useFixedLength, name: "useFixedLength");
			length = s.Serialize<float>(length, name: "length");
			maxLength = s.Serialize<float>(maxLength, name: "maxLength");
			minLength = s.Serialize<float>(minLength, name: "minLength");
			shouldLimitAngle = s.Serialize<int>(shouldLimitAngle, name: "shouldLimitAngle");
			minAngle = s.Serialize<float>(minAngle, name: "minAngle");
			maxAngle = s.Serialize<float>(maxAngle, name: "maxAngle");
			stiffness = s.Serialize<float>(stiffness, name: "stiffness");
			damping = s.Serialize<float>(damping, name: "damping");
			constraintPrecision = s.Serialize<Enum_constraintPrecision>(constraintPrecision, name: "constraintPrecision");
			delayBetweenOnHitFx = s.Serialize<float>(delayBetweenOnHitFx, name: "delayBetweenOnHitFx");
			playOnHitForceThreshold = s.Serialize<float>(playOnHitForceThreshold, name: "playOnHitForceThreshold");
			playOnStartMoveSpeedThreshold = s.Serialize<float>(playOnStartMoveSpeedThreshold, name: "playOnStartMoveSpeedThreshold");
		}
		public enum Enum_collisionFilter {
			[Serialize("Value_0"        )] Value_0 = 0,
			[Serialize("Value_0xFFFFFFF")] Value_0xFFFFFFF = 0xFFFFFFF,
			[Serialize("Value_4"        )] Value_4 = 4,
			[Serialize("Value_2"        )] Value_2 = 2,
			[Serialize("Value_8"        )] Value_8 = 8,
			[Serialize("Value_16"       )] Value_16 = 16,
		}
		public enum Enum_constraintPrecision {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xCD580692;
	}
}

