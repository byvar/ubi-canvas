using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventLuckyTicketOfferEnd : Event {
		[Serialize("friendID")] public int friendID;
		[Serialize("friendID")] public bool friendID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(friendID));
			} else {
				SerializeField(s, nameof(friendID));
			}
		}
		public override uint? ClassCRC => 0xEA32E78E;
	}
}

