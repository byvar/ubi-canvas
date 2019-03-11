using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_FruitAIComponent : Ray_BossPlantArenaAIComponent {
		[Serialize("firstBounceDirection")] public float firstBounceDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(firstBounceDirection));
		}
		public override uint? ClassCRC => 0x607182A5;
	}
}

