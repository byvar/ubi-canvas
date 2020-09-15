using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class FixedCameraComponent : BaseCameraComponent {
		[Serialize("offset")] public Vec3d offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(offset));
			}
		}
		public override uint? ClassCRC => 0x461D3103;
	}
}

