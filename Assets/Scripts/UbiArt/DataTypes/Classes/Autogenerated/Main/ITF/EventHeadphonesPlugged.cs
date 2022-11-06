using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventHeadphonesPlugged : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x199D7DBE;
	}
}

