using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_alTranquiloAiComponent : AIComponent {
		[Serialize("bubbleLifetime")] public float bubbleLifetime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bubbleLifetime));
			}
		}
		public override uint? ClassCRC => 0xCCB31478;
	}
}

