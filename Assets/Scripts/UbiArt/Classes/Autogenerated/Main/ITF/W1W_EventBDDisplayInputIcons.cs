using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventBDDisplayInputIcons : Event {
		[Serialize("bool__0")] public bool bool__0;
		[Serialize("uint__1")] public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(uint__1));
		}
		public override uint? ClassCRC => 0x7F15D99D;
	}
}

