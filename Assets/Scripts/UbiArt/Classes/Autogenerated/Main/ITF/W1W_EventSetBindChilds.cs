using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventSetBindChilds : Event {
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("bool__1"    )] public bool bool__1;
		[Serialize("bool__2"    )] public bool bool__2;
		[Serialize("bool__3"    )] public bool bool__3;
		[Serialize("bool__4"    )] public bool bool__4;
		[Serialize("bool__5"    )] public bool bool__5;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(StringID__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
			SerializeField(s, nameof(bool__4));
			SerializeField(s, nameof(bool__5));
		}
		public override uint? ClassCRC => 0xFD48BE51;
	}
}

