using UnityEngine;

namespace UbiArt.ITF {
	public partial class Is2DNoScreenRatioComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7E0D2EF9;
	}
}

