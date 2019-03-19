using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class TimedSpawnerAIComponent : AIComponent {
		[Serialize("spawnData")] public TimedSpawnerData spawnData;
		[Serialize("health"   )] public int health;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(health));
				}
				SerializeField(s, nameof(spawnData));
			} else {
				SerializeField(s, nameof(spawnData));
			}
		}
		public override uint? ClassCRC => 0xF3FC1E91;
	}
}

