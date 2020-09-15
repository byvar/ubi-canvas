using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_NewComponent_Template : CSerializable {
		public float scale;
		public float yOffsetFromBottom;
		public float xOffsetFromLeft;
		public float transitionTime;
		public float waitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scale = s.Serialize<float>(scale, name: "scale");
			yOffsetFromBottom = s.Serialize<float>(yOffsetFromBottom, name: "yOffsetFromBottom");
			xOffsetFromLeft = s.Serialize<float>(xOffsetFromLeft, name: "xOffsetFromLeft");
			transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
			waitTime = s.Serialize<float>(waitTime, name: "waitTime");
		}
		public override uint? ClassCRC => 0x63FD32D8;
	}
}

