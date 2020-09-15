using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_DuckPlugPlayableController_Template : RO2_ActorPlugTransfoController_Template {
		public float walkSpeed;
		public float runSpeed;
		public float flySpeed;
		public float wingBoost;
		public float wingXBoost;
		public float fallBreak;
		public float bounceImpulse;
		public float blendSpeedFactor;
		public float groundSpeedFactor;
		public float maxForce;
		public float breakingThreshold;
		public float speedReduce;
		public float speedFactorWhenHit;
		public float fallFriction;
		public float deadSoulSpeed;
		public float deadSoulControl;
		public float deadSoulForcedMove;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			walkSpeed = s.Serialize<float>(walkSpeed, name: "walkSpeed");
			runSpeed = s.Serialize<float>(runSpeed, name: "runSpeed");
			flySpeed = s.Serialize<float>(flySpeed, name: "flySpeed");
			wingBoost = s.Serialize<float>(wingBoost, name: "wingBoost");
			wingXBoost = s.Serialize<float>(wingXBoost, name: "wingXBoost");
			fallBreak = s.Serialize<float>(fallBreak, name: "fallBreak");
			bounceImpulse = s.Serialize<float>(bounceImpulse, name: "bounceImpulse");
			blendSpeedFactor = s.Serialize<float>(blendSpeedFactor, name: "blendSpeedFactor");
			groundSpeedFactor = s.Serialize<float>(groundSpeedFactor, name: "groundSpeedFactor");
			maxForce = s.Serialize<float>(maxForce, name: "maxForce");
			breakingThreshold = s.Serialize<float>(breakingThreshold, name: "breakingThreshold");
			speedReduce = s.Serialize<float>(speedReduce, name: "speedReduce");
			speedFactorWhenHit = s.Serialize<float>(speedFactorWhenHit, name: "speedFactorWhenHit");
			fallFriction = s.Serialize<float>(fallFriction, name: "fallFriction");
			deadSoulSpeed = s.Serialize<float>(deadSoulSpeed, name: "deadSoulSpeed");
			deadSoulControl = s.Serialize<float>(deadSoulControl, name: "deadSoulControl");
			deadSoulForcedMove = s.Serialize<float>(deadSoulForcedMove, name: "deadSoulForcedMove");
		}
		public override uint? ClassCRC => 0xCBD9D4E2;
	}
}

