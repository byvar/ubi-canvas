using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionFX_Template : TweenInstruction_Template {
		public StringID fx;
		public int stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fx = s.SerializeObject<StringID>(fx, name: "fx");
			stop = s.Serialize<int>(stop, name: "stop");
		}
		public override uint? ClassCRC => 0x6699D058;
	}
}

