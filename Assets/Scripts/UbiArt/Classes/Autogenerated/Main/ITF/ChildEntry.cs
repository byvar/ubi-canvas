using UnityEngine;

namespace UbiArt.ITF {
	public partial class ChildEntry : CSerializable {
		[Serialize("Path"     )] public ObjectPath Path;
		[Serialize("TagValues")] public CList<TagValue> TagValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Path));
			SerializeField(s, nameof(TagValues));
		}
	}
}

