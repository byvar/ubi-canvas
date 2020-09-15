using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BulletLauncherComponent : ActorComponent {
		public TimedSpawnerData timedSpawnerData;
		public bool startActive;
		public bool applyColorsToBullet;
		public bool useTutoOnBullet;
		public bool activePhysic;
		public bool destroyAllBulletInstanceWhenDisabled;
		public bool spawnAlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
					startActive = s.Serialize<bool>(startActive, name: "startActive");
					applyColorsToBullet = s.Serialize<bool>(applyColorsToBullet, name: "applyColorsToBullet");
					useTutoOnBullet = s.Serialize<bool>(useTutoOnBullet, name: "useTutoOnBullet", options: CSerializerObject.Options.BoolAsByte);
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
					startActive = s.Serialize<bool>(startActive, name: "startActive");
					applyColorsToBullet = s.Serialize<bool>(applyColorsToBullet, name: "applyColorsToBullet");
					useTutoOnBullet = s.Serialize<bool>(useTutoOnBullet, name: "useTutoOnBullet");
					activePhysic = s.Serialize<bool>(activePhysic, name: "activePhysic");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
					startActive = s.Serialize<bool>(startActive, name: "startActive");
					applyColorsToBullet = s.Serialize<bool>(applyColorsToBullet, name: "applyColorsToBullet");
					useTutoOnBullet = s.Serialize<bool>(useTutoOnBullet, name: "useTutoOnBullet");
					activePhysic = s.Serialize<bool>(activePhysic, name: "activePhysic");
					destroyAllBulletInstanceWhenDisabled = s.Serialize<bool>(destroyAllBulletInstanceWhenDisabled, name: "destroyAllBulletInstanceWhenDisabled");
					spawnAlwaysActive = s.Serialize<bool>(spawnAlwaysActive, name: "spawnAlwaysActive");
				}
			}
		}
		public override uint? ClassCRC => 0xB782C5CD;
	}
}

