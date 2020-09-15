using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TutorialComponent_Template : ActorComponent_Template {
		public int startsActive;
		public int isSprintTutorial;
		public float padDisplayDuration;
		public LocalisationId nunchukWiiLineId;
		public LocalisationId sidewayWiiLineId;
		public LocalisationId classicWiiLineId;
		public LocalisationId ps3LineId;
		public LocalisationId vitaLineId;
		public LocalisationId ctrLineId;
		public LocalisationId x360LineId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			startsActive = s.Serialize<int>(startsActive, name: "startsActive");
			isSprintTutorial = s.Serialize<int>(isSprintTutorial, name: "isSprintTutorial");
			padDisplayDuration = s.Serialize<float>(padDisplayDuration, name: "padDisplayDuration");
			nunchukWiiLineId = s.SerializeObject<LocalisationId>(nunchukWiiLineId, name: "nunchukWiiLineId");
			sidewayWiiLineId = s.SerializeObject<LocalisationId>(sidewayWiiLineId, name: "sidewayWiiLineId");
			classicWiiLineId = s.SerializeObject<LocalisationId>(classicWiiLineId, name: "classicWiiLineId");
			ps3LineId = s.SerializeObject<LocalisationId>(ps3LineId, name: "ps3LineId");
			vitaLineId = s.SerializeObject<LocalisationId>(vitaLineId, name: "vitaLineId");
			ctrLineId = s.SerializeObject<LocalisationId>(ctrLineId, name: "ctrLineId");
			x360LineId = s.SerializeObject<LocalisationId>(x360LineId, name: "x360LineId");
		}
		public override uint? ClassCRC => 0xEA42F12A;
	}
}

