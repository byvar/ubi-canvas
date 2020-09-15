using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BuzzSawAIComponent : RO2_AIComponent {
		public float scaleSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scaleSize = s.Serialize<float>(scaleSize, name: "scaleSize");
		}
		public override uint? ClassCRC => 0xE13F7847;
	}
}

