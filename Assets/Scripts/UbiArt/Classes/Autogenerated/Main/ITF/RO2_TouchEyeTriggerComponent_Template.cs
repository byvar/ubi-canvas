using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TouchEyeTriggerComponent_Template : ShapeComponent_Template {
		public StringID eyeInput;
		public TouchEyeMode mode;
		public uint touchPriority;
		public bool activateOnSlide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eyeInput = s.SerializeObject<StringID>(eyeInput, name: "eyeInput");
			mode = s.Serialize<TouchEyeMode>(mode, name: "mode");
			touchPriority = s.Serialize<uint>(touchPriority, name: "touchPriority");
			activateOnSlide = s.Serialize<bool>(activateOnSlide, name: "activateOnSlide");
		}
		public enum TouchEyeMode {
			[Serialize("TouchEyeMode_AlwaysOpen")] AlwaysOpen = 0,
			[Serialize("TouchEyeMode_Proximity" )] Proximity = 2,
			[Serialize("TouchEyeMode_Timer"     )] Timer = 3,
		}
		public override uint? ClassCRC => 0x51D52C48;
	}
}

