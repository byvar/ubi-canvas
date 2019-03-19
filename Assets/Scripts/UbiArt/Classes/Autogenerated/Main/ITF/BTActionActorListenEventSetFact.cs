using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BTActionActorListenEventSetFact : BTAction {
		[Serialize("ListenEvent")] public Generic<Event> ListenEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ListenEvent));
		}
		public override uint? ClassCRC => 0xE5787CFF;
	}
}

