using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventSetColorInput : Event {
		public StringID inputName;
		public Color inputValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputName = s.SerializeObject<StringID>(inputName, name: "inputName");
			inputValue = s.SerializeObject<Color>(inputValue, name: "inputValue");
		}
		public override uint? ClassCRC => 0xA0721B0A;
	}
}

