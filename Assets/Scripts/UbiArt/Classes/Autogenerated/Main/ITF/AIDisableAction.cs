using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIDisableAction : AIAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7D3371A4;
	}
}

