using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class FactionManager_Template : TemplateObj {
		public CListO<FactionRelationContainer> factions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
			} else {
				factions = s.SerializeObject<CListO<FactionRelationContainer>>(factions, name: "factions");
			}
		}
		public override uint? ClassCRC => 0x7E58190C;
	}
}

