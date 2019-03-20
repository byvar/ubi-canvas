using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL | GameFlags.COL)]
	public partial class EventGhostTrigger : Event {
		[Serialize("recordType")] public uint recordType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(recordType));
		}
		public override uint? ClassCRC => 0x7130EB99;
	}
}

