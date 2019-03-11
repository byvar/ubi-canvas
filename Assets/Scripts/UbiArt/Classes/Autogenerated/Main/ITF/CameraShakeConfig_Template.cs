using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraShakeConfig_Template : TemplateObj {
		[Serialize("shakes")] public CList<CameraShake> shakes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(shakes));
		}
		public override uint? ClassCRC => 0x04623994;
	}
}

