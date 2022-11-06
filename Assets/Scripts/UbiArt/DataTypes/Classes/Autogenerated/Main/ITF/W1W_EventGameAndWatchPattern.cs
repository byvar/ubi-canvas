using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventGameAndWatchPattern : Event {
		public uint uint__0;
		public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
		}
		public override uint? ClassCRC => 0x9D142EBF;
	}
}

