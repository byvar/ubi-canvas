using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_473_sub_B94A50 : RO2_EnemyBTAIComponent {
		[Serialize("beforeCamRelativeInitialPos")] public Vector3 beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
		}
		public override uint? ClassCRC => 0xAEAE137A;
	}
}

