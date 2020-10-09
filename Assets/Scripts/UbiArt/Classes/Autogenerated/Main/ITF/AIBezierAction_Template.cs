using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIBezierAction_Template : AIAction_Template {
		public bool changeAngle;
		public bool updatePhysSpeedAtEnd;
		public float speed;
		public float fixedDuration;
		public uint fixedDurationInterpolType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			changeAngle = s.Serialize<bool>(changeAngle, name: "changeAngle");
			updatePhysSpeedAtEnd = s.Serialize<bool>(updatePhysSpeedAtEnd, name: "updatePhysSpeedAtEnd");
			speed = s.Serialize<float>(speed, name: "speed");
			fixedDuration = s.Serialize<float>(fixedDuration, name: "fixedDuration");
			fixedDurationInterpolType = s.Serialize<uint>(fixedDurationInterpolType, name: "fixedDurationInterpolType");
		}
		public override uint? ClassCRC => 0x155F0C44;
	}
}

