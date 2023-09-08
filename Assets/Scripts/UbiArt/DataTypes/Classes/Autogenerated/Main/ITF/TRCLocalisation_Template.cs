namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TRCLocalisation_Template : TemplateObj {
		public CMap<GameplayErrorContext, TRCLocalisation_Detail> TRCLocalisationList;
		public CListO<TRCLocalisation_Detail> TRCLocalisationList_RL;
		public CArrayO<Path> TRCActorsList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || 
				s.Settings.Game == Game.VH ||
				s.Settings.Game == Game.COL) {
				TRCLocalisationList_RL = s.SerializeObject<CListO<TRCLocalisation_Detail>>(TRCLocalisationList_RL, name: "TRCLocalisationList");
				//TRCLocalisationList = s.SerializeObject<CMap<GameplayErrorContext, TRCLocalisation_Detail>>(TRCLocalisationList, name: "TRCLocalisationList");
				TRCActorsList = s.SerializeObject<CArrayO<Path>>(TRCActorsList, name: "TRCActorsList");
			} else {
				TRCLocalisationList = s.SerializeObject<CMap<GameplayErrorContext, TRCLocalisation_Detail>>(TRCLocalisationList, name: "TRCLocalisationList");
			}
		}
		public override uint? ClassCRC => 0xFB182DFC;
	}
}

