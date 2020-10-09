using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CreatureWH_BulbComponent_Template : RO2_AIComponent_Template {
		// v From RO2_BezierTree_Template
		public uint sampleCount;
		public float widthForAABB;
		public RO2_BezierTree_Template.LinkMode linkMainBranch;
		public CArrayO<Generic<RO2_BezierBranchComponent_Template>> branchComponents;
		public TweenInterpreter_Template tweenInterpreter;
		public StringID lengthCursorInput;
		// ^ From RO2_BezierTree_Template
		public float attackRadius;
		public float reflexAttackRadius;
		public float speedAttack;
		public float speedReturn;
		public float chargeAnticipDist;
		public float chargeDashDist;
		public float reflexAttackSpeed;
		public float reflexAttackDuration;
		public float reflexAttackInertiaDist;
		public Vec2d eatPos;
		public bool useEatAnim;
		public float timeAnticip;
		public float timeWaitOnPlayerEscape;
		public float timeWaitAfterCatch;
		public float timeWaitAfterMiss;
		public float timeWaitAfterEat;
		public float timeDeploy;
		public float timeRetract;
		public float sinXMin;
		public float sinXMax;
		public float sinYMin;
		public float sinYMax;
		public StringID childBone;
		public Vec2d childAttachOffset;
		public CListO<StringID> parentBones;
		public float handOffset;
		public float collisionRadiusWhileMoving;
		public float collisionRadiusMin;
		public float collisionRadiusMax;
		public float collisionAcceleration;
		public float collisionRetractSpeed;
		public float collisionRetractMinDuration;
		public float collisionWaitDuration;
		public float collisionDeploySpeed;
		public float collisionDeployMinDuration;
		public float tapRadius;
		public float tapRetractDistance;
		public float tapRetractSpeedSmoothA;
		public float tapRetractSpeedSmoothB;
		public float tapCooldown;
		public Generic<PhysShape> collisionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sampleCount = s.Serialize<uint>(sampleCount, name: "sampleCount");
			widthForAABB = s.Serialize<float>(widthForAABB, name: "widthForAABB");
			linkMainBranch = s.Serialize<RO2_BezierTree_Template.LinkMode>(linkMainBranch, name: "linkMainBranch");
			branchComponents = s.SerializeObject<CArrayO<Generic<RO2_BezierBranchComponent_Template>>>(branchComponents, name: "branchComponents");
			tweenInterpreter = s.SerializeObject<TweenInterpreter_Template>(tweenInterpreter, name: "tweenInterpreter");
			lengthCursorInput = s.SerializeObject<StringID>(lengthCursorInput, name: "lengthCursorInput");
			attackRadius = s.Serialize<float>(attackRadius, name: "attackRadius");
			reflexAttackRadius = s.Serialize<float>(reflexAttackRadius, name: "reflexAttackRadius");
			speedAttack = s.Serialize<float>(speedAttack, name: "speedAttack");
			speedReturn = s.Serialize<float>(speedReturn, name: "speedReturn");
			chargeAnticipDist = s.Serialize<float>(chargeAnticipDist, name: "chargeAnticipDist");
			chargeDashDist = s.Serialize<float>(chargeDashDist, name: "chargeDashDist");
			reflexAttackSpeed = s.Serialize<float>(reflexAttackSpeed, name: "reflexAttackSpeed");
			reflexAttackDuration = s.Serialize<float>(reflexAttackDuration, name: "reflexAttackDuration");
			reflexAttackInertiaDist = s.Serialize<float>(reflexAttackInertiaDist, name: "reflexAttackInertiaDist");
			eatPos = s.SerializeObject<Vec2d>(eatPos, name: "eatPos");
			useEatAnim = s.Serialize<bool>(useEatAnim, name: "useEatAnim");
			timeAnticip = s.Serialize<float>(timeAnticip, name: "timeAnticip");
			timeWaitOnPlayerEscape = s.Serialize<float>(timeWaitOnPlayerEscape, name: "timeWaitOnPlayerEscape");
			timeWaitAfterCatch = s.Serialize<float>(timeWaitAfterCatch, name: "timeWaitAfterCatch");
			timeWaitAfterMiss = s.Serialize<float>(timeWaitAfterMiss, name: "timeWaitAfterMiss");
			timeWaitAfterEat = s.Serialize<float>(timeWaitAfterEat, name: "timeWaitAfterEat");
			timeDeploy = s.Serialize<float>(timeDeploy, name: "timeDeploy");
			timeRetract = s.Serialize<float>(timeRetract, name: "timeRetract");
			sinXMin = s.Serialize<float>(sinXMin, name: "sinXMin");
			sinXMax = s.Serialize<float>(sinXMax, name: "sinXMax");
			sinYMin = s.Serialize<float>(sinYMin, name: "sinYMin");
			sinYMax = s.Serialize<float>(sinYMax, name: "sinYMax");
			childBone = s.SerializeObject<StringID>(childBone, name: "childBone");
			childAttachOffset = s.SerializeObject<Vec2d>(childAttachOffset, name: "childAttachOffset");
			parentBones = s.SerializeObject<CListO<StringID>>(parentBones, name: "parentBones");
			handOffset = s.Serialize<float>(handOffset, name: "handOffset");
			collisionRadiusWhileMoving = s.Serialize<float>(collisionRadiusWhileMoving, name: "collisionRadiusWhileMoving");
			collisionRadiusMin = s.Serialize<float>(collisionRadiusMin, name: "collisionRadiusMin");
			collisionRadiusMax = s.Serialize<float>(collisionRadiusMax, name: "collisionRadiusMax");
			collisionAcceleration = s.Serialize<float>(collisionAcceleration, name: "collisionAcceleration");
			collisionRetractSpeed = s.Serialize<float>(collisionRetractSpeed, name: "collisionRetractSpeed");
			collisionRetractMinDuration = s.Serialize<float>(collisionRetractMinDuration, name: "collisionRetractMinDuration");
			collisionWaitDuration = s.Serialize<float>(collisionWaitDuration, name: "collisionWaitDuration");
			collisionDeploySpeed = s.Serialize<float>(collisionDeploySpeed, name: "collisionDeploySpeed");
			collisionDeployMinDuration = s.Serialize<float>(collisionDeployMinDuration, name: "collisionDeployMinDuration");
			tapRadius = s.Serialize<float>(tapRadius, name: "tapRadius");
			tapRetractDistance = s.Serialize<float>(tapRetractDistance, name: "tapRetractDistance");
			tapRetractSpeedSmoothA = s.Serialize<float>(tapRetractSpeedSmoothA, name: "tapRetractSpeedSmoothA");
			tapRetractSpeedSmoothB = s.Serialize<float>(tapRetractSpeedSmoothB, name: "tapRetractSpeedSmoothB");
			tapCooldown = s.Serialize<float>(tapCooldown, name: "tapCooldown");
			collisionShape = s.SerializeObject<Generic<PhysShape>>(collisionShape, name: "collisionShape");
		}
		public override uint? ClassCRC => 0xABE470E1;
		
	}
}

