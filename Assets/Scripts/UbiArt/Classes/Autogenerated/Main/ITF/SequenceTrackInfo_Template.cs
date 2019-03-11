using UnityEngine;

namespace UbiArt.ITF {
	public partial class SequenceTrackInfo_Template : CSerializable {
		[Serialize("isEnable"   )] public bool isEnable;
		[Serialize("selected"   )] public bool selected;
		[Serialize("isGroup"    )] public bool isGroup;
		[Serialize("parentGroup")] public uint parentGroup;
		[Serialize("name"       )] public string name;
		[Serialize("fold"       )] public bool fold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isEnable));
			SerializeField(s, nameof(selected));
			SerializeField(s, nameof(isGroup));
			SerializeField(s, nameof(parentGroup));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(fold));
		}
	}
}

