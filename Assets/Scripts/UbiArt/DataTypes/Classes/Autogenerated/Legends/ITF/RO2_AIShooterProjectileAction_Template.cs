namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIShooterProjectileAction_Template : AIAction_Template {
		public RO2_BasicBullet_Template basicBullet;
		public Vec2d posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<RO2_BasicBullet_Template>(basicBullet, name: "basicBullet");
			posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
		}
		public override uint? ClassCRC => 0x2B5B95B0;
	}
}

