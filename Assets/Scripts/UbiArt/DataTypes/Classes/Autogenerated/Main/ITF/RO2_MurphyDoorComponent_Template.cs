using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MurphyDoorComponent_Template : ActorComponent_Template {
		public float cursorTapProgressValue;
		public float cursorGlobalProgressSpeed;
		public bool PAL;
		public AABB PALModePlayerAABBRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cursorTapProgressValue = s.Serialize<float>(cursorTapProgressValue, name: "cursorTapProgressValue");
			cursorGlobalProgressSpeed = s.Serialize<float>(cursorGlobalProgressSpeed, name: "cursorGlobalProgressSpeed");
			PAL = s.Serialize<bool>(PAL, name: "PAL");
			PALModePlayerAABBRange = s.SerializeObject<AABB>(PALModePlayerAABBRange, name: "PALModePlayerAABBRange");
		}
		public override uint? ClassCRC => 0x4E3C471D;
	}
}

