using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ExitComponent : ActorComponent {
		public Vec3d captainExitRitualOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			captainExitRitualOffset = s.SerializeObject<Vec3d>(captainExitRitualOffset, name: "captainExitRitualOffset");
		}
		public override uint? ClassCRC => 0xD337C6AA;
	}
}

