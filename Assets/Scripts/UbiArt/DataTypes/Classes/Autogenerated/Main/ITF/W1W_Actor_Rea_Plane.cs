using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Plane : W1W_Actor_Rea {
		public float float__0_;
		public float float__1_;
		public StringID StringID__2;
		public Color Color__3;
		public Color Color__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				float__0_ = s.Serialize<float>(float__0_, name: "float__0");
				float__1_ = s.Serialize<float>(float__1_, name: "float__1");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
				Color__3 = s.SerializeObject<Color>(Color__3, name: "Color__3");
				Color__4 = s.SerializeObject<Color>(Color__4, name: "Color__4");
			}
		}
		public override uint? ClassCRC => 0x9E67B116;
	}
}

