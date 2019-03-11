using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SwingRopeComponent : SoftPlatformComponent {
		[Serialize("initialAngle")] public Angle initialAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(initialAngle));
			}
		}
		public override uint? ClassCRC => 0x3076274A;
	}
}

