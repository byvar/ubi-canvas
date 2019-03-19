using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea_Plane_Template : W1W_Actor_Rea_Template {
		[Serialize("uint__0"    )] public uint uint__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		[Serialize("StringID__4")] public StringID StringID__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(StringID__2));
			SerializeField(s, nameof(StringID__3));
			SerializeField(s, nameof(StringID__4));
		}
		public override uint? ClassCRC => 0xA3C49EAE;
	}
}

