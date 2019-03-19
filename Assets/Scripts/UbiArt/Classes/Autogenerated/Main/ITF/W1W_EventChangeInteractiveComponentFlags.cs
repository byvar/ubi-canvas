using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventChangeInteractiveComponentFlags : Event {
		[Serialize("uint__0")] public uint uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
		}
		public override uint? ClassCRC => 0x6EAF284B;
	}
}

