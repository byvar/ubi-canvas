using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchMoveComponent : ActorComponent {
		[Serialize("touchHandler"      )] public RO2_TouchHandler touchHandler;
		[Serialize("speedFactor"       )] public float speedFactor;
		[Serialize("smoothFactor"      )] public float smoothFactor;
		[Serialize("targetSmoothFactor")] public float targetSmoothFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(touchHandler));
			SerializeField(s, nameof(speedFactor));
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(targetSmoothFactor));
		}
		public override uint? ClassCRC => 0x194F03C1;
	}
}

