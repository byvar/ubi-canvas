using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenFlip_Template : TweenInstruction_Template {
		public TweenFlipMode mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mode = s.Serialize<TweenFlipMode>(mode, name: "mode");
		}
		public enum TweenFlipMode {
			[Serialize("TweenFlipMode_SetUnflipped")] SetUnflipped = 0,
			[Serialize("TweenFlipMode_SetFlipped"  )] SetFlipped = 1,
			[Serialize("TweenFlipMode_Toggle"      )] Toggle = 2,
		}
		public override uint? ClassCRC => 0x4EBF04E1;
	}
}

