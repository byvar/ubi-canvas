using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIGroundRunAwayBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		[Serialize("jumpOverObstacle"       )] public Placeholder jumpOverObstacle;
		[Serialize("jumpOverVoid"           )] public Placeholder jumpOverVoid;
		[Serialize("fall"                   )] public Placeholder fall;
		[Serialize("enemyJumpDetectDistance")] public float enemyJumpDetectDistance;
		[Serialize("voidJumpDetectDistance" )] public float voidJumpDetectDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(jumpOverObstacle));
			SerializeField(s, nameof(jumpOverVoid));
			SerializeField(s, nameof(fall));
			SerializeField(s, nameof(enemyJumpDetectDistance));
			SerializeField(s, nameof(voidJumpDetectDistance));
		}
		public override uint? ClassCRC => 0x1BD200F0;
	}
}

