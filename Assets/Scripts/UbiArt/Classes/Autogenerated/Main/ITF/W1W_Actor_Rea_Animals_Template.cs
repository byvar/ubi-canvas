using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Animals_Template : W1W_Actor_Rea_Template {
		public StringID StringID__0_;
		public StringID StringID__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0_ = s.SerializeObject<StringID>(StringID__0_, name: "StringID__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
		}
		public override uint? ClassCRC => 0x9C47DBFC;
	}
}

