using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIBounceRoamingBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("bounceMove"               )] public Placeholder bounceMove;
		[Serialize("bounceIdle"               )] public Placeholder bounceIdle;
		[Serialize("bounceJump"               )] public Placeholder bounceJump;
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
		public override uint? ClassCRC => 0x3BB502ED;
	}
}

