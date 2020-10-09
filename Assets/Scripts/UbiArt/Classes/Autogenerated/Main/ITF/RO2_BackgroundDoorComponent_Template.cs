using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BackgroundDoorComponent_Template : RO2_DoorComponent_Template {
		public Vec3d walkThroughDoorTarget;
		public Color enterColor;
		public float walkOutDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			walkThroughDoorTarget = s.SerializeObject<Vec3d>(walkThroughDoorTarget, name: "walkThroughDoorTarget");
			enterColor = s.SerializeObject<Color>(enterColor, name: "enterColor");
			walkOutDistance = s.Serialize<float>(walkOutDistance, name: "walkOutDistance");
		}
		public override uint? ClassCRC => 0x255A779A;
	}
}

