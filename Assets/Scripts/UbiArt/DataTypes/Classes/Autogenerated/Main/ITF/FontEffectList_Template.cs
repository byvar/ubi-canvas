namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class FontEffectList_Template : TemplateObj {
		public CListO<FontEffect_Template> effects;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
			} else {
				effects = s.SerializeObject<CListO<FontEffect_Template>>(effects, name: "effects");
			}
		}
		public override uint? ClassCRC => 0x5261948B;
	}
}

