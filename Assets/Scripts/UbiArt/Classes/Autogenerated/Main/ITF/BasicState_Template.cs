using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BasicState_Template : CSerializable {
		[Serialize("stateName"            )] public StringID stateName;
		[Serialize("defaultNextState"     )] public StringID defaultNextState;
		[Serialize("implementParamHandler")] public ImpParamHandler_Template implementParamHandler;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(stateName));
				SerializeField(s, nameof(defaultNextState));
			} else {
				SerializeField(s, nameof(stateName));
				SerializeField(s, nameof(defaultNextState));
				SerializeField(s, nameof(implementParamHandler));
			}
		}
		public override uint? ClassCRC => 0x757E7BB4;
	}
}

