using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TRCLocalisation_Template : TemplateObj {
		public CMap<GameplayErrorContext, TRCLocalisation_Detail> TRCLocalisationList;
		public CArrayO<Path> TRCActorsList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || 
				Settings.s.game == Settings.Game.VH ||
				Settings.s.game == Settings.Game.COL) {
				TRCLocalisationList = s.SerializeObject<CMap<GameplayErrorContext, TRCLocalisation_Detail>>(TRCLocalisationList, name: "TRCLocalisationList");
				TRCActorsList = s.SerializeObject<CArrayO<Path>>(TRCActorsList, name: "TRCActorsList");
			} else {
				TRCLocalisationList = s.SerializeObject<CMap<GameplayErrorContext, TRCLocalisation_Detail>>(TRCLocalisationList, name: "TRCLocalisationList");
			}
		}
		public override uint? ClassCRC => 0xFB182DFC;
	}
}

