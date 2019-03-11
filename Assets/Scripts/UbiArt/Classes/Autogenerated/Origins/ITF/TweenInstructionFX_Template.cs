using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstructionFX_Template : CSerializable {
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		[Serialize("fx"      )] public StringID fx;
		[Serialize("stop"    )] public bool stop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(fx));
			SerializeField(s, nameof(stop));
		}
		public override uint? ClassCRC => 0x6699D058;
	}
}

