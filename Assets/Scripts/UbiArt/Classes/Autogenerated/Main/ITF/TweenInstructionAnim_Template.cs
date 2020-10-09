using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class TweenInstructionAnim_Template : TweenInstruction_Template {
		public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			anim = s.SerializeObject<StringID>(anim, name: "anim");
		}
		public override uint? ClassCRC => 0xA7732122;
	}
}

