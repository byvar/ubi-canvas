using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class DeformOnTrajectoryComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x12CCFB0D;
	}
}

