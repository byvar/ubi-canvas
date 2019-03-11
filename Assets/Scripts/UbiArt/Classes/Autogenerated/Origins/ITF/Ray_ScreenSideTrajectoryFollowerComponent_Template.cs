using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ScreenSideTrajectoryFollowerComponent_Template : TrajectoryFollowerComponent_Template {
		[Serialize("distanceFromSide")] public float distanceFromSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(distanceFromSide));
		}
		public override uint? ClassCRC => 0x43F707F7;
	}
}

