using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_LuckyTicketStock : RLC_InventoryItem {
		[Serialize("ticketType")] public Enum_ticketType ticketType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ticketType));
		}
		public enum Enum_ticketType {
		}
		public override uint? ClassCRC => 0x85F1FD26;
	}
}

