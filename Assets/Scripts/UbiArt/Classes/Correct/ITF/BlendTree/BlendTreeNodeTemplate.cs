using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class BlendTreeNodeTemplate<T> : CSerializable {
		public StringID nodeName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nodeName = s.SerializeObject<StringID>(nodeName, name: "nodeName");
		}
		public override uint? ClassCRC => 0x61D64AC7;
	}
}

