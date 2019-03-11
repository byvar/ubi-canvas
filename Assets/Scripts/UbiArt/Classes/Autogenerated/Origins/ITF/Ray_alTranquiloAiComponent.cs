using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_alTranquiloAiComponent : CSerializable {
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

