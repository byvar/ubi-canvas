using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_426_sub_B4DC30 : ActorComponent_Template {
		public int DebugDisplay;
		public int DebugDisplayName;
		public uint RewardLumNb;
		public float ForceScale;
		public float DetectionRadius;
		public int LifePoints;
		public int FlamesCanHit;
		public float TimeToTriggerFlamesOnGround;
		public StringID GenericEventId;
		public float TargetBlowingRadius;
		public float AABBSpecificSize;
		public float RotationBlendCoeff;
		public float MoveToTargetValidationDistance;
		public float SpeedMax;
		public float BlendedTargetPosition_BlendCoeff;
		public Path ImpactFX;
		public Path FireFX;
		public Path MouthFX;
		public Path GroundFX;
		public Path Light;
		public StringID TongueBone;
		public StringID IKHeadBone;
		public float IK_TargetPosBlendCoeff;
		public float IK_BlendPosBlendCoeff;
		public float LookAtOffset;
		public Angle HeadMaxAngleByBone;
		public StringID IKTailBone;
		public Angle TailMaxAngleByBone;
		public uint TailStepNb;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			DebugDisplay = s.Serialize<int>(DebugDisplay, name: "DebugDisplay");
			DebugDisplayName = s.Serialize<int>(DebugDisplayName, name: "DebugDisplayName");
			RewardLumNb = s.Serialize<uint>(RewardLumNb, name: "RewardLumNb");
			ForceScale = s.Serialize<float>(ForceScale, name: "ForceScale");
			DetectionRadius = s.Serialize<float>(DetectionRadius, name: "DetectionRadius");
			LifePoints = s.Serialize<int>(LifePoints, name: "LifePoints");
			FlamesCanHit = s.Serialize<int>(FlamesCanHit, name: "FlamesCanHit");
			TimeToTriggerFlamesOnGround = s.Serialize<float>(TimeToTriggerFlamesOnGround, name: "TimeToTriggerFlamesOnGround");
			GenericEventId = s.SerializeObject<StringID>(GenericEventId, name: "GenericEventId");
			TargetBlowingRadius = s.Serialize<float>(TargetBlowingRadius, name: "TargetBlowingRadius");
			AABBSpecificSize = s.Serialize<float>(AABBSpecificSize, name: "AABBSpecificSize");
			RotationBlendCoeff = s.Serialize<float>(RotationBlendCoeff, name: "RotationBlendCoeff");
			MoveToTargetValidationDistance = s.Serialize<float>(MoveToTargetValidationDistance, name: "MoveToTargetValidationDistance");
			SpeedMax = s.Serialize<float>(SpeedMax, name: "SpeedMax");
			BlendedTargetPosition_BlendCoeff = s.Serialize<float>(BlendedTargetPosition_BlendCoeff, name: "BlendedTargetPosition_BlendCoeff");
			ImpactFX = s.SerializeObject<Path>(ImpactFX, name: "ImpactFX");
			FireFX = s.SerializeObject<Path>(FireFX, name: "FireFX");
			MouthFX = s.SerializeObject<Path>(MouthFX, name: "MouthFX");
			GroundFX = s.SerializeObject<Path>(GroundFX, name: "GroundFX");
			Light = s.SerializeObject<Path>(Light, name: "Light");
			TongueBone = s.SerializeObject<StringID>(TongueBone, name: "TongueBone");
			IKHeadBone = s.SerializeObject<StringID>(IKHeadBone, name: "IKHeadBone");
			IK_TargetPosBlendCoeff = s.Serialize<float>(IK_TargetPosBlendCoeff, name: "IK_TargetPosBlendCoeff");
			IK_BlendPosBlendCoeff = s.Serialize<float>(IK_BlendPosBlendCoeff, name: "IK_BlendPosBlendCoeff");
			LookAtOffset = s.Serialize<float>(LookAtOffset, name: "LookAtOffset");
			HeadMaxAngleByBone = s.SerializeObject<Angle>(HeadMaxAngleByBone, name: "HeadMaxAngleByBone");
			IKTailBone = s.SerializeObject<StringID>(IKTailBone, name: "IKTailBone");
			TailMaxAngleByBone = s.SerializeObject<Angle>(TailMaxAngleByBone, name: "TailMaxAngleByBone");
			TailStepNb = s.Serialize<uint>(TailStepNb, name: "TailStepNb");
		}
		public override uint? ClassCRC => 0x5CFF41F9;
	}
}

