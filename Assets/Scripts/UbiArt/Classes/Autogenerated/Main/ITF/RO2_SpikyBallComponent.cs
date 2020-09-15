using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SpikyBallComponent : ActorComponent {
		public float torqueFriction;
		public float airFrictionMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			torqueFriction = s.Serialize<float>(torqueFriction, name: "torqueFriction");
			airFrictionMultiplier = s.Serialize<float>(airFrictionMultiplier, name: "airFrictionMultiplier");
		}
		public override uint? ClassCRC => 0x80EF4FD3;
	}
}

