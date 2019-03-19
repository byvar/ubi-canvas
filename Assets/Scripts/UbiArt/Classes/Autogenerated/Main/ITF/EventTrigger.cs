using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventTrigger : Event {
		[Serialize("activated")] public bool activated;
		[Serialize("activator")] public ObjectRef activator;
		[Serialize("toggle"   )] public bool toggle;
		[Serialize("activator")] public uint activator;
		[Serialize("sender"   )] public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
			} else if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(activated));
			} else if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
			} else {
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
				SerializeField(s, nameof(toggle));
			}
		}
		public override uint? ClassCRC => 0x500D33CE;
	}
}

