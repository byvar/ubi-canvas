using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionAppearSplinterCell_Template : BTAction_Template {
		[Serialize("animSwimUp"      )] public StringID animSwimUp;
		[Serialize("speedLimitToStop")] public float speedLimitToStop;
		[Serialize("antiBounceFactor")] public float antiBounceFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(animSwimUp));
			SerializeField(s, nameof(speedLimitToStop));
			SerializeField(s, nameof(antiBounceFactor));
		}
		public override uint? ClassCRC => 0x9D54B652;
	}
}

