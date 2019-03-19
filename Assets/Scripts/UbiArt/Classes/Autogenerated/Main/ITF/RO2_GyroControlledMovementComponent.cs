using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GyroControlledMovementComponent : ActorComponent {
		[Serialize("maxSpeed")] public float maxSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxSpeed));
		}
		public override uint? ClassCRC => 0x2079E709;
	}
}

