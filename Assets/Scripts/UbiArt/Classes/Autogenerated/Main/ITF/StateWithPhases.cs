using UnityEngine;

namespace UbiArt.ITF {
	public partial class StateWithPhases : State {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x768CDD21;
	}
}

