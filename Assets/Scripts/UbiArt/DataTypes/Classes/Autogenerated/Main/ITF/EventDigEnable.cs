using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventDigEnable : Event {
		public bool enable;
		public float radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enable = s.Serialize<bool>(enable, name: "enable");
			radius = s.Serialize<float>(radius, name: "radius");
		}
		public override uint? ClassCRC => 0xAD06DCD9;
	}
}

