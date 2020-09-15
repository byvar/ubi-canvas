using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SeekingBulletAIComponent_Template : RO2_BulletAIComponent_Template {
		public Angle maxTurnAngle;
		public float phaseChangeRadius;
		public bool autoSeek;
		public float autoSeekDelay;
		public AABB autoSeekRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxTurnAngle = s.SerializeObject<Angle>(maxTurnAngle, name: "maxTurnAngle");
			phaseChangeRadius = s.Serialize<float>(phaseChangeRadius, name: "phaseChangeRadius");
			autoSeek = s.Serialize<bool>(autoSeek, name: "autoSeek");
			autoSeekDelay = s.Serialize<float>(autoSeekDelay, name: "autoSeekDelay");
			autoSeekRange = s.SerializeObject<AABB>(autoSeekRange, name: "autoSeekRange");
		}
		public override uint? ClassCRC => 0xDB809A3D;
	}
}

