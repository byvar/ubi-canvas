using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MicDetectorComponent : ShapeDetectorComponent {
		[Serialize("smoothFactor"      )] public float smoothFactor;
		[Serialize("validationDuration")] public float validationDuration;
		[Serialize("validationRMSLevel")] public float validationRMSLevel;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(smoothFactor));
			SerializeField(s, nameof(validationDuration));
			SerializeField(s, nameof(validationRMSLevel));
		}
		public override uint? ClassCRC => 0xA94E89D7;
	}
}

