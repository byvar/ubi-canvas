using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CustomAnimEvt : Event {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(StringID__1));
		}
		public override uint? ClassCRC => 0x7C8DAB43;
	}
}

