using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class RO2_EventSetDirection : Event {
		public Vec2d direction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			direction = s.SerializeObject<Vec2d>(direction, name: "direction");
		}
		public override uint? ClassCRC => 0x6EC4A473;
	}
}

