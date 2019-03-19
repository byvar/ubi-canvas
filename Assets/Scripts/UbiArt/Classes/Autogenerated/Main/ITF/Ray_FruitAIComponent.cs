using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_FruitAIComponent : Ray_AIComponent {
		[Serialize("firstBounceDirection")] public float firstBounceDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(firstBounceDirection));
		}
		public override uint? ClassCRC => 0x607182A5;
	}
}

