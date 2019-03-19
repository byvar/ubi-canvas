using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIProgressBar : CSerializable {
		[Serialize("barHeight")] public float barHeight;
		[Serialize("barWidth" )] public float barWidth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(barHeight));
				SerializeField(s, nameof(barWidth));
			}
		}
		public override uint? ClassCRC => 0x6FE31CAF;
	}
}

