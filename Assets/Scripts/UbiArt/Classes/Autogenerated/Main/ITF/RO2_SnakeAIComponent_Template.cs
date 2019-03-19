using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeAIComponent_Template : ActorComponent_Template {
		[Serialize("crushSpeedMultiplier"       )] public float crushSpeedMultiplier;
		[Serialize("crushAccelerationMultiplier")] public float crushAccelerationMultiplier;
		[Serialize("crushAccelerateDuration"    )] public float crushAccelerateDuration;
		[Serialize("crushDecelerateDuration"    )] public float crushDecelerateDuration;
		[Serialize("tapSpeedMultiplier"         )] public float tapSpeedMultiplier;
		[Serialize("tapAccelerationMultiplier"  )] public float tapAccelerationMultiplier;
		[Serialize("tapCooldownDuration"        )] public float tapCooldownDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(crushSpeedMultiplier));
			SerializeField(s, nameof(crushAccelerationMultiplier));
			SerializeField(s, nameof(crushAccelerateDuration));
			SerializeField(s, nameof(crushDecelerateDuration));
			SerializeField(s, nameof(tapSpeedMultiplier));
			SerializeField(s, nameof(tapAccelerationMultiplier));
			SerializeField(s, nameof(tapCooldownDuration));
		}
		public override uint? ClassCRC => 0x26E2EBD2;
	}
}

