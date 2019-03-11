using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ScaleFunnelComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA0DADB47;
	}
}

