namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossJungleComponent_Template : ActorComponent_Template {
		public bool debugTrajectory;
		public bool debugIK;
		public bool debugAttackShape;
		public float RotationBlendCoeff;
		public float SpeedMax;
		public StringID TongueBone;
		public StringID FlameBone;
		public StringID ProjectileBone;
		public uint faction;
		public float attackShapeWidthStart;
		public float attackShapeWidthSlope;
		public float attackShapeLength;
		public float attackShapeSpeed;
		public float attackHitCooldown;
		public float attackAbortCooldown;
		public Path projectilePath;
		public Path BlurPath;
		public Path flamePath;
		public StringID flameFXName;
		public uint hitPoints;
		public StringID IKHeadBone;
		public float IK_TargetPosBlendCoeff;
		public float LookAtOffset;
		public Angle HeadMaxAngleByBone;
		public StringID IKTailBone;
		public Angle TailMaxAngleByBone;
		public uint TailStepNb;
		public float AABBSize;
		public Vec2d flameFXScale;
		public StringID CamShakeType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				debugTrajectory = s.Serialize<bool>(debugTrajectory, name: "debugTrajectory");
				debugIK = s.Serialize<bool>(debugIK, name: "debugIK");
				debugAttackShape = s.Serialize<bool>(debugAttackShape, name: "debugAttackShape");
				RotationBlendCoeff = s.Serialize<float>(RotationBlendCoeff, name: "RotationBlendCoeff");
				SpeedMax = s.Serialize<float>(SpeedMax, name: "SpeedMax");
				TongueBone = s.SerializeObject<StringID>(TongueBone, name: "TongueBone");
				FlameBone = s.SerializeObject<StringID>(FlameBone, name: "FlameBone");
				ProjectileBone = s.SerializeObject<StringID>(ProjectileBone, name: "ProjectileBone");
				faction = s.Serialize<uint>(faction, name: "faction");
				attackShapeWidthStart = s.Serialize<float>(attackShapeWidthStart, name: "attackShapeWidthStart");
				attackShapeWidthSlope = s.Serialize<float>(attackShapeWidthSlope, name: "attackShapeWidthSlope");
				attackShapeLength = s.Serialize<float>(attackShapeLength, name: "attackShapeLength");
				attackShapeSpeed = s.Serialize<float>(attackShapeSpeed, name: "attackShapeSpeed");
				attackHitCooldown = s.Serialize<float>(attackHitCooldown, name: "attackHitCooldown");
				attackAbortCooldown = s.Serialize<float>(attackAbortCooldown, name: "attackAbortCooldown");
				projectilePath = s.SerializeObject<Path>(projectilePath, name: "projectilePath");
				BlurPath = s.SerializeObject<Path>(BlurPath, name: "BlurPath");
				flamePath = s.SerializeObject<Path>(flamePath, name: "flamePath");
				flameFXName = s.SerializeObject<StringID>(flameFXName, name: "flameFXName");
				flameFXScale = s.SerializeObject<Vec2d>(flameFXScale, name: "flameFXScale");
				hitPoints = s.Serialize<uint>(hitPoints, name: "hitPoints");
				IKHeadBone = s.SerializeObject<StringID>(IKHeadBone, name: "IKHeadBone");
				IK_TargetPosBlendCoeff = s.Serialize<float>(IK_TargetPosBlendCoeff, name: "IK_TargetPosBlendCoeff");
				LookAtOffset = s.Serialize<float>(LookAtOffset, name: "LookAtOffset");
				HeadMaxAngleByBone = s.SerializeObject<Angle>(HeadMaxAngleByBone, name: "HeadMaxAngleByBone");
				IKTailBone = s.SerializeObject<StringID>(IKTailBone, name: "IKTailBone");
				TailMaxAngleByBone = s.SerializeObject<Angle>(TailMaxAngleByBone, name: "TailMaxAngleByBone");
				TailStepNb = s.Serialize<uint>(TailStepNb, name: "TailStepNb");
				AABBSize = s.Serialize<float>(AABBSize, name: "AABBSize");
				CamShakeType = s.SerializeObject<StringID>(CamShakeType, name: "CamShakeType");
			} else {
				debugTrajectory = s.Serialize<bool>(debugTrajectory, name: "debugTrajectory");
				debugIK = s.Serialize<bool>(debugIK, name: "debugIK");
				debugAttackShape = s.Serialize<bool>(debugAttackShape, name: "debugAttackShape");
				RotationBlendCoeff = s.Serialize<float>(RotationBlendCoeff, name: "RotationBlendCoeff");
				SpeedMax = s.Serialize<float>(SpeedMax, name: "SpeedMax");
				TongueBone = s.SerializeObject<StringID>(TongueBone, name: "TongueBone");
				FlameBone = s.SerializeObject<StringID>(FlameBone, name: "FlameBone");
				ProjectileBone = s.SerializeObject<StringID>(ProjectileBone, name: "ProjectileBone");
				faction = s.Serialize<uint>(faction, name: "faction");
				attackShapeWidthStart = s.Serialize<float>(attackShapeWidthStart, name: "attackShapeWidthStart");
				attackShapeWidthSlope = s.Serialize<float>(attackShapeWidthSlope, name: "attackShapeWidthSlope");
				attackShapeLength = s.Serialize<float>(attackShapeLength, name: "attackShapeLength");
				attackShapeSpeed = s.Serialize<float>(attackShapeSpeed, name: "attackShapeSpeed");
				attackHitCooldown = s.Serialize<float>(attackHitCooldown, name: "attackHitCooldown");
				attackAbortCooldown = s.Serialize<float>(attackAbortCooldown, name: "attackAbortCooldown");
				projectilePath = s.SerializeObject<Path>(projectilePath, name: "projectilePath");
				BlurPath = s.SerializeObject<Path>(BlurPath, name: "BlurPath");
				flamePath = s.SerializeObject<Path>(flamePath, name: "flamePath");
				flameFXName = s.SerializeObject<StringID>(flameFXName, name: "flameFXName");
				hitPoints = s.Serialize<uint>(hitPoints, name: "hitPoints");
				IKHeadBone = s.SerializeObject<StringID>(IKHeadBone, name: "IKHeadBone");
				IK_TargetPosBlendCoeff = s.Serialize<float>(IK_TargetPosBlendCoeff, name: "IK_TargetPosBlendCoeff");
				LookAtOffset = s.Serialize<float>(LookAtOffset, name: "LookAtOffset");
				HeadMaxAngleByBone = s.SerializeObject<Angle>(HeadMaxAngleByBone, name: "HeadMaxAngleByBone");
				IKTailBone = s.SerializeObject<StringID>(IKTailBone, name: "IKTailBone");
				TailMaxAngleByBone = s.SerializeObject<Angle>(TailMaxAngleByBone, name: "TailMaxAngleByBone");
				TailStepNb = s.Serialize<uint>(TailStepNb, name: "TailStepNb");
				AABBSize = s.Serialize<float>(AABBSize, name: "AABBSize");
			}
		}
		public override uint? ClassCRC => 0x4F32481F;
	}
}

