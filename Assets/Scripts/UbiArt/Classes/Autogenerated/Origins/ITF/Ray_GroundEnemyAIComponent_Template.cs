using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_GroundEnemyAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("roamBehavior"                 )] public Placeholder roamBehavior;
		[Serialize("receiveHitBehavior"           )] public Placeholder receiveHitBehavior;
		[Serialize("deathBehavior"                )] public Placeholder deathBehavior;
		[Serialize("crushedBehavior"              )] public Placeholder crushedBehavior;
		[Serialize("spawnBehavior"                )] public Placeholder spawnBehavior;
		[Serialize("closeRangeAttackBehavior"     )] public Placeholder closeRangeAttackBehavior;
		[Serialize("hitWallBehavior"              )] public Placeholder hitWallBehavior;
		[Serialize("sleepBehavior"                )] public Placeholder sleepBehavior;
		[Serialize("closeRangeDetectionShape"     )] public Placeholder closeRangeDetectionShape;
		[Serialize("closeRangeAttackPushBackForce")] public float closeRangeAttackPushBackForce;
		[Serialize("squashPenetrationRadius"      )] public float squashPenetrationRadius;
		[Serialize("dieInWater"                   )] public bool dieInWater;
		[Serialize("rayCastDist"                  )] public float rayCastDist;
		[Serialize("checkSquash"                  )] public bool checkSquash;
		[Serialize("unbindChildrenOnHit"          )] public bool unbindChildrenOnHit;
		[Serialize("checkStickForCloseRangeAttack")] public bool checkStickForCloseRangeAttack;
		[Serialize("detectHunterOwnBullet"        )] public bool detectHunterOwnBullet;
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

