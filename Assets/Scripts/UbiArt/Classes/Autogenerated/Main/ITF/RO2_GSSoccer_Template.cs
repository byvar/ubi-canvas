using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GSSoccer_Template : TemplateObj {
		public float bounceToLayerSpeed;
		public float cameraDistanceTeamSelect;
		public float cameraDistanceIntro;
		public float cameraDistanceOutro;
		public float cameraBlendSequence;
		public float cameraBlendTime;
		public float matchDuration;
		public float matchStartPulse;
		public float overtimeAlphaSpeed;
		public float gametimeAlphaSpeed;
		public float lastGoalDelayEnding;
		public float teamSelectDelay;
		public float ringFadeDuration;
		public float goalLaunchBallDelay;
		public float lastSecondsMatchFXStart;
		public float matchOutroPlayerSeparation;
		public float darkSideInFadeTime;
		public float darkSideOutFadeTime;
		public Path ball;
		public Path lastSecondsMatchFX;
		public Path teamSelectFX;
		public Path ballExplodeFX;
		public LocalisationId redTeamWin;
		public LocalisationId blueTeamWin;
		public LocalisationId drawMatch;
		public float jumpForceYMultiplier;
		public float airSuspensionMaxYSpeedMultiplier;
		public float airSuspensionMinYSpeedMultiplier;
		public float airSuspensionMinMultiplierMultiplier;
		public float airSuspensionMaxMultiplierMultiplier;
		public float airSuspensionDelayMultiplier;
		public float airSuspensionPushThresholdMultiplier;
		public float airForceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bounceToLayerSpeed = s.Serialize<float>(bounceToLayerSpeed, name: "bounceToLayerSpeed");
			cameraDistanceTeamSelect = s.Serialize<float>(cameraDistanceTeamSelect, name: "cameraDistanceTeamSelect");
			cameraDistanceIntro = s.Serialize<float>(cameraDistanceIntro, name: "cameraDistanceIntro");
			cameraDistanceOutro = s.Serialize<float>(cameraDistanceOutro, name: "cameraDistanceOutro");
			cameraBlendSequence = s.Serialize<float>(cameraBlendSequence, name: "cameraBlendSequence");
			cameraBlendTime = s.Serialize<float>(cameraBlendTime, name: "cameraBlendTime");
			matchDuration = s.Serialize<float>(matchDuration, name: "matchDuration");
			matchStartPulse = s.Serialize<float>(matchStartPulse, name: "matchStartPulse");
			overtimeAlphaSpeed = s.Serialize<float>(overtimeAlphaSpeed, name: "overtimeAlphaSpeed");
			gametimeAlphaSpeed = s.Serialize<float>(gametimeAlphaSpeed, name: "gametimeAlphaSpeed");
			lastGoalDelayEnding = s.Serialize<float>(lastGoalDelayEnding, name: "lastGoalDelayEnding");
			teamSelectDelay = s.Serialize<float>(teamSelectDelay, name: "teamSelectDelay");
			ringFadeDuration = s.Serialize<float>(ringFadeDuration, name: "ringFadeDuration");
			goalLaunchBallDelay = s.Serialize<float>(goalLaunchBallDelay, name: "goalLaunchBallDelay");
			lastSecondsMatchFXStart = s.Serialize<float>(lastSecondsMatchFXStart, name: "lastSecondsMatchFXStart");
			matchOutroPlayerSeparation = s.Serialize<float>(matchOutroPlayerSeparation, name: "matchOutroPlayerSeparation");
			darkSideInFadeTime = s.Serialize<float>(darkSideInFadeTime, name: "darkSideInFadeTime");
			darkSideOutFadeTime = s.Serialize<float>(darkSideOutFadeTime, name: "darkSideOutFadeTime");
			ball = s.SerializeObject<Path>(ball, name: "ball");
			lastSecondsMatchFX = s.SerializeObject<Path>(lastSecondsMatchFX, name: "lastSecondsMatchFX");
			teamSelectFX = s.SerializeObject<Path>(teamSelectFX, name: "teamSelectFX");
			ballExplodeFX = s.SerializeObject<Path>(ballExplodeFX, name: "ballExplodeFX");
			redTeamWin = s.SerializeObject<LocalisationId>(redTeamWin, name: "redTeamWin");
			blueTeamWin = s.SerializeObject<LocalisationId>(blueTeamWin, name: "blueTeamWin");
			drawMatch = s.SerializeObject<LocalisationId>(drawMatch, name: "drawMatch");
			jumpForceYMultiplier = s.Serialize<float>(jumpForceYMultiplier, name: "jumpForceYMultiplier");
			airSuspensionMaxYSpeedMultiplier = s.Serialize<float>(airSuspensionMaxYSpeedMultiplier, name: "airSuspensionMaxYSpeedMultiplier");
			airSuspensionMinYSpeedMultiplier = s.Serialize<float>(airSuspensionMinYSpeedMultiplier, name: "airSuspensionMinYSpeedMultiplier");
			airSuspensionMinMultiplierMultiplier = s.Serialize<float>(airSuspensionMinMultiplierMultiplier, name: "airSuspensionMinMultiplierMultiplier");
			airSuspensionMaxMultiplierMultiplier = s.Serialize<float>(airSuspensionMaxMultiplierMultiplier, name: "airSuspensionMaxMultiplierMultiplier");
			airSuspensionDelayMultiplier = s.Serialize<float>(airSuspensionDelayMultiplier, name: "airSuspensionDelayMultiplier");
			airSuspensionPushThresholdMultiplier = s.Serialize<float>(airSuspensionPushThresholdMultiplier, name: "airSuspensionPushThresholdMultiplier");
			airForceMultiplier = s.Serialize<float>(airForceMultiplier, name: "airForceMultiplier");
		}
		public override uint? ClassCRC => 0x6A25DFBB;
	}
}

