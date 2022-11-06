using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class EventTogglePlayersActivation : Event {
		public int activate_player;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			activate_player = s.Serialize<int>(activate_player, name: "activate_player");
		}
		public override uint? ClassCRC => 0x8CB84633;
	}
}

