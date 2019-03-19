using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventHidePlayer : Event {
		[Serialize("bool__0")] public bool bool__0;
		[Serialize("bool__1")] public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(bool__1));
		}
		public override uint? ClassCRC => 0xE7782EEE;
	}
}

