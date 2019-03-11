using UnityEngine;

namespace UbiArt.ITF {
	public partial class GroundAIControllerComponent : BaseAIControllerComponent {
		[Serialize("AppearDisablePhysic")] public bool AppearDisablePhysic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(AppearDisablePhysic));
			}
		}
		public override uint? ClassCRC => 0x8B5C8C04;
	}
}

