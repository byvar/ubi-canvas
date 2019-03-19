using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIHunterAttackBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"               )] public Generic<AIAction_Template> idle;
		[Serialize("aim"                )] public Generic<AIAction_Template> aim;
		[Serialize("hit"                )] public Generic<Ray_AIHunterLaunchBulletAction_Template> hit;
		[Serialize("giveup"             )] public Generic<AIAction_Template> giveup;
		[Serialize("attackDistance"     )] public float attackDistance;
		[Serialize("minAngle"           )] public Angle minAngle;
		[Serialize("maxAngle"           )] public Angle maxAngle;
		[Serialize("lookRight"          )] public int lookRight;
		[Serialize("DEBUG_disableAttack")] public int DEBUG_disableAttack;
		[Serialize("giveUpRange"        )] public float giveUpRange;
		[Serialize("aimCursorRestingPos")] public float aimCursorRestingPos;
		[Serialize("aimTimeToFade"      )] public float aimTimeToFade;
		[Serialize("aimOffset"          )] public float aimOffset;
		[Serialize("forceAngle"         )] public int forceAngle;
		[Serialize("forcedAngle"        )] public Angle forcedAngle;
		[Serialize("numBulletsPerCycle" )] public uint numBulletsPerCycle;
		[Serialize("timeBetweenBullets" )] public float timeBetweenBullets;
		[Serialize("timeBetweenCycles"  )] public float timeBetweenCycles;
		[Serialize("canFlip"            )] public int canFlip;
		[Serialize("findEnemyRadius"    )] public float findEnemyRadius;
		[Serialize("useRadius"          )] public int useRadius;
		[Serialize("detectionRange"     )] public AABB detectionRange;
		[Serialize("minArmAngle"        )] public Angle minArmAngle;
		[Serialize("maxArmAngle"        )] public Angle maxArmAngle;
		[Serialize("maxLivingMissiles"  )] public uint maxLivingMissiles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(aim));
			SerializeField(s, nameof(hit));
			SerializeField(s, nameof(giveup));
			SerializeField(s, nameof(attackDistance));
			SerializeField(s, nameof(minAngle));
			SerializeField(s, nameof(maxAngle));
			SerializeField(s, nameof(lookRight));
			SerializeField(s, nameof(DEBUG_disableAttack));
			SerializeField(s, nameof(giveUpRange));
			SerializeField(s, nameof(aimCursorRestingPos));
			SerializeField(s, nameof(aimTimeToFade));
			SerializeField(s, nameof(aimOffset));
			SerializeField(s, nameof(forceAngle));
			SerializeField(s, nameof(forcedAngle));
			SerializeField(s, nameof(numBulletsPerCycle));
			SerializeField(s, nameof(timeBetweenBullets));
			SerializeField(s, nameof(timeBetweenCycles));
			SerializeField(s, nameof(canFlip));
			SerializeField(s, nameof(findEnemyRadius));
			SerializeField(s, nameof(useRadius));
			SerializeField(s, nameof(detectionRange));
			SerializeField(s, nameof(minArmAngle));
			SerializeField(s, nameof(maxArmAngle));
			SerializeField(s, nameof(maxLivingMissiles));
		}
		public override uint? ClassCRC => 0x0703BB0D;
	}
}

