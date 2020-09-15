using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventPlayerScore : Event {
		public uint playerLocalIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerLocalIndex = s.Serialize<uint>(playerLocalIndex, name: "playerLocalIndex");
		}
		public override uint? ClassCRC => 0x71C44CC8;
	}
}

