using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDragonSwitchPhase : Event {
		public uint phase;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			phase = s.Serialize<uint>(phase, name: "phase");
		}
		public override uint? ClassCRC => 0xFB794B30;
	}
}

