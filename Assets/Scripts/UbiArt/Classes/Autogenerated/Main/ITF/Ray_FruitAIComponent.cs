using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_FruitAIComponent : Ray_AIComponent {
		public float firstBounceDirection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			firstBounceDirection = s.Serialize<float>(firstBounceDirection, name: "firstBounceDirection");
		}
		public override uint? ClassCRC => 0x607182A5;
	}
}

