using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossJungleComponent_Template : ActorComponent_Template {
		[Serialize("debugTrajectory"       )] public bool debugTrajectory;
		[Serialize("debugIK"               )] public bool debugIK;
		[Serialize("debugAttackShape"      )] public bool debugAttackShape;
		[Serialize("RotationBlendCoeff"    )] public float RotationBlendCoeff;
		[Serialize("SpeedMax"              )] public float SpeedMax;
		[Serialize("TongueBone"            )] public StringID TongueBone;
		[Serialize("FlameBone"             )] public StringID FlameBone;
		[Serialize("ProjectileBone"        )] public StringID ProjectileBone;
		[Serialize("faction"               )] public uint faction;
		[Serialize("attackShapeWidthStart" )] public float attackShapeWidthStart;
		[Serialize("attackShapeWidthSlope" )] public float attackShapeWidthSlope;
		[Serialize("attackShapeLength"     )] public float attackShapeLength;
		[Serialize("attackShapeSpeed"      )] public float attackShapeSpeed;
		[Serialize("attackHitCooldown"     )] public float attackHitCooldown;
		[Serialize("attackAbortCooldown"   )] public float attackAbortCooldown;
		[Serialize("projectilePath"        )] public Path projectilePath;
		[Serialize("BlurPath"              )] public Path BlurPath;
		[Serialize("flamePath"             )] public Path flamePath;
		[Serialize("flameFXName"           )] public StringID flameFXName;
		[Serialize("hitPoints"             )] public uint hitPoints;
		[Serialize("IKHeadBone"            )] public StringID IKHeadBone;
		[Serialize("IK_TargetPosBlendCoeff")] public float IK_TargetPosBlendCoeff;
		[Serialize("LookAtOffset"          )] public float LookAtOffset;
		[Serialize("HeadMaxAngleByBone"    )] public Angle HeadMaxAngleByBone;
		[Serialize("IKTailBone"            )] public StringID IKTailBone;
		[Serialize("TailMaxAngleByBone"    )] public Angle TailMaxAngleByBone;
		[Serialize("TailStepNb"            )] public uint TailStepNb;
		[Serialize("AABBSize"              )] public float AABBSize;
		[Serialize("flameFXScale"          )] public Vector2 flameFXScale;
		[Serialize("CamShakeType"          )] public StringID CamShakeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(debugTrajectory));
				SerializeField(s, nameof(debugIK));
				SerializeField(s, nameof(debugAttackShape));
				SerializeField(s, nameof(RotationBlendCoeff));
				SerializeField(s, nameof(SpeedMax));
				SerializeField(s, nameof(TongueBone));
				SerializeField(s, nameof(FlameBone));
				SerializeField(s, nameof(ProjectileBone));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(attackShapeWidthStart));
				SerializeField(s, nameof(attackShapeWidthSlope));
				SerializeField(s, nameof(attackShapeLength));
				SerializeField(s, nameof(attackShapeSpeed));
				SerializeField(s, nameof(attackHitCooldown));
				SerializeField(s, nameof(attackAbortCooldown));
				SerializeField(s, nameof(projectilePath));
				SerializeField(s, nameof(BlurPath));
				SerializeField(s, nameof(flamePath));
				SerializeField(s, nameof(flameFXName));
				SerializeField(s, nameof(flameFXScale));
				SerializeField(s, nameof(hitPoints));
				SerializeField(s, nameof(IKHeadBone));
				SerializeField(s, nameof(IK_TargetPosBlendCoeff));
				SerializeField(s, nameof(LookAtOffset));
				SerializeField(s, nameof(HeadMaxAngleByBone));
				SerializeField(s, nameof(IKTailBone));
				SerializeField(s, nameof(TailMaxAngleByBone));
				SerializeField(s, nameof(TailStepNb));
				SerializeField(s, nameof(AABBSize));
				SerializeField(s, nameof(CamShakeType));
			} else {
				SerializeField(s, nameof(debugTrajectory));
				SerializeField(s, nameof(debugIK));
				SerializeField(s, nameof(debugAttackShape));
				SerializeField(s, nameof(RotationBlendCoeff));
				SerializeField(s, nameof(SpeedMax));
				SerializeField(s, nameof(TongueBone));
				SerializeField(s, nameof(FlameBone));
				SerializeField(s, nameof(ProjectileBone));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(attackShapeWidthStart));
				SerializeField(s, nameof(attackShapeWidthSlope));
				SerializeField(s, nameof(attackShapeLength));
				SerializeField(s, nameof(attackShapeSpeed));
				SerializeField(s, nameof(attackHitCooldown));
				SerializeField(s, nameof(attackAbortCooldown));
				SerializeField(s, nameof(projectilePath));
				SerializeField(s, nameof(BlurPath));
				SerializeField(s, nameof(flamePath));
				SerializeField(s, nameof(flameFXName));
				SerializeField(s, nameof(hitPoints));
				SerializeField(s, nameof(IKHeadBone));
				SerializeField(s, nameof(IK_TargetPosBlendCoeff));
				SerializeField(s, nameof(LookAtOffset));
				SerializeField(s, nameof(HeadMaxAngleByBone));
				SerializeField(s, nameof(IKTailBone));
				SerializeField(s, nameof(TailMaxAngleByBone));
				SerializeField(s, nameof(TailStepNb));
				SerializeField(s, nameof(AABBSize));
			}
		}
		public override uint? ClassCRC => 0x4F32481F;
	}
}

