using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventHanging : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA8779A69;
	}
}

