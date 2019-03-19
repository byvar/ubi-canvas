using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIFadeAction_Template : AIAction_Template {
		[Serialize("visible"     )] public bool visible;
		[Serialize("fadeDuration")] public float fadeDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(visible));
			SerializeField(s, nameof(fadeDuration));
		}
		public override uint? ClassCRC => 0x26B4AE5C;
	}
}

