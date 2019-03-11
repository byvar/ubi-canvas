using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CauldronComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8010E5CA;
	}
}

