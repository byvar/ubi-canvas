using UnityEngine;

namespace UbiArt.ITF {
	public partial class ChildrenTagParam : CSerializable {
		[Serialize("TagName")] public StringID TagName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TagName));
		}
	}
}

