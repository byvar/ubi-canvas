using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_alTranquiloAiComponent : AIComponent {
		[Serialize("bubbleLifetime")] public float bubbleLifetime;
		[Serialize("useTuto"       )] public bool useTuto;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bubbleLifetime));
				SerializeField(s, nameof(useTuto));
			}
		}
		public override uint? ClassCRC => 0x949607D4;
	}
}

