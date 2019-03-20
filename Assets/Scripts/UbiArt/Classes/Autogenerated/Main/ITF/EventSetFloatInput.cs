using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetFloatInput : Event {
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("inputValue")] public float inputValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputName));
			SerializeField(s, nameof(inputValue));
		}
		public override uint? ClassCRC => 0x302A1685;
	}
}

