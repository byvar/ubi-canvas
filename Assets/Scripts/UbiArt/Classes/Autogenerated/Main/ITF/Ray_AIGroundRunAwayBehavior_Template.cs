using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AIGroundRunAwayBehavior_Template : Ray_AIGroundBaseMovementBehavior_Template {
		public Generic<AIJumpAction_Template> jumpOverObstacle;
		public Generic<AIJumpAction_Template> jumpOverVoid;
		public Generic<AIFallAction_Template> fall;
		public float enemyJumpDetectDistance;
		public float voidJumpDetectDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			jumpOverObstacle = s.SerializeObject<Generic<AIJumpAction_Template>>(jumpOverObstacle, name: "jumpOverObstacle");
			jumpOverVoid = s.SerializeObject<Generic<AIJumpAction_Template>>(jumpOverVoid, name: "jumpOverVoid");
			fall = s.SerializeObject<Generic<AIFallAction_Template>>(fall, name: "fall");
			enemyJumpDetectDistance = s.Serialize<float>(enemyJumpDetectDistance, name: "enemyJumpDetectDistance");
			voidJumpDetectDistance = s.Serialize<float>(voidJumpDetectDistance, name: "voidJumpDetectDistance");
		}
		public override uint? ClassCRC => 0x1BD200F0;
	}
}

