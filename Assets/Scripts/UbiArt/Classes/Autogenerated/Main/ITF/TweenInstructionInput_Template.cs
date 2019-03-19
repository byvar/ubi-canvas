using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenInstructionInput_Template : TweenInstruction_Template {
		[Serialize("duration"   )] public float duration;
		[Serialize("name"       )] public StringID name;
		[Serialize("inputName"  )] public StringID inputName;
		[Serialize("floatValue" )] public float floatValue;
		[Serialize("uintValue"  )] public uint uintValue;
		[Serialize("StringID__0")] public StringID StringID__0;
		[Serialize("float__1"   )] public float float__1;
		[Serialize("uint__2"    )] public uint uint__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(inputName));
				SerializeField(s, nameof(floatValue));
				SerializeField(s, nameof(uintValue));
			} else {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(uint__2));
			}
		}
		public override uint? ClassCRC => 0xAA2BA0F3;
	}
}

