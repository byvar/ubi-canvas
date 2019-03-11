using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstructionAnim_Template : CSerializable {
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		[Serialize("anim"    )] public StringID anim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(anim));
		}
		public override uint? ClassCRC => 0xA7732122;
	}
}

