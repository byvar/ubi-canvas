using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ToadPlugPlayableController : ActorPlugPlayableController {
		[Serialize("tweakJumpImpulse"          )] public float tweakJumpImpulse;
		[Serialize("tweakBoostedJumpImpulse"   )] public float tweakBoostedJumpImpulse;
		[Serialize("tweakBoostTolerance"       )] public float tweakBoostTolerance;
		[Serialize("tweakAirControlSpeed"      )] public Vec2d tweakAirControlSpeed;
		[Serialize("tweakAirControlBlendSpeed" )] public float tweakAirControlBlendSpeed;
		[Serialize("tweakAirControlMaxForce"   )] public float tweakAirControlMaxForce;
		[Serialize("tweakPhysGravityMultiplier")] public float tweakPhysGravityMultiplier;
		[Serialize("minUnPlugJumpHeightFactor" )] public float minUnPlugJumpHeightFactor;
		[Serialize("maxUnPlugJumpHeightFactor" )] public float maxUnPlugJumpHeightFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(tweakJumpImpulse));
				SerializeField(s, nameof(tweakBoostedJumpImpulse));
				SerializeField(s, nameof(tweakBoostTolerance));
				SerializeField(s, nameof(tweakAirControlSpeed));
				SerializeField(s, nameof(tweakAirControlBlendSpeed));
				SerializeField(s, nameof(tweakAirControlMaxForce));
				SerializeField(s, nameof(tweakPhysGravityMultiplier));
				SerializeField(s, nameof(minUnPlugJumpHeightFactor));
				SerializeField(s, nameof(maxUnPlugJumpHeightFactor));
			}
		}
		public override uint? ClassCRC => 0x869BA922;
	}
}

