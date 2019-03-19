using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_SeasonalEventShopMenu_Template : RLC_ShopScrollingMenu_Template {
		[Serialize("watchVideoButtonPath")] public PathRef watchVideoButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(watchVideoButtonPath));
		}
		public override uint? ClassCRC => 0x66662C01;
	}
}

