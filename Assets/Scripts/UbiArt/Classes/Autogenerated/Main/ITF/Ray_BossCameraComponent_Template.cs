using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BossCameraComponent_Template : BaseCameraComponent_Template {
		[Serialize("attachBone")] public StringID attachBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(attachBone));
		}
		public override uint? ClassCRC => 0x9E57A0C3;
	}
}

