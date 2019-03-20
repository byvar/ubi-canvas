using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventTriggerTag : Event {
		[Serialize("tag"   )] public StringID tag;
		[Serialize("value" )] public uint value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tag));
			SerializeField(s, nameof(value));
		}
		public override uint? ClassCRC => 0x30551100;
	}
}

