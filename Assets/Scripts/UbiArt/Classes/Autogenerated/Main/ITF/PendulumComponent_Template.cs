using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PendulumComponent_Template : ActorComponent_Template {
		[Serialize("pendulumLength"           )] public float pendulumLength;
		[Serialize("pendulumInitialAngle"     )] public float pendulumInitialAngle;
		[Serialize("pendulumInitialVelocity"  )] public float pendulumInitialVelocity;
		[Serialize("pendulumGravityMultiplier")] public float pendulumGravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pendulumLength));
			SerializeField(s, nameof(pendulumInitialAngle));
			SerializeField(s, nameof(pendulumInitialVelocity));
			SerializeField(s, nameof(pendulumGravityMultiplier));
		}
		public override uint? ClassCRC => 0x71CA7C14;
	}
}

