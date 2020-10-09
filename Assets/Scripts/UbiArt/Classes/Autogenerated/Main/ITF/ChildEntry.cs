using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class ChildEntry : CSerializable {
		public ObjectPath Path;
		public CListO<TagValue> TagValues;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path = s.SerializeObject<ObjectPath>(Path, name: "Path");
			TagValues = s.SerializeObject<CListO<TagValue>>(TagValues, name: "TagValues");
		}
	}
}

