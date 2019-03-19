using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BuzzSawAIComponent : RO2_AIComponent {
		[Serialize("scaleSize")] public float scaleSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(scaleSize));
		}
		public override uint? ClassCRC => 0xE13F7847;
	}
}

