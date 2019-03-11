using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventOnNetworkObjectReady : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF6B26B19;
	}
}

