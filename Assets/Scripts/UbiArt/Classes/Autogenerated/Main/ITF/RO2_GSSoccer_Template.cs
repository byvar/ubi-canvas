using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_GSSoccer_Template : TemplateObj {
		[Serialize("bounceToLayerSpeed"                  )] public float bounceToLayerSpeed;
		[Serialize("cameraDistanceTeamSelect"            )] public float cameraDistanceTeamSelect;
		[Serialize("cameraDistanceIntro"                 )] public float cameraDistanceIntro;
		[Serialize("cameraDistanceOutro"                 )] public float cameraDistanceOutro;
		[Serialize("cameraBlendSequence"                 )] public float cameraBlendSequence;
		[Serialize("cameraBlendTime"                     )] public float cameraBlendTime;
		[Serialize("matchDuration"                       )] public float matchDuration;
		[Serialize("matchStartPulse"                     )] public float matchStartPulse;
		[Serialize("overtimeAlphaSpeed"                  )] public float overtimeAlphaSpeed;
		[Serialize("gametimeAlphaSpeed"                  )] public float gametimeAlphaSpeed;
		[Serialize("lastGoalDelayEnding"                 )] public float lastGoalDelayEnding;
		[Serialize("teamSelectDelay"                     )] public float teamSelectDelay;
		[Serialize("ringFadeDuration"                    )] public float ringFadeDuration;
		[Serialize("goalLaunchBallDelay"                 )] public float goalLaunchBallDelay;
		[Serialize("lastSecondsMatchFXStart"             )] public float lastSecondsMatchFXStart;
		[Serialize("matchOutroPlayerSeparation"          )] public float matchOutroPlayerSeparation;
		[Serialize("darkSideInFadeTime"                  )] public float darkSideInFadeTime;
		[Serialize("darkSideOutFadeTime"                 )] public float darkSideOutFadeTime;
		[Serialize("ball"                                )] public Path ball;
		[Serialize("lastSecondsMatchFX"                  )] public Path lastSecondsMatchFX;
		[Serialize("teamSelectFX"                        )] public Path teamSelectFX;
		[Serialize("ballExplodeFX"                       )] public Path ballExplodeFX;
		[Serialize("redTeamWin"                          )] public LocalisationId redTeamWin;
		[Serialize("blueTeamWin"                         )] public LocalisationId blueTeamWin;
		[Serialize("drawMatch"                           )] public LocalisationId drawMatch;
		[Serialize("jumpForceYMultiplier"                )] public float jumpForceYMultiplier;
		[Serialize("airSuspensionMaxYSpeedMultiplier"    )] public float airSuspensionMaxYSpeedMultiplier;
		[Serialize("airSuspensionMinYSpeedMultiplier"    )] public float airSuspensionMinYSpeedMultiplier;
		[Serialize("airSuspensionMinMultiplierMultiplier")] public float airSuspensionMinMultiplierMultiplier;
		[Serialize("airSuspensionMaxMultiplierMultiplier")] public float airSuspensionMaxMultiplierMultiplier;
		[Serialize("airSuspensionDelayMultiplier"        )] public float airSuspensionDelayMultiplier;
		[Serialize("airSuspensionPushThresholdMultiplier")] public float airSuspensionPushThresholdMultiplier;
		[Serialize("airForceMultiplier"                  )] public float airForceMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bounceToLayerSpeed));
			SerializeField(s, nameof(cameraDistanceTeamSelect));
			SerializeField(s, nameof(cameraDistanceIntro));
			SerializeField(s, nameof(cameraDistanceOutro));
			SerializeField(s, nameof(cameraBlendSequence));
			SerializeField(s, nameof(cameraBlendTime));
			SerializeField(s, nameof(matchDuration));
			SerializeField(s, nameof(matchStartPulse));
			SerializeField(s, nameof(overtimeAlphaSpeed));
			SerializeField(s, nameof(gametimeAlphaSpeed));
			SerializeField(s, nameof(lastGoalDelayEnding));
			SerializeField(s, nameof(teamSelectDelay));
			SerializeField(s, nameof(ringFadeDuration));
			SerializeField(s, nameof(goalLaunchBallDelay));
			SerializeField(s, nameof(lastSecondsMatchFXStart));
			SerializeField(s, nameof(matchOutroPlayerSeparation));
			SerializeField(s, nameof(darkSideInFadeTime));
			SerializeField(s, nameof(darkSideOutFadeTime));
			SerializeField(s, nameof(ball));
			SerializeField(s, nameof(lastSecondsMatchFX));
			SerializeField(s, nameof(teamSelectFX));
			SerializeField(s, nameof(ballExplodeFX));
			SerializeField(s, nameof(redTeamWin));
			SerializeField(s, nameof(blueTeamWin));
			SerializeField(s, nameof(drawMatch));
			SerializeField(s, nameof(jumpForceYMultiplier));
			SerializeField(s, nameof(airSuspensionMaxYSpeedMultiplier));
			SerializeField(s, nameof(airSuspensionMinYSpeedMultiplier));
			SerializeField(s, nameof(airSuspensionMinMultiplierMultiplier));
			SerializeField(s, nameof(airSuspensionMaxMultiplierMultiplier));
			SerializeField(s, nameof(airSuspensionDelayMultiplier));
			SerializeField(s, nameof(airSuspensionPushThresholdMultiplier));
			SerializeField(s, nameof(airForceMultiplier));
		}
		public override uint? ClassCRC => 0x6A25DFBB;
	}
}

