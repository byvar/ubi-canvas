using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventTrigger : Event {
		[Serialize("activated")] public bool activated;
		[Serialize("activator")] public ObjectRef activator;
		[Serialize("toggle"   )] public bool toggle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game != Settings.Game.RA) {
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator), type: typeof(uint));
			} else {
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
				SerializeField(s, nameof(toggle));
			}
		}
		public override uint? ClassCRC => 0x500D33CE;
	}
}

