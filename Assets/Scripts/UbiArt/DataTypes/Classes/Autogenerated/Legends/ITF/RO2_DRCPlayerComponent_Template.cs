namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DRCPlayerComponent_Template : ActorComponent_Template {
		public float maxSpeed_level0;
		public float maxSpeed_level1;
		public Generic<PhysShape> phantomShape;
		public uint faction;
		public StringID moveHoldFXName;
		public StringID moveTapFXName;
		public float tapDuration;
		public StringID releaseFXName;
		public StringID appearFXName;
		public StringID disapearFXName;
		public StringID sparklesFXName;
		public StringID autoMurphyFXName;
		public StringID autoMurphyFXWaitActionName;
		public float maxSpeed;
		public float distMinTeleport;
		public float distMaxDrag;
		public StringID animFly;
		public StringID animTeleport;
		public StringID animCatch;
		public StringID animRotatingPlatform;
		public StringID animCatchFront;
		public StringID animAppearSequence;
		public StringID animDisappearSequence;
		public StringID animUturn;
		public StringID animPunch;
		public StringID animTickle;
		public StringID animPunchBurst;
		public StringID animEat;
		public StringID animSlingShot;
		public StringID animCatchFrontHard;
		public StringID animCallPlayer;
		public float distMaxArms;
		public float distMinGrabFront;
		public float thresholdSpeedForUturn;
		public float thresholdSpeedForAnim;
		public float smoothFactorSlow;
		public float smoothFactorFast;
		public int useMagicCurve;
		public BezierCurveRenderer_Template bezierRenderer;
		public float distTang;
		public float freqRotateTangStart;
		public float freqRotateTangEnd;
		public float magicCurveOffsetStart;
		public float magicCurveOffsetEnd;
		public float magicCurveDistMin;
		public RO2_SwarmRepellerPowerUp_Template swarmRepeller;
		public int debug;
		public float disappearSequenceDialogDuration;
		public float appearSequenceDuration;
		public AccelType appearSequenceTravelType;
		public StringID appearSequenceFXName;
		public Vec2d appearSequenceDestPosOffset;
		public StringID appearSequenceFXPosBoneName;
		public float timeHysteresisGrab;
		public Path trailPath;
		public Path flashPath;
		public float lookAutoPlayerWaitDuration;
		public float forceMoveWaitingDurationMin;
		public float forceMoveWaitingDurationMax;
		public float murphyFlipOnTouchRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			maxSpeed_level0 = s.Serialize<float>(maxSpeed_level0, name: "maxSpeed_level0");
			maxSpeed_level1 = s.Serialize<float>(maxSpeed_level1, name: "maxSpeed_level1");
			phantomShape = s.SerializeObject<Generic<PhysShape>>(phantomShape, name: "phantomShape");
			faction = s.Serialize<uint>(faction, name: "faction");
			moveHoldFXName = s.SerializeObject<StringID>(moveHoldFXName, name: "moveHoldFXName");
			moveTapFXName = s.SerializeObject<StringID>(moveTapFXName, name: "moveTapFXName");
			tapDuration = s.Serialize<float>(tapDuration, name: "tapDuration");
			releaseFXName = s.SerializeObject<StringID>(releaseFXName, name: "releaseFXName");
			appearFXName = s.SerializeObject<StringID>(appearFXName, name: "appearFXName");
			disapearFXName = s.SerializeObject<StringID>(disapearFXName, name: "disapearFXName");
			sparklesFXName = s.SerializeObject<StringID>(sparklesFXName, name: "sparklesFXName");
			autoMurphyFXName = s.SerializeObject<StringID>(autoMurphyFXName, name: "autoMurphyFXName");
			autoMurphyFXWaitActionName = s.SerializeObject<StringID>(autoMurphyFXWaitActionName, name: "autoMurphyFXWaitActionName");
			maxSpeed = s.Serialize<float>(maxSpeed, name: "maxSpeed");
			distMinTeleport = s.Serialize<float>(distMinTeleport, name: "distMinTeleport");
			distMaxDrag = s.Serialize<float>(distMaxDrag, name: "distMaxDrag");
			animFly = s.SerializeObject<StringID>(animFly, name: "animFly");
			animTeleport = s.SerializeObject<StringID>(animTeleport, name: "animTeleport");
			animCatch = s.SerializeObject<StringID>(animCatch, name: "animCatch");
			animRotatingPlatform = s.SerializeObject<StringID>(animRotatingPlatform, name: "animRotatingPlatform");
			animCatchFront = s.SerializeObject<StringID>(animCatchFront, name: "animCatchFront");
			animAppearSequence = s.SerializeObject<StringID>(animAppearSequence, name: "animAppearSequence");
			animDisappearSequence = s.SerializeObject<StringID>(animDisappearSequence, name: "animDisappearSequence");
			animUturn = s.SerializeObject<StringID>(animUturn, name: "animUturn");
			animPunch = s.SerializeObject<StringID>(animPunch, name: "animPunch");
			animTickle = s.SerializeObject<StringID>(animTickle, name: "animTickle");
			animPunchBurst = s.SerializeObject<StringID>(animPunchBurst, name: "animPunchBurst");
			animEat = s.SerializeObject<StringID>(animEat, name: "animEat");
			animSlingShot = s.SerializeObject<StringID>(animSlingShot, name: "animSlingShot");
			animCatchFrontHard = s.SerializeObject<StringID>(animCatchFrontHard, name: "animCatchFrontHard");
			animCallPlayer = s.SerializeObject<StringID>(animCallPlayer, name: "animCallPlayer");
			distMaxArms = s.Serialize<float>(distMaxArms, name: "distMaxArms");
			distMinGrabFront = s.Serialize<float>(distMinGrabFront, name: "distMinGrabFront");
			thresholdSpeedForUturn = s.Serialize<float>(thresholdSpeedForUturn, name: "thresholdSpeedForUturn");
			thresholdSpeedForAnim = s.Serialize<float>(thresholdSpeedForAnim, name: "thresholdSpeedForAnim");
			smoothFactorSlow = s.Serialize<float>(smoothFactorSlow, name: "smoothFactorSlow");
			smoothFactorFast = s.Serialize<float>(smoothFactorFast, name: "smoothFactorFast");
			useMagicCurve = s.Serialize<int>(useMagicCurve, name: "useMagicCurve");
			bezierRenderer = s.SerializeObject<BezierCurveRenderer_Template>(bezierRenderer, name: "bezierRenderer");
			distTang = s.Serialize<float>(distTang, name: "distTang");
			freqRotateTangStart = s.Serialize<float>(freqRotateTangStart, name: "freqRotateTangStart");
			freqRotateTangEnd = s.Serialize<float>(freqRotateTangEnd, name: "freqRotateTangEnd");
			magicCurveOffsetStart = s.Serialize<float>(magicCurveOffsetStart, name: "magicCurveOffsetStart");
			magicCurveOffsetEnd = s.Serialize<float>(magicCurveOffsetEnd, name: "magicCurveOffsetEnd");
			magicCurveDistMin = s.Serialize<float>(magicCurveDistMin, name: "magicCurveDistMin");
			swarmRepeller = s.SerializeObject<RO2_SwarmRepellerPowerUp_Template>(swarmRepeller, name: "swarmRepeller");
			debug = s.Serialize<int>(debug, name: "debug");
			disappearSequenceDialogDuration = s.Serialize<float>(disappearSequenceDialogDuration, name: "disappearSequenceDialogDuration");
			appearSequenceDuration = s.Serialize<float>(appearSequenceDuration, name: "appearSequenceDuration");
			appearSequenceTravelType = s.Serialize<AccelType>(appearSequenceTravelType, name: "appearSequenceTravelType");
			appearSequenceFXName = s.SerializeObject<StringID>(appearSequenceFXName, name: "appearSequenceFXName");
			appearSequenceDestPosOffset = s.SerializeObject<Vec2d>(appearSequenceDestPosOffset, name: "appearSequenceDestPosOffset");
			appearSequenceFXPosBoneName = s.SerializeObject<StringID>(appearSequenceFXPosBoneName, name: "appearSequenceFXPosBoneName");
			timeHysteresisGrab = s.Serialize<float>(timeHysteresisGrab, name: "timeHysteresisGrab");
			trailPath = s.SerializeObject<Path>(trailPath, name: "trailPath");
			flashPath = s.SerializeObject<Path>(flashPath, name: "flashPath");
			lookAutoPlayerWaitDuration = s.Serialize<float>(lookAutoPlayerWaitDuration, name: "lookAutoPlayerWaitDuration");
			forceMoveWaitingDurationMin = s.Serialize<float>(forceMoveWaitingDurationMin, name: "forceMoveWaitingDurationMin");
			forceMoveWaitingDurationMax = s.Serialize<float>(forceMoveWaitingDurationMax, name: "forceMoveWaitingDurationMax");
			murphyFlipOnTouchRadius = s.Serialize<float>(murphyFlipOnTouchRadius, name: "murphyFlipOnTouchRadius");
		}
		public enum AccelType {
			[Serialize("AccelType_Linear")] Linear = 0,
			[Serialize("AccelType_X2"    )] X2 = 1,
			[Serialize("AccelType_X3"    )] X3 = 2,
			[Serialize("AccelType_X4"    )] X4 = 3,
			[Serialize("AccelType_X5"    )] X5 = 4,
			[Serialize("AccelType_InvX2" )] InvX2 = 5,
			[Serialize("AccelType_InvX3" )] InvX3 = 6,
			[Serialize("AccelType_InvX4" )] InvX4 = 7,
			[Serialize("AccelType_InvX5" )] InvX5 = 8,
		}
		public override uint? ClassCRC => 0xC9214390;
	}
}

