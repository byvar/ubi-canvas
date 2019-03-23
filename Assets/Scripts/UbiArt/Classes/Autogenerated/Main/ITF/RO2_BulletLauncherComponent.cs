using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_BulletLauncherComponent : ActorComponent {
		[Serialize("timedSpawnerData"                    )] public TimedSpawnerData timedSpawnerData;
		[Serialize("startActive"                         )] public bool startActive;
		[Serialize("applyColorsToBullet"                 )] public bool applyColorsToBullet;
		[Serialize("useTutoOnBullet"                     )] public bool useTutoOnBullet;
		[Serialize("activePhysic"                        )] public bool activePhysic;
		[Serialize("destroyAllBulletInstanceWhenDisabled")] public bool destroyAllBulletInstanceWhenDisabled;
		[Serialize("spawnAlwaysActive"                   )] public bool spawnAlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(timedSpawnerData));
					SerializeField(s, nameof(startActive));
					SerializeField(s, nameof(applyColorsToBullet));
					SerializeField(s, nameof(useTutoOnBullet), boolAsByte: true);
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(timedSpawnerData));
					SerializeField(s, nameof(startActive));
					SerializeField(s, nameof(applyColorsToBullet));
					SerializeField(s, nameof(useTutoOnBullet));
					SerializeField(s, nameof(activePhysic));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(timedSpawnerData));
					SerializeField(s, nameof(startActive));
					SerializeField(s, nameof(applyColorsToBullet));
					SerializeField(s, nameof(useTutoOnBullet));
					SerializeField(s, nameof(activePhysic));
					SerializeField(s, nameof(destroyAllBulletInstanceWhenDisabled));
					SerializeField(s, nameof(spawnAlwaysActive));
				}
			}
		}
		public override uint? ClassCRC => 0xB782C5CD;
	}
}

