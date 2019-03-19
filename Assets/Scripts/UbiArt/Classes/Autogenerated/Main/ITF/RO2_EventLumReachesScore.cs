using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventLumReachesScore : Event {
		[Serialize("valueToAdd")] public uint valueToAdd;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(valueToAdd));
		}
		public override uint? ClassCRC => 0x0DF37C13;
	}
}

