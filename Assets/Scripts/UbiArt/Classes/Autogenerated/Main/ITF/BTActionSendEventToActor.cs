using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class BTActionSendEventToActor : BTAction {
		public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
			} else {
				_event = s.SerializeObject<Generic<Event>>(_event, name: "event");
			}
		}
		public override uint? ClassCRC => 0x7E0B8BDB;
	}
}

