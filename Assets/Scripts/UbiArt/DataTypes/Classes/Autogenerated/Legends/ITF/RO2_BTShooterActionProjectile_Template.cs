namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_BTShooterActionProjectile_Template : BTAction_Template {
		public StringID anim;
		public RO2_BasicBullet_Template basicBullet;
		public Vec2d posOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
			basicBullet = s.SerializeObject<RO2_BasicBullet_Template>(basicBullet, name: "basicBullet");
			posOffset = s.SerializeObject<Vec2d>(posOffset, name: "posOffset");
		}
		public override uint? ClassCRC => 0x3863E02D;
	}
}

