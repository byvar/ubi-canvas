using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Dialog : W1W_InteractiveGenComponent {
		[Serialize("bool__0"    )] public bool bool__0;
		[Serialize("bool__1"    )] public bool bool__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		[Serialize("StringID__3")] public StringID StringID__3;
		[Serialize("StringID__4")] public StringID StringID__4;
		[Serialize("StringID__5")] public StringID StringID__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(bool__1));
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(StringID__3));
				SerializeField(s, nameof(StringID__4));
				SerializeField(s, nameof(StringID__5));
			}
		}
		public override uint? ClassCRC => 0x562EEC6F;
	}
}

