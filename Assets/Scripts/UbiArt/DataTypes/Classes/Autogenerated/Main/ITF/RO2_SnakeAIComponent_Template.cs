using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SnakeAIComponent_Template : ActorComponent_Template {
		public float crushSpeedMultiplier;
		public float crushAccelerationMultiplier;
		public float crushAccelerateDuration;
		public float crushDecelerateDuration;
		public float tapSpeedMultiplier;
		public float tapAccelerationMultiplier;
		public float tapCooldownDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			crushSpeedMultiplier = s.Serialize<float>(crushSpeedMultiplier, name: "crushSpeedMultiplier");
			crushAccelerationMultiplier = s.Serialize<float>(crushAccelerationMultiplier, name: "crushAccelerationMultiplier");
			crushAccelerateDuration = s.Serialize<float>(crushAccelerateDuration, name: "crushAccelerateDuration");
			crushDecelerateDuration = s.Serialize<float>(crushDecelerateDuration, name: "crushDecelerateDuration");
			tapSpeedMultiplier = s.Serialize<float>(tapSpeedMultiplier, name: "tapSpeedMultiplier");
			tapAccelerationMultiplier = s.Serialize<float>(tapAccelerationMultiplier, name: "tapAccelerationMultiplier");
			tapCooldownDuration = s.Serialize<float>(tapCooldownDuration, name: "tapCooldownDuration");
		}
		public override uint? ClassCRC => 0x26E2EBD2;
	}
}

