using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventQueryLumStage : Event {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2303D0AA;
	}
}

