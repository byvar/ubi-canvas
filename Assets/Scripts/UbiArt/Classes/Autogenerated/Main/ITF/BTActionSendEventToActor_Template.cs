using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTActionSendEventToActor_Template : BTAction_Template {
		[Serialize("target")] public StringID target;
		[Serialize("event" )] public Generic<Event> _event;
		[Serialize("name"  )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(target));
				SerializeField(s, nameof(_event));
			} else {
				SerializeField(s, nameof(target));
				SerializeField(s, nameof(_event));
			}
		}
		public override uint? ClassCRC => 0xF5050E97;
	}
}

