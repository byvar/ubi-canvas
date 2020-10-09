using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_LastPlayerTriggerComponent_Template : TriggerComponent_Template {
		public bool useTimeBeforeActivation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useTimeBeforeActivation = s.Serialize<bool>(useTimeBeforeActivation, name: "useTimeBeforeActivation");
		}
		public override uint? ClassCRC => 0x82597EF2;
	}
}

