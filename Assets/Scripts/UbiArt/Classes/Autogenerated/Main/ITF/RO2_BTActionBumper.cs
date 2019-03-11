using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionBumper : BTAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBEE31ABB;
	}
}

