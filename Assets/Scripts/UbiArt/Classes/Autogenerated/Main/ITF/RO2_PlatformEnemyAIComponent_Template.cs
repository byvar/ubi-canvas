using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlatformEnemyAIComponent_Template : RO2_GroundEnemyAIComponent_Template {
		[Serialize("restartTweeningAfterHit")] public bool restartTweeningAfterHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(restartTweeningAfterHit));
		}
		public override uint? ClassCRC => 0xCEB9F834;
	}
}

