using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_SeasonalEventShopMenu : RLC_ShopScrollingMenu {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD9363798;
	}
}

