using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventSwipe : Event {
		public Angle angle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			angle = s.SerializeObject<Angle>(angle, name: "angle");
		}
		public override uint? ClassCRC => 0x4FECC5D6;
	}
}

