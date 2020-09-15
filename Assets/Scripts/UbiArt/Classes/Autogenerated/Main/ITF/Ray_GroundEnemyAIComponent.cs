using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_GroundEnemyAIComponent : Ray_AIComponent {
		public int useRaycast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			useRaycast = s.Serialize<int>(useRaycast, name: "useRaycast");
		}
		public override uint? ClassCRC => 0xDA325BB4;
	}
}

