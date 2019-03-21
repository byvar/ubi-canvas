using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionFX_Template : TweenInstruction_Template {
		[Serialize("fx"         )] public StringID fx;
		[Serialize("stop"       )] public int stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(stop));
		}
		public override uint? ClassCRC => 0x6699D058;
	}
}

