using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_TeleportPortalComponent_Template : ActorComponent_Template {
		[Serialize("directionAngleOffset")] public Angle directionAngleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(directionAngleOffset));
		}
		public override uint? ClassCRC => 0xE40DC41B;
	}
}

