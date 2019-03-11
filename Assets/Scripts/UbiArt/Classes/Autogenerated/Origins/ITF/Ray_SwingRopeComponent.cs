using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SwingRopeComponent : Ray_AINetworkComponent {
		[Serialize("initialAngle")] public Angle initialAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(initialAngle));
			}
		}
		public override uint? ClassCRC => 0x6AA2E69F;
	}
}

