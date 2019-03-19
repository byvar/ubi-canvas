using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionThrowStone : BTAction {
		[Serialize("enemyDetectionRange")] public Generic<PhysShape> enemyDetectionRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enemyDetectionRange));
		}
		public override uint? ClassCRC => 0xB157EFF3;
	}
}

