using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_SeekingBulletAIComponent_Template : Ray_BulletAIComponent_Template {
		[Serialize("maxTurnAngle"     )] public Angle maxTurnAngle;
		[Serialize("phaseChangeRadius")] public float phaseChangeRadius;
		[Serialize("autoSeek"         )] public int autoSeek;
		[Serialize("autoSeekDelay"    )] public float autoSeekDelay;
		[Serialize("autoSeekRange"    )] public AABB autoSeekRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxTurnAngle));
			SerializeField(s, nameof(phaseChangeRadius));
			SerializeField(s, nameof(autoSeek));
			SerializeField(s, nameof(autoSeekDelay));
			SerializeField(s, nameof(autoSeekRange));
		}
		public override uint? ClassCRC => 0x4D6FF211;
	}
}

