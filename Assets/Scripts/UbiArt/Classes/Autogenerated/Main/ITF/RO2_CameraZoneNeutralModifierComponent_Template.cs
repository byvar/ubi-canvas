using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CameraZoneNeutralModifierComponent_Template : ActorComponent_Template {
		public Vec2d zoneNeutral;
		public float swipeSpeed;
		public float swipeToleranceTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			zoneNeutral = s.SerializeObject<Vec2d>(zoneNeutral, name: "zoneNeutral");
			swipeSpeed = s.Serialize<float>(swipeSpeed, name: "swipeSpeed");
			swipeToleranceTime = s.Serialize<float>(swipeToleranceTime, name: "swipeToleranceTime");
		}
		public override uint? ClassCRC => 0xBE62EA71;
	}
}

