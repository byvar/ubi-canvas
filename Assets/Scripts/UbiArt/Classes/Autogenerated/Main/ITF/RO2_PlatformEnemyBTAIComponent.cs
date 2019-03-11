using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlatformEnemyBTAIComponent : RO2_EnemyBTAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x42014318;
	}
}

