using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_430_sub_B590D0 : ActorComponent_Template {
		[Serialize("maxSpeed_level0"                )] public float maxSpeed_level0;
		[Serialize("maxSpeed_level1"                )] public float maxSpeed_level1;
		[Serialize("phantomShape"                   )] public Generic<PhysShape> phantomShape;
		[Serialize("faction"                        )] public uint faction;
		[Serialize("moveHoldFXName"                 )] public StringID moveHoldFXName;
		[Serialize("moveTapFXName"                  )] public StringID moveTapFXName;
		[Serialize("tapDuration"                    )] public float tapDuration;
		[Serialize("releaseFXName"                  )] public StringID releaseFXName;
		[Serialize("appearFXName"                   )] public StringID appearFXName;
		[Serialize("disapearFXName"                 )] public StringID disapearFXName;
		[Serialize("sparklesFXName"                 )] public StringID sparklesFXName;
		[Serialize("autoMurphyFXName"               )] public StringID autoMurphyFXName;
		[Serialize("autoMurphyFXWaitActionName"     )] public StringID autoMurphyFXWaitActionName;
		[Serialize("maxSpeed"                       )] public float maxSpeed;
		[Serialize("distMinTeleport"                )] public float distMinTeleport;
		[Serialize("distMaxDrag"                    )] public float distMaxDrag;
		[Serialize("animFly"                        )] public StringID animFly;
		[Serialize("animTeleport"                   )] public StringID animTeleport;
		[Serialize("animCatch"                      )] public StringID animCatch;
		[Serialize("animRotatingPlatform"           )] public StringID animRotatingPlatform;
		[Serialize("animCatchFront"                 )] public StringID animCatchFront;
		[Serialize("animAppearSequence"             )] public StringID animAppearSequence;
		[Serialize("animDisappearSequence"          )] public StringID animDisappearSequence;
		[Serialize("animUturn"                      )] public StringID animUturn;
		[Serialize("animPunch"                      )] public StringID animPunch;
		[Serialize("animTickle"                     )] public StringID animTickle;
		[Serialize("animPunchBurst"                 )] public StringID animPunchBurst;
		[Serialize("animEat"                        )] public StringID animEat;
		[Serialize("animSlingShot"                  )] public StringID animSlingShot;
		[Serialize("animCatchFrontHard"             )] public StringID animCatchFrontHard;
		[Serialize("animCallPlayer"                 )] public StringID animCallPlayer;
		[Serialize("distMaxArms"                    )] public float distMaxArms;
		[Serialize("distMinGrabFront"               )] public float distMinGrabFront;
		[Serialize("thresholdSpeedForUturn"         )] public float thresholdSpeedForUturn;
		[Serialize("thresholdSpeedForAnim"          )] public float thresholdSpeedForAnim;
		[Serialize("smoothFactorSlow"               )] public float smoothFactorSlow;
		[Serialize("smoothFactorFast"               )] public float smoothFactorFast;
		[Serialize("useMagicCurve"                  )] public int useMagicCurve;
		[Serialize("bezierRenderer"                 )] public BezierCurveRenderer_Template bezierRenderer;
		[Serialize("distTang"                       )] public float distTang;
		[Serialize("freqRotateTangStart"            )] public float freqRotateTangStart;
		[Serialize("freqRotateTangEnd"              )] public float freqRotateTangEnd;
		[Serialize("magicCurveOffsetStart"          )] public float magicCurveOffsetStart;
		[Serialize("magicCurveOffsetEnd"            )] public float magicCurveOffsetEnd;
		[Serialize("magicCurveDistMin"              )] public float magicCurveDistMin;
		[Serialize("swarmRepeller"                  )] public RO2_SwarmRepellerPowerUp_Template swarmRepeller;
		[Serialize("debug"                          )] public int debug;
		[Serialize("disappearSequenceDialogDuration")] public float disappearSequenceDialogDuration;
		[Serialize("appearSequenceDuration"         )] public float appearSequenceDuration;
		[Serialize("appearSequenceTravelType"       )] public Enum_appearSequenceTravelType appearSequenceTravelType;
		[Serialize("appearSequenceFXName"           )] public StringID appearSequenceFXName;
		[Serialize("appearSequenceDestPosOffset"    )] public Vec2d appearSequenceDestPosOffset;
		[Serialize("appearSequenceFXPosBoneName"    )] public StringID appearSequenceFXPosBoneName;
		[Serialize("timeHysteresisGrab"             )] public float timeHysteresisGrab;
		[Serialize("trailPath"                      )] public Path trailPath;
		[Serialize("flashPath"                      )] public Path flashPath;
		[Serialize("lookAutoPlayerWaitDuration"     )] public float lookAutoPlayerWaitDuration;
		[Serialize("forceMoveWaitingDurationMin"    )] public float forceMoveWaitingDurationMin;
		[Serialize("forceMoveWaitingDurationMax"    )] public float forceMoveWaitingDurationMax;
		[Serialize("murphyFlipOnTouchRadius"        )] public float murphyFlipOnTouchRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxSpeed_level0));
			SerializeField(s, nameof(maxSpeed_level1));
			SerializeField(s, nameof(phantomShape));
			SerializeField(s, nameof(faction));
			SerializeField(s, nameof(moveHoldFXName));
			SerializeField(s, nameof(moveTapFXName));
			SerializeField(s, nameof(tapDuration));
			SerializeField(s, nameof(releaseFXName));
			SerializeField(s, nameof(appearFXName));
			SerializeField(s, nameof(disapearFXName));
			SerializeField(s, nameof(sparklesFXName));
			SerializeField(s, nameof(autoMurphyFXName));
			SerializeField(s, nameof(autoMurphyFXWaitActionName));
			SerializeField(s, nameof(maxSpeed));
			SerializeField(s, nameof(distMinTeleport));
			SerializeField(s, nameof(distMaxDrag));
			SerializeField(s, nameof(animFly));
			SerializeField(s, nameof(animTeleport));
			SerializeField(s, nameof(animCatch));
			SerializeField(s, nameof(animRotatingPlatform));
			SerializeField(s, nameof(animCatchFront));
			SerializeField(s, nameof(animAppearSequence));
			SerializeField(s, nameof(animDisappearSequence));
			SerializeField(s, nameof(animUturn));
			SerializeField(s, nameof(animPunch));
			SerializeField(s, nameof(animTickle));
			SerializeField(s, nameof(animPunchBurst));
			SerializeField(s, nameof(animEat));
			SerializeField(s, nameof(animSlingShot));
			SerializeField(s, nameof(animCatchFrontHard));
			SerializeField(s, nameof(animCallPlayer));
			SerializeField(s, nameof(distMaxArms));
			SerializeField(s, nameof(distMinGrabFront));
			SerializeField(s, nameof(thresholdSpeedForUturn));
			SerializeField(s, nameof(thresholdSpeedForAnim));
			SerializeField(s, nameof(smoothFactorSlow));
			SerializeField(s, nameof(smoothFactorFast));
			SerializeField(s, nameof(useMagicCurve));
			SerializeField(s, nameof(bezierRenderer));
			SerializeField(s, nameof(distTang));
			SerializeField(s, nameof(freqRotateTangStart));
			SerializeField(s, nameof(freqRotateTangEnd));
			SerializeField(s, nameof(magicCurveOffsetStart));
			SerializeField(s, nameof(magicCurveOffsetEnd));
			SerializeField(s, nameof(magicCurveDistMin));
			SerializeField(s, nameof(swarmRepeller));
			SerializeField(s, nameof(debug));
			SerializeField(s, nameof(disappearSequenceDialogDuration));
			SerializeField(s, nameof(appearSequenceDuration));
			SerializeField(s, nameof(appearSequenceTravelType));
			SerializeField(s, nameof(appearSequenceFXName));
			SerializeField(s, nameof(appearSequenceDestPosOffset));
			SerializeField(s, nameof(appearSequenceFXPosBoneName));
			SerializeField(s, nameof(timeHysteresisGrab));
			SerializeField(s, nameof(trailPath));
			SerializeField(s, nameof(flashPath));
			SerializeField(s, nameof(lookAutoPlayerWaitDuration));
			SerializeField(s, nameof(forceMoveWaitingDurationMin));
			SerializeField(s, nameof(forceMoveWaitingDurationMax));
			SerializeField(s, nameof(murphyFlipOnTouchRadius));
		}
		public enum Enum_appearSequenceTravelType {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
			[Serialize("Value_6")] Value_6 = 6,
			[Serialize("Value_7")] Value_7 = 7,
			[Serialize("Value_8")] Value_8 = 8,
		}
		public override uint? ClassCRC => 0xC9214390;
	}
}

