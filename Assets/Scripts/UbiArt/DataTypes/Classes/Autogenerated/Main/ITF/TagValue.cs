using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class TagValue : CSerializable {
		public StringID Tag;
		public string Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Tag = s.SerializeObject<StringID>(Tag, name: "Tag");
			Value = s.Serialize<string>(Value, name: "Value");
		}
	}
}

