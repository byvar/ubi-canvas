using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_CreditsComponent : CreditsComponent {
		[Serialize("jobTitleNameGape" )] public float jobTitleNameGape;
		[Serialize("jobTitleHorOffset")] public float jobTitleHorOffset;
		[Serialize("nameHorOffset"    )] public float nameHorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jobTitleNameGape));
			SerializeField(s, nameof(jobTitleHorOffset));
			SerializeField(s, nameof(nameHorOffset));
		}
		public override uint? ClassCRC => 0x9A9CE614;
	}
}

