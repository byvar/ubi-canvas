using UnityEngine;

namespace UbiArt.ITF {
	public partial class PerformanceTestComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9A10D672;
	}
}

