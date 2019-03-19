using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.VH | GameFlags.RL)]
	public partial class EventGhostHitTrigger : EventTrigger {
		[Serialize("triggeredByCollision")] public bool triggeredByCollision;
		[Serialize("triggeredByHitStim"  )] public bool triggeredByHitStim;
		[Serialize("sender"              )] public uint sender;
		[Serialize("activated"           )] public int activated;
		[Serialize("activator"           )] public uint activator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(activated));
				SerializeField(s, nameof(activator));
				SerializeField(s, nameof(triggeredByCollision));
				SerializeField(s, nameof(triggeredByHitStim));
			} else {
				SerializeField(s, nameof(triggeredByCollision));
				SerializeField(s, nameof(triggeredByHitStim));
			}
		}
		public override uint? ClassCRC => 0x824DC666;
	}
}

