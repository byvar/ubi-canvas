using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Boss : W1W_Actor_Rea {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		[Serialize("float__4"   )] public float float__4_;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(StringID__2));
			SerializeField(s, nameof(StringID__3));
			SerializeField(s, nameof(float__4_));
		}
		public override uint? ClassCRC => 0x0B0234EF;
	}
}

