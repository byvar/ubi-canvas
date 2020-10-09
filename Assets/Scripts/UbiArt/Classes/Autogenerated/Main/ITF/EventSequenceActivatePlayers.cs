using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventSequenceActivatePlayers : Event {
		public bool activate;
		public bool playStart;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				activate = s.Serialize<bool>(activate, name: "activate");
			} else {
				activate = s.Serialize<bool>(activate, name: "activate");
				playStart = s.Serialize<bool>(playStart, name: "playStart");
			}
		}
		public override uint? ClassCRC => 0xC1B4AADE;
	}
}

