using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AIBounceRoamingBehavior_Template : TemplateAIBehavior {
		[Serialize("bounceMove"               )] public Generic<AIJumpInDirAction_Template> bounceMove;
		[Serialize("bounceIdle"               )] public Generic<AIJumpInDirAction_Template> bounceIdle;
		[Serialize("bounceJump"               )] public Generic<AIJumpAction_Template> bounceJump;
		[Serialize("minTimeToWalk"            )] public float minTimeToWalk;
		[Serialize("maxTimeToWalk"            )] public float maxTimeToWalk;
		[Serialize("minTimeToIdle"            )] public float minTimeToIdle;
		[Serialize("maxTimeToIdle"            )] public float maxTimeToIdle;
		[Serialize("obstacleDetectionDistance")] public float obstacleDetectionDistance;
		[Serialize("wallJumpHeight"           )] public float wallJumpHeight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bounceMove));
			SerializeField(s, nameof(bounceIdle));
			SerializeField(s, nameof(bounceJump));
			SerializeField(s, nameof(minTimeToWalk));
			SerializeField(s, nameof(maxTimeToWalk));
			SerializeField(s, nameof(minTimeToIdle));
			SerializeField(s, nameof(maxTimeToIdle));
			SerializeField(s, nameof(obstacleDetectionDistance));
			SerializeField(s, nameof(wallJumpHeight));
		}
		public override uint? ClassCRC => 0xCB383C6D;
	}
}

