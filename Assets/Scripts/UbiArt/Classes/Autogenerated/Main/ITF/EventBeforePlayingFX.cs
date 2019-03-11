using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventBeforePlayingFX : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x99519FC5;
	}
}

