using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Plane_Template : W1W_Actor_Rea_Template {
		public uint uint__0;
		public StringID StringID__1;
		public StringID StringID__2;
		public StringID StringID__3;
		public StringID StringID__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
			StringID__3 = s.SerializeObject<StringID>(StringID__3, name: "StringID__3");
			StringID__4 = s.SerializeObject<StringID>(StringID__4, name: "StringID__4");
		}
		public override uint? ClassCRC => 0xA3C49EAE;
	}
}

