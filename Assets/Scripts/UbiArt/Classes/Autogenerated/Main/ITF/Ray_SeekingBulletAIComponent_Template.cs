using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SeekingBulletAIComponent_Template : Ray_BulletAIComponent_Template {
		public Angle maxTurnAngle;
		public float phaseChangeRadius;
		public int autoSeek;
		public float autoSeekDelay;
		public AABB autoSeekRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxTurnAngle = s.SerializeObject<Angle>(maxTurnAngle, name: "maxTurnAngle");
			phaseChangeRadius = s.Serialize<float>(phaseChangeRadius, name: "phaseChangeRadius");
			autoSeek = s.Serialize<int>(autoSeek, name: "autoSeek");
			autoSeekDelay = s.Serialize<float>(autoSeekDelay, name: "autoSeekDelay");
			autoSeekRange = s.SerializeObject<AABB>(autoSeekRange, name: "autoSeekRange");
		}
		public override uint? ClassCRC => 0x4D6FF211;
	}
}

