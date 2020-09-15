using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class ChildEntry : CSerializable {
		public ObjectPath Path;
		public CList<TagValue> TagValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path = s.SerializeObject<ObjectPath>(Path, name: "Path");
			TagValues = s.SerializeObject<CList<TagValue>>(TagValues, name: "TagValues");
		}
	}
}

