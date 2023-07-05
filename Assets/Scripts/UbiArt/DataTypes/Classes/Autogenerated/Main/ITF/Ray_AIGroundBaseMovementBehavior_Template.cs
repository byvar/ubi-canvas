namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_AIGroundBaseMovementBehavior_Template : Ray_AIGroundBaseBehavior_Template {
		public Generic<AIIdleAction_Template> idle;
		public Generic<AIWalkInDirAction_Template> move;
		public Generic<AIUTurnAction_Template> uturn;
		public Generic<AIBounceToLayerAction_Template> bounceToLayer;
		public Generic<AIBumperAction_Template> bounce;
		public float obstacleDetectionRange;
		public float obstacleJumpHeight;
		public float holeDetectionRange;
		public float holeJumpDepth;
		public float stuckDelay;
		public float uturnDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Generic<AIIdleAction_Template>>(idle, name: "idle");
			move = s.SerializeObject<Generic<AIWalkInDirAction_Template>>(move, name: "move");
			uturn = s.SerializeObject<Generic<AIUTurnAction_Template>>(uturn, name: "uturn");
			bounceToLayer = s.SerializeObject<Generic<AIBounceToLayerAction_Template>>(bounceToLayer, name: "bounceToLayer");
			bounce = s.SerializeObject<Generic<AIBumperAction_Template>>(bounce, name: "bounce");
			obstacleDetectionRange = s.Serialize<float>(obstacleDetectionRange, name: "obstacleDetectionRange");
			obstacleJumpHeight = s.Serialize<float>(obstacleJumpHeight, name: "obstacleJumpHeight");
			holeDetectionRange = s.Serialize<float>(holeDetectionRange, name: "holeDetectionRange");
			holeJumpDepth = s.Serialize<float>(holeJumpDepth, name: "holeJumpDepth");
			stuckDelay = s.Serialize<float>(stuckDelay, name: "stuckDelay");
			uturnDelay = s.Serialize<float>(uturnDelay, name: "uturnDelay");
		}
		public override uint? ClassCRC => 0x3A4B6276;
	}
}

