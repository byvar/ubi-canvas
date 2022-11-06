using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PlatformEnemyBTAIComponent_Template : RO2_EnemyBTAIComponent_Template {
		public bool RestartTweeningAfterHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RestartTweeningAfterHit = s.Serialize<bool>(RestartTweeningAfterHit, name: "RestartTweeningAfterHit");
		}
		public override uint? ClassCRC => 0x5E4BCF60;
	}
}

