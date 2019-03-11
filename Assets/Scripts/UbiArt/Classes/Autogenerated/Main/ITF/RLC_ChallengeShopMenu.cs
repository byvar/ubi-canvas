using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_ChallengeShopMenu : RLC_ShopScrollingMenu {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x78D9AA66;
	}
}

