using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterGardianMoray_Template : Ray_SnakeAIComponent_Template {
		[Serialize("waterPerturbationForce"  )] public float waterPerturbationForce;
		[Serialize("waterTestWidth"          )] public float waterTestWidth;
		[Serialize("waterTestBubonWidth"     )] public float waterTestBubonWidth;
		[Serialize("waterTestTailLength"     )] public float waterTestTailLength;
		[Serialize("waterTestTailWidth"      )] public float waterTestTailWidth;
		[Serialize("waterTestHeadLength"     )] public float waterTestHeadLength;
		[Serialize("waterTestHeadWidth"      )] public float waterTestHeadWidth;
		[Serialize("waterSpawnFxDelay"       )] public float waterSpawnFxDelay;
		[Serialize("deathRewardSpawnPath"    )] public Path deathRewardSpawnPath;
		[Serialize("deathRewardNumber"       )] public uint deathRewardNumber;
		[Serialize("deathRewardSpawnDuration")] public float deathRewardSpawnDuration;
		[Serialize("deathRewardSpawnDist"    )] public Vec2d deathRewardSpawnDist;
		[Serialize("deathRewardSpawnAngle"   )] public Vec2d deathRewardSpawnAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waterPerturbationForce));
			SerializeField(s, nameof(waterTestWidth));
			SerializeField(s, nameof(waterTestBubonWidth));
			SerializeField(s, nameof(waterTestTailLength));
			SerializeField(s, nameof(waterTestTailWidth));
			SerializeField(s, nameof(waterTestHeadLength));
			SerializeField(s, nameof(waterTestHeadWidth));
			SerializeField(s, nameof(waterSpawnFxDelay));
			SerializeField(s, nameof(deathRewardSpawnPath));
			SerializeField(s, nameof(deathRewardNumber));
			SerializeField(s, nameof(deathRewardSpawnDuration));
			SerializeField(s, nameof(deathRewardSpawnDist));
			SerializeField(s, nameof(deathRewardSpawnAngle));
		}
		public override uint? ClassCRC => 0x72E73AE1;
	}
}

