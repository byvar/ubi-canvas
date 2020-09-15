using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventTicklePrisoner : Event {
		public bool start;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			start = s.Serialize<bool>(start, name: "start");
		}
		public override uint? ClassCRC => 0x455A3DEC;
	}
}

