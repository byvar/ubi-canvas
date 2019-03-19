using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIGround_ReceiveNormalHitAction_Template : RO2_AIGroundReceiveHitAction_Template {
		[Serialize("frictionMultiplier"         )] public float frictionMultiplier;
		[Serialize("gravityMultiplier"          )] public float gravityMultiplier;
		[Serialize("hitForce"                   )] public float hitForce;
		[Serialize("verticalHitForce"           )] public float verticalHitForce;
		[Serialize("randomHitForce"             )] public float randomHitForce;
		[Serialize("randomAngleMax"             )] public Angle randomAngleMax;
		[Serialize("antigravRampUpTime"         )] public float antigravRampUpTime;
		[Serialize("fullAntigravTime"           )] public float fullAntigravTime;
		[Serialize("antigravRampDownTime"       )] public float antigravRampDownTime;
		[Serialize("pushBackForce"              )] public float pushBackForce;
		[Serialize("canBlockHits"               )] public bool canBlockHits;
		[Serialize("minStunTime"                )] public float minStunTime;
		[Serialize("maxStunTime"                )] public float maxStunTime;
		[Serialize("ejectAnimSpeed"             )] public float ejectAnimSpeed;
		[Serialize("brakeForce"                 )] public float brakeForce;
		[Serialize("brakeHeight"                )] public float brakeHeight;
		[Serialize("speedLimit"                 )] public float speedLimit;
		[Serialize("mustFinishWithHurtTimer"    )] public bool mustFinishWithHurtTimer;
		[Serialize("resetSpeedAtStart"          )] public bool resetSpeedAtStart;
		[Serialize("orientVerticalForceToGround")] public bool orientVerticalForceToGround;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(frictionMultiplier));
			SerializeField(s, nameof(gravityMultiplier));
			SerializeField(s, nameof(hitForce));
			SerializeField(s, nameof(verticalHitForce));
			SerializeField(s, nameof(randomHitForce));
			SerializeField(s, nameof(randomAngleMax));
			SerializeField(s, nameof(antigravRampUpTime));
			SerializeField(s, nameof(fullAntigravTime));
			SerializeField(s, nameof(antigravRampDownTime));
			SerializeField(s, nameof(pushBackForce));
			SerializeField(s, nameof(canBlockHits));
			SerializeField(s, nameof(minStunTime));
			SerializeField(s, nameof(maxStunTime));
			SerializeField(s, nameof(ejectAnimSpeed));
			SerializeField(s, nameof(brakeForce));
			SerializeField(s, nameof(brakeHeight));
			SerializeField(s, nameof(speedLimit));
			SerializeField(s, nameof(mustFinishWithHurtTimer));
			SerializeField(s, nameof(resetSpeedAtStart));
			SerializeField(s, nameof(orientVerticalForceToGround));
		}
		public override uint? ClassCRC => 0xDB1C4F32;
	}
}

