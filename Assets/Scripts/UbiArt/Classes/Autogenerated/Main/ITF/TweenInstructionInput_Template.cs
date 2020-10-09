using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class TweenInstructionInput_Template : TweenInstruction_Template {
		public StringID inputName;
		public float floatValue;
		public uint uintValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputName = s.SerializeObject<StringID>(inputName, name: "inputName");
			floatValue = s.Serialize<float>(floatValue, name: "floatValue");
			uintValue = s.Serialize<uint>(uintValue, name: "uintValue");
		}
		public override uint? ClassCRC => 0xAA2BA0F3;
	}
}

