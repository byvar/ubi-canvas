using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetUintInput : Event {
		[Serialize("inputName" )] public StringID inputName;
		[Serialize("inputValue")] public uint inputValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputName));
			SerializeField(s, nameof(inputValue));
		}
		public override uint? ClassCRC => 0x603D2117;
	}
}

