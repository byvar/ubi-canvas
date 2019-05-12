using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RFR)]
	public partial class CheckpointComponent_Template : ActorComponent_Template {
		[Serialize("spawnPlayer")] public bool spawnPlayer;
		[Serialize("int__0"     )] public int int__0;
		[Serialize("int__1"     )] public int int__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (this is Ray_ShooterCheckPointComponent_Template) return;
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(int__1));
			} else {
				SerializeField(s, nameof(spawnPlayer));
			}
		}
		public override uint? ClassCRC => 0x0F8AF4A2;
	}
}

