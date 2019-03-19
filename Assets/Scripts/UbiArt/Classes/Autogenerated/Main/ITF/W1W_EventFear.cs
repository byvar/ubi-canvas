using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventFear : Event {
		[Serialize("int__0")] public int int__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(int__0));
		}
		public override uint? ClassCRC => 0x414387A5;
	}
}

