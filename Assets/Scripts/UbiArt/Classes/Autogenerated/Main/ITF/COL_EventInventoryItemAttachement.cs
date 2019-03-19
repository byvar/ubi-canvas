using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_EventInventoryItemAttachement : CSerializable {
		[Serialize("sender")] public uint sender;
		[Serialize("action")] public Enum_action action;
		[Serialize("itemID")] public StringID itemID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sender));
			SerializeField(s, nameof(action));
			SerializeField(s, nameof(itemID));
		}
		public enum Enum_action {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0x1DA2E705;
	}
}

