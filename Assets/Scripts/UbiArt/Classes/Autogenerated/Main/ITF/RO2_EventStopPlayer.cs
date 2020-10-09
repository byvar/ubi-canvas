using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventStopPlayer : Event {
		public bool stop;
		public bool disablePhysic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stop = s.Serialize<bool>(stop, name: "stop");
			disablePhysic = s.Serialize<bool>(disablePhysic, name: "disablePhysic");
		}
		public override uint? ClassCRC => 0xEC105334;
	}
}

