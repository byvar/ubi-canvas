using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIShooterAttackBehavior_Template : TemplateAIBehavior {
		public Generic<AIIdleAction_Template> idle;
		public Generic<Ray_AIShooterLaunchBulletAction_Template> hit;
		public Generic<AIAction_Template> giveup;
		public float attackDistance;
		public StringID gunPivotBone;
		public int rotateUsingAnimation;
		public Angle minAngle;
		public Angle maxAngle;
		public int minMaxAngleFlip;
		public int lookRight;
		public float giveUpRange;
		public float aimCursorRestingPos;
		public float aimTimeToFade;
		public float aimOffset;
		public int forceAngle;
		public Angle forcedAngle;
		public int keepDirForBurst;
		public int autoForceDir;
		public int DEBUG_disableAttack;
		public StringID canonPivotBoneName;
		public StringID canonExtremityBoneName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIIdleAction_Template>>(idle, name: "idle");
			hit = s.SerializeObject<Generic<Ray_AIShooterLaunchBulletAction_Template>>(hit, name: "hit");
			giveup = s.SerializeObject<Generic<AIAction_Template>>(giveup, name: "giveup");
			attackDistance = s.Serialize<float>(attackDistance, name: "attackDistance");
			gunPivotBone = s.SerializeObject<StringID>(gunPivotBone, name: "gunPivotBone");
			rotateUsingAnimation = s.Serialize<int>(rotateUsingAnimation, name: "rotateUsingAnimation");
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			minMaxAngleFlip = s.Serialize<int>(minMaxAngleFlip, name: "minMaxAngleFlip");
			lookRight = s.Serialize<int>(lookRight, name: "lookRight");
			giveUpRange = s.Serialize<float>(giveUpRange, name: "giveUpRange");
			aimCursorRestingPos = s.Serialize<float>(aimCursorRestingPos, name: "aimCursorRestingPos");
			aimTimeToFade = s.Serialize<float>(aimTimeToFade, name: "aimTimeToFade");
			aimOffset = s.Serialize<float>(aimOffset, name: "aimOffset");
			forceAngle = s.Serialize<int>(forceAngle, name: "forceAngle");
			forcedAngle = s.SerializeObject<Angle>(forcedAngle, name: "forcedAngle");
			keepDirForBurst = s.Serialize<int>(keepDirForBurst, name: "keepDirForBurst");
			autoForceDir = s.Serialize<int>(autoForceDir, name: "autoForceDir");
			DEBUG_disableAttack = s.Serialize<int>(DEBUG_disableAttack, name: "DEBUG_disableAttack");
			canonPivotBoneName = s.SerializeObject<StringID>(canonPivotBoneName, name: "canonPivotBoneName");
			canonExtremityBoneName = s.SerializeObject<StringID>(canonExtremityBoneName, name: "canonExtremityBoneName");
		}
		public override uint? ClassCRC => 0x961F5753;
	}
}

