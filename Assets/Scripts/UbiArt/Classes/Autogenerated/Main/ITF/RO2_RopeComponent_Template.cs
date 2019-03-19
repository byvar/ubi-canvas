using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RopeComponent_Template : GraphicComponent_Template {
		[Serialize("beginTexture"                   )] public Path beginTexture;
		[Serialize("endTexture"                     )] public Path endTexture;
		[Serialize("beginMaterial"                  )] public GFXMaterialSerializable beginMaterial;
		[Serialize("endMaterial"                    )] public GFXMaterialSerializable endMaterial;
		[Serialize("gameMaterial"                   )] public Path gameMaterial;
		[Serialize("beginTextureScale"              )] public Vector2 beginTextureScale;
		[Serialize("endTextureScale"                )] public Vector2 endTextureScale;
		[Serialize("useSwingRope"                   )] public bool useSwingRope;
		[Serialize("elastic"                        )] public bool elastic;
		[Serialize("oneEventoneChild"               )] public bool oneEventoneChild;
		[Serialize("gravityFollowOrientation"       )] public bool gravityFollowOrientation;
		[Serialize("deactivateOnFinish"             )] public bool deactivateOnFinish;
		[Serialize("bezierRenderer"                 )] public BezierCurveRenderer_Template bezierRenderer;
		[Serialize("cutSectionGameMaterial"         )] public Path cutSectionGameMaterial;
		[Serialize("cutGameMaterial"                )] public Path cutGameMaterial;
		[Serialize("cutEndGameMaterial"             )] public Path cutEndGameMaterial;
		[Serialize("movingPolyForce"                )] public float movingPolyForce;
		[Serialize("weightMultiplier"               )] public float weightMultiplier;
		[Serialize("landSpeedMultiplier"            )] public float landSpeedMultiplier;
		[Serialize("hitForceMultiplier"             )] public float hitForceMultiplier;
		[Serialize("impulseMultiplier"              )] public float impulseMultiplier;
		[Serialize("phantom"                        )] public bool phantom;
		[Serialize("bodyWindMultiplier"             )] public float bodyWindMultiplier;
		[Serialize("bodyGravityMultiplier"          )] public float bodyGravityMultiplier;
		[Serialize("constraintMinAngle"             )] public Angle constraintMinAngle;
		[Serialize("constraintMaxAngle"             )] public Angle constraintMaxAngle;
		[Serialize("constraintMinLength"            )] public float constraintMinLength;
		[Serialize("constraintMaxLength"            )] public float constraintMaxLength;
		[Serialize("constraintStiff"                )] public float constraintStiff;
		[Serialize("constraintDamp"                 )] public float constraintDamp;
		[Serialize("moveNoise"                      )] public float moveNoise;
		[Serialize("moveNoiseSpeed"                 )] public float moveNoiseSpeed;
		[Serialize("cutForceUp"                     )] public float cutForceUp;
		[Serialize("constraintLimitAngle"           )] public bool constraintLimitAngle;
		[Serialize("constraintRelaxLength"          )] public bool constraintRelaxLength;
		[Serialize("precision"                      )] public ConstraintSolverIterationPrecision precision;
		[Serialize("faction"                        )] public uint faction;
		[Serialize("ropeCreakSound"                 )] public StringID ropeCreakSound;
		[Serialize("swingMaxSwingAngle"             )] public Angle swingMaxSwingAngle;
		[Serialize("swingStiffGravityMultiplier"    )] public float swingStiffGravityMultiplier;
		[Serialize("swingStiffImpulseMultiplier"    )] public float swingStiffImpulseMultiplier;
		[Serialize("swingStiffSwingSpeedFriction"   )] public float swingStiffSwingSpeedFriction;
		[Serialize("swingNonStiffSwingSpeedFriction")] public float swingNonStiffSwingSpeedFriction;
		[Serialize("swingLandDragMultiplier"        )] public float swingLandDragMultiplier;
		[Serialize("swingLandDragDuration"          )] public float swingLandDragDuration;
		[Serialize("swingCanUseSmall"               )] public bool swingCanUseSmall;
		[Serialize("swingCanUseNormal"              )] public bool swingCanUseNormal;
		[Serialize("swingRepositionWithBones"       )] public bool swingRepositionWithBones;
		[Serialize("animMeshAnims"                  )] public CList<StringID> animMeshAnims;
		[Serialize("animMeshEnding"                 )] public StringID animMeshEnding;
		[Serialize("animMeshVertexAngleOffset"      )] public Angle animMeshVertexAngleOffset;
		[Serialize("fullDisappearOnCut"             )] public CutFade fullDisappearOnCut;
		[Serialize("precision"                      )] public Enum_precision precision;
		[Serialize("fullDisappearOnCut"             )] public Enum_fullDisappearOnCut fullDisappearOnCut;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(beginTexture));
					SerializeField(s, nameof(endTexture));
				}
				SerializeField(s, nameof(beginMaterial));
				SerializeField(s, nameof(endMaterial));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(beginTextureScale));
				SerializeField(s, nameof(endTextureScale));
				SerializeField(s, nameof(useSwingRope));
				SerializeField(s, nameof(elastic));
				SerializeField(s, nameof(oneEventoneChild));
				SerializeField(s, nameof(gravityFollowOrientation));
				SerializeField(s, nameof(deactivateOnFinish));
				SerializeField(s, nameof(bezierRenderer));
				SerializeField(s, nameof(cutSectionGameMaterial));
				SerializeField(s, nameof(cutGameMaterial));
				SerializeField(s, nameof(cutEndGameMaterial));
				SerializeField(s, nameof(movingPolyForce));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(bodyWindMultiplier));
				SerializeField(s, nameof(bodyGravityMultiplier));
				SerializeField(s, nameof(constraintMinAngle));
				SerializeField(s, nameof(constraintMaxAngle));
				SerializeField(s, nameof(constraintMinLength));
				SerializeField(s, nameof(constraintMaxLength));
				SerializeField(s, nameof(constraintStiff));
				SerializeField(s, nameof(constraintDamp));
				SerializeField(s, nameof(moveNoise));
				SerializeField(s, nameof(moveNoiseSpeed));
				SerializeField(s, nameof(cutForceUp));
				SerializeField(s, nameof(constraintLimitAngle));
				SerializeField(s, nameof(constraintRelaxLength));
				SerializeField(s, nameof(precision));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(ropeCreakSound));
				SerializeField(s, nameof(swingMaxSwingAngle));
				SerializeField(s, nameof(swingStiffGravityMultiplier));
				SerializeField(s, nameof(swingStiffImpulseMultiplier));
				SerializeField(s, nameof(swingStiffSwingSpeedFriction));
				SerializeField(s, nameof(swingNonStiffSwingSpeedFriction));
				SerializeField(s, nameof(swingLandDragMultiplier));
				SerializeField(s, nameof(swingLandDragDuration));
				SerializeField(s, nameof(swingCanUseSmall));
				SerializeField(s, nameof(swingCanUseNormal));
				SerializeField(s, nameof(swingRepositionWithBones));
				SerializeField(s, nameof(animMeshAnims));
				SerializeField(s, nameof(animMeshEnding));
				SerializeField(s, nameof(animMeshVertexAngleOffset));
				SerializeField(s, nameof(fullDisappearOnCut));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(beginTexture));
					SerializeField(s, nameof(endTexture));
				}
				SerializeField(s, nameof(beginMaterial));
				SerializeField(s, nameof(endMaterial));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(beginTextureScale));
				SerializeField(s, nameof(endTextureScale));
				SerializeField(s, nameof(useSwingRope));
				SerializeField(s, nameof(elastic));
				SerializeField(s, nameof(oneEventoneChild));
				SerializeField(s, nameof(gravityFollowOrientation));
				SerializeField(s, nameof(deactivateOnFinish));
				SerializeField(s, nameof(bezierRenderer));
				SerializeField(s, nameof(cutSectionGameMaterial));
				SerializeField(s, nameof(cutGameMaterial));
				SerializeField(s, nameof(cutEndGameMaterial));
				SerializeField(s, nameof(movingPolyForce));
				SerializeField(s, nameof(weightMultiplier));
				SerializeField(s, nameof(landSpeedMultiplier));
				SerializeField(s, nameof(hitForceMultiplier));
				SerializeField(s, nameof(impulseMultiplier));
				SerializeField(s, nameof(phantom));
				SerializeField(s, nameof(bodyWindMultiplier));
				SerializeField(s, nameof(bodyGravityMultiplier));
				SerializeField(s, nameof(constraintMinAngle));
				SerializeField(s, nameof(constraintMaxAngle));
				SerializeField(s, nameof(constraintMinLength));
				SerializeField(s, nameof(constraintMaxLength));
				SerializeField(s, nameof(constraintStiff));
				SerializeField(s, nameof(constraintDamp));
				SerializeField(s, nameof(moveNoise));
				SerializeField(s, nameof(moveNoiseSpeed));
				SerializeField(s, nameof(cutForceUp));
				SerializeField(s, nameof(constraintLimitAngle));
				SerializeField(s, nameof(constraintRelaxLength));
				SerializeField(s, nameof(precision));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(ropeCreakSound));
				SerializeField(s, nameof(swingMaxSwingAngle));
				SerializeField(s, nameof(swingStiffGravityMultiplier));
				SerializeField(s, nameof(swingStiffImpulseMultiplier));
				SerializeField(s, nameof(swingStiffSwingSpeedFriction));
				SerializeField(s, nameof(swingNonStiffSwingSpeedFriction));
				SerializeField(s, nameof(swingLandDragMultiplier));
				SerializeField(s, nameof(swingLandDragDuration));
				SerializeField(s, nameof(swingCanUseSmall));
				SerializeField(s, nameof(swingCanUseNormal));
				SerializeField(s, nameof(swingRepositionWithBones));
				SerializeField(s, nameof(animMeshAnims));
				SerializeField(s, nameof(animMeshEnding));
				SerializeField(s, nameof(animMeshVertexAngleOffset));
				SerializeField(s, nameof(fullDisappearOnCut));
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

