using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.VH | GameFlags.RL)]
	public partial class EventGhostHitTrigger : EventTrigger {
		[Serialize("triggeredByCollision")] public bool triggeredByCollision;
		[Serialize("triggeredByHitStim"  )] public bool triggeredByHitStim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(triggeredByCollision));
			SerializeField(s, nameof(triggeredByHitStim));
		}
		public override uint? ClassCRC => 0x824DC666;
	}
}

