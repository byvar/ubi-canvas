using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class TweenCircle_Template : TweenTranslation_Template {
		public Vec3d pivot;
		public float cycleCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pivot = s.SerializeObject<Vec3d>(pivot, name: "pivot");
			cycleCount = s.Serialize<float>(cycleCount, name: "cycleCount");
		}
		public override uint? ClassCRC => 0x63707AC1;
	}
}

