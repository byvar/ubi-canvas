using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BubbleSpawnerComponent : ActorComponent {
		[Serialize("bubbleLifetime"   )] public float bubbleLifetime;
		[Serialize("bubbleFloatForceX")] public float bubbleFloatForceX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bubbleLifetime));
				SerializeField(s, nameof(bubbleFloatForceX));
			}
		}
		public override uint? ClassCRC => 0xF43E36BB;
	}
}

