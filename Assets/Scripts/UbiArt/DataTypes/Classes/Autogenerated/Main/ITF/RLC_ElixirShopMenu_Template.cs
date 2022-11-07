namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ElixirShopMenu_Template : RLC_ShopScrollingMenu_Template {
		public PathRef elixirPackButtonPath;
		public PathRef allElixirPackButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			elixirPackButtonPath = s.SerializeObject<PathRef>(elixirPackButtonPath, name: "elixirPackButtonPath");
			allElixirPackButtonPath = s.SerializeObject<PathRef>(allElixirPackButtonPath, name: "allElixirPackButtonPath");
		}
		public override uint? ClassCRC => 0x47D7CD6D;
	}
}

