using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EnduranceRule_Template : CSerializable {
		[Serialize("distanceOffset")] public float distanceOffset;
		[Serialize("distanceRepeat")] public float distanceRepeat;
		[Serialize("tags"          )] public CList<StringID> tags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(distanceOffset));
			SerializeField(s, nameof(distanceRepeat));
			SerializeField(s, nameof(tags));
		}
	}
}

