using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventSendSeed : Event {
		[Serialize("seed")] public uint seed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(seed));
		}
		public override uint? ClassCRC => 0xA3902CCF;
	}
}

