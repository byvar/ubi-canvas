using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterTurretAIComponent : Ray_MultiPiecesActorAIComponent {
		[Serialize("timedSpawnerData")] public Placeholder timedSpawnerData;
		[Serialize("fixedAngle"      )] public float fixedAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timedSpawnerData));
			SerializeField(s, nameof(fixedAngle));
		}
		public override uint? ClassCRC => 0xC97160CC;
	}
}

