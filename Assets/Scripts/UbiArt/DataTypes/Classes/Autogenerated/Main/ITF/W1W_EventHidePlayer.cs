using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventHidePlayer : Event {
		public bool bool__0;
		public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
			bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
		}
		public override uint? ClassCRC => 0xE7782EEE;
	}
}

