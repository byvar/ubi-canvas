using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ScreenSideTrajectoryFollowerComponent_Template : TrajectoryFollowerComponent_Template {
		public float distanceFromSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			distanceFromSide = s.Serialize<float>(distanceFromSide, name: "distanceFromSide");
		}
		public override uint? ClassCRC => 0x43F707F7;
	}
}

