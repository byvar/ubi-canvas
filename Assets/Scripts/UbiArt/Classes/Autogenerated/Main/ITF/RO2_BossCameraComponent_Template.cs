using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BossCameraComponent_Template : BaseCameraComponent_Template {
		[Serialize("attachBone")] public StringID attachBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(attachBone));
		}
		public override uint? ClassCRC => 0x9FE95EE7;
	}
}

