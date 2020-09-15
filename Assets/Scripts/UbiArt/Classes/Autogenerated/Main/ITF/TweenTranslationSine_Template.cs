using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class TweenTranslationSine_Template : TweenTranslation_Template {
		public Vec3d movement;
		public float amplitude;
		public float cycleCount;
		public float cycleOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			movement = s.SerializeObject<Vec3d>(movement, name: "movement");
			amplitude = s.Serialize<float>(amplitude, name: "amplitude");
			cycleCount = s.Serialize<float>(cycleCount, name: "cycleCount");
			cycleOffset = s.Serialize<float>(cycleOffset, name: "cycleOffset");
		}
		public override uint? ClassCRC => 0xA6CFC699;
	}
}

