using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIDisableAction_Template : AIAction_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x73BE444F;
	}
}

