using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameAndWatchPattern : Event {
		[Serialize("uint__0" )] public uint uint__0;
		[Serialize("float__1")] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0x9D142EBF;
	}
}

