using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionAnim_Template : TweenInstruction_Template {
		[Serialize("duration"   )] public float duration;
		[Serialize("name"       )] public StringID name;
		[Serialize("anim"       )] public StringID anim;
		[Serialize("StringID__0")] public StringID StringID__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(anim));
			} else {
				SerializeField(s, nameof(StringID__0));
			}
		}
		public override uint? ClassCRC => 0xA7732122;
	}
}

