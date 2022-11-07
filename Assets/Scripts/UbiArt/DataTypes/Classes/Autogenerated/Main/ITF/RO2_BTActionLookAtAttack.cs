namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionLookAtAttack : BTAction {
		public Generic<PhysShape> enemyDetectionRange;
		public Generic<PhysShape> enemyAttackRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			enemyAttackRange = s.SerializeObject<Generic<PhysShape>>(enemyAttackRange, name: "enemyAttackRange");
		}
		public override uint? ClassCRC => 0xEE3BD0D7;
	}
}

