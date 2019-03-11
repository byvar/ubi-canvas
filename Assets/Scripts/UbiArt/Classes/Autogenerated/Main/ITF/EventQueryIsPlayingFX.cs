using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventQueryIsPlayingFX : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6E3DB0D8;
	}
}

