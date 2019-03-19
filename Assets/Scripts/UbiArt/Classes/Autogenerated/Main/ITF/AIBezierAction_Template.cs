using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AIBezierAction_Template : AIAction_Template {
		[Serialize("changeAngle"              )] public bool changeAngle;
		[Serialize("updatePhysSpeedAtEnd"     )] public bool updatePhysSpeedAtEnd;
		[Serialize("speed"                    )] public float speed;
		[Serialize("fixedDuration"            )] public float fixedDuration;
		[Serialize("fixedDurationInterpolType")] public uint fixedDurationInterpolType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(changeAngle));
			SerializeField(s, nameof(updatePhysSpeedAtEnd));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(fixedDuration));
			SerializeField(s, nameof(fixedDurationInterpolType));
		}
		public override uint? ClassCRC => 0x155F0C44;
	}
}

