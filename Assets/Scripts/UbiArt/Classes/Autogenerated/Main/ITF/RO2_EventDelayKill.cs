using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDelayKill : Event {
		[Serialize("delay")] public float delay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(delay));
		}
		public override uint? ClassCRC => 0x9619DF4D;
	}
}

