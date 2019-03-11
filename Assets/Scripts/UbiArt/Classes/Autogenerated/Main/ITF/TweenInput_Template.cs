using UnityEngine;

namespace UbiArt.ITF {
	public partial class TweenInput_Template : TweenInstruction_Template {
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("floatValue")] public float floatValue;
		[Serialize("uintValue" )] public uint uintValue;
		[Serialize("duration"  )] public float duration;
		[Serialize("name"      )] public StringID name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(duration));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(inputName));
				SerializeField(s, nameof(floatValue));
				SerializeField(s, nameof(uintValue));
			} else {
				SerializeField(s, nameof(inputName));
				SerializeField(s, nameof(floatValue));
				SerializeField(s, nameof(uintValue));
			}
		}
		public override uint? ClassCRC => 0x552239C3;
	}
}

