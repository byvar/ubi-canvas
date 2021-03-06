using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class GroundAIControllerComponent_Template : BaseAIControllerComponent_Template {
		public float walkForce;
		public float walkEfficiencyMaxSpeed;
		public Angle walkEfficiencyMinGroundAngle;
		public Angle walkEfficiencyMaxGroundAngle;
		public float walkEfficiencyMinAngleMultiplier;
		public float walkEfficiencyMaxAngleMultiplier;
		public float walkMoveTargetMultiplierMin;
		public float walkMoveTargetMultiplierMax;
		public float walkMoveTargetBlendTime;
		public float airForce;
		public float airTopSpeed;
		public float airFriction;
		public float airSuspensionMinYSpeed;
		public float airSuspensionMaxYSpeed;
		public float airSuspensionMinMultiplier;
		public float airSuspensionMaxMultiplier;
		public float swimWaterResistMinSpeed;
		public float swimWaterResistMaxSpeed;
		public float swimWaterResistMaxMultiplier;
		public float swimJumpRange;
		public float swimInertiaSpeed;
		public float swimTopSpeed;
		public float swimTurnDistanceMultiplier;
		public float swimTurnSpeedMultiplier;
		public bool swimDisableRotation;
		public float flyInertiaSpeed;
		public float flyTopSpeed;
		public float jumpForce;
		public float jumpToActorYFuncPoint0Dist;
		public float jumpToActorYFuncPoint1Dist;
		public float jumpToActorXZFuncPoint0T;
		public float jumpToActorXZFuncPoint1T;
		public float jumpToActorSpeed;
		public float jumpToActorMinTime;
		public float avoidanceRadius;
		public float minVariation;
		public float maxVariation;
		public float sprintWalkForceMultiplier;
		public float sprintEfficiencyMaxSpeedMultiplier;
		public float sprintAccelerationDuration;
		public float dashSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				walkForce = s.Serialize<float>(walkForce, name: "walkForce");
				walkEfficiencyMaxSpeed = s.Serialize<float>(walkEfficiencyMaxSpeed, name: "walkEfficiencyMaxSpeed");
				walkEfficiencyMinGroundAngle = s.SerializeObject<Angle>(walkEfficiencyMinGroundAngle, name: "walkEfficiencyMinGroundAngle");
				walkEfficiencyMaxGroundAngle = s.SerializeObject<Angle>(walkEfficiencyMaxGroundAngle, name: "walkEfficiencyMaxGroundAngle");
				walkEfficiencyMinAngleMultiplier = s.Serialize<float>(walkEfficiencyMinAngleMultiplier, name: "walkEfficiencyMinAngleMultiplier");
				walkEfficiencyMaxAngleMultiplier = s.Serialize<float>(walkEfficiencyMaxAngleMultiplier, name: "walkEfficiencyMaxAngleMultiplier");
				walkMoveTargetMultiplierMin = s.Serialize<float>(walkMoveTargetMultiplierMin, name: "walkMoveTargetMultiplierMin");
				walkMoveTargetMultiplierMax = s.Serialize<float>(walkMoveTargetMultiplierMax, name: "walkMoveTargetMultiplierMax");
				walkMoveTargetBlendTime = s.Serialize<float>(walkMoveTargetBlendTime, name: "walkMoveTargetBlendTime");
				airForce = s.Serialize<float>(airForce, name: "airForce");
				airTopSpeed = s.Serialize<float>(airTopSpeed, name: "airTopSpeed");
				airFriction = s.Serialize<float>(airFriction, name: "airFriction");
				airSuspensionMinYSpeed = s.Serialize<float>(airSuspensionMinYSpeed, name: "airSuspensionMinYSpeed");
				airSuspensionMaxYSpeed = s.Serialize<float>(airSuspensionMaxYSpeed, name: "airSuspensionMaxYSpeed");
				airSuspensionMinMultiplier = s.Serialize<float>(airSuspensionMinMultiplier, name: "airSuspensionMinMultiplier");
				airSuspensionMaxMultiplier = s.Serialize<float>(airSuspensionMaxMultiplier, name: "airSuspensionMaxMultiplier");
				swimWaterResistMinSpeed = s.Serialize<float>(swimWaterResistMinSpeed, name: "swimWaterResistMinSpeed");
				swimWaterResistMaxSpeed = s.Serialize<float>(swimWaterResistMaxSpeed, name: "swimWaterResistMaxSpeed");
				swimWaterResistMaxMultiplier = s.Serialize<float>(swimWaterResistMaxMultiplier, name: "swimWaterResistMaxMultiplier");
				swimJumpRange = s.Serialize<float>(swimJumpRange, name: "swimJumpRange");
				swimInertiaSpeed = s.Serialize<float>(swimInertiaSpeed, name: "swimInertiaSpeed");
				swimTopSpeed = s.Serialize<float>(swimTopSpeed, name: "swimTopSpeed");
				swimTurnDistanceMultiplier = s.Serialize<float>(swimTurnDistanceMultiplier, name: "swimTurnDistanceMultiplier");
				swimTurnSpeedMultiplier = s.Serialize<float>(swimTurnSpeedMultiplier, name: "swimTurnSpeedMultiplier");
				jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
				jumpToActorYFuncPoint0Dist = s.Serialize<float>(jumpToActorYFuncPoint0Dist, name: "jumpToActorYFuncPoint0Dist");
				jumpToActorYFuncPoint1Dist = s.Serialize<float>(jumpToActorYFuncPoint1Dist, name: "jumpToActorYFuncPoint1Dist");
				jumpToActorXZFuncPoint0T = s.Serialize<float>(jumpToActorXZFuncPoint0T, name: "jumpToActorXZFuncPoint0T");
				jumpToActorXZFuncPoint1T = s.Serialize<float>(jumpToActorXZFuncPoint1T, name: "jumpToActorXZFuncPoint1T");
				jumpToActorSpeed = s.Serialize<float>(jumpToActorSpeed, name: "jumpToActorSpeed");
				jumpToActorMinTime = s.Serialize<float>(jumpToActorMinTime, name: "jumpToActorMinTime");
				avoidanceRadius = s.Serialize<float>(avoidanceRadius, name: "avoidanceRadius");
				minVariation = s.Serialize<float>(minVariation, name: "minVariation");
				maxVariation = s.Serialize<float>(maxVariation, name: "maxVariation");
				sprintWalkForceMultiplier = s.Serialize<float>(sprintWalkForceMultiplier, name: "sprintWalkForceMultiplier");
				sprintEfficiencyMaxSpeedMultiplier = s.Serialize<float>(sprintEfficiencyMaxSpeedMultiplier, name: "sprintEfficiencyMaxSpeedMultiplier");
				sprintAccelerationDuration = s.Serialize<float>(sprintAccelerationDuration, name: "sprintAccelerationDuration");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				walkForce = s.Serialize<float>(walkForce, name: "walkForce");
				walkEfficiencyMaxSpeed = s.Serialize<float>(walkEfficiencyMaxSpeed, name: "walkEfficiencyMaxSpeed");
				walkEfficiencyMinGroundAngle = s.SerializeObject<Angle>(walkEfficiencyMinGroundAngle, name: "walkEfficiencyMinGroundAngle");
				walkEfficiencyMaxGroundAngle = s.SerializeObject<Angle>(walkEfficiencyMaxGroundAngle, name: "walkEfficiencyMaxGroundAngle");
				walkEfficiencyMinAngleMultiplier = s.Serialize<float>(walkEfficiencyMinAngleMultiplier, name: "walkEfficiencyMinAngleMultiplier");
				walkEfficiencyMaxAngleMultiplier = s.Serialize<float>(walkEfficiencyMaxAngleMultiplier, name: "walkEfficiencyMaxAngleMultiplier");
				walkMoveTargetMultiplierMin = s.Serialize<float>(walkMoveTargetMultiplierMin, name: "walkMoveTargetMultiplierMin");
				walkMoveTargetMultiplierMax = s.Serialize<float>(walkMoveTargetMultiplierMax, name: "walkMoveTargetMultiplierMax");
				walkMoveTargetBlendTime = s.Serialize<float>(walkMoveTargetBlendTime, name: "walkMoveTargetBlendTime");
				airForce = s.Serialize<float>(airForce, name: "airForce");
				airTopSpeed = s.Serialize<float>(airTopSpeed, name: "airTopSpeed");
				airFriction = s.Serialize<float>(airFriction, name: "airFriction");
				airSuspensionMinYSpeed = s.Serialize<float>(airSuspensionMinYSpeed, name: "airSuspensionMinYSpeed");
				airSuspensionMaxYSpeed = s.Serialize<float>(airSuspensionMaxYSpeed, name: "airSuspensionMaxYSpeed");
				airSuspensionMinMultiplier = s.Serialize<float>(airSuspensionMinMultiplier, name: "airSuspensionMinMultiplier");
				airSuspensionMaxMultiplier = s.Serialize<float>(airSuspensionMaxMultiplier, name: "airSuspensionMaxMultiplier");
				swimWaterResistMinSpeed = s.Serialize<float>(swimWaterResistMinSpeed, name: "swimWaterResistMinSpeed");
				swimWaterResistMaxSpeed = s.Serialize<float>(swimWaterResistMaxSpeed, name: "swimWaterResistMaxSpeed");
				swimWaterResistMaxMultiplier = s.Serialize<float>(swimWaterResistMaxMultiplier, name: "swimWaterResistMaxMultiplier");
				swimJumpRange = s.Serialize<float>(swimJumpRange, name: "swimJumpRange");
				swimInertiaSpeed = s.Serialize<float>(swimInertiaSpeed, name: "swimInertiaSpeed");
				swimTopSpeed = s.Serialize<float>(swimTopSpeed, name: "swimTopSpeed");
				swimTurnDistanceMultiplier = s.Serialize<float>(swimTurnDistanceMultiplier, name: "swimTurnDistanceMultiplier");
				swimTurnSpeedMultiplier = s.Serialize<float>(swimTurnSpeedMultiplier, name: "swimTurnSpeedMultiplier");
				swimDisableRotation = s.Serialize<bool>(swimDisableRotation, name: "swimDisableRotation");
				flyInertiaSpeed = s.Serialize<float>(flyInertiaSpeed, name: "flyInertiaSpeed");
				flyTopSpeed = s.Serialize<float>(flyTopSpeed, name: "flyTopSpeed");
				jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
				jumpToActorYFuncPoint0Dist = s.Serialize<float>(jumpToActorYFuncPoint0Dist, name: "jumpToActorYFuncPoint0Dist");
				jumpToActorYFuncPoint1Dist = s.Serialize<float>(jumpToActorYFuncPoint1Dist, name: "jumpToActorYFuncPoint1Dist");
				jumpToActorXZFuncPoint0T = s.Serialize<float>(jumpToActorXZFuncPoint0T, name: "jumpToActorXZFuncPoint0T");
				jumpToActorXZFuncPoint1T = s.Serialize<float>(jumpToActorXZFuncPoint1T, name: "jumpToActorXZFuncPoint1T");
				jumpToActorSpeed = s.Serialize<float>(jumpToActorSpeed, name: "jumpToActorSpeed");
				jumpToActorMinTime = s.Serialize<float>(jumpToActorMinTime, name: "jumpToActorMinTime");
				avoidanceRadius = s.Serialize<float>(avoidanceRadius, name: "avoidanceRadius");
				minVariation = s.Serialize<float>(minVariation, name: "minVariation");
				maxVariation = s.Serialize<float>(maxVariation, name: "maxVariation");
				sprintWalkForceMultiplier = s.Serialize<float>(sprintWalkForceMultiplier, name: "sprintWalkForceMultiplier");
				sprintEfficiencyMaxSpeedMultiplier = s.Serialize<float>(sprintEfficiencyMaxSpeedMultiplier, name: "sprintEfficiencyMaxSpeedMultiplier");
				sprintAccelerationDuration = s.Serialize<float>(sprintAccelerationDuration, name: "sprintAccelerationDuration");
			} else {
				walkForce = s.Serialize<float>(walkForce, name: "walkForce");
				walkEfficiencyMaxSpeed = s.Serialize<float>(walkEfficiencyMaxSpeed, name: "walkEfficiencyMaxSpeed");
				walkEfficiencyMinGroundAngle = s.SerializeObject<Angle>(walkEfficiencyMinGroundAngle, name: "walkEfficiencyMinGroundAngle");
				walkEfficiencyMaxGroundAngle = s.SerializeObject<Angle>(walkEfficiencyMaxGroundAngle, name: "walkEfficiencyMaxGroundAngle");
				walkEfficiencyMinAngleMultiplier = s.Serialize<float>(walkEfficiencyMinAngleMultiplier, name: "walkEfficiencyMinAngleMultiplier");
				walkEfficiencyMaxAngleMultiplier = s.Serialize<float>(walkEfficiencyMaxAngleMultiplier, name: "walkEfficiencyMaxAngleMultiplier");
				walkMoveTargetMultiplierMin = s.Serialize<float>(walkMoveTargetMultiplierMin, name: "walkMoveTargetMultiplierMin");
				walkMoveTargetMultiplierMax = s.Serialize<float>(walkMoveTargetMultiplierMax, name: "walkMoveTargetMultiplierMax");
				walkMoveTargetBlendTime = s.Serialize<float>(walkMoveTargetBlendTime, name: "walkMoveTargetBlendTime");
				airForce = s.Serialize<float>(airForce, name: "airForce");
				airTopSpeed = s.Serialize<float>(airTopSpeed, name: "airTopSpeed");
				airFriction = s.Serialize<float>(airFriction, name: "airFriction");
				airSuspensionMinYSpeed = s.Serialize<float>(airSuspensionMinYSpeed, name: "airSuspensionMinYSpeed");
				airSuspensionMaxYSpeed = s.Serialize<float>(airSuspensionMaxYSpeed, name: "airSuspensionMaxYSpeed");
				airSuspensionMinMultiplier = s.Serialize<float>(airSuspensionMinMultiplier, name: "airSuspensionMinMultiplier");
				airSuspensionMaxMultiplier = s.Serialize<float>(airSuspensionMaxMultiplier, name: "airSuspensionMaxMultiplier");
				swimWaterResistMinSpeed = s.Serialize<float>(swimWaterResistMinSpeed, name: "swimWaterResistMinSpeed");
				swimWaterResistMaxSpeed = s.Serialize<float>(swimWaterResistMaxSpeed, name: "swimWaterResistMaxSpeed");
				swimWaterResistMaxMultiplier = s.Serialize<float>(swimWaterResistMaxMultiplier, name: "swimWaterResistMaxMultiplier");
				swimJumpRange = s.Serialize<float>(swimJumpRange, name: "swimJumpRange");
				swimInertiaSpeed = s.Serialize<float>(swimInertiaSpeed, name: "swimInertiaSpeed");
				swimTopSpeed = s.Serialize<float>(swimTopSpeed, name: "swimTopSpeed");
				swimTurnDistanceMultiplier = s.Serialize<float>(swimTurnDistanceMultiplier, name: "swimTurnDistanceMultiplier");
				swimTurnSpeedMultiplier = s.Serialize<float>(swimTurnSpeedMultiplier, name: "swimTurnSpeedMultiplier");
				swimDisableRotation = s.Serialize<bool>(swimDisableRotation, name: "swimDisableRotation");
				flyInertiaSpeed = s.Serialize<float>(flyInertiaSpeed, name: "flyInertiaSpeed");
				flyTopSpeed = s.Serialize<float>(flyTopSpeed, name: "flyTopSpeed");
				jumpForce = s.Serialize<float>(jumpForce, name: "jumpForce");
				jumpToActorYFuncPoint0Dist = s.Serialize<float>(jumpToActorYFuncPoint0Dist, name: "jumpToActorYFuncPoint0Dist");
				jumpToActorYFuncPoint1Dist = s.Serialize<float>(jumpToActorYFuncPoint1Dist, name: "jumpToActorYFuncPoint1Dist");
				jumpToActorXZFuncPoint0T = s.Serialize<float>(jumpToActorXZFuncPoint0T, name: "jumpToActorXZFuncPoint0T");
				jumpToActorXZFuncPoint1T = s.Serialize<float>(jumpToActorXZFuncPoint1T, name: "jumpToActorXZFuncPoint1T");
				jumpToActorSpeed = s.Serialize<float>(jumpToActorSpeed, name: "jumpToActorSpeed");
				jumpToActorMinTime = s.Serialize<float>(jumpToActorMinTime, name: "jumpToActorMinTime");
				avoidanceRadius = s.Serialize<float>(avoidanceRadius, name: "avoidanceRadius");
				minVariation = s.Serialize<float>(minVariation, name: "minVariation");
				maxVariation = s.Serialize<float>(maxVariation, name: "maxVariation");
				sprintWalkForceMultiplier = s.Serialize<float>(sprintWalkForceMultiplier, name: "sprintWalkForceMultiplier");
				sprintEfficiencyMaxSpeedMultiplier = s.Serialize<float>(sprintEfficiencyMaxSpeedMultiplier, name: "sprintEfficiencyMaxSpeedMultiplier");
				sprintAccelerationDuration = s.Serialize<float>(sprintAccelerationDuration, name: "sprintAccelerationDuration");
				dashSpeed = s.Serialize<float>(dashSpeed, name: "dashSpeed");
			}
		}
		public override uint? ClassCRC => 0x4530E988;
	}
}

