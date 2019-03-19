using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_453_sub_B89E60 : CSerializable {
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
		public override uint? ClassCRC => 0x69FBAF75;
	}
}

