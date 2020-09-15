using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_LivingStoneAIComponent2_Template : Ray_GroundEnemyAIComponent_Template {
		public int spikyHat;
		public float spikyHatMaxDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spikyHat = s.Serialize<int>(spikyHat, name: "spikyHat");
			spikyHatMaxDistance = s.Serialize<float>(spikyHatMaxDistance, name: "spikyHatMaxDistance");
		}
		public override uint? ClassCRC => 0xF3941F2E;
	}
}

