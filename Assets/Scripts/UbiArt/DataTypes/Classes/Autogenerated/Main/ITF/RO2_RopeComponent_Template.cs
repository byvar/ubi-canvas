namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_RopeComponent_Template : GraphicComponent_Template {
		public Path beginTexture;
		public Path endTexture;
		public GFXMaterialSerializable beginMaterial;
		public GFXMaterialSerializable endMaterial;
		public Path gameMaterial;
		public Vec2d beginTextureScale = Vec2d.One;
		public Vec2d endTextureScale = Vec2d.One;
		public bool useSwingRope = true;
		public bool elastic;
		public bool oneEventoneChild;
		public bool gravityFollowOrientation;
		public bool deactivateOnFinish = true;
		public BezierCurveRenderer_Template bezierRenderer;
		public Path cutSectionGameMaterial;
		public Path cutGameMaterial;
		public Path cutEndGameMaterial;
		public float movingPolyForce;
		public float weightMultiplier = 1f;
		public float landSpeedMultiplier = 1f;
		public float hitForceMultiplier = 1f;
		public float impulseMultiplier = 1f;
		public bool phantom = true;
		public float bodyWindMultiplier = 1f;
		public float bodyGravityMultiplier = 1f;
		public Angle constraintMinAngle;
		public Angle constraintMaxAngle = 6.283185f;
		public float constraintMinLength;
		public float constraintMaxLength = 1f;
		public float constraintStiff;
		public float constraintDamp;
		public float moveNoise;
		public float moveNoiseSpeed = 1f;
		public float cutForceUp = 600f;
		public bool constraintLimitAngle;
		public bool constraintRelaxLength;
		public ConstraintSolverIterationPrecision precision;
		public uint faction = 2;
		public StringID ropeCreakSound;
		public Angle swingMaxSwingAngle = 1.570796f;
		public float swingStiffGravityMultiplier = 4f;
		public float swingStiffImpulseMultiplier = 2.5f;
		public float swingStiffSwingSpeedFriction = 0.9f;
		public float swingNonStiffSwingSpeedFriction = 0.95f;
		public float swingLandDragMultiplier = 10f;
		public float swingLandDragDuration = 0.5f;
		public bool swingCanUseSmall = true;
		public bool swingCanUseNormal = true;
		public bool swingRepositionWithBones = true;
		public CListO<StringID> animMeshAnims;
		public StringID animMeshEnding;
		public Angle animMeshVertexAngleOffset;
		public CutFade fullDisappearOnCut;

		public Path VitaCutGameMaterial { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					beginTexture = s.SerializeObject<Path>(beginTexture, name: "beginTexture");
					endTexture = s.SerializeObject<Path>(endTexture, name: "endTexture");
				}
				beginMaterial = s.SerializeObject<GFXMaterialSerializable>(beginMaterial, name: "beginMaterial");
				endMaterial = s.SerializeObject<GFXMaterialSerializable>(endMaterial, name: "endMaterial");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				beginTextureScale = s.SerializeObject<Vec2d>(beginTextureScale, name: "beginTextureScale");
				endTextureScale = s.SerializeObject<Vec2d>(endTextureScale, name: "endTextureScale");
				useSwingRope = s.Serialize<bool>(useSwingRope, name: "useSwingRope");
				elastic = s.Serialize<bool>(elastic, name: "elastic");
				oneEventoneChild = s.Serialize<bool>(oneEventoneChild, name: "oneEventoneChild");
				gravityFollowOrientation = s.Serialize<bool>(gravityFollowOrientation, name: "gravityFollowOrientation");
				deactivateOnFinish = s.Serialize<bool>(deactivateOnFinish, name: "deactivateOnFinish");
				bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
				cutSectionGameMaterial = s.SerializeObject<Path>(cutSectionGameMaterial, name: "cutSectionGameMaterial");
				cutGameMaterial = s.SerializeObject<Path>(cutGameMaterial, name: "cutGameMaterial");
				cutEndGameMaterial = s.SerializeObject<Path>(cutEndGameMaterial, name: "cutEndGameMaterial");
				if (s.Settings.platform == Settings.Platform.Vita) {
					VitaCutGameMaterial = s.SerializeObject<Path>(VitaCutGameMaterial, name: nameof(VitaCutGameMaterial));
				}
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
				moveNoise = s.Serialize<float>(moveNoise, name: "moveNoise");
				moveNoiseSpeed = s.Serialize<float>(moveNoiseSpeed, name: "moveNoiseSpeed");
				cutForceUp = s.Serialize<float>(cutForceUp, name: "cutForceUp");
				constraintLimitAngle = s.Serialize<bool>(constraintLimitAngle, name: "constraintLimitAngle");
				constraintRelaxLength = s.Serialize<bool>(constraintRelaxLength, name: "constraintRelaxLength");
				precision = s.Serialize<ConstraintSolverIterationPrecision>(precision, name: "precision");
				faction = s.Serialize<uint>(faction, name: "faction");
				ropeCreakSound = s.SerializeObject<StringID>(ropeCreakSound, name: "ropeCreakSound");
				swingMaxSwingAngle = s.SerializeObject<Angle>(swingMaxSwingAngle, name: "swingMaxSwingAngle");
				swingStiffGravityMultiplier = s.Serialize<float>(swingStiffGravityMultiplier, name: "swingStiffGravityMultiplier");
				swingStiffImpulseMultiplier = s.Serialize<float>(swingStiffImpulseMultiplier, name: "swingStiffImpulseMultiplier");
				swingStiffSwingSpeedFriction = s.Serialize<float>(swingStiffSwingSpeedFriction, name: "swingStiffSwingSpeedFriction");
				swingNonStiffSwingSpeedFriction = s.Serialize<float>(swingNonStiffSwingSpeedFriction, name: "swingNonStiffSwingSpeedFriction");
				swingLandDragMultiplier = s.Serialize<float>(swingLandDragMultiplier, name: "swingLandDragMultiplier");
				swingLandDragDuration = s.Serialize<float>(swingLandDragDuration, name: "swingLandDragDuration");
				swingCanUseSmall = s.Serialize<bool>(swingCanUseSmall, name: "swingCanUseSmall");
				swingCanUseNormal = s.Serialize<bool>(swingCanUseNormal, name: "swingCanUseNormal");
				swingRepositionWithBones = s.Serialize<bool>(swingRepositionWithBones, name: "swingRepositionWithBones");
				animMeshAnims = s.SerializeObject<CListO<StringID>>(animMeshAnims, name: "animMeshAnims");
				animMeshEnding = s.SerializeObject<StringID>(animMeshEnding, name: "animMeshEnding");
				animMeshVertexAngleOffset = s.SerializeObject<Angle>(animMeshVertexAngleOffset, name: "animMeshVertexAngleOffset");
				fullDisappearOnCut = s.Serialize<CutFade>(fullDisappearOnCut, name: "fullDisappearOnCut");
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					beginTexture = s.SerializeObject<Path>(beginTexture, name: "beginTexture");
					endTexture = s.SerializeObject<Path>(endTexture, name: "endTexture");
				}
				beginMaterial = s.SerializeObject<GFXMaterialSerializable>(beginMaterial, name: "beginMaterial");
				endMaterial = s.SerializeObject<GFXMaterialSerializable>(endMaterial, name: "endMaterial");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				beginTextureScale = s.SerializeObject<Vec2d>(beginTextureScale, name: "beginTextureScale");
				endTextureScale = s.SerializeObject<Vec2d>(endTextureScale, name: "endTextureScale");
				useSwingRope = s.Serialize<bool>(useSwingRope, name: "useSwingRope");
				elastic = s.Serialize<bool>(elastic, name: "elastic");
				oneEventoneChild = s.Serialize<bool>(oneEventoneChild, name: "oneEventoneChild");
				gravityFollowOrientation = s.Serialize<bool>(gravityFollowOrientation, name: "gravityFollowOrientation");
				deactivateOnFinish = s.Serialize<bool>(deactivateOnFinish, name: "deactivateOnFinish");
				bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
				cutSectionGameMaterial = s.SerializeObject<Path>(cutSectionGameMaterial, name: "cutSectionGameMaterial");
				cutGameMaterial = s.SerializeObject<Path>(cutGameMaterial, name: "cutGameMaterial");
				cutEndGameMaterial = s.SerializeObject<Path>(cutEndGameMaterial, name: "cutEndGameMaterial");
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
				moveNoise = s.Serialize<float>(moveNoise, name: "moveNoise");
				moveNoiseSpeed = s.Serialize<float>(moveNoiseSpeed, name: "moveNoiseSpeed");
				cutForceUp = s.Serialize<float>(cutForceUp, name: "cutForceUp");
				constraintLimitAngle = s.Serialize<bool>(constraintLimitAngle, name: "constraintLimitAngle");
				constraintRelaxLength = s.Serialize<bool>(constraintRelaxLength, name: "constraintRelaxLength");
				precision = s.Serialize<ConstraintSolverIterationPrecision>(precision, name: "precision");
				faction = s.Serialize<uint>(faction, name: "faction");
				ropeCreakSound = s.SerializeObject<StringID>(ropeCreakSound, name: "ropeCreakSound");
				swingMaxSwingAngle = s.SerializeObject<Angle>(swingMaxSwingAngle, name: "swingMaxSwingAngle");
				swingStiffGravityMultiplier = s.Serialize<float>(swingStiffGravityMultiplier, name: "swingStiffGravityMultiplier");
				swingStiffImpulseMultiplier = s.Serialize<float>(swingStiffImpulseMultiplier, name: "swingStiffImpulseMultiplier");
				swingStiffSwingSpeedFriction = s.Serialize<float>(swingStiffSwingSpeedFriction, name: "swingStiffSwingSpeedFriction");
				swingNonStiffSwingSpeedFriction = s.Serialize<float>(swingNonStiffSwingSpeedFriction, name: "swingNonStiffSwingSpeedFriction");
				swingLandDragMultiplier = s.Serialize<float>(swingLandDragMultiplier, name: "swingLandDragMultiplier");
				swingLandDragDuration = s.Serialize<float>(swingLandDragDuration, name: "swingLandDragDuration");
				swingCanUseSmall = s.Serialize<bool>(swingCanUseSmall, name: "swingCanUseSmall");
				swingCanUseNormal = s.Serialize<bool>(swingCanUseNormal, name: "swingCanUseNormal");
				swingRepositionWithBones = s.Serialize<bool>(swingRepositionWithBones, name: "swingRepositionWithBones");
				animMeshAnims = s.SerializeObject<CListO<StringID>>(animMeshAnims, name: "animMeshAnims");
				animMeshEnding = s.SerializeObject<StringID>(animMeshEnding, name: "animMeshEnding");
				animMeshVertexAngleOffset = s.SerializeObject<Angle>(animMeshVertexAngleOffset, name: "animMeshVertexAngleOffset");
				fullDisappearOnCut = s.Serialize<CutFade>(fullDisappearOnCut, name: "fullDisappearOnCut");
			}
		}
		public enum ConstraintSolverIterationPrecision {
			[Serialize("ConstraintSolverIterationPrecision_Low"   )] Low = 0,
			[Serialize("ConstraintSolverIterationPrecision_Medium")] Medium = 1,
			[Serialize("ConstraintSolverIterationPrecision_High"  )] High = 2,
		}
		public enum CutFade {
			[Serialize("CutFade_None" )] None = 0,
			[Serialize("CutFade_Full" )] Full = 1,
			[Serialize("CutFade_Begin")] Begin = 2,
			[Serialize("CutFade_End"  )] End = 3,
		}
		public override uint? ClassCRC => 0x7559AA65;
	}
}

