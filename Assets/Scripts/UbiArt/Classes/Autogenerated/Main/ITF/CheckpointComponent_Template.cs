using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RFR)]
	public partial class CheckpointComponent_Template : ActorComponent_Template {
		public bool spawnPlayer;
		public int int__0;
		public int int__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (this is Ray_ShooterCheckPointComponent_Template) return;
			if (Settings.s.game == Settings.Game.RFR) {
				int__0 = s.Serialize<int>(int__0, name: "int__0");
				int__1 = s.Serialize<int>(int__1, name: "int__1");
			} else {
				spawnPlayer = s.Serialize<bool>(spawnPlayer, name: "spawnPlayer");
			}
		}
		public override uint? ClassCRC => 0x0F8AF4A2;
	}
}

