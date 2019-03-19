using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class BTActionSendEventToActor : BTAction {
		[Serialize("event")] public Generic<Event> _event;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
			} else {
				SerializeField(s, nameof(_event));
			}
		}
		public override uint? ClassCRC => 0x7E0B8BDB;
	}
}

