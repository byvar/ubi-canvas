using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterTurretAIComponent : Unknown_RL_466_sub_B92120 {
		public TimedSpawnerData timedSpawnerData;
		public float fixedAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timedSpawnerData = s.SerializeObject<TimedSpawnerData>(timedSpawnerData, name: "timedSpawnerData");
			fixedAngle = s.Serialize<float>(fixedAngle, name: "fixedAngle");
		}
		public override uint? ClassCRC => 0x35663FAD;
	}
}

