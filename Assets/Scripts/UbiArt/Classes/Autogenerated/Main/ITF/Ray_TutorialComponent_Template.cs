using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TutorialComponent_Template : ActorComponent_Template {
		[Serialize("startsActive"      )] public int startsActive;
		[Serialize("isSprintTutorial"  )] public int isSprintTutorial;
		[Serialize("padDisplayDuration")] public float padDisplayDuration;
		[Serialize("nunchukWiiLineId"  )] public LocalisationId nunchukWiiLineId;
		[Serialize("sidewayWiiLineId"  )] public LocalisationId sidewayWiiLineId;
		[Serialize("classicWiiLineId"  )] public LocalisationId classicWiiLineId;
		[Serialize("ps3LineId"         )] public LocalisationId ps3LineId;
		[Serialize("vitaLineId"        )] public LocalisationId vitaLineId;
		[Serialize("ctrLineId"         )] public LocalisationId ctrLineId;
		[Serialize("x360LineId"        )] public LocalisationId x360LineId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(startsActive));
			SerializeField(s, nameof(isSprintTutorial));
			SerializeField(s, nameof(padDisplayDuration));
			SerializeField(s, nameof(nunchukWiiLineId));
			SerializeField(s, nameof(sidewayWiiLineId));
			SerializeField(s, nameof(classicWiiLineId));
			SerializeField(s, nameof(ps3LineId));
			SerializeField(s, nameof(vitaLineId));
			SerializeField(s, nameof(ctrLineId));
			SerializeField(s, nameof(x360LineId));
		}
		public override uint? ClassCRC => 0xEA42F12A;
	}
}

