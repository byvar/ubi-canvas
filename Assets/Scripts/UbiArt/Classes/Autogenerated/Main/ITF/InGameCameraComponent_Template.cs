using UnityEngine;

namespace UbiArt.ITF {
	public partial class InGameCameraComponent_Template : BaseCameraComponent_Template {
		[Serialize("CM")] public CamModifier_Template CM;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CM));
		}
		public override uint? ClassCRC => 0xD96E4BFB;
	}
}

