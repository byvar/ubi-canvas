using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionStack : BTAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6545B845;
	}
}

