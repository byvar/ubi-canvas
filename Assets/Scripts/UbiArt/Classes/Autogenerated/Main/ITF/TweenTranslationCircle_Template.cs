using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenTranslationCircle_Template : TweenTranslation_Template {
		[Serialize("pivot"     )] public Vec3d pivot;
		[Serialize("cycleCount")] public float cycleCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pivot));
			SerializeField(s, nameof(cycleCount));
		}
		public override uint? ClassCRC => 0x18724DE5;
	}
}

