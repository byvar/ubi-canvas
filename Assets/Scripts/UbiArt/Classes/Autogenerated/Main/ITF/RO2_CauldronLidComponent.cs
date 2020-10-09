using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CauldronLidComponent : ActorComponent {
		public RO2_TouchHandler touchHandler;
		public float speedFactor;
		public float smoothFactor;
		public float targetSmoothFactor;
		public StringID attachmentBone;
		public StringID cauldronAttachmentBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				touchHandler = s.SerializeObject<RO2_TouchHandler>(touchHandler, name: "touchHandler");
				speedFactor = s.Serialize<float>(speedFactor, name: "speedFactor");
				smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
				targetSmoothFactor = s.Serialize<float>(targetSmoothFactor, name: "targetSmoothFactor");
				attachmentBone = s.SerializeObject<StringID>(attachmentBone, name: "attachmentBone");
				cauldronAttachmentBone = s.SerializeObject<StringID>(cauldronAttachmentBone, name: "cauldronAttachmentBone");
			}
		}
		public override uint? ClassCRC => 0xEE8704C7;
	}
}

