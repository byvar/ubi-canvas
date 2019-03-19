using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventLuckyTicketOfferEnd : Event {
		[Serialize("friendID")] public int friendID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(friendID));
		}
		public override uint? ClassCRC => 0xEA32E78E;
	}
}

