using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SwingRopeComponent : SoftPlatformComponent {
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

