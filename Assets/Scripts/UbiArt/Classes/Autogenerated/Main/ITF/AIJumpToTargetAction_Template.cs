using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIJumpToTargetAction_Template : AIAction_Template {
		[Serialize("duration")] public float duration;
		[Serialize("height0" )] public float height0;
		[Serialize("heught1" )] public float heught1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(height0));
			SerializeField(s, nameof(heught1));
		}
		public override uint? ClassCRC => 0xBCB521D7;
	}
}

