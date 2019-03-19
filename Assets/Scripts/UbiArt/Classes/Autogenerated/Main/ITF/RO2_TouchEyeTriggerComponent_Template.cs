using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TouchEyeTriggerComponent_Template : ShapeComponent_Template {
		[Serialize("eyeInput"       )] public StringID eyeInput;
		[Serialize("mode"           )] public TouchEyeMode mode;
		[Serialize("touchPriority"  )] public uint touchPriority;
		[Serialize("activateOnSlide")] public bool activateOnSlide;
		[Serialize("mode"           )] public Enum_mode mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(eyeInput));
				SerializeField(s, nameof(mode));
				SerializeField(s, nameof(touchPriority));
				SerializeField(s, nameof(activateOnSlide));
			} else {
				SerializeField(s, nameof(eyeInput));
				SerializeField(s, nameof(mode));
				SerializeField(s, nameof(touchPriority));
				SerializeField(s, nameof(activateOnSlide));
			}
		}
		public enum TouchEyeMode {
			[Serialize("TouchEyeMode_AlwaysOpen")] AlwaysOpen = 0,
			[Serialize("TouchEyeMode_Proximity" )] Proximity = 2,
			[Serialize("TouchEyeMode_Timer"     )] Timer = 3,
		}
		public enum Enum_mode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x51D52C48;
	}
}

