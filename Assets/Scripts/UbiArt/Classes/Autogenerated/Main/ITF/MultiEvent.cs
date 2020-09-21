using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class MultiEvent : Event {
		public CArrayO<Generic<Event>> eventList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eventList = s.SerializeObject<CArrayO<Generic<Event>>>(eventList, name: "eventList");
		}
		public override uint? ClassCRC => 0x7D0F222F;
	}
}

