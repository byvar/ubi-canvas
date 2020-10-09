using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventLoadMap : Event {
		public Path map;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			map = s.SerializeObject<Path>(map, name: "map");
		}
		public override uint? ClassCRC => 0xADE35B67;
	}
}

