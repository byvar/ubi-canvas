using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ChallengeShopMenu_Template : RLC_ShopScrollingMenu_Template {
		[Serialize("watchVideoButtonPath"       )] public PathRef watchVideoButtonPath;
		[Serialize("seasonalEventPackButtonPath")] public PathRef seasonalEventPackButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(watchVideoButtonPath));
			SerializeField(s, nameof(seasonalEventPackButtonPath));
		}
		public override uint? ClassCRC => 0xF3D14340;
	}
}

