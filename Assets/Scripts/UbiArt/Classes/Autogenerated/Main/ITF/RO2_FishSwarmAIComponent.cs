using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FishSwarmAIComponent : RO2_AIComponent {
		[Serialize("numFishPerColumn")] public uint numFishPerColumn;
		[Serialize("numColumn"       )] public uint numColumn;
		[Serialize("borderForceUp"   )] public float borderForceUp;
		[Serialize("borderForceDown" )] public float borderForceDown;
		[Serialize("borderForceRight")] public float borderForceRight;
		[Serialize("borderForceLeft" )] public float borderForceLeft;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(numFishPerColumn));
				SerializeField(s, nameof(numColumn));
				SerializeField(s, nameof(borderForceUp));
				SerializeField(s, nameof(borderForceDown));
				SerializeField(s, nameof(borderForceRight));
				SerializeField(s, nameof(borderForceLeft));
			}
		}
		public override uint? ClassCRC => 0x07764263;
	}
}

