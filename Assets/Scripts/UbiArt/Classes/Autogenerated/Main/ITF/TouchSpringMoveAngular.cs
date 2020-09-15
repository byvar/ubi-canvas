using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class TouchSpringMoveAngular : TouchSpringMoveBase {
		public Angle totalAngle;
		public Angle minAngleLimit;
		public Angle maxAngleLimit;
		public Angle initAngle;
		public Angle axisOffsetAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			totalAngle = s.SerializeObject<Angle>(totalAngle, name: "totalAngle");
			minAngleLimit = s.SerializeObject<Angle>(minAngleLimit, name: "minAngleLimit");
			maxAngleLimit = s.SerializeObject<Angle>(maxAngleLimit, name: "maxAngleLimit");
			initAngle = s.SerializeObject<Angle>(initAngle, name: "initAngle");
			axisOffsetAngle = s.SerializeObject<Angle>(axisOffsetAngle, name: "axisOffsetAngle");
		}
		public override uint? ClassCRC => 0x81E5A7CA;
	}
}

