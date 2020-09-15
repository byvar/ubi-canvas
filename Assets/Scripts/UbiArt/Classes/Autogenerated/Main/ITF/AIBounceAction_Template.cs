using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIBounceAction_Template : AIAction_Template {
		public float maxXSpeed;
		public float bounceForce;
		public float maxXSpeedThresholdForce;
		public Angle minBounceAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxXSpeed = s.Serialize<float>(maxXSpeed, name: "maxXSpeed");
			bounceForce = s.Serialize<float>(bounceForce, name: "bounceForce");
			maxXSpeedThresholdForce = s.Serialize<float>(maxXSpeedThresholdForce, name: "maxXSpeedThresholdForce");
			minBounceAngle = s.SerializeObject<Angle>(minBounceAngle, name: "minBounceAngle");
		}
		public override uint? ClassCRC => 0x63987C5A;
	}
}

