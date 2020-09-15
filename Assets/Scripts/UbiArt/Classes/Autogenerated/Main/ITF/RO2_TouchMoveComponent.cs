using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchMoveComponent : ActorComponent {
		public RO2_TouchHandler touchHandler;
		public float speedFactor;
		public float smoothFactor;
		public float targetSmoothFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			touchHandler = s.SerializeObject<RO2_TouchHandler>(touchHandler, name: "touchHandler");
			speedFactor = s.Serialize<float>(speedFactor, name: "speedFactor");
			smoothFactor = s.Serialize<float>(smoothFactor, name: "smoothFactor");
			targetSmoothFactor = s.Serialize<float>(targetSmoothFactor, name: "targetSmoothFactor");
		}
		public override uint? ClassCRC => 0x194F03C1;
	}
}

