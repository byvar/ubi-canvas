using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AISwordFishBehavior_Template : RO2_AIGroundBaseBehavior_Template {
		public Generic<AIAction_Template> idle;
		public Generic<AIAction_Template> anticipation;
		public Generic<AIAction_Template> attack;
		public Generic<AIAction_Template> stuck;
		public Generic<PhysShape> detectionShape;
		public float anticipationDuration;
		public float force;
		public float maxSpeed;
		public float minSpeed;
		public float offsetDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIAction_Template>>(idle, name: "idle");
			anticipation = s.SerializeObject<Generic<AIAction_Template>>(anticipation, name: "anticipation");
			attack = s.SerializeObject<Generic<AIAction_Template>>(attack, name: "attack");
			stuck = s.SerializeObject<Generic<AIAction_Template>>(stuck, name: "stuck");
			detectionShape = s.SerializeObject<Generic<PhysShape>>(detectionShape, name: "detectionShape");
			anticipationDuration = s.Serialize<float>(anticipationDuration, name: "anticipationDuration");
			force = s.Serialize<float>(force, name: "force");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			offsetDist = s.Serialize<float>(offsetDist, name: "offsetDist");
		}
		public override uint? ClassCRC => 0xA9185A9A;
	}
}

