using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventSetColorInput : Event {
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("inputValue")] public Color inputValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputName));
			SerializeField(s, nameof(inputValue));
		}
		public override uint? ClassCRC => 0xA0721B0A;
	}
}

