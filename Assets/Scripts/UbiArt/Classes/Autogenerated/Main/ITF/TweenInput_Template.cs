using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class TweenInput_Template : TweenInstruction_Template {
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("floatValue")] public float floatValue;
		[Serialize("uintValue" )] public uint uintValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputName));
			SerializeField(s, nameof(floatValue));
			SerializeField(s, nameof(uintValue));
		}
		public override uint? ClassCRC => 0x552239C3;
	}
}

