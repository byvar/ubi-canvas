using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RO)]
	public partial class TimedSpawnerModifierComponent : ActorComponent {
		[Serialize("timedSpawnerData")] public TimedSpawnerData timedSpawnerData;
		[Serialize("TimedSpawnerData")] public Placeholder TimedSpawnerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(timedSpawnerData));
				SerializeField(s, nameof(TimedSpawnerData));
			} else {
				SerializeField(s, nameof(timedSpawnerData));
			}
		}
		public override uint? ClassCRC => 0x5DF76399;
	}
}

