using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventLuckyTicketOfferEnd : Event {
		public int friendID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			friendID = s.Serialize<int>(friendID, name: "friendID");
		}
		public override uint? ClassCRC => 0xEA32E78E;
	}
}

