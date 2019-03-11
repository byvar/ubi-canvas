using UnityEngine;

namespace UbiArt.ITF {
	public partial class SetChildren2DNoScreenRatioComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF41B09B0;
	}
}

