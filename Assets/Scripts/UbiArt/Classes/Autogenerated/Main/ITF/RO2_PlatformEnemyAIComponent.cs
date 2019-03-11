using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_PlatformEnemyAIComponent : RO2_GroundEnemyAIComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xE332CBB2;
	}
}

