using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionThrowStone : BTAction {
		public Generic<PhysShape> enemyDetectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
		}
		public override uint? ClassCRC => 0xB157EFF3;
	}
}

