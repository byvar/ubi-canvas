using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenAnim_Template : TweenInstruction_Template {
		[Serialize("anim"    )] public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0x00785E69;
	}
}

