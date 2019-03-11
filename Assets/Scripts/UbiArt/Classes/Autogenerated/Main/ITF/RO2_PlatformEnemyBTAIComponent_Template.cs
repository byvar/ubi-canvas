using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlatformEnemyBTAIComponent_Template : RO2_EnemyBTAIComponent_Template {
		[Serialize("RestartTweeningAfterHit")] public bool RestartTweeningAfterHit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(RestartTweeningAfterHit));
		}
		public override uint? ClassCRC => 0x5E4BCF60;
	}
}

