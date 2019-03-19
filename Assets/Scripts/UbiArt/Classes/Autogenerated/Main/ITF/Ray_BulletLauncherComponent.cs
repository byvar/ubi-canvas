using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BulletLauncherComponent : ActorComponent {
		[Serialize("timedSpawnerData")] public TimedSpawnerData timedSpawnerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timedSpawnerData));
		}
		public override uint? ClassCRC => 0x4F484F30;
	}
}

