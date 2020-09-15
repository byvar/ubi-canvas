using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionCopyFact_Template : BTAction_Template {
		public StringID src;
		public StringID dst;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			src = s.SerializeObject<StringID>(src, name: "src");
			dst = s.SerializeObject<StringID>(dst, name: "dst");
		}
		public override uint? ClassCRC => 0x52CB412D;
	}
}

