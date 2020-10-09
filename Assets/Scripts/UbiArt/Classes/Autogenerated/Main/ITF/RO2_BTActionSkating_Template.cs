using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionSkating_Template : BTActionPlayAnim_Template {
		public float holeDetectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			holeDetectionRange = s.Serialize<float>(holeDetectionRange, name: "holeDetectionRange");
		}
		public override uint? ClassCRC => 0xAAAC9A41;
	}
}

