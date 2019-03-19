using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_GroundEnemyAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("roamBehavior"                 )] public Generic<TemplateAIBehavior> roamBehavior;
		[Serialize("receiveHitBehavior"           )] public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"                )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("crushedBehavior"              )] public Generic<TemplateAIBehavior> crushedBehavior;
		[Serialize("spawnBehavior"                )] public Generic<TemplateAIBehavior> spawnBehavior;
		[Serialize("closeRangeAttackBehavior"     )] public Generic<TemplateAIBehavior> closeRangeAttackBehavior;
		[Serialize("hitWallBehavior"              )] public Generic<Ray_AIHitWallBehavior_Template> hitWallBehavior;
		[Serialize("sleepBehavior"                )] public Generic<Ray_AISleepBehavior_Template> sleepBehavior;
		[Serialize("closeRangeDetectionShape"     )] public Generic<PhysShape> closeRangeDetectionShape;
		[Serialize("closeRangeAttackPushBackForce")] public float closeRangeAttackPushBackForce;
		[Serialize("squashPenetrationRadius"      )] public float squashPenetrationRadius;
		[Serialize("dieInWater"                   )] public int dieInWater;
		[Serialize("rayCastDist"                  )] public float rayCastDist;
		[Serialize("checkSquash"                  )] public int checkSquash;
		[Serialize("unbindChildrenOnHit"          )] public int unbindChildrenOnHit;
		[Serialize("checkStickForCloseRangeAttack")] public int checkStickForCloseRangeAttack;
		[Serialize("detectHunterOwnBullet"        )] public int detectHunterOwnBullet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(roamBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(crushedBehavior));
			SerializeField(s, nameof(spawnBehavior));
			SerializeField(s, nameof(closeRangeAttackBehavior));
			SerializeField(s, nameof(hitWallBehavior));
			SerializeField(s, nameof(sleepBehavior));
			SerializeField(s, nameof(closeRangeDetectionShape));
			SerializeField(s, nameof(closeRangeAttackPushBackForce));
			SerializeField(s, nameof(squashPenetrationRadius));
			SerializeField(s, nameof(dieInWater));
			SerializeField(s, nameof(rayCastDist));
			SerializeField(s, nameof(checkSquash));
			SerializeField(s, nameof(unbindChildrenOnHit));
			SerializeField(s, nameof(checkStickForCloseRangeAttack));
			SerializeField(s, nameof(detectHunterOwnBullet));
		}
		public override uint? ClassCRC => 0x4053D4E8;
	}
}

