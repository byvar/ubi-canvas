using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AILums2Behavior_Template : TemplateAIBehavior {
		[Serialize("takenTrajectoryFactorX"           )] public float takenTrajectoryFactorX;
		[Serialize("takenTrajectoryFactorY"           )] public float takenTrajectoryFactorY;
		[Serialize("percentTimeStartFading"           )] public float percentTimeStartFading;
		[Serialize("alphaWhenReachedScore"            )] public float alphaWhenReachedScore;
		[Serialize("waitDurationPerRankWhenAutoPicked")] public float waitDurationPerRankWhenAutoPicked;
		[Serialize("isKing"                           )] public int isKing;
		[Serialize("startKingComboFXLevel1"           )] public StringID startKingComboFXLevel1;
		[Serialize("startKingComboFXLevel2"           )] public StringID startKingComboFXLevel2;
		[Serialize("lumTrailACT"                      )] public Path lumTrailACT;
		[Serialize("trailWidth"                       )] public float trailWidth;
		[Serialize("redCompanionLumDelay"             )] public float redCompanionLumDelay;
		[Serialize("circularRotationSpeed"            )] public float circularRotationSpeed;
		[Serialize("lumKingMusicVolume"               )] public Volume lumKingMusicVolume;
		[Serialize("extraDuration"                    )] public float extraDuration;
		[Serialize("pickingAnimDuration"              )] public float pickingAnimDuration;
		[Serialize("particleLumAABB"                  )] public AABB particleLumAABB;
		[Serialize("scaleWhenReachedScore"            )] public float scaleWhenReachedScore;
		[Serialize("percentTimeStartScaling"          )] public float percentTimeStartScaling;
		[Serialize("playerDetectorMultiplierInWater"  )] public float playerDetectorMultiplierInWater;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(takenTrajectoryFactorX));
			SerializeField(s, nameof(takenTrajectoryFactorY));
			SerializeField(s, nameof(percentTimeStartFading));
			SerializeField(s, nameof(alphaWhenReachedScore));
			SerializeField(s, nameof(waitDurationPerRankWhenAutoPicked));
			SerializeField(s, nameof(isKing));
			SerializeField(s, nameof(startKingComboFXLevel1));
			SerializeField(s, nameof(startKingComboFXLevel2));
			SerializeField(s, nameof(lumTrailACT));
			SerializeField(s, nameof(trailWidth));
			SerializeField(s, nameof(redCompanionLumDelay));
			SerializeField(s, nameof(circularRotationSpeed));
			SerializeField(s, nameof(lumKingMusicVolume));
			SerializeField(s, nameof(extraDuration));
			SerializeField(s, nameof(pickingAnimDuration));
			SerializeField(s, nameof(particleLumAABB));
			SerializeField(s, nameof(scaleWhenReachedScore));
			SerializeField(s, nameof(percentTimeStartScaling));
			SerializeField(s, nameof(playerDetectorMultiplierInWater));
		}
		public override uint? ClassCRC => 0xF45E5A5E;
	}
}

