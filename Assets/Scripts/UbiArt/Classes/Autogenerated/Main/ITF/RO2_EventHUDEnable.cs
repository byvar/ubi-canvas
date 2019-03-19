using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventHUDEnable : Event {
		[Serialize("enable")] public bool enable;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enable));
		}
		public override uint? ClassCRC => 0xABC011F0;
	}
}

