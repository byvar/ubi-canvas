using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ElixirShopMenu_Template : RLC_ShopScrollingMenu_Template {
		[Serialize("elixirPackButtonPath"   )] public PathRef elixirPackButtonPath;
		[Serialize("allElixirPackButtonPath")] public PathRef allElixirPackButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(elixirPackButtonPath));
			SerializeField(s, nameof(allElixirPackButtonPath));
		}
		public override uint? ClassCRC => 0x47D7CD6D;
	}
}

