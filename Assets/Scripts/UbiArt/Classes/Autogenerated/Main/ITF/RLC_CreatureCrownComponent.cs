using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CreatureCrownComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEF3A9E8C;
	}
}

