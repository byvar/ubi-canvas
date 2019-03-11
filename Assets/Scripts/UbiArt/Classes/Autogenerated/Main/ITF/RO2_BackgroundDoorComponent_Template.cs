using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BackgroundDoorComponent_Template : RO2_DoorComponent_Template {
		[Serialize("walkThroughDoorTarget")] public Vector3 walkThroughDoorTarget;
		[Serialize("walkOutDistance"      )] public float walkOutDistance;
		[Serialize("enterColor"           )] public Color enterColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(walkThroughDoorTarget));
				SerializeField(s, nameof(enterColor));
				SerializeField(s, nameof(walkOutDistance));
			} else {
				SerializeField(s, nameof(walkThroughDoorTarget));
				SerializeField(s, nameof(walkOutDistance));
			}
		}
		public override uint? ClassCRC => 0x255A779A;
	}
}

