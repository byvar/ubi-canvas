using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CraftingMenu_Template : CSerializable {
		public StringID craftingAvailableFX;
		public StringID craftSuccessFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			craftingAvailableFX = s.SerializeObject<StringID>(craftingAvailableFX, name: "craftingAvailableFX");
			craftSuccessFX = s.SerializeObject<StringID>(craftSuccessFX, name: "craftSuccessFX");
		}
		public override uint? ClassCRC => 0x6AC2A5BB;
	}
}

