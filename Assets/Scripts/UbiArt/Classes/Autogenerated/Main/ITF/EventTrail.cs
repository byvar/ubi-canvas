using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTrail : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xACC5BE2F;
	}
}

