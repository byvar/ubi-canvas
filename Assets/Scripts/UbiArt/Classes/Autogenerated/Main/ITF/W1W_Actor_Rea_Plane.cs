using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Plane : W1W_Actor_Rea {
		[Serialize("float__0"   )] public float float__0_;
		[Serialize("float__1"   )] public float float__1_;
		[Serialize("StringID__2")] public StringID StringID__2;
		[Serialize("Color__3"   )] public Color Color__3;
		[Serialize("Color__4"   )] public Color Color__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(float__0_));
				SerializeField(s, nameof(float__1_));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(Color__3));
				SerializeField(s, nameof(Color__4));
			}
		}
		public override uint? ClassCRC => 0x9E67B116;
	}
}

