namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIShooterCloseAttackBehavior_Template : CSerializable {
		public Placeholder attack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			attack = s.SerializeObject<Placeholder>(attack, name: "attack");
		}
		public override uint? ClassCRC => 0x57732622;
	}
}

