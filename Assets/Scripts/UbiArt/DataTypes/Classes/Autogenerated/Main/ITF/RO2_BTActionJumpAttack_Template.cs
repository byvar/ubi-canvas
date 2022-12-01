namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionJumpAttack_Template : BTAction_Template {
		public StringID animAnticip;
		public StringID animJump;
		public StringID animWallStand;
		public StringID animWallJump;
		public StringID animReception;
		public float jumpImpulse = 10f;
		public Vec2d jumpDir = Vec2d.One;
		public float wallJumpImpulse = 10f;
		public Vec2d wallJumpDir = Vec2d.One;
		public float jumpGravityMult = 1f;
		public float holeDetectionDist = 2f;
		public float wallDetectionDist = 1f;
		public float timeAnticip = 1f;
		public float timeWallAnticip = 0.5f;
		public bool avoidHoles;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animAnticip = s.SerializeObject<StringID>(animAnticip, name: "animAnticip");
			animJump = s.SerializeObject<StringID>(animJump, name: "animJump");
			animWallStand = s.SerializeObject<StringID>(animWallStand, name: "animWallStand");
			animWallJump = s.SerializeObject<StringID>(animWallJump, name: "animWallJump");
			animReception = s.SerializeObject<StringID>(animReception, name: "animReception");
			jumpImpulse = s.Serialize<float>(jumpImpulse, name: "jumpImpulse");
			jumpDir = s.SerializeObject<Vec2d>(jumpDir, name: "jumpDir");
			wallJumpImpulse = s.Serialize<float>(wallJumpImpulse, name: "wallJumpImpulse");
			wallJumpDir = s.SerializeObject<Vec2d>(wallJumpDir, name: "wallJumpDir");
			jumpGravityMult = s.Serialize<float>(jumpGravityMult, name: "jumpGravityMult");
			holeDetectionDist = s.Serialize<float>(holeDetectionDist, name: "holeDetectionDist");
			wallDetectionDist = s.Serialize<float>(wallDetectionDist, name: "wallDetectionDist");
			timeAnticip = s.Serialize<float>(timeAnticip, name: "timeAnticip");
			timeWallAnticip = s.Serialize<float>(timeWallAnticip, name: "timeWallAnticip");
			avoidHoles = s.Serialize<bool>(avoidHoles, name: "avoidHoles");
		}
		public override uint? ClassCRC => 0x05360873;
	}
}

