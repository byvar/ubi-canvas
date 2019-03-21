using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionAnim_Template : TweenInstruction_Template {
		[Serialize("anim"       )] public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0xA7732122;
	}
}

