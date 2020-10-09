using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ToadPlugPlayableController : ActorPlugPlayableController {
		public float tweakJumpImpulse;
		public float tweakBoostedJumpImpulse;
		public float tweakBoostTolerance;
		public Vec2d tweakAirControlSpeed;
		public float tweakAirControlBlendSpeed;
		public float tweakAirControlMaxForce;
		public float tweakPhysGravityMultiplier;
		public float minUnPlugJumpHeightFactor;
		public float maxUnPlugJumpHeightFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				tweakJumpImpulse = s.Serialize<float>(tweakJumpImpulse, name: "tweakJumpImpulse");
				tweakBoostedJumpImpulse = s.Serialize<float>(tweakBoostedJumpImpulse, name: "tweakBoostedJumpImpulse");
				tweakBoostTolerance = s.Serialize<float>(tweakBoostTolerance, name: "tweakBoostTolerance");
				tweakAirControlSpeed = s.SerializeObject<Vec2d>(tweakAirControlSpeed, name: "tweakAirControlSpeed");
				tweakAirControlBlendSpeed = s.Serialize<float>(tweakAirControlBlendSpeed, name: "tweakAirControlBlendSpeed");
				tweakAirControlMaxForce = s.Serialize<float>(tweakAirControlMaxForce, name: "tweakAirControlMaxForce");
				tweakPhysGravityMultiplier = s.Serialize<float>(tweakPhysGravityMultiplier, name: "tweakPhysGravityMultiplier");
				minUnPlugJumpHeightFactor = s.Serialize<float>(minUnPlugJumpHeightFactor, name: "minUnPlugJumpHeightFactor");
				maxUnPlugJumpHeightFactor = s.Serialize<float>(maxUnPlugJumpHeightFactor, name: "maxUnPlugJumpHeightFactor");
			}
		}
		public override uint? ClassCRC => 0x869BA922;
	}
}

