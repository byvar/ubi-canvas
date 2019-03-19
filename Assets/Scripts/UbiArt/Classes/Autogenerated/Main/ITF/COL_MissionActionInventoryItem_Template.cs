using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionActionInventoryItem_Template : CSerializable {
		[Description("item")]
		[Serialize("itemID"   )] public StringID itemID;
		[Serialize("add"      )] public bool add;
		[Serialize("showpopup")] public bool showpopup;
		[Description("quantity")]
		[Serialize("quantity" )] public uint quantity;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(itemID));
			SerializeField(s, nameof(add), boolAsByte: true);
			SerializeField(s, nameof(showpopup), boolAsByte: true);
			SerializeField(s, nameof(quantity));
		}
		public override uint? ClassCRC => 0x392801DF;
	}
}

