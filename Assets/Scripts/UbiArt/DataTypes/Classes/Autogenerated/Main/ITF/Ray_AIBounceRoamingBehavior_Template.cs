namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBounceRoamingBehavior_Template : TemplateAIBehavior {
		public Placeholder bounceMove;
		public Placeholder bounceIdle;
		public Placeholder bounceJump;
		public float minTimeToWalk;
		public float maxTimeToWalk;
		public float minTimeToIdle;
		public float maxTimeToIdle;
		public float obstacleDetectionDistance;
		public float wallJumpHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bounceMove = s.SerializeObject<Placeholder>(bounceMove, name: "bounceMove");
			bounceIdle = s.SerializeObject<Placeholder>(bounceIdle, name: "bounceIdle");
			bounceJump = s.SerializeObject<Placeholder>(bounceJump, name: "bounceJump");
			minTimeToWalk = s.Serialize<float>(minTimeToWalk, name: "minTimeToWalk");
			maxTimeToWalk = s.Serialize<float>(maxTimeToWalk, name: "maxTimeToWalk");
			minTimeToIdle = s.Serialize<float>(minTimeToIdle, name: "minTimeToIdle");
			maxTimeToIdle = s.Serialize<float>(maxTimeToIdle, name: "maxTimeToIdle");
			obstacleDetectionDistance = s.Serialize<float>(obstacleDetectionDistance, name: "obstacleDetectionDistance");
			wallJumpHeight = s.Serialize<float>(wallJumpHeight, name: "wallJumpHeight");
		}
		public override uint? ClassCRC => 0x3BB502ED;
	}
}

