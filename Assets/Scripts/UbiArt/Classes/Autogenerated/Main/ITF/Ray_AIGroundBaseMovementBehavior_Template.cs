using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_AIGroundBaseMovementBehavior_Template : TemplateAIBehavior {
		[Serialize("idle"                  )] public Generic<AIIdleAction_Template> idle;
		[Serialize("move"                  )] public Generic<AIWalkInDirAction_Template> move;
		[Serialize("uturn"                 )] public Generic<AIUTurnAction_Template> uturn;
		[Serialize("bounceToLayer"         )] public Generic<AIBounceToLayerAction_Template> bounceToLayer;
		[Serialize("bounce"                )] public Generic<AIBumperAction_Template> bounce;
		[Serialize("obstacleDetectionRange")] public float obstacleDetectionRange;
		[Serialize("obstacleJumpHeight"    )] public float obstacleJumpHeight;
		[Serialize("holeDetectionRange"    )] public float holeDetectionRange;
		[Serialize("holeJumpDepth"         )] public float holeJumpDepth;
		[Serialize("stuckDelay"            )] public float stuckDelay;
		[Serialize("uturnDelay"            )] public float uturnDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(move));
			SerializeField(s, nameof(uturn));
			SerializeField(s, nameof(bounceToLayer));
			SerializeField(s, nameof(bounce));
			SerializeField(s, nameof(obstacleDetectionRange));
			SerializeField(s, nameof(obstacleJumpHeight));
			SerializeField(s, nameof(holeDetectionRange));
			SerializeField(s, nameof(holeJumpDepth));
			SerializeField(s, nameof(stuckDelay));
			SerializeField(s, nameof(uturnDelay));
		}
		public override uint? ClassCRC => 0x3A4B6276;
	}
}

