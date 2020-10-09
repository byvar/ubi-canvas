using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_AILums2Behavior_Template : TemplateAIBehavior {
		public float takenTrajectoryFactorX;
		public float takenTrajectoryFactorY;
		public float percentTimeStartFading;
		public float alphaWhenReachedScore;
		public float waitDurationPerRankWhenAutoPicked;
		public int isKing;
		public StringID startKingComboFXLevel1;
		public StringID startKingComboFXLevel2;
		public Path lumTrailACT;
		public float trailWidth;
		public float redCompanionLumDelay;
		public float circularRotationSpeed;
		public Volume lumKingMusicVolume;
		public float extraDuration;
		public float pickingAnimDuration;
		public AABB particleLumAABB;
		public float scaleWhenReachedScore;
		public float percentTimeStartScaling;
		public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			takenTrajectoryFactorX = s.Serialize<float>(takenTrajectoryFactorX, name: "takenTrajectoryFactorX");
			takenTrajectoryFactorY = s.Serialize<float>(takenTrajectoryFactorY, name: "takenTrajectoryFactorY");
			percentTimeStartFading = s.Serialize<float>(percentTimeStartFading, name: "percentTimeStartFading");
			alphaWhenReachedScore = s.Serialize<float>(alphaWhenReachedScore, name: "alphaWhenReachedScore");
			waitDurationPerRankWhenAutoPicked = s.Serialize<float>(waitDurationPerRankWhenAutoPicked, name: "waitDurationPerRankWhenAutoPicked");
			isKing = s.Serialize<int>(isKing, name: "isKing");
			startKingComboFXLevel1 = s.SerializeObject<StringID>(startKingComboFXLevel1, name: "startKingComboFXLevel1");
			startKingComboFXLevel2 = s.SerializeObject<StringID>(startKingComboFXLevel2, name: "startKingComboFXLevel2");
			lumTrailACT = s.SerializeObject<Path>(lumTrailACT, name: "lumTrailACT");
			trailWidth = s.Serialize<float>(trailWidth, name: "trailWidth");
			redCompanionLumDelay = s.Serialize<float>(redCompanionLumDelay, name: "redCompanionLumDelay");
			circularRotationSpeed = s.Serialize<float>(circularRotationSpeed, name: "circularRotationSpeed");
			lumKingMusicVolume = s.SerializeObject<Volume>(lumKingMusicVolume, name: "lumKingMusicVolume");
			extraDuration = s.Serialize<float>(extraDuration, name: "extraDuration");
			pickingAnimDuration = s.Serialize<float>(pickingAnimDuration, name: "pickingAnimDuration");
			particleLumAABB = s.SerializeObject<AABB>(particleLumAABB, name: "particleLumAABB");
			scaleWhenReachedScore = s.Serialize<float>(scaleWhenReachedScore, name: "scaleWhenReachedScore");
			percentTimeStartScaling = s.Serialize<float>(percentTimeStartScaling, name: "percentTimeStartScaling");
			playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
		}
		public override uint? ClassCRC => 0xF45E5A5E;
	}
}

