using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WM_WorldRecapComponent_Template : CSerializable {
		public Path recapElem;
		public float yBGScale;
		public float xMaxBGScale;
		public float elemMaxLength;
		public float elemMaxScale;
		public float yOffsetFromBottom;
		public float transitionTime;
		public StringID boneToFollow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			recapElem = s.SerializeObject<Path>(recapElem, name: "recapElem");
			yBGScale = s.Serialize<float>(yBGScale, name: "yBGScale");
			xMaxBGScale = s.Serialize<float>(xMaxBGScale, name: "xMaxBGScale");
			elemMaxLength = s.Serialize<float>(elemMaxLength, name: "elemMaxLength");
			elemMaxScale = s.Serialize<float>(elemMaxScale, name: "elemMaxScale");
			yOffsetFromBottom = s.Serialize<float>(yOffsetFromBottom, name: "yOffsetFromBottom");
			transitionTime = s.Serialize<float>(transitionTime, name: "transitionTime");
			boneToFollow = s.SerializeObject<StringID>(boneToFollow, name: "boneToFollow");
		}
		public override uint? ClassCRC => 0x9ABDF755;
	}
}

