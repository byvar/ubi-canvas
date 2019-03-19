using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DuckPlugPlayableController_Template : RO2_ActorPlugTransfoController_Template {
		[Serialize("walkSpeed"         )] public float walkSpeed;
		[Serialize("runSpeed"          )] public float runSpeed;
		[Serialize("flySpeed"          )] public float flySpeed;
		[Serialize("wingBoost"         )] public float wingBoost;
		[Serialize("wingXBoost"        )] public float wingXBoost;
		[Serialize("fallBreak"         )] public float fallBreak;
		[Serialize("bounceImpulse"     )] public float bounceImpulse;
		[Serialize("blendSpeedFactor"  )] public float blendSpeedFactor;
		[Serialize("groundSpeedFactor" )] public float groundSpeedFactor;
		[Serialize("maxForce"          )] public float maxForce;
		[Serialize("breakingThreshold" )] public float breakingThreshold;
		[Serialize("speedReduce"       )] public float speedReduce;
		[Serialize("speedFactorWhenHit")] public float speedFactorWhenHit;
		[Serialize("fallFriction"      )] public float fallFriction;
		[Serialize("deadSoulSpeed"     )] public float deadSoulSpeed;
		[Serialize("deadSoulControl"   )] public float deadSoulControl;
		[Serialize("deadSoulForcedMove")] public float deadSoulForcedMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(walkSpeed));
			SerializeField(s, nameof(runSpeed));
			SerializeField(s, nameof(flySpeed));
			SerializeField(s, nameof(wingBoost));
			SerializeField(s, nameof(wingXBoost));
			SerializeField(s, nameof(fallBreak));
			SerializeField(s, nameof(bounceImpulse));
			SerializeField(s, nameof(blendSpeedFactor));
			SerializeField(s, nameof(groundSpeedFactor));
			SerializeField(s, nameof(maxForce));
			SerializeField(s, nameof(breakingThreshold));
			SerializeField(s, nameof(speedReduce));
			SerializeField(s, nameof(speedFactorWhenHit));
			SerializeField(s, nameof(fallFriction));
			SerializeField(s, nameof(deadSoulSpeed));
			SerializeField(s, nameof(deadSoulControl));
			SerializeField(s, nameof(deadSoulForcedMove));
		}
		public override uint? ClassCRC => 0xCBD9D4E2;
	}
}

