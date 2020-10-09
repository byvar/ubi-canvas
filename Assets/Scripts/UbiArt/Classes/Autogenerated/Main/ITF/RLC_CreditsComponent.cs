using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_CreditsComponent : CreditsComponent {
		public float jobTitleNameGape;
		public float jobTitleHorOffset;
		public float nameHorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jobTitleNameGape = s.Serialize<float>(jobTitleNameGape, name: "jobTitleNameGape");
			jobTitleHorOffset = s.Serialize<float>(jobTitleHorOffset, name: "jobTitleHorOffset");
			nameHorOffset = s.Serialize<float>(nameHorOffset, name: "nameHorOffset");
		}
		public override uint? ClassCRC => 0x9A9CE614;
	}
}

