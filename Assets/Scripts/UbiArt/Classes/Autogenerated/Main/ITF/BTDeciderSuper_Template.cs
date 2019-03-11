using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDeciderSuper_Template : BTDecider_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x2BF15155;
	}
}

