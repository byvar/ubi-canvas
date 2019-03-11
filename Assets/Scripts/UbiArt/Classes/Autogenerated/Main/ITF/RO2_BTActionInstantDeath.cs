using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BTActionInstantDeath : BTAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x8F3BC00C;
	}
}

