using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RopeComponent_Template : GraphicComponent_Template {
		public Path beginTexture;
		public Path endTexture;
		public GFXMaterialSerializable beginMaterial;
		public GFXMaterialSerializable endMaterial;
		public Path gameMaterial;
		public Vec2d beginTextureScale;
		public Vec2d endTextureScale;
		public bool useSwingRope;
		public bool elastic;
		public bool oneEventoneChild;
		public bool gravityFollowOrientation;
		public bool deactivateOnFinish;
		public BezierCurveRenderer_Template bezierRenderer;
		public Path cutSectionGameMaterial;
		public Path cutGameMaterial;
		public Path cutEndGameMaterial;
		public float movingPolyForce;
		public float weightMultiplier;
		public float landSpeedMultiplier;
		public float hitForceMultiplier;
		public float impulseMultiplier;
		public bool phantom;
		public float bodyWindMultiplier;
		public float bodyGravityMultiplier;
		public Angle constraintMinAngle;
		public Angle constraintMaxAngle;
		public float constraintMinLength;
		public float constraintMaxLength;
		public float constraintStiff;
		public float constraintDamp;
		public float moveNoise;
		public float moveNoiseSpeed;
		public float cutForceUp;
		public bool constraintLimitAngle;
		public bool constraintRelaxLength;
		public ConstraintSolverIterationPrecision precision;
		public uint faction;
		public StringID ropeCreakSound;
		public Angle swingMaxSwingAngle;
		public float swingStiffGravityMultiplier;
		public float swingStiffImpulseMultiplier;
		public float swingStiffSwingSpeedFriction;
		public float swingNonStiffSwingSpeedFriction;
		public float swingLandDragMultiplier;
		public float swingLandDragDuration;
		public bool swingCanUseSmall;
		public bool swingCanUseNormal;
		public bool swingRepositionWithBones;
		public CList<StringID> animMeshAnims;
		public StringID animMeshEnding;
		public Angle animMeshVertexAngleOffset;
		public CutFade fullDisappearOnCut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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
				animMeshAnims = s.SerializeObject<CList<StringID>>(animMeshAnims, name: "animMeshAnims");
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
				animMeshAnims = s.SerializeObject<CList<StringID>>(animMeshAnims, name: "animMeshAnims");
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
		public enum Enum_precision {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_fullDisappearOnCut {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x7559AA65;
	}
}

