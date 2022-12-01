namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionTorture_Template : BTAction_Template {
		public StringID animTortureHitHeadOnGround;
		public StringID animTortureJumpOnVictim;
		public float forceSoftCol = 1f;
		public float speedMinSoftCol;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animTortureHitHeadOnGround = s.SerializeObject<StringID>(animTortureHitHeadOnGround, name: "animTortureHitHeadOnGround");
			animTortureJumpOnVictim = s.SerializeObject<StringID>(animTortureJumpOnVictim, name: "animTortureJumpOnVictim");
			forceSoftCol = s.Serialize<float>(forceSoftCol, name: "forceSoftCol");
			speedMinSoftCol = s.Serialize<float>(speedMinSoftCol, name: "speedMinSoftCol");
		}
		public override uint? ClassCRC => 0x929F99E8;
	}
}

