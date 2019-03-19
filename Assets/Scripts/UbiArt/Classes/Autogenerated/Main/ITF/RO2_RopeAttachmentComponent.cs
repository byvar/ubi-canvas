using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RopeAttachmentComponent : ActorComponent {
		[Serialize("torqueFriction")] public float torqueFriction;
		[Serialize("speedFriction" )] public float speedFriction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(torqueFriction));
			SerializeField(s, nameof(speedFriction));
		}
		public override uint? ClassCRC => 0xB9F4AF56;
	}
}

