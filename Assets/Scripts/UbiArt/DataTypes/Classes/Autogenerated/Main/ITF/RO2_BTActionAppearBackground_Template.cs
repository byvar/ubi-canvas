namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearBackground_Template : BTAction_Template {
		public StringID animStandHideBack;
		public StringID animAnticipBack;
		public StringID animJumpBack;
		public StringID animLandingBack;
		public StringID animStandHideFore;
		public StringID animAnticipFore;
		public StringID animJumpFore;
		public StringID animLandingFore;
		public bool waitForTrigger;
		public bool disablePhys;
		public bool resetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animStandHideBack = s.SerializeObject<StringID>(animStandHideBack, name: "animStandHideBack");
			animAnticipBack = s.SerializeObject<StringID>(animAnticipBack, name: "animAnticipBack");
			animJumpBack = s.SerializeObject<StringID>(animJumpBack, name: "animJumpBack");
			animLandingBack = s.SerializeObject<StringID>(animLandingBack, name: "animLandingBack");
			animStandHideFore = s.SerializeObject<StringID>(animStandHideFore, name: "animStandHideFore");
			animAnticipFore = s.SerializeObject<StringID>(animAnticipFore, name: "animAnticipFore");
			animJumpFore = s.SerializeObject<StringID>(animJumpFore, name: "animJumpFore");
			animLandingFore = s.SerializeObject<StringID>(animLandingFore, name: "animLandingFore");
			waitForTrigger = s.Serialize<bool>(waitForTrigger, name: "waitForTrigger");
			disablePhys = s.Serialize<bool>(disablePhys, name: "disablePhys");
			resetAngle = s.Serialize<bool>(resetAngle, name: "resetAngle");
		}
		public override uint? ClassCRC => 0x56A59302;
	}
}

