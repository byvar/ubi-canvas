using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_GroundEnemyAIComponent : Ray_BossPlantArenaAIComponent {
		[Serialize("useRaycast")] public bool useRaycast;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useRaycast));
		}
		public override uint? ClassCRC => 0xDA325BB4;
	}
}

