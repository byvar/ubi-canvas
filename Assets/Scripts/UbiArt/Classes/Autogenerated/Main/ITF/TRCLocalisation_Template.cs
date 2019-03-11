using UnityEngine;

namespace UbiArt.ITF {
	public partial class TRCLocalisation_Template : TemplateObj {
		[Serialize("TRCLocalisationList")] public CMap<GameplayErrorContext, TRCLocalisation_Detail> TRCLocalisationList;
		[Serialize("TRCActorsList"      )] public Placeholder TRCActorsList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(TRCLocalisationList));
				SerializeField(s, nameof(TRCActorsList));
			} else {
				SerializeField(s, nameof(TRCLocalisationList));
			}
		}
		public override uint? ClassCRC => 0xFB182DFC;
	}
}

