using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventInventoryItemAttachement : Event {
		public Enum_action action;
		public StringID itemID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			action = s.Serialize<Enum_action>(action, name: "action");
			itemID = s.SerializeObject<StringID>(itemID, name: "itemID");
		}
		public enum Enum_action {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x1DA2E705;
	}
}

