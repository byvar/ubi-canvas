using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventTriggerExitMapRitual : Event {
		public bool stopPlayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			stopPlayers = s.Serialize<bool>(stopPlayers, name: "stopPlayers");
		}
		public override uint? ClassCRC => 0x58803DBB;
	}
}

