using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventTriggerTag : Event {
		public StringID tag;
		public uint value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			tag = s.SerializeObject<StringID>(tag, name: "tag");
			value = s.Serialize<uint>(value, name: "value");
		}
		public override uint? ClassCRC => 0x30551100;
	}
}

