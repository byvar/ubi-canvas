using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventDigEnable : Event {
		[Serialize("enable")] public bool enable;
		[Serialize("radius")] public float radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enable));
			SerializeField(s, nameof(radius));
		}
		public override uint? ClassCRC => 0x41B70F26;
	}
}

