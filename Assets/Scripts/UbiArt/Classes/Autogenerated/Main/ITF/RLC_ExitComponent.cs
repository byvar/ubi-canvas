using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ExitComponent : ActorComponent {
		[Serialize("captainExitRitualOffset")] public Vec3d captainExitRitualOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(captainExitRitualOffset));
		}
		public override uint? ClassCRC => 0xD337C6AA;
	}
}

