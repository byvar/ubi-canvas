using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GroundEnemyAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("roamBehavior"                 )] public Generic<TemplateAIBehavior> roamBehavior;
		[Serialize("receiveHitBehavior"           )] public Generic<RO2_AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("deathBehavior"                )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("crushedBehavior"              )] public Generic<TemplateAIBehavior> crushedBehavior;
		[Serialize("spawnBehavior"                )] public Generic<TemplateAIBehavior> spawnBehavior;
		[Serialize("closeRangeAttackBehavior"     )] public Generic<TemplateAIBehavior> closeRangeAttackBehavior;
		[Serialize("hitWallBehavior"              )] public Generic<RO2_AIHitWallBehavior_Template> hitWallBehavior;
		[Serialize("sleepBehavior"                )] public Generic<RO2_AISleepBehavior_Template> sleepBehavior;
		[Serialize("closeRangeDetectionShape"     )] public Generic<PhysShape> closeRangeDetectionShape;
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
		public override uint? ClassCRC => 0x5E424511;
	}
}

