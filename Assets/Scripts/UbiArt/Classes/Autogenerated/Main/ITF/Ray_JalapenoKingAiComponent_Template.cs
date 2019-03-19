using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_JalapenoKingAiComponent_Template : AIComponent_Template {
		[Serialize("deathReward")] public Placeholder deathReward;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(deathReward));
		}
		public override uint? ClassCRC => 0x182D7E15;
	}
}

