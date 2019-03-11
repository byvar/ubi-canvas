using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryBlocksHits : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x07F8710C;
	}
}

