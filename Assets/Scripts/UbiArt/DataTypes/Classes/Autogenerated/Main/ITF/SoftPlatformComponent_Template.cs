namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class SoftPlatformComponent_Template : ActorComponent_Template {
		public CListO<SoftPlatformComponent_Template.BodyData> softPlatformParticles;
		public CListO<SoftPlatformComponent_Template.ConstraintData> softPlatformConstraints;
		public float weightMultiplier;
		public float landSpeedMultiplier;
		public float hitForceMultiplier;
		public float impulseMultiplier;
		public float movingPolylineForce;
		public Path gameMaterial;
		public bool usePhantom;
		public ConstraintSolverIterationPrecision precision;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				softPlatformParticles = s.SerializeObject<CListO<SoftPlatformComponent_Template.BodyData>>(softPlatformParticles, name: "softPlatformParticles");
				softPlatformConstraints = s.SerializeObject<CListO<SoftPlatformComponent_Template.ConstraintData>>(softPlatformConstraints, name: "softPlatformConstraints");
				weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
				landSpeedMultiplier = s.Serialize<float>(landSpeedMultiplier, name: "landSpeedMultiplier");
				hitForceMultiplier = s.Serialize<float>(hitForceMultiplier, name: "hitForceMultiplier");
				impulseMultiplier = s.Serialize<float>(impulseMultiplier, name: "impulseMultiplier");
				movingPolylineForce = s.Serialize<float>(movingPolylineForce, name: "movingPolylineForce");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				usePhantom = s.Serialize<bool>(usePhantom, name: "usePhantom");
			} else {
				softPlatformParticles = s.SerializeObject<CListO<SoftPlatformComponent_Template.BodyData>>(softPlatformParticles, name: "softPlatformParticles");
				softPlatformConstraints = s.SerializeObject<CListO<SoftPlatformComponent_Template.ConstraintData>>(softPlatformConstraints, name: "softPlatformConstraints");
				weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
				landSpeedMultiplier = s.Serialize<float>(landSpeedMultiplier, name: "landSpeedMultiplier");
				hitForceMultiplier = s.Serialize<float>(hitForceMultiplier, name: "hitForceMultiplier");
				impulseMultiplier = s.Serialize<float>(impulseMultiplier, name: "impulseMultiplier");
				movingPolylineForce = s.Serialize<float>(movingPolylineForce, name: "movingPolylineForce");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				usePhantom = s.Serialize<bool>(usePhantom, name: "usePhantom");
				precision = s.Serialize<ConstraintSolverIterationPrecision>(precision, name: "precision");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class BodyData : CSerializable {
			public string bone;
			public bool _static;
			public float gravityMultiplier;
			public float windMultiplier;
			public bool useStaticAngle;
			public Angle setAngle;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				bone = s.Serialize<string>(bone, name: "bone");
				_static = s.Serialize<bool>(_static, name: "static");
				gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
				windMultiplier = s.Serialize<float>(windMultiplier, name: "windMultiplier");
				useStaticAngle = s.Serialize<bool>(useStaticAngle, name: "useStaticAngle");
				setAngle = s.SerializeObject<Angle>(setAngle, name: "setAngle");
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
		public partial class ConstraintData : CSerializable {
			public string bodyA;
			public string bodyB;
			public Angle minAngle;
			public Angle maxAngle;
			public float minLength;
			public float maxLength;
			public float stiff;
			public float damp;
			public bool limitAngle;
			public bool relaxLength;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				bodyA = s.Serialize<string>(bodyA, name: "bodyA");
				bodyB = s.Serialize<string>(bodyB, name: "bodyB");
				minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
				maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
				minLength = s.Serialize<float>(minLength, name: "minLength");
				maxLength = s.Serialize<float>(maxLength, name: "maxLength");
				stiff = s.Serialize<float>(stiff, name: "stiff");
				damp = s.Serialize<float>(damp, name: "damp");
				limitAngle = s.Serialize<bool>(limitAngle, name: "limitAngle");
				relaxLength = s.Serialize<bool>(relaxLength, name: "relaxLength");
			}
		}
		public enum ConstraintSolverIterationPrecision {
			[Serialize("ConstraintSolverIterationPrecision_Low"   )] Low = 0,
			[Serialize("ConstraintSolverIterationPrecision_Medium")] Medium = 1,
			[Serialize("ConstraintSolverIterationPrecision_High"  )] High = 2,
		}
		public override uint? ClassCRC => 0x44047C07;
	}
}

