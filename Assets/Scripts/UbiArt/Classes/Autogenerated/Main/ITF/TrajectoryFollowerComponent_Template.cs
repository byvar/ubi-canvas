using UnityEngine;

namespace UbiArt.ITF {
	public partial class TrajectoryFollowerComponent_Template : ActorComponent_Template {
		[Serialize("speed"                     )] public float speed;
		[Serialize("speedSmoothFactor"         )] public float speedSmoothFactor;
		[Serialize("cameraRelative"            )] public bool cameraRelative;
		[Serialize("skipRetrigger"             )] public bool skipRetrigger;
		[Serialize("destroyAtEnd"              )] public bool destroyAtEnd;
		[Serialize("updatesAnimInput"          )] public bool updatesAnimInput;
		[Serialize("startsActivated"           )] public bool startsActivated;
		[Serialize("updatesAngle"              )] public bool updatesAngle;
		[Serialize("updatesZ"                  )] public bool updatesZ;
		[Serialize("triggerChildren"           )] public bool triggerChildren;
		[Serialize("safeDistance"              )] public float safeDistance;
		[Serialize("iAmThePursueur"            )] public bool iAmThePursueur;
		[Serialize("minSpeed"                  )] public float minSpeed;
		[Serialize("maxSpeed"                  )] public float maxSpeed;
		[Serialize("inputOrientEnabled"        )] public bool inputOrientEnabled;
		[Serialize("inputOrientBlendFactor"    )] public float inputOrientBlendFactor;
		[Serialize("useCheckpointLoaded"       )] public bool useCheckpointLoaded;
		[Serialize("inputAddVerticalEnabled"   )] public bool inputAddVerticalEnabled;
		[Serialize("inputAddVerticalMinSpeed"  )] public float inputAddVerticalMinSpeed;
		[Serialize("inputAddVerticalMaxSpeed"  )] public float inputAddVerticalMaxSpeed;
		[Serialize("inputAddHorizontalEnabled" )] public bool inputAddHorizontalEnabled;
		[Serialize("inputAddHorizontalMinSpeed")] public float inputAddHorizontalMinSpeed;
		[Serialize("inputAddHorizontalMaxSpeed")] public float inputAddHorizontalMaxSpeed;
		[Serialize("inputSpeedMaxEnabled"      )] public bool inputSpeedMaxEnabled;
		[Serialize("inputSpeedMaxMinTime"      )] public float inputSpeedMaxMinTime;
		[Serialize("inputSpeedMaxThreshold"    )] public float inputSpeedMaxThreshold;
		[Serialize("playRateEnabled"           )] public bool playRateEnabled;
		[Serialize("playRateMin"               )] public float playRateMin;
		[Serialize("playRateMax"               )] public float playRateMax;
		[Serialize("uTurnEnabled"              )] public bool uTurnEnabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(speedSmoothFactor));
				SerializeField(s, nameof(cameraRelative));
				SerializeField(s, nameof(skipRetrigger));
				SerializeField(s, nameof(destroyAtEnd));
				SerializeField(s, nameof(updatesAnimInput));
				SerializeField(s, nameof(startsActivated));
				SerializeField(s, nameof(updatesAngle));
				SerializeField(s, nameof(updatesZ));
				SerializeField(s, nameof(safeDistance));
				SerializeField(s, nameof(minSpeed));
				SerializeField(s, nameof(maxSpeed));
			} else {
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(speedSmoothFactor));
				SerializeField(s, nameof(cameraRelative));
				SerializeField(s, nameof(skipRetrigger));
				SerializeField(s, nameof(destroyAtEnd));
				SerializeField(s, nameof(updatesAnimInput));
				SerializeField(s, nameof(startsActivated));
				SerializeField(s, nameof(updatesAngle));
				SerializeField(s, nameof(updatesZ));
				SerializeField(s, nameof(triggerChildren));
				SerializeField(s, nameof(safeDistance));
				SerializeField(s, nameof(iAmThePursueur));
				SerializeField(s, nameof(minSpeed));
				SerializeField(s, nameof(maxSpeed));
				SerializeField(s, nameof(inputOrientEnabled));
				SerializeField(s, nameof(inputOrientBlendFactor));
				SerializeField(s, nameof(useCheckpointLoaded));
				SerializeField(s, nameof(inputAddVerticalEnabled));
				SerializeField(s, nameof(inputAddVerticalMinSpeed));
				SerializeField(s, nameof(inputAddVerticalMaxSpeed));
				SerializeField(s, nameof(inputAddHorizontalEnabled));
				SerializeField(s, nameof(inputAddHorizontalMinSpeed));
				SerializeField(s, nameof(inputAddHorizontalMaxSpeed));
				SerializeField(s, nameof(inputSpeedMaxEnabled));
				SerializeField(s, nameof(inputSpeedMaxMinTime));
				SerializeField(s, nameof(inputSpeedMaxThreshold));
				SerializeField(s, nameof(playRateEnabled));
				SerializeField(s, nameof(playRateMin));
				SerializeField(s, nameof(playRateMax));
				SerializeField(s, nameof(uTurnEnabled));
			}
		}
		public override uint? ClassCRC => 0x5D6B650C;
	}
}

