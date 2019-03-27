using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)] // There is one more empty parent between this and RO2_AIComponent
	public partial class RO2_ShooterTurretAIComponent : RO2_AIComponent {
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

