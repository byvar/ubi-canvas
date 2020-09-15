using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AISwordFishBehavior_Template : TemplateAIBehavior {
		public Placeholder idle;
		public Placeholder anticipation;
		public Placeholder attack;
		public Placeholder stuck;
		public Placeholder detectionShape;
		public float anticipationDuration;
		public float force;
		public float maxSpeed;
		public float minSpeed;
		public float offsetDist;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Placeholder>(idle, name: "idle");
			anticipation = s.SerializeObject<Placeholder>(anticipation, name: "anticipation");
			attack = s.SerializeObject<Placeholder>(attack, name: "attack");
			stuck = s.SerializeObject<Placeholder>(stuck, name: "stuck");
			detectionShape = s.SerializeObject<Placeholder>(detectionShape, name: "detectionShape");
			anticipationDuration = s.Serialize<float>(anticipationDuration, name: "anticipationDuration");
			force = s.Serialize<float>(force, name: "force");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
			offsetDist = s.Serialize<float>(offsetDist, name: "offsetDist");
		}
		public override uint? ClassCRC => 0xE0DE0498;
	}
}

