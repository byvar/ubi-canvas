using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventNPCRoaming : Event {
		[Serialize("bool__0"    )] public bool bool__0;
		[Serialize("bool__1"    )] public bool bool__1;
		[Serialize("StringID__2")] public StringID StringID__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(StringID__2));
		}
		public override uint? ClassCRC => 0x7118B8E4;
	}
}

