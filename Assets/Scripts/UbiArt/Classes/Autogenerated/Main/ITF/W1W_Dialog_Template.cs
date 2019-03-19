using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Dialog_Template : W1W_InteractiveGenComponent_Template {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(StringID__3));
			}
		}
		public override uint? ClassCRC => 0x290673F8;
	}
}

