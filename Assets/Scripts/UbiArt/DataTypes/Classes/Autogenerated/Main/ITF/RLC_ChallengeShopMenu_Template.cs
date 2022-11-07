namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ChallengeShopMenu_Template : RLC_ShopScrollingMenu_Template {
		public PathRef watchVideoButtonPath;
		public PathRef seasonalEventPackButtonPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			watchVideoButtonPath = s.SerializeObject<PathRef>(watchVideoButtonPath, name: "watchVideoButtonPath");
			seasonalEventPackButtonPath = s.SerializeObject<PathRef>(seasonalEventPackButtonPath, name: "seasonalEventPackButtonPath");
		}
		public override uint? ClassCRC => 0xF3D14340;
	}
}

