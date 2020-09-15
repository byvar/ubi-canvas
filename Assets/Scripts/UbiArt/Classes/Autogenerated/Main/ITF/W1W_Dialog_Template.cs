using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Dialog_Template : W1W_InteractiveGenComponent_Template {
		public StringID StringID__0;
		public StringID StringID__1_;
		public StringID StringID__2;
		public StringID StringID__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				StringID__1_ = s.SerializeObject<StringID>(StringID__1_, name: "StringID__1_");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
				StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
			}
		}
		public override uint? ClassCRC => 0x290673F8;
	}
}

