using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventActorRea_Wait : Event {
		[Serialize("bool__0"    )] public bool bool__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("bool__2"    )] public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(bool__2));
		}
		public override uint? ClassCRC => 0x9367F119;
	}
}

