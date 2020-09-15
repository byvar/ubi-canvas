using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBlowingBirdLookatBehavior_Template : TemplateAIBehavior {
		public Placeholder uturn;
		public Placeholder attack;
		public float beginDuration;
		public Angle rotationSpeed;
		public Angle minAngle;
		public Angle maxAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uturn = s.SerializeObject<Placeholder>(uturn, name: "uturn");
			attack = s.SerializeObject<Placeholder>(attack, name: "attack");
			beginDuration = s.Serialize<float>(beginDuration, name: "beginDuration");
			rotationSpeed = s.SerializeObject<Angle>(rotationSpeed, name: "rotationSpeed");
			minAngle = s.SerializeObject<Angle>(minAngle, name: "minAngle");
			maxAngle = s.SerializeObject<Angle>(maxAngle, name: "maxAngle");
		}
		public override uint? ClassCRC => 0x374B614A;
	}
}

