namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class MetaFriezeConfig : TemplatePickable {
		public CListO<MetaFriezeParams> _params;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
			} else {
				_params = s.SerializeObject<CListO<MetaFriezeParams>>(_params, name: "params");
			}
		}
		public override uint? ClassCRC => 0x11626154;
	}
}

