using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimTreeNodePlayAnimInterpolateCursor : AnimTreeNodePlayAnim {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x1F19AF55;
	}
}

