using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventChangeAllPlayersGameMode : RO2_EventChangeOnePlayerGameMode {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAC63A7A3;
	}
}

