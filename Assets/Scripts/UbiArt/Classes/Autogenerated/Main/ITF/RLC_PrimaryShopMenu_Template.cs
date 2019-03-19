using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_PrimaryShopMenu_Template : RLC_ShopScrollingMenu_Template {
		[Serialize("starterPackButtonPath")] public PathRef starterPackButtonPath;
		[Serialize("watchVideoButtonPath" )] public PathRef watchVideoButtonPath;
		[Serialize("gemPackButtonPath"    )] public PathRef gemPackButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(starterPackButtonPath));
			SerializeField(s, nameof(watchVideoButtonPath));
			SerializeField(s, nameof(gemPackButtonPath));
		}
		public override uint? ClassCRC => 0x342834A7;
	}
}

