namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionHitReflexTarget : BTAction {
		public Generic<PhysShape> enemyDetectionRange;
		public Generic<PhysShape> enemyDetectionRangeInCharge;
		public Generic<PhysShape> enemyDetectionRangeInRangedAttack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			enemyDetectionRangeInCharge = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRangeInCharge, name: "enemyDetectionRangeInCharge");
			enemyDetectionRangeInRangedAttack = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRangeInRangedAttack, name: "enemyDetectionRangeInRangedAttack");
		}
		public override uint? ClassCRC => 0x2C4D12BC;
	}
}

