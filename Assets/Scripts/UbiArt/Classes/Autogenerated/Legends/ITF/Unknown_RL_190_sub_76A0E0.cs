using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_190_sub_76A0E0 : Unknown_RL_183_sub_7628A0 {
		[Serialize("mainNodeDefaultScale"        )] public Vector2 mainNodeDefaultScale;
		[Serialize("mainNodeRollOverScale"       )] public Vector2 mainNodeRollOverScale;
		[Serialize("defaultScale"                )] public Vector2 defaultScale;
		[Serialize("rollOverScale"               )] public Vector2 rollOverScale;
		[Serialize("focusColor"                  )] public Color focusColor;
		[Serialize("paintingScale"               )] public Vector2 paintingScale;
		[Serialize("pastilleActorPath"           )] public Path pastilleActorPath;
		[Serialize("arrowActorPath"              )] public Path arrowActorPath;
		[Serialize("paintingColorAnim"           )] public StringID paintingColorAnim;
		[Serialize("tomorrowText"                )] public SmartLocId tomorrowText;
		[Serialize("nextWeekText"                )] public SmartLocId nextWeekText;
		[Serialize("selectBlinkScale"            )] public float selectBlinkScale;
		[Serialize("selectBlinkPeriod"           )] public float selectBlinkPeriod;
		[Serialize("time_countdownPulseThreshold")] public float time_countdownPulseThreshold;
		[Serialize("time_countdownPulseScale"    )] public float time_countdownPulseScale;
		[Serialize("time_countdownPulsePeriod"   )] public float time_countdownPulsePeriod;
		[Serialize("time_countdownPulseColor"    )] public Color time_countdownPulseColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mainNodeDefaultScale));
			SerializeField(s, nameof(mainNodeRollOverScale));
			SerializeField(s, nameof(defaultScale));
			SerializeField(s, nameof(rollOverScale));
			SerializeField(s, nameof(focusColor));
			SerializeField(s, nameof(paintingScale));
			SerializeField(s, nameof(pastilleActorPath));
			SerializeField(s, nameof(arrowActorPath));
			SerializeField(s, nameof(paintingColorAnim));
			SerializeField(s, nameof(tomorrowText));
			SerializeField(s, nameof(nextWeekText));
			SerializeField(s, nameof(selectBlinkScale));
			SerializeField(s, nameof(selectBlinkPeriod));
			SerializeField(s, nameof(time_countdownPulseThreshold));
			SerializeField(s, nameof(time_countdownPulseScale));
			SerializeField(s, nameof(time_countdownPulsePeriod));
			SerializeField(s, nameof(time_countdownPulseColor));
		}
		public override uint? ClassCRC => 0xB4DBA90C;
	}
}

