using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class GroundAIControllerComponent : BaseAIControllerComponent {
		public bool AppearDisablePhysic;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
			} else {
				AppearDisablePhysic = s.Serialize<bool>(AppearDisablePhysic, name: "AppearDisablePhysic");
			}
		}
		public override uint? ClassCRC => 0x8B5C8C04;
	}
}

