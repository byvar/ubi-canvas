using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_InflatedIslandComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x03BB594F;
	}
}

