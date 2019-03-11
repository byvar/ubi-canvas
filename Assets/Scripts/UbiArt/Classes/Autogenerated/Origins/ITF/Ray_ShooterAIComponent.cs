using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterAIComponent : Ray_BossPlantArenaAIComponent {
		[Serialize("beforeCamRelativeInitialPos")] public Vector3 beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
		}
		public override uint? ClassCRC => 0xC82C333D;
	}
}

