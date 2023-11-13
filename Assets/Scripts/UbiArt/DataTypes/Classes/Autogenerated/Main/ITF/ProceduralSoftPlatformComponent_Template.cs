namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class ProceduralSoftPlatformComponent_Template : GraphicComponent_Template {
		public bool isSwing;
		public bool isLiana;
		public Vec3d defaultEndPos = Vec3d.Zero - Vec3d.Up;
		public float edgeLength = 1f;
		public float lengthFactor = 1f;
		public uint bezierSampling = 1;
		public bool inverseCurveRenderer;
		public Path beginTexture;
		public Path endTexture;
		public GFXMaterialSerializable beginMaterial;
		public GFXMaterialSerializable endMaterial;
		public BezierCurveRenderer_Template bezierRenderer;
		public float bezierZOffset;
		public Vec2d beginTextureScale = Vec2d.One;
		public Vec2d endTextureScale = Vec2d.One;
		public Path gameMaterial;
		public float movingPolyForce;
		public float weightMultiplier = 1f;
		public float landSpeedMultiplier = 1f;
		public float hitForceMultiplier = 1f;
		public float impulseMultiplier = 1f;
		public bool phantom = true;
		public bool oppositePhantom;
		public float bodyWindMultiplier = 1f;
		public float bodyGravityMultiplier = 1f;
		public Angle constraintMinAngle;
		public Angle constraintMaxAngle = 6.283185f;
		public float constraintMinLength;
		public float constraintMaxLength = 1f;
		public float constraintStiff;
		public float constraintDamp;
		public bool constraintLimitAngle;
		public bool constraintRelaxLength;
		public ConstraintSolverIterationPrecision precision;
		public Angle maxSwingAngle = 1.570796f;
		public float stiffSwingSpeedFriction = 0.95f;
		public float nonStiffSwingSpeedFriction = 0.95f;
		public StringID startingBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				isSwing = s.Serialize<bool>(isSwing, name: "isSwing");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				isLiana = s.Serialize<bool>(isLiana, name: "isLiana");
				movingPolyForce = s.Serialize<float>(movingPolyForce, name: "movingPolyForce");
				weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
				landSpeedMultiplier = s.Serialize<float>(landSpeedMultiplier, name: "landSpeedMultiplier");
				hitForceMultiplier = s.Serialize<float>(hitForceMultiplier, name: "hitForceMultiplier");
				impulseMultiplier = s.Serialize<float>(impulseMultiplier, name: "impulseMultiplier");
				phantom = s.Serialize<bool>(phantom, name: "phantom");
				bodyWindMultiplier = s.Serialize<float>(bodyWindMultiplier, name: "bodyWindMultiplier");
				bodyGravityMultiplier = s.Serialize<float>(bodyGravityMultiplier, name: "bodyGravityMultiplier");
				constraintMinAngle = s.SerializeObject<Angle>(constraintMinAngle, name: "constraintMinAngle");
				constraintMaxAngle = s.SerializeObject<Angle>(constraintMaxAngle, name: "constraintMaxAngle");
				constraintMinLength = s.Serialize<float>(constraintMinLength, name: "constraintMinLength");
				constraintMaxLength = s.Serialize<float>(constraintMaxLength, name: "constraintMaxLength");
				constraintStiff = s.Serialize<float>(constraintStiff, name: "constraintStiff");
				constraintDamp = s.Serialize<float>(constraintDamp, name: "constraintDamp");
				constraintLimitAngle = s.Serialize<bool>(constraintLimitAngle, name: "constraintLimitAngle");
				constraintRelaxLength = s.Serialize<bool>(constraintRelaxLength, name: "constraintRelaxLength");
				lengthFactor = s.Serialize<float>(lengthFactor, name: "lengthFactor");
				edgeLength = s.Serialize<float>(edgeLength, name: "edgeLength");
				bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
				beginTexture = s.SerializeObject<Path>(beginTexture, name: "beginTexture");
				endTexture = s.SerializeObject<Path>(endTexture, name: "endTexture");
				bezierSampling = s.Serialize<uint>(bezierSampling, name: "bezierSampling");
			} else {
				isSwing = s.Serialize<bool>(isSwing, name: "isSwing");
				isLiana = s.Serialize<bool>(isLiana, name: "isLiana");
				defaultEndPos = s.SerializeObject<Vec3d>(defaultEndPos, name: "defaultEndPos");
				edgeLength = s.Serialize<float>(edgeLength, name: "edgeLength");
				lengthFactor = s.Serialize<float>(lengthFactor, name: "lengthFactor");
				bezierSampling = s.Serialize<uint>(bezierSampling, name: "bezierSampling");
				inverseCurveRenderer = s.Serialize<bool>(inverseCurveRenderer, name: "inverseCurveRenderer");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					beginTexture = s.SerializeObject<Path>(beginTexture, name: "beginTexture");
					endTexture = s.SerializeObject<Path>(endTexture, name: "endTexture");
				}
				beginMaterial = s.SerializeObject<GFXMaterialSerializable>(beginMaterial, name: "beginMaterial");
				endMaterial = s.SerializeObject<GFXMaterialSerializable>(endMaterial, name: "endMaterial");
				bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
				bezierZOffset = s.Serialize<float>(bezierZOffset, name: "bezierZOffset");
				beginTextureScale = s.SerializeObject<Vec2d>(beginTextureScale, name: "beginTextureScale");
				endTextureScale = s.SerializeObject<Vec2d>(endTextureScale, name: "endTextureScale");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				movingPolyForce = s.Serialize<float>(movingPolyForce, name: "movingPolyForce");
				weightMultiplier = s.Serialize<float>(weightMultiplier, name: "weightMultiplier");
				landSpeedMultiplier = s.Serialize<float>(landSpeedMultiplier, name: "landSpeedMultiplier");
				hitForceMultiplier = s.Serialize<float>(hitForceMultiplier, name: "hitForceMultiplier");
				impulseMultiplier = s.Serialize<float>(impulseMultiplier, name: "impulseMultiplier");
				phantom = s.Serialize<bool>(phantom, name: "phantom");
				oppositePhantom = s.Serialize<bool>(oppositePhantom, name: "oppositePhantom");
				bodyWindMultiplier = s.Serialize<float>(bodyWindMultiplier, name: "bodyWindMultiplier");
				bodyGravityMultiplier = s.Serialize<float>(bodyGravityMultiplier, name: "bodyGravityMultiplier");
				constraintMinAngle = s.SerializeObject<Angle>(constraintMinAngle, name: "constraintMinAngle");
				constraintMaxAngle = s.SerializeObject<Angle>(constraintMaxAngle, name: "constraintMaxAngle");
				constraintMinLength = s.Serialize<float>(constraintMinLength, name: "constraintMinLength");
				constraintMaxLength = s.Serialize<float>(constraintMaxLength, name: "constraintMaxLength");
				constraintStiff = s.Serialize<float>(constraintStiff, name: "constraintStiff");
				constraintDamp = s.Serialize<float>(constraintDamp, name: "constraintDamp");
				constraintLimitAngle = s.Serialize<bool>(constraintLimitAngle, name: "constraintLimitAngle");
				constraintRelaxLength = s.Serialize<bool>(constraintRelaxLength, name: "constraintRelaxLength");
				precision = s.Serialize<ConstraintSolverIterationPrecision>(precision, name: "precision");
				maxSwingAngle = s.SerializeObject<Angle>(maxSwingAngle, name: "maxSwingAngle");
				stiffSwingSpeedFriction = s.Serialize<float>(stiffSwingSpeedFriction, name: "stiffSwingSpeedFriction");
				nonStiffSwingSpeedFriction = s.Serialize<float>(nonStiffSwingSpeedFriction, name: "nonStiffSwingSpeedFriction");
				startingBone = s.SerializeObject<StringID>(startingBone, name: "startingBone");
			}
		}
		public enum ConstraintSolverIterationPrecision {
			[Serialize("ConstraintSolverIterationPrecision_Low"   )] Low = 0,
			[Serialize("ConstraintSolverIterationPrecision_Medium")] Medium = 1,
			[Serialize("ConstraintSolverIterationPrecision_High"  )] High = 2,
		}
		public override uint? ClassCRC => 0x90F63027;
	}
}

