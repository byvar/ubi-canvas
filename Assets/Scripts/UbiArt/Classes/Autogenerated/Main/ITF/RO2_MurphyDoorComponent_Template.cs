using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MurphyDoorComponent_Template : ActorComponent_Template {
		[Serialize("cursorTapProgressValue"   )] public float cursorTapProgressValue;
		[Serialize("cursorGlobalProgressSpeed")] public float cursorGlobalProgressSpeed;
		[Serialize("PAL"                      )] public bool PAL;
		[Serialize("PALModePlayerAABBRange"   )] public AABB PALModePlayerAABBRange;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cursorTapProgressValue));
			SerializeField(s, nameof(cursorGlobalProgressSpeed));
			SerializeField(s, nameof(PAL));
			SerializeField(s, nameof(PALModePlayerAABBRange));
		}
		public override uint? ClassCRC => 0x4E3C471D;
	}
}

