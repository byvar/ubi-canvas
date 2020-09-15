using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetFloatInput : Event {
		public StringID inputName;
		public float inputValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inputName = s.SerializeObject<StringID>(inputName, name: "inputName");
			inputValue = s.Serialize<float>(inputValue, name: "inputValue");
		}
		public override uint? ClassCRC => 0x302A1685;
	}
}

