namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionJumpJanod_Template : BTAction_Template {
		public float speedJump;
		public float timeOnGround;
		public StringID animAnticip;
		public StringID animJump;
		public StringID animFall;
		public StringID animLanding;
		public StringID animIdle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			speedJump = s.Serialize<float>(speedJump, name: "speedJump");
			timeOnGround = s.Serialize<float>(timeOnGround, name: "timeOnGround");
			animAnticip = s.SerializeObject<StringID>(animAnticip, name: "animAnticip");
			animJump = s.SerializeObject<StringID>(animJump, name: "animJump");
			animFall = s.SerializeObject<StringID>(animFall, name: "animFall");
			animLanding = s.SerializeObject<StringID>(animLanding, name: "animLanding");
			animIdle = s.SerializeObject<StringID>(animIdle, name: "animIdle");
		}
		public override uint? ClassCRC => 0xF0FBD948;
	}
}

