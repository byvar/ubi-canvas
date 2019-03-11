using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ScoreLumAIComponent_Template : ActorComponent_Template {
		[Serialize("takenTrajectoryFactorX"           )] public float takenTrajectoryFactorX;
		[Serialize("takenTrajectoryFactorY"           )] public float takenTrajectoryFactorY;
		[Serialize("percentTimeStartFading"           )] public float percentTimeStartFading;
		[Serialize("alphaWhenReachedScore"            )] public float alphaWhenReachedScore;
		[Serialize("waitDurationPerRankWhenAutoPicked")] public float waitDurationPerRankWhenAutoPicked;
		[Serialize("redCompanionLumDelay"             )] public float redCompanionLumDelay;
		[Serialize("circularRotationSpeed"            )] public float circularRotationSpeed;
		[Serialize("extraDuration"                    )] public float extraDuration;
		[Serialize("particleLumAABB"                  )] public AABB particleLumAABB;
		[Serialize("scaleWhenReachedScore"            )] public float scaleWhenReachedScore;
		[Serialize("percentTimeStartScaling"          )] public float percentTimeStartScaling;
		[Serialize("lumScale"                         )] public float lumScale;
		[Serialize("lumSpawnRadius"                   )] public float lumSpawnRadius;
		[Serialize("yellowPickingAnim"                )] public StringID yellowPickingAnim;
		[Serialize("yellowFlyAnim"                    )] public StringID yellowFlyAnim;
		[Serialize("redPickingAnim"                   )] public StringID redPickingAnim;
		[Serialize("redFlyAnim"                       )] public StringID redFlyAnim;
		[Serialize("redLongPickingAnim"               )] public StringID redLongPickingAnim;
		[Serialize("yellowLongPickingAnim"            )] public StringID yellowLongPickingAnim;
		[Serialize("flightTime"                       )] public float flightTime;
		[Serialize("minScreenSize"                    )] public float minScreenSize;
		[Serialize("yellowFlightFX"                   )] public StringID yellowFlightFX;
		[Serialize("redFlightFX"                      )] public StringID redFlightFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(takenTrajectoryFactorX));
			SerializeField(s, nameof(takenTrajectoryFactorY));
			SerializeField(s, nameof(percentTimeStartFading));
			SerializeField(s, nameof(alphaWhenReachedScore));
			SerializeField(s, nameof(waitDurationPerRankWhenAutoPicked));
			SerializeField(s, nameof(redCompanionLumDelay));
			SerializeField(s, nameof(circularRotationSpeed));
			SerializeField(s, nameof(extraDuration));
			SerializeField(s, nameof(particleLumAABB));
			SerializeField(s, nameof(scaleWhenReachedScore));
			SerializeField(s, nameof(percentTimeStartScaling));
			SerializeField(s, nameof(lumScale));
			SerializeField(s, nameof(lumSpawnRadius));
			SerializeField(s, nameof(yellowPickingAnim));
			SerializeField(s, nameof(yellowFlyAnim));
			SerializeField(s, nameof(redPickingAnim));
			SerializeField(s, nameof(redFlyAnim));
			SerializeField(s, nameof(redLongPickingAnim));
			SerializeField(s, nameof(yellowLongPickingAnim));
			SerializeField(s, nameof(flightTime));
			SerializeField(s, nameof(minScreenSize));
			SerializeField(s, nameof(yellowFlightFX));
			SerializeField(s, nameof(redFlightFX));
		}
		public override uint? ClassCRC => 0x41688A24;
	}
}

