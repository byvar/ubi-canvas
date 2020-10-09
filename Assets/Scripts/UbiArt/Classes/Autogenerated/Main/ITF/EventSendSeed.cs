using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventSendSeed : Event {
		public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			seed = s.Serialize<uint>(seed, name: "seed");
		}
		public override uint? ClassCRC => 0xA3902CCF;
	}
}

