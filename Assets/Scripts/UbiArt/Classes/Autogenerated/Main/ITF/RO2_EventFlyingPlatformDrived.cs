using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventFlyingPlatformDrived : Event {
		[Serialize("isDrived")] public bool isDrived;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isDrived));
		}
		public override uint? ClassCRC => 0x7CA504A9;
	}
}

