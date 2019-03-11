using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstruction_Template : CSerializable {
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(name));
		}
		public override uint? ClassCRC => 0xF14825EE;
	}
}

