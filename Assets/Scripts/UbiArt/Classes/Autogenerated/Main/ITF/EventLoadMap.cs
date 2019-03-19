using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventLoadMap : Event {
		[Serialize("map")] public Path map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(map));
		}
		public override uint? ClassCRC => 0xADE35B67;
	}
}

