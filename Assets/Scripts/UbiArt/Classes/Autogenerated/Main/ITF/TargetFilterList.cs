using UnityEngine;

namespace UbiArt.ITF {
	public partial class TargetFilterList : CSerializable {
		[Serialize("objects")] public CArray<string> objects;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(objects));
		}
	}
}

