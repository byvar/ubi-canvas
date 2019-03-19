using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventKarlHealed : Event {
		[Serialize("uint__0")] public uint uint__0;
		[Serialize("bool__1")] public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(bool__1));
		}
		public override uint? ClassCRC => 0x6BCFB0E8;
	}
}

