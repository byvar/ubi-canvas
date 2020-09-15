using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class ChildrenTagParam : CSerializable {
		public StringID TagName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TagName = s.SerializeObject<StringID>(TagName, name: "TagName");
		}
	}
}

