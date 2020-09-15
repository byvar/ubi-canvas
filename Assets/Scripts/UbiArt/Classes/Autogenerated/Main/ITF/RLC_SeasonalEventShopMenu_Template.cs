using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SeasonalEventShopMenu_Template : RLC_ShopScrollingMenu_Template {
		public PathRef watchVideoButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			watchVideoButtonPath = s.SerializeObject<PathRef>(watchVideoButtonPath, name: "watchVideoButtonPath");
		}
		public override uint? ClassCRC => 0x66662C01;
	}
}

