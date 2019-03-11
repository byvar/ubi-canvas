using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_FruitAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("roamBehavior"                  )] public Placeholder roamBehavior;
		[Serialize("deathBehavior"                 )] public Placeholder deathBehavior;
		[Serialize("floatingBehavior"              )] public Placeholder floatingBehavior;
		[Serialize("receiveHitBehavior"            )] public Placeholder receiveHitBehavior;
		[Serialize("sleepBehavior"                 )] public Placeholder sleepBehavior;
		[Serialize("stuckBehavior"                 )] public Placeholder stuckBehavior;
		[Serialize("snappedBehavior"               )] public Placeholder snappedBehavior;
		[Serialize("isHanging"                     )] public bool isHanging;
		[Serialize("nonStickableTime"              )] public float nonStickableTime;
		[Serialize("reinitWhenBecomesInactive"     )] public bool reinitWhenBecomesInactive;
		[Serialize("canReceiveHit"                 )] public bool canReceiveHit;
		[Serialize("shooterHitForce"               )] public float shooterHitForce;
		[Serialize("shooterHitSpeedMultiplier"     )] public float shooterHitSpeedMultiplier;
		[Serialize("squashPenetrationRadiusPercent")] public float squashPenetrationRadiusPercent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(roamBehavior));
			SerializeField(s, nameof(deathBehavior));
			SerializeField(s, nameof(floatingBehavior));
			SerializeField(s, nameof(receiveHitBehavior));
			SerializeField(s, nameof(sleepBehavior));
			SerializeField(s, nameof(stuckBehavior));
			SerializeField(s, nameof(snappedBehavior));
			SerializeField(s, nameof(isHanging));
			SerializeField(s, nameof(nonStickableTime));
			SerializeField(s, nameof(reinitWhenBecomesInactive));
			SerializeField(s, nameof(canReceiveHit));
			SerializeField(s, nameof(shooterHitForce));
			SerializeField(s, nameof(shooterHitSpeedMultiplier));
			SerializeField(s, nameof(squashPenetrationRadiusPercent));
		}
		public override uint? ClassCRC => 0x1769E45A;
	}
}

