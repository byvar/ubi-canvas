using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class TRCLocalisation_Template : TemplateObj {
		[Serialize("TRCLocalisationList")] public CMap<GameplayErrorContext, TRCLocalisation_Detail> TRCLocalisationList;
		[Serialize("TRCActorsList"      )] public CArray<Path> TRCActorsList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || 
				Settings.s.game == Settings.Game.VH ||
				Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(TRCLocalisationList));
				SerializeField(s, nameof(TRCActorsList));
			} else {
				SerializeField(s, nameof(TRCLocalisationList));
			}
		}
		public override uint? ClassCRC => 0xFB182DFC;
	}
}

