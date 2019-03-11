using UnityEngine;

namespace UbiArt.ITF {
	public partial class Animation3DSet_Template : CSerializable {
		[Serialize("animations")] public CList<Animation3DInfo_Template> animations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animations));
		}
	}
}

