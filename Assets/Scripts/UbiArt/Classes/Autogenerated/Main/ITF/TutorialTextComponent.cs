using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TutorialTextComponent : ActorComponent {
		public Vec2d RELATIVEPOS;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				RELATIVEPOS = s.SerializeObject<Vec2d>(RELATIVEPOS, name: "RELATIVEPOS");
			}
		}
		public override uint? ClassCRC => 0x92A7EA4E;
	}
}

