using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_NewComponent_Template : CSerializable {
		[Serialize("scale"            )] public float scale;
		[Serialize("yOffsetFromBottom")] public float yOffsetFromBottom;
		[Serialize("xOffsetFromLeft"  )] public float xOffsetFromLeft;
		[Serialize("transitionTime"   )] public float transitionTime;
		[Serialize("waitTime"         )] public float waitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(yOffsetFromBottom));
			SerializeField(s, nameof(xOffsetFromLeft));
			SerializeField(s, nameof(transitionTime));
			SerializeField(s, nameof(waitTime));
		}
		public override uint? ClassCRC => 0x63FD32D8;
	}
}

