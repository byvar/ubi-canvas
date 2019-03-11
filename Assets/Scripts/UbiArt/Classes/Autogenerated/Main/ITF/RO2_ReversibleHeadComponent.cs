using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ReversibleHeadComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4F7BE17B;
	}
}

