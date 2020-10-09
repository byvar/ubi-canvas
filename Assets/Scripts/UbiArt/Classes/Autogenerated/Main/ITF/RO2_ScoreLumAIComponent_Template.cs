using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ScoreLumAIComponent_Template : ActorComponent_Template {
		public float takenTrajectoryFactorX;
		public float takenTrajectoryFactorY;
		public float percentTimeStartFading;
		public float alphaWhenReachedScore;
		public float waitDurationPerRankWhenAutoPicked;
		public float redCompanionLumDelay;
		public float circularRotationSpeed;
		public float extraDuration;
		public AABB particleLumAABB;
		public float scaleWhenReachedScore;
		public float percentTimeStartScaling;
		public float lumScale;
		public float lumSpawnRadius;
		public StringID yellowPickingAnim;
		public StringID yellowFlyAnim;
		public StringID redPickingAnim;
		public StringID redFlyAnim;
		public StringID redLongPickingAnim;
		public StringID yellowLongPickingAnim;
		public float flightTime;
		public float minScreenSize;
		public StringID yellowFlightFX;
		public StringID redFlightFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			takenTrajectoryFactorX = s.Serialize<float>(takenTrajectoryFactorX, name: "takenTrajectoryFactorX");
			takenTrajectoryFactorY = s.Serialize<float>(takenTrajectoryFactorY, name: "takenTrajectoryFactorY");
			percentTimeStartFading = s.Serialize<float>(percentTimeStartFading, name: "percentTimeStartFading");
			alphaWhenReachedScore = s.Serialize<float>(alphaWhenReachedScore, name: "alphaWhenReachedScore");
			waitDurationPerRankWhenAutoPicked = s.Serialize<float>(waitDurationPerRankWhenAutoPicked, name: "waitDurationPerRankWhenAutoPicked");
			redCompanionLumDelay = s.Serialize<float>(redCompanionLumDelay, name: "redCompanionLumDelay");
			circularRotationSpeed = s.Serialize<float>(circularRotationSpeed, name: "circularRotationSpeed");
			extraDuration = s.Serialize<float>(extraDuration, name: "extraDuration");
			particleLumAABB = s.SerializeObject<AABB>(particleLumAABB, name: "particleLumAABB");
			scaleWhenReachedScore = s.Serialize<float>(scaleWhenReachedScore, name: "scaleWhenReachedScore");
			percentTimeStartScaling = s.Serialize<float>(percentTimeStartScaling, name: "percentTimeStartScaling");
			lumScale = s.Serialize<float>(lumScale, name: "lumScale");
			lumSpawnRadius = s.Serialize<float>(lumSpawnRadius, name: "lumSpawnRadius");
			yellowPickingAnim = s.SerializeObject<StringID>(yellowPickingAnim, name: "yellowPickingAnim");
			yellowFlyAnim = s.SerializeObject<StringID>(yellowFlyAnim, name: "yellowFlyAnim");
			redPickingAnim = s.SerializeObject<StringID>(redPickingAnim, name: "redPickingAnim");
			redFlyAnim = s.SerializeObject<StringID>(redFlyAnim, name: "redFlyAnim");
			redLongPickingAnim = s.SerializeObject<StringID>(redLongPickingAnim, name: "redLongPickingAnim");
			yellowLongPickingAnim = s.SerializeObject<StringID>(yellowLongPickingAnim, name: "yellowLongPickingAnim");
			flightTime = s.Serialize<float>(flightTime, name: "flightTime");
			minScreenSize = s.Serialize<float>(minScreenSize, name: "minScreenSize");
			yellowFlightFX = s.SerializeObject<StringID>(yellowFlightFX, name: "yellowFlightFX");
			redFlightFX = s.SerializeObject<StringID>(redFlightFX, name: "redFlightFX");
		}
		public override uint? ClassCRC => 0x41688A24;
	}
}

