using UnityEngine;

namespace UbiArt.ITF {
	public partial class TagValue : CSerializable {
		[Serialize("Tag"  )] public StringID Tag;
		[Serialize("Value")] public string Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Tag));
			SerializeField(s, nameof(Value));
		}
	}
}

