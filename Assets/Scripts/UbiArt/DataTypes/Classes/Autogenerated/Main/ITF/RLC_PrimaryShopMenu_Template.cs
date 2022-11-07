namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_PrimaryShopMenu_Template : RLC_ShopScrollingMenu_Template {
		public PathRef starterPackButtonPath;
		public PathRef watchVideoButtonPath;
		public PathRef gemPackButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			starterPackButtonPath = s.SerializeObject<PathRef>(starterPackButtonPath, name: "starterPackButtonPath");
			watchVideoButtonPath = s.SerializeObject<PathRef>(watchVideoButtonPath, name: "watchVideoButtonPath");
			gemPackButtonPath = s.SerializeObject<PathRef>(gemPackButtonPath, name: "gemPackButtonPath");
		}
		public override uint? ClassCRC => 0x342834A7;
	}
}

