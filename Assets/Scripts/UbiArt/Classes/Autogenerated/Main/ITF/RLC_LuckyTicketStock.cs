using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_LuckyTicketStock : RLC_InventoryItem {
		public Enum_ticketType ticketType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ticketType = s.Serialize<Enum_ticketType>(ticketType, name: "ticketType");
		}
		public enum Enum_ticketType {
		}
		public override uint? ClassCRC => 0x85F1FD26;
	}
}

