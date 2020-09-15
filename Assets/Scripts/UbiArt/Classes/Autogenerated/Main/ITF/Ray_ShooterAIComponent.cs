using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterAIComponent : Ray_AIComponent {
		[Serialize("beforeCamRelativeInitialPos")] public Vec3d beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
		}
		public override uint? ClassCRC => 0xC82C333D;
	}
}

