using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDrcInsensitive : Event {
		[Serialize("duration")] public float duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
		}
		public override uint? ClassCRC => 0x963DBDCE;
	}
}

