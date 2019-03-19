using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class GroundAIControllerComponent : BaseAIControllerComponent {
		[Serialize("AppearDisablePhysic")] public bool AppearDisablePhysic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
			} else {
				SerializeField(s, nameof(AppearDisablePhysic));
			}
		}
		public override uint? ClassCRC => 0x8B5C8C04;
	}
}

