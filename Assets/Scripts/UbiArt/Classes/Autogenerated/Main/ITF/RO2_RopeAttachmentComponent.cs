using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RopeAttachmentComponent : ActorComponent {
		public float torqueFriction;
		public float speedFriction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			torqueFriction = s.Serialize<float>(torqueFriction, name: "torqueFriction");
			speedFriction = s.Serialize<float>(speedFriction, name: "speedFriction");
		}
		public override uint? ClassCRC => 0xB9F4AF56;
	}
}

