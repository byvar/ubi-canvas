using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTActionBallisticsApex : BTActionBallistics {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC714081C;
	}
}

