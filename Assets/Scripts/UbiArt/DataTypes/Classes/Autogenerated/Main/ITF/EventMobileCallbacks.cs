using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventMobileCallbacks : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x200A5AEF;
	}
}

