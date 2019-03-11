using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionCopyFact_Template : BTAction_Template {
		[Serialize("src")] public StringID src;
		[Serialize("dst")] public StringID dst;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(src));
			SerializeField(s, nameof(dst));
		}
		public override uint? ClassCRC => 0x52CB412D;
	}
}

