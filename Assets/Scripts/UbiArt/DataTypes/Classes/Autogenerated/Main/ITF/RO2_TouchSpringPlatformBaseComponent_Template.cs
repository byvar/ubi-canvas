using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchSpringPlatformBaseComponent_Template : ActorComponent_Template {
		public float swipeValidationSpeed;
		public float tapValidationDuration;
		public float realWorldPosCompensateBlendFactor;
		public bool checkpointRestoreSavedCursor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			swipeValidationSpeed = s.Serialize<float>(swipeValidationSpeed, name: "swipeValidationSpeed");
			tapValidationDuration = s.Serialize<float>(tapValidationDuration, name: "tapValidationDuration");
			realWorldPosCompensateBlendFactor = s.Serialize<float>(realWorldPosCompensateBlendFactor, name: "realWorldPosCompensateBlendFactor");
			checkpointRestoreSavedCursor = s.Serialize<bool>(checkpointRestoreSavedCursor, name: "checkpointRestoreSavedCursor");
		}
		public override uint? ClassCRC => 0xCF81EB81;
	}
}

