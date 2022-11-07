namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PlayerControllerComponent : PlayerControllerComponent {
		public Path trailPath;
		public Path reticlePath;
		public Path minePath;
		public Path projectilePath;
		public bool disableColorRamp;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					trailPath = s.SerializeObject<Path>(trailPath, name: "trailPath");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					trailPath = s.SerializeObject<Path>(trailPath, name: "trailPath");
					reticlePath = s.SerializeObject<Path>(reticlePath, name: "reticlePath");
					minePath = s.SerializeObject<Path>(minePath, name: "minePath");
					projectilePath = s.SerializeObject<Path>(projectilePath, name: "projectilePath");
				}
				disableColorRamp = s.Serialize<bool>(disableColorRamp, name: "disableColorRamp");
			}
		}
		[Games(GameFlags.RA)]
		public partial class StateDeadSoul_Template : CSerializable {
			public Generic<PhysShape> phantomShape;
			public float softCollisionRadiusMultiplier;
			public bool ignoreCollisions;
			public float minLocalSpeed;
			public float maxLocalSpeed;
			public float maxLocalSpeedWithBoost;
			public float inputInertia;
			public float camSpeedInfluence;
			public float ejectFromBorderForce;
			public Vec2d ejectMargin;
			public float minInputForRotation;
			public Angle maxAngle;
			public float angularSmoothMinSpeed;
			public float angularSmoothMaxSpeed;
			public float angularSmoothMinValue;
			public float angularSmoothMaxValue;
			public bool useTrail;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				phantomShape = s.SerializeObject<Generic<PhysShape>>(phantomShape, name: "phantomShape");
				softCollisionRadiusMultiplier = s.Serialize<float>(softCollisionRadiusMultiplier, name: "softCollisionRadiusMultiplier");
				ignoreCollisions = s.Serialize<bool>(ignoreCollisions, name: "ignoreCollisions");
				minLocalSpeed = s.Serialize<float>(minLocalSpeed, name: "minLocalSpeed");
				maxLocalSpeed = s.Serialize<float>(maxLocalSpeed, name: "maxLocalSpeed");
				maxLocalSpeedWithBoost = s.Serialize<float>(maxLocalSpeedWithBoost, name: "maxLocalSpeedWithBoost");
				inputInertia = s.Serialize<float>(inputInertia, name: "inputInertia");
				camSpeedInfluence = s.Serialize<float>(camSpeedInfluence, name: "camSpeedInfluence");
				ejectFromBorderForce = s.Serialize<float>(ejectFromBorderForce, name: "ejectFromBorderForce");
				ejectMargin = s.SerializeObject<Vec2d>(ejectMargin, name: "ejectMargin");
				minInputForRotation = s.Serialize<float>(minInputForRotation, name: "minInputForRotation");
				maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
				angularSmoothMinSpeed = s.Serialize<float>(angularSmoothMinSpeed, name: "angularSmoothMinSpeed");
				angularSmoothMaxSpeed = s.Serialize<float>(angularSmoothMaxSpeed, name: "angularSmoothMaxSpeed");
				angularSmoothMinValue = s.Serialize<float>(angularSmoothMinValue, name: "angularSmoothMinValue");
				angularSmoothMaxValue = s.Serialize<float>(angularSmoothMaxValue, name: "angularSmoothMaxValue");
				useTrail = s.Serialize<bool>(useTrail, name: "useTrail");
			}
		}
		[Games(GameFlags.RA)]
		public partial class StateRevive_Template : CSerializable {
			public float duration;
			public float bezierHitMultiplier;
			public float bezierMidRadius;
			public float bezierMidInfluence;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				duration = s.Serialize<float>(duration, name: "duration");
				bezierHitMultiplier = s.Serialize<float>(bezierHitMultiplier, name: "bezierHitMultiplier");
				bezierMidRadius = s.Serialize<float>(bezierMidRadius, name: "bezierMidRadius");
				bezierMidInfluence = s.Serialize<float>(bezierMidInfluence, name: "bezierMidInfluence");
			}
		}
		public override uint? ClassCRC => 0x74D86EDB;
	}
}

