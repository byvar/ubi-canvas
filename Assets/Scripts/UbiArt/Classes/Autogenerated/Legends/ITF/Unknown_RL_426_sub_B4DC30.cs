using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_426_sub_B4DC30 : ActorComponent_Template {
		[Serialize("DebugDisplay"                    )] public int DebugDisplay;
		[Serialize("DebugDisplayName"                )] public int DebugDisplayName;
		[Serialize("RewardLumNb"                     )] public uint RewardLumNb;
		[Serialize("ForceScale"                      )] public float ForceScale;
		[Serialize("DetectionRadius"                 )] public float DetectionRadius;
		[Serialize("LifePoints"                      )] public int LifePoints;
		[Serialize("FlamesCanHit"                    )] public int FlamesCanHit;
		[Serialize("TimeToTriggerFlamesOnGround"     )] public float TimeToTriggerFlamesOnGround;
		[Serialize("GenericEventId"                  )] public StringID GenericEventId;
		[Serialize("TargetBlowingRadius"             )] public float TargetBlowingRadius;
		[Serialize("AABBSpecificSize"                )] public float AABBSpecificSize;
		[Serialize("RotationBlendCoeff"              )] public float RotationBlendCoeff;
		[Serialize("MoveToTargetValidationDistance"  )] public float MoveToTargetValidationDistance;
		[Serialize("SpeedMax"                        )] public float SpeedMax;
		[Serialize("BlendedTargetPosition_BlendCoeff")] public float BlendedTargetPosition_BlendCoeff;
		[Serialize("ImpactFX"                        )] public Path ImpactFX;
		[Serialize("FireFX"                          )] public Path FireFX;
		[Serialize("MouthFX"                         )] public Path MouthFX;
		[Serialize("GroundFX"                        )] public Path GroundFX;
		[Serialize("Light"                           )] public Path Light;
		[Serialize("TongueBone"                      )] public StringID TongueBone;
		[Serialize("IKHeadBone"                      )] public StringID IKHeadBone;
		[Serialize("IK_TargetPosBlendCoeff"          )] public float IK_TargetPosBlendCoeff;
		[Serialize("IK_BlendPosBlendCoeff"           )] public float IK_BlendPosBlendCoeff;
		[Serialize("LookAtOffset"                    )] public float LookAtOffset;
		[Serialize("HeadMaxAngleByBone"              )] public Angle HeadMaxAngleByBone;
		[Serialize("IKTailBone"                      )] public StringID IKTailBone;
		[Serialize("TailMaxAngleByBone"              )] public Angle TailMaxAngleByBone;
		[Serialize("TailStepNb"                      )] public uint TailStepNb;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(DebugDisplay));
			SerializeField(s, nameof(DebugDisplayName));
			SerializeField(s, nameof(RewardLumNb));
			SerializeField(s, nameof(ForceScale));
			SerializeField(s, nameof(DetectionRadius));
			SerializeField(s, nameof(LifePoints));
			SerializeField(s, nameof(FlamesCanHit));
			SerializeField(s, nameof(TimeToTriggerFlamesOnGround));
			SerializeField(s, nameof(GenericEventId));
			SerializeField(s, nameof(TargetBlowingRadius));
			SerializeField(s, nameof(AABBSpecificSize));
			SerializeField(s, nameof(RotationBlendCoeff));
			SerializeField(s, nameof(MoveToTargetValidationDistance));
			SerializeField(s, nameof(SpeedMax));
			SerializeField(s, nameof(BlendedTargetPosition_BlendCoeff));
			SerializeField(s, nameof(ImpactFX));
			SerializeField(s, nameof(FireFX));
			SerializeField(s, nameof(MouthFX));
			SerializeField(s, nameof(GroundFX));
			SerializeField(s, nameof(Light));
			SerializeField(s, nameof(TongueBone));
			SerializeField(s, nameof(IKHeadBone));
			SerializeField(s, nameof(IK_TargetPosBlendCoeff));
			SerializeField(s, nameof(IK_BlendPosBlendCoeff));
			SerializeField(s, nameof(LookAtOffset));
			SerializeField(s, nameof(HeadMaxAngleByBone));
			SerializeField(s, nameof(IKTailBone));
			SerializeField(s, nameof(TailMaxAngleByBone));
			SerializeField(s, nameof(TailStepNb));
		}
		public override uint? ClassCRC => 0x5CFF41F9;
	}
}

