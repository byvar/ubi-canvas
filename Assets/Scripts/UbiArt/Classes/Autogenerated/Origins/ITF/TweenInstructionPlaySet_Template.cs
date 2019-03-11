using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstructionPlaySet_Template : CSerializable {
		[Serialize("duration")] public float duration;
		[Serialize("name"    )] public StringID name;
		[Serialize("set"     )] public StringID set;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(set));
		}
		public override uint? ClassCRC => 0x025C92CF;
	}
}

