namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class TrajectoryFollowerComponent_Template : ActorComponent_Template {
		public float speed = 1f;
		public float speedSmoothFactor = 1f;
		public bool cameraRelative;
		public bool skipRetrigger;
		public bool destroyAtEnd;
		public bool updatesAnimInput = true;
		public bool startsActivated;
		public bool updatesAngle = true;
		public bool updatesZ = true;
		public bool triggerChildren = true;
		public float safeDistance;
		public bool iAmThePursueur;
		public float minSpeed;
		public float maxSpeed = 1f;
		public bool inputOrientEnabled;
		public float inputOrientBlendFactor = 1f;
		public bool useCheckpointLoaded;
		public bool inputAddVerticalEnabled;
		public float inputAddVerticalMinSpeed;
		public float inputAddVerticalMaxSpeed;
		public bool inputAddHorizontalEnabled;
		public float inputAddHorizontalMinSpeed;
		public float inputAddHorizontalMaxSpeed;
		public bool inputSpeedMaxEnabled;
		public float inputSpeedMaxMinTime;
		public float inputSpeedMaxThreshold;
		public bool playRateEnabled;
		public float playRateMin = 1f;
		public float playRateMax = 1f;
		public bool uTurnEnabled;

		public uint Vita_00 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				speed = s.Serialize<float>(speed, name: "speed");
				speedSmoothFactor = s.Serialize<float>(speedSmoothFactor, name: "speedSmoothFactor");
				cameraRelative = s.Serialize<bool>(cameraRelative, name: "cameraRelative");
				skipRetrigger = s.Serialize<bool>(skipRetrigger, name: "skipRetrigger");
				destroyAtEnd = s.Serialize<bool>(destroyAtEnd, name: "destroyAtEnd");
				updatesAnimInput = s.Serialize<bool>(updatesAnimInput, name: "updatesAnimInput");
				startsActivated = s.Serialize<bool>(startsActivated, name: "startsActivated");
				updatesAngle = s.Serialize<bool>(updatesAngle, name: "updatesAngle");
				updatesZ = s.Serialize<bool>(updatesZ, name: "updatesZ");
				safeDistance = s.Serialize<float>(safeDistance, name: "safeDistance");
				minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
				maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			} else {
				speed = s.Serialize<float>(speed, name: "speed");
				speedSmoothFactor = s.Serialize<float>(speedSmoothFactor, name: "speedSmoothFactor");
				cameraRelative = s.Serialize<bool>(cameraRelative, name: "cameraRelative");
				skipRetrigger = s.Serialize<bool>(skipRetrigger, name: "skipRetrigger");
				destroyAtEnd = s.Serialize<bool>(destroyAtEnd, name: "destroyAtEnd");
				updatesAnimInput = s.Serialize<bool>(updatesAnimInput, name: "updatesAnimInput");
				startsActivated = s.Serialize<bool>(startsActivated, name: "startsActivated");
				updatesAngle = s.Serialize<bool>(updatesAngle, name: "updatesAngle");
				updatesZ = s.Serialize<bool>(updatesZ, name: "updatesZ");
				triggerChildren = s.Serialize<bool>(triggerChildren, name: "triggerChildren");
				safeDistance = s.Serialize<float>(safeDistance, name: "safeDistance");
				iAmThePursueur = s.Serialize<bool>(iAmThePursueur, name: "iAmThePursueur");
				minSpeed = s.Serialize<float>(minSpeed, name: "minSpeed");
				maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
				inputOrientEnabled = s.Serialize<bool>(inputOrientEnabled, name: "inputOrientEnabled");
				inputOrientBlendFactor = s.Serialize<float>(inputOrientBlendFactor, name: "inputOrientBlendFactor");
				useCheckpointLoaded = s.Serialize<bool>(useCheckpointLoaded, name: "useCheckpointLoaded");
				inputAddVerticalEnabled = s.Serialize<bool>(inputAddVerticalEnabled, name: "inputAddVerticalEnabled");
				inputAddVerticalMinSpeed = s.Serialize<float>(inputAddVerticalMinSpeed, name: "inputAddVerticalMinSpeed");
				inputAddVerticalMaxSpeed = s.Serialize<float>(inputAddVerticalMaxSpeed, name: "inputAddVerticalMaxSpeed");
				inputAddHorizontalEnabled = s.Serialize<bool>(inputAddHorizontalEnabled, name: "inputAddHorizontalEnabled");
				inputAddHorizontalMinSpeed = s.Serialize<float>(inputAddHorizontalMinSpeed, name: "inputAddHorizontalMinSpeed");
				inputAddHorizontalMaxSpeed = s.Serialize<float>(inputAddHorizontalMaxSpeed, name: "inputAddHorizontalMaxSpeed");
				inputSpeedMaxEnabled = s.Serialize<bool>(inputSpeedMaxEnabled, name: "inputSpeedMaxEnabled");
				inputSpeedMaxMinTime = s.Serialize<float>(inputSpeedMaxMinTime, name: "inputSpeedMaxMinTime");
				inputSpeedMaxThreshold = s.Serialize<float>(inputSpeedMaxThreshold, name: "inputSpeedMaxThreshold");
				playRateEnabled = s.Serialize<bool>(playRateEnabled, name: "playRateEnabled");
				playRateMin = s.Serialize<float>(playRateMin, name: "playRateMin");
				playRateMax = s.Serialize<float>(playRateMax, name: "playRateMax");
				uTurnEnabled = s.Serialize<bool>(uTurnEnabled, name: "uTurnEnabled");
				if (s.Settings.Platform == GamePlatform.Vita) {
					Vita_00 = s.Serialize<uint>(Vita_00, name: nameof(Vita_00));
				}
			}
		}
		public override uint? ClassCRC => 0x5D6B650C;
	}
}

