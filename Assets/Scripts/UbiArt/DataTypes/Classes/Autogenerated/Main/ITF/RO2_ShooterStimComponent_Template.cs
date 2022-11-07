namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ShooterStimComponent_Template : ActorComponent_Template {
		public RO2_BasicBullet_Template basicBullet;
		public float fxDelayBeforeDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			basicBullet = s.SerializeObject<RO2_BasicBullet_Template>(basicBullet, name: "basicBullet");
			fxDelayBeforeDestroy = s.Serialize<float>(fxDelayBeforeDestroy, name: "fxDelayBeforeDestroy");
		}
		public override uint? ClassCRC => 0xEBA11379;
	}
}

