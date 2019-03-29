using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterTurretAIComponent : Unknown_RL_466_sub_B92120 {
		[Serialize("timedSpawnerData")] public TimedSpawnerData timedSpawnerData;
		[Serialize("fixedAngle"      )] public float fixedAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timedSpawnerData));
			SerializeField(s, nameof(fixedAngle));
		}
		public override uint? ClassCRC => 0x35663FAD;
	}
}

