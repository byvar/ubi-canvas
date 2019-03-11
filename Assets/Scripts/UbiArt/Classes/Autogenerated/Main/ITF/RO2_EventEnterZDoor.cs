using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventEnterZDoor : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC9AD121B;
	}
}

