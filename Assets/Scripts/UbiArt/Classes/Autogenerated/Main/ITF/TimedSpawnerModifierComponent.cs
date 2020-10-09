using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TimedSpawnerModifierComponent : ActorComponent {
		public TimedSpawnerData timedSpawnerData;
		public Placeholder TimedSpawnerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
				TimedSpawnerData = s.SerializeObject<Placeholder>(TimedSpawnerData, name: "TimedSpawnerData");
			} else {
				timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
			}
		}
		public override uint? ClassCRC => 0x5DF76399;
	}
}

