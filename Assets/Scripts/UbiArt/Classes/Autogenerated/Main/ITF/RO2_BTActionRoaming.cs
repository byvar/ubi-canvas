using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionRoaming : BTAction {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x792D0821;
	}
}

