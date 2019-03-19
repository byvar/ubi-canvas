using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventStopPlayer : Event {
		[Serialize("stop"         )] public bool stop;
		[Serialize("disablePhysic")] public bool disablePhysic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stop));
			SerializeField(s, nameof(disablePhysic));
		}
		public override uint? ClassCRC => 0xEC105334;
	}
}

