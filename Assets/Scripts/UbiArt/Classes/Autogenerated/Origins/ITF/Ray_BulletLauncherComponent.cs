using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BulletLauncherComponent : CSerializable {
		[Serialize("timedSpawnerData")] public Placeholder timedSpawnerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timedSpawnerData));
		}
		public override uint? ClassCRC => 0x4F484F30;
	}
}

