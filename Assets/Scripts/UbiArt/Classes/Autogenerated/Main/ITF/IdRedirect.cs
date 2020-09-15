using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class IdRedirect : CSerializable {
		public StringID src;
		public StringID dst;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			src = s.SerializeObject<StringID>(src, name: "src");
			dst = s.SerializeObject<StringID>(dst, name: "dst");
		}
	}
}

