using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenFlip_Template : TweenInstruction_Template {
		[Serialize("mode"    )] public TweenFlipMode mode;
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		[Serialize("mode"    )] public Enum_mode mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(mode));
			} else {
				SerializeField(s, nameof(mode));
			}
		}
		public enum TweenFlipMode {
			[Serialize("TweenFlipMode_SetUnflipped")] SetUnflipped = 0,
			[Serialize("TweenFlipMode_SetFlipped"  )] SetFlipped = 1,
			[Serialize("TweenFlipMode_Toggle"      )] Toggle = 2,
		}
		public enum Enum_mode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x4EBF04E1;
	}
}

