using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GameGlobalsDevTeamCondition : online.GameGlobalsCondition {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x595BA274;
	}
}

