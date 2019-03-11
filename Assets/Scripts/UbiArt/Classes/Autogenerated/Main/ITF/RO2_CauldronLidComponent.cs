using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CauldronLidComponent : ActorComponent {
		[Serialize("touchHandler"          )] public RO2_TouchHandler touchHandler;
		[Serialize("speedFactor"           )] public float speedFactor;
		[Serialize("smoothFactor"          )] public float smoothFactor;
		[Serialize("targetSmoothFactor"    )] public float targetSmoothFactor;
		[Serialize("attachmentBone"        )] public StringID attachmentBone;
		[Serialize("cauldronAttachmentBone")] public StringID cauldronAttachmentBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(touchHandler));
				SerializeField(s, nameof(speedFactor));
				SerializeField(s, nameof(smoothFactor));
				SerializeField(s, nameof(targetSmoothFactor));
				SerializeField(s, nameof(attachmentBone));
				SerializeField(s, nameof(cauldronAttachmentBone));
			}
		}
		public override uint? ClassCRC => 0xEE8704C7;
	}
}

