using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_FruitAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("roamBehavior"                  )] public Generic<TemplateAIBehavior> roamBehavior;
		[Serialize("deathBehavior"                 )] public Generic<TemplateAIBehavior> deathBehavior;
		[Serialize("floatingBehavior"              )] public Generic<TemplateAIBehavior> floatingBehavior;
		[Serialize("receiveHitBehavior"            )] public Generic<TemplateAIBehavior> receiveHitBehavior;
		[Serialize("sleepBehavior"                 )] public Generic<TemplateAIBehavior> sleepBehavior;
		[Serialize("stuckBehavior"                 )] public Generic<TemplateAIBehavior> stuckBehavior;
		[Serialize("snappedBehavior"               )] public Generic<TemplateAIBehavior> snappedBehavior;
		[Serialize("isHanging"                     )] public int isHanging;
		[Serialize("nonStickableTime"              )] public float nonStickableTime;
		[Serialize("reinitWhenBecomesInactive"     )] public int reinitWhenBecomesInactive;
		[Serialize("canReceiveHit"                 )] public int canReceiveHit;
		[Serialize("shooterHitForce"               )] public float shooterHitForce;
		[Serialize("shooterHitSpeedMultiplier"     )] public float shooterHitSpeedMultiplier;
		[Serialize("squashPenetrationRadiusPercent")] public float squashPenetrationRadiusPercent;
		[Serialize("fruitsOverlap"                 )] public int fruitsOverlap;
		[Serialize("jamMaxTime"                    )] public float jamMaxTime;
		[Serialize("eyePath"                       )] public Path eyePath;
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
			SerializeField(s, nameof(fruitsOverlap));
			SerializeField(s, nameof(jamMaxTime));
			SerializeField(s, nameof(eyePath));
		}
		public override uint? ClassCRC => 0xCB7548C5;
	}
}

