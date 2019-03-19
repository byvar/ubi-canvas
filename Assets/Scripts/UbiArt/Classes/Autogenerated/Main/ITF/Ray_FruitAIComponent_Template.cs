using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_FruitAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("roamBehavior"                  )] public Generic<Ray_AIFruitRoamingBehavior_Template> roamBehavior;
		[Serialize("deathBehavior"                 )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("floatingBehavior"              )] public Generic<Ray_AIWaterBaseBehavior_Template> floatingBehavior;
		[Serialize("receiveHitBehavior"            )] public Generic<Ray_AIReceiveHitBehavior_Template> receiveHitBehavior;
		[Serialize("sleepBehavior"                 )] public Generic<Ray_AISleepBehavior_Template> sleepBehavior;
		[Serialize("stuckBehavior"                 )] public Generic<TemplateAIBehavior> stuckBehavior;
		[Serialize("snappedBehavior"               )] public Generic<TemplateAIBehavior> snappedBehavior;
		[Serialize("isHanging"                     )] public int isHanging;
		[Serialize("nonStickableTime"              )] public float nonStickableTime;
		[Serialize("reinitWhenBecomesInactive"     )] public int reinitWhenBecomesInactive;
		[Serialize("canReceiveHit"                 )] public int canReceiveHit;
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

