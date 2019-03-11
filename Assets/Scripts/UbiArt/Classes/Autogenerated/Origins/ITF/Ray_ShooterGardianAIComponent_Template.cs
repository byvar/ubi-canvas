using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterGardianAIComponent_Template : Ray_SimpleAIComponent_Template {
		[Serialize("minHitStunLevel"           )] public uint minHitStunLevel;
		[Serialize("multiPlayerLifePointFactor")] public float multiPlayerLifePointFactor;
		[Serialize("deathRewardSpawnPath"      )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"         )] public uint deathRewardNumber;
		[Serialize("deathRewardSpawnDuration"  )] public float deathRewardSpawnDuration;
		[Serialize("deathRewardSpawnDist"      )] public Vector2 deathRewardSpawnDist;
		[Serialize("deathRewardSpawnAngle"     )] public Vector2 deathRewardSpawnAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minHitStunLevel));
			SerializeField(s, nameof(multiPlayerLifePointFactor));
			SerializeField(s, nameof(deathRewardSpawnPath));
			SerializeField(s, nameof(deathRewardNumber));
			SerializeField(s, nameof(deathRewardSpawnDuration));
			SerializeField(s, nameof(deathRewardSpawnDist));
			SerializeField(s, nameof(deathRewardSpawnAngle));
		}
		public override uint? ClassCRC => 0xA7CBA488;
	}
}

