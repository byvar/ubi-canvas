using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RAVersion)]
	public partial class EventReleaseRope : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x84F8886D;
	}
}

