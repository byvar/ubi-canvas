using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_LivingStoneAIComponent2_Template : Ray_GroundEnemyAIComponent_Template {
		[Serialize("spikyHat"           )] public int spikyHat;
		[Serialize("spikyHatMaxDistance")] public float spikyHatMaxDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spikyHat));
			SerializeField(s, nameof(spikyHatMaxDistance));
		}
		public override uint? ClassCRC => 0xF3941F2E;
	}
}

