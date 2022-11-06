using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventDelayKill : Event {
		public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			delay = s.Serialize<float>(delay, name: "delay");
		}
		public override uint? ClassCRC => 0x9619DF4D;
	}
}

