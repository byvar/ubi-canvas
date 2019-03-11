using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventTriggerExitMapRitual : Event {
		[Serialize("stopPlayers")] public bool stopPlayers;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stopPlayers));
		}
		public override uint? ClassCRC => 0x58803DBB;
	}
}

