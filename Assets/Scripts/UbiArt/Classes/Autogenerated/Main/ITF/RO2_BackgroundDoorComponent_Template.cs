using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BackgroundDoorComponent_Template : RO2_DoorComponent_Template {
		[Serialize("walkThroughDoorTarget")] public Vec3d walkThroughDoorTarget;
		[Serialize("enterColor"           )] public Color enterColor;
		[Serialize("walkOutDistance"      )] public float walkOutDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(walkThroughDoorTarget));
			SerializeField(s, nameof(enterColor));
			SerializeField(s, nameof(walkOutDistance));
		}
		public override uint? ClassCRC => 0x255A779A;
	}
}

