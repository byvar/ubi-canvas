using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchEyeTriggerComponent_Template : ShapeComponent_Template {
		[Serialize("eyeInput"       )] public StringID eyeInput;
		[Serialize("mode"           )] public TouchEyeMode mode;
		[Serialize("touchPriority"  )] public uint touchPriority;
		[Serialize("activateOnSlide")] public bool activateOnSlide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eyeInput));
			SerializeField(s, nameof(mode));
			SerializeField(s, nameof(touchPriority));
			SerializeField(s, nameof(activateOnSlide));
		}
		public enum TouchEyeMode {
			[Serialize("TouchEyeMode_AlwaysOpen")] AlwaysOpen = 0,
			[Serialize("TouchEyeMode_Proximity" )] Proximity = 2,
			[Serialize("TouchEyeMode_Timer"     )] Timer = 3,
		}
		public override uint? ClassCRC => 0x51D52C48;
	}
}

