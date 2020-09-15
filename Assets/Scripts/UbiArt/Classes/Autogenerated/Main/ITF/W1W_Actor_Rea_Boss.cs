using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Boss : W1W_Actor_Rea {
		public StringID StringID__0;
		public StringID StringID__1;
		public StringID StringID__2;
		public StringID StringID__3;
		public float float__4_;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
			StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
			float__4_ = s.Serialize<float>(float__4_, name: "float__4_");
		}
		public override uint? ClassCRC => 0x0B0234EF;
	}
}

