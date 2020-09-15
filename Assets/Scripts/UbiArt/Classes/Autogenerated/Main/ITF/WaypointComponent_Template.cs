using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class WaypointComponent_Template : ActorComponent_Template {
		public StringID wayPointId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			wayPointId = s.SerializeObject<StringID>(wayPointId, name: "wayPointId");
		}
		public override uint? ClassCRC => 0xAF7CABD2;
	}
}

