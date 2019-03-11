using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDeciderSuper : BTDecider {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCEB0548A;
	}
}

