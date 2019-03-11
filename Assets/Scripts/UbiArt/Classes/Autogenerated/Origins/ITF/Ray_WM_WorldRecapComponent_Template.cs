using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_WM_WorldRecapComponent_Template : CSerializable {
		[Serialize("recapElem"        )] public Path recapElem;
		[Serialize("yBGScale"         )] public float yBGScale;
		[Serialize("xMaxBGScale"      )] public float xMaxBGScale;
		[Serialize("elemMaxLength"    )] public float elemMaxLength;
		[Serialize("elemMaxScale"     )] public float elemMaxScale;
		[Serialize("yOffsetFromBottom")] public float yOffsetFromBottom;
		[Serialize("transitionTime"   )] public float transitionTime;
		[Serialize("boneToFollow"     )] public StringID boneToFollow;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(recapElem));
			SerializeField(s, nameof(yBGScale));
			SerializeField(s, nameof(xMaxBGScale));
			SerializeField(s, nameof(elemMaxLength));
			SerializeField(s, nameof(elemMaxScale));
			SerializeField(s, nameof(yOffsetFromBottom));
			SerializeField(s, nameof(transitionTime));
			SerializeField(s, nameof(boneToFollow));
		}
		public override uint? ClassCRC => 0x9ABDF755;
	}
}

