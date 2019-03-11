using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TouchSpringPlatformBaseComponent_Template : ActorComponent_Template {
		[Serialize("swipeValidationSpeed"             )] public float swipeValidationSpeed;
		[Serialize("tapValidationDuration"            )] public float tapValidationDuration;
		[Serialize("realWorldPosCompensateBlendFactor")] public float realWorldPosCompensateBlendFactor;
		[Serialize("checkpointRestoreSavedCursor"     )] public bool checkpointRestoreSavedCursor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(swipeValidationSpeed));
			SerializeField(s, nameof(tapValidationDuration));
			SerializeField(s, nameof(realWorldPosCompensateBlendFactor));
			SerializeField(s, nameof(checkpointRestoreSavedCursor));
		}
		public override uint? ClassCRC => 0xCF81EB81;
	}
}

