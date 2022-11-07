namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_AIHunterAttackBehavior_Template : TemplateAIBehavior {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> aim;
		public Generic<Ray_AIHunterLaunchBulletAction_Template> hit;
		public Generic<AIAction_Template> giveup;
		public float attackDistance;
		public Angle minAngle;
		public Angle maxAngle;
		public int lookRight;
		public int DEBUG_disableAttack;
		public float giveUpRange;
		public float aimCursorRestingPos;
		public float aimTimeToFade;
		public float aimOffset;
		public int forceAngle;
		public Angle forcedAngle;
		public uint numBulletsPerCycle;
		public float timeBetweenBullets;
		public float timeBetweenCycles;
		public int canFlip;
		public float findEnemyRadius;
		public int useRadius;
		public AABB detectionRange;
		public Angle minArmAngle;
		public Angle maxArmAngle;
		public uint maxLivingMissiles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			aim = s.SerializeObject<Generic<AIAction_Template>>(aim, name: "aim");
			hit = s.SerializeObject<Generic<Ray_AIHunterLaunchBulletAction_Template>>(hit, name: "hit");
			giveup = s.SerializeObject<Generic<AIAction_Template>>(giveup, name: "giveup");
			attackDistance = s.Serialize<float>(attackDistance, name: "attackDistance");
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
			lookRight = s.Serialize<int>(lookRight, name: "lookRight");
			DEBUG_disableAttack = s.Serialize<int>(DEBUG_disableAttack, name: "DEBUG_disableAttack");
			giveUpRange = s.Serialize<float>(giveUpRange, name: "giveUpRange");
			aimCursorRestingPos = s.Serialize<float>(aimCursorRestingPos, name: "aimCursorRestingPos");
			aimTimeToFade = s.Serialize<float>(aimTimeToFade, name: "aimTimeToFade");
			aimOffset = s.Serialize<float>(aimOffset, name: "aimOffset");
			forceAngle = s.Serialize<int>(forceAngle, name: "forceAngle");
			forcedAngle = s.SerializeObject<Angle>(forcedAngle, name: "forcedAngle");
			numBulletsPerCycle = s.Serialize<uint>(numBulletsPerCycle, name: "numBulletsPerCycle");
			timeBetweenBullets = s.Serialize<float>(timeBetweenBullets, name: "timeBetweenBullets");
			timeBetweenCycles = s.Serialize<float>(timeBetweenCycles, name: "timeBetweenCycles");
			canFlip = s.Serialize<int>(canFlip, name: "canFlip");
			findEnemyRadius = s.Serialize<float>(findEnemyRadius, name: "findEnemyRadius");
			useRadius = s.Serialize<int>(useRadius, name: "useRadius");
			detectionRange = s.SerializeObject<AABB>(detectionRange, name: "detectionRange");
			minArmAngle = s.SerializeObject<Angle>(minArmAngle, name: "minArmAngle");
			maxArmAngle = s.SerializeObject<Angle>(maxArmAngle, name: "maxArmAngle");
			maxLivingMissiles = s.Serialize<uint>(maxLivingMissiles, name: "maxLivingMissiles");
		}
		public override uint? ClassCRC => 0x0703BB0D;
	}
}

