using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenTranslationCircle_Template : TweenTranslation_Template {
		public Vec3d pivot;
		public float cycleCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pivot = s.SerializeObject<Vec3d>(pivot, name: "pivot");
			cycleCount = s.Serialize<float>(cycleCount, name: "cycleCount");
		}
		public override uint? ClassCRC => 0x18724DE5;
	}
}

