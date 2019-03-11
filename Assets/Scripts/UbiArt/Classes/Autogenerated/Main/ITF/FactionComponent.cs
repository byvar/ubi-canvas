using UnityEngine;

namespace UbiArt.ITF {
	public partial class FactionComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9A275982;
	}
}

