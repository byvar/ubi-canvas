using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionSkating_Template : BTActionPlayAnim_Template {
		[Serialize("holeDetectionRange")] public float holeDetectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(holeDetectionRange));
		}
		public override uint? ClassCRC => 0xAAAC9A41;
	}
}

