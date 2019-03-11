using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_DemoTrailerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFD853F6C;
	}
}

