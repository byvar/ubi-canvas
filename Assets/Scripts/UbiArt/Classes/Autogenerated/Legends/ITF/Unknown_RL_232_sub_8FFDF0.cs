using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_232_sub_8FFDF0 : RO2_GameModeParameters {
		[Serialize("activateModeOnFirstActivation")] public bool activateModeOnFirstActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(activateModeOnFirstActivation), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x572E39FF;
	}
}

