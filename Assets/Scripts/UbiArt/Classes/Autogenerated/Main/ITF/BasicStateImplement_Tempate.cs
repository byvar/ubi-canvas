using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class BasicStateImplement_Tempate : BasicState_Template {
		[Serialize("implementTempate"     )] public StateImplement_Template implementTempate;
		[Serialize("stateName"            )] public StringID stateName;
		[Serialize("defaultNextState"     )] public StringID defaultNextState;
		[Serialize("implementParamHandler")] public Placeholder implementParamHandler;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(stateName));
				SerializeField(s, nameof(defaultNextState));
				SerializeField(s, nameof(implementParamHandler));
				SerializeField(s, nameof(implementTempate));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(stateName));
				SerializeField(s, nameof(defaultNextState));
			} else {
				SerializeField(s, nameof(implementTempate));
			}
		}
		public override uint? ClassCRC => 0x8B17155B;
	}
}

