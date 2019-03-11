using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInstructionInput_Template : CSerializable {
		[Serialize("duration"  )] public float duration;
		[Serialize("name"      )] public StringID name;
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("floatValue")] public float floatValue;
		[Serialize("uintValue" )] public uint uintValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(inputName));
			SerializeField(s, nameof(floatValue));
			SerializeField(s, nameof(uintValue));
		}
		public override uint? ClassCRC => 0xAA2BA0F3;
	}
}

