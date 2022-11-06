using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class RopeAttachmentComponent : ActorComponent {
		public float torqueFriction;
		public float speedFriction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			torqueFriction = s.Serialize<float>(torqueFriction, name: "torqueFriction");
			speedFriction = s.Serialize<float>(speedFriction, name: "speedFriction");
		}
		public override uint? ClassCRC => 0xBCF6A595;
	}
}

