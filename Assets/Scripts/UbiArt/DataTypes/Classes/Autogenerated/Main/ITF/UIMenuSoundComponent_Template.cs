namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class UIMenuSoundComponent_Template : ActorComponent_Template {
		public CListO<UIMenuPageSoundConfig> pageConfigList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
			} else {
				pageConfigList = s.SerializeObject<CListO<UIMenuPageSoundConfig>>(pageConfigList, name: "pageConfigList");
			}
		}
		public override uint? ClassCRC => 0x1C3ACDE0;
	}
}

