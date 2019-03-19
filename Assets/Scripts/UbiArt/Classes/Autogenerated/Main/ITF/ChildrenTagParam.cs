using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ChildrenTagParam : CSerializable {
		[Serialize("TagName")] public StringID TagName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TagName));
		}
	}
}

