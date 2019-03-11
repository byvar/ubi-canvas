using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimStateWithPhases : StateWithPhases {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB52FA65F;
	}
}

