using UnityEngine;

namespace UbiArt.ITF {
	public partial class RopeAttachmentComponent : ActorComponent {
		[Serialize("torqueFriction")] public float torqueFriction;
		[Serialize("speedFriction" )] public float speedFriction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(torqueFriction));
			SerializeField(s, nameof(speedFriction));
		}
		public override uint? ClassCRC => 0xBCF6A595;
	}
}

