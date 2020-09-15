using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TriggerEventCountComponent : ActorComponent {
		public uint nbEvents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				nbEvents = s.Serialize<uint>(nbEvents, name: "nbEvents");
			}
		}
		public override uint? ClassCRC => 0x335BFD0C;
	}
}

