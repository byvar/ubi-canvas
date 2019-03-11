using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_ElixirShopMenu : RLC_ShopScrollingMenu {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x53526ADB;
	}
}

