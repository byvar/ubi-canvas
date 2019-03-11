using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSwiming : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x932E5C13;
	}
}

