namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_HomeNodeDailyComponent_Template : RO2_HomeComponent_Template {
		public Vec2d mainNodeDefaultScale;
		public Vec2d mainNodeRollOverScale;
		public Vec2d defaultScale;
		public Vec2d rollOverScale;
		public Color focusColor;
		public Vec2d paintingScale;
		public Path pastilleActorPath;
		public Path arrowActorPath;
		public StringID paintingColorAnim;
		public SmartLocId tomorrowText;
		public SmartLocId nextWeekText;
		public float selectBlinkScale;
		public float selectBlinkPeriod;
		public float time_countdownPulseThreshold;
		public float time_countdownPulseScale;
		public float time_countdownPulsePeriod;
		public Color time_countdownPulseColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mainNodeDefaultScale = s.SerializeObject<Vec2d>(mainNodeDefaultScale, name: "mainNodeDefaultScale");
			mainNodeRollOverScale = s.SerializeObject<Vec2d>(mainNodeRollOverScale, name: "mainNodeRollOverScale");
			defaultScale = s.SerializeObject<Vec2d>(defaultScale, name: "defaultScale");
			rollOverScale = s.SerializeObject<Vec2d>(rollOverScale, name: "rollOverScale");
			focusColor = s.SerializeObject<Color>(focusColor, name: "focusColor");
			paintingScale = s.SerializeObject<Vec2d>(paintingScale, name: "paintingScale");
			pastilleActorPath = s.SerializeObject<Path>(pastilleActorPath, name: "pastilleActorPath");
			arrowActorPath = s.SerializeObject<Path>(arrowActorPath, name: "arrowActorPath");
			paintingColorAnim = s.SerializeObject<StringID>(paintingColorAnim, name: "paintingColorAnim");
			tomorrowText = s.SerializeObject<SmartLocId>(tomorrowText, name: "tomorrowText");
			nextWeekText = s.SerializeObject<SmartLocId>(nextWeekText, name: "nextWeekText");
			selectBlinkScale = s.Serialize<float>(selectBlinkScale, name: "selectBlinkScale");
			selectBlinkPeriod = s.Serialize<float>(selectBlinkPeriod, name: "selectBlinkPeriod");
			time_countdownPulseThreshold = s.Serialize<float>(time_countdownPulseThreshold, name: "time_countdownPulseThreshold");
			time_countdownPulseScale = s.Serialize<float>(time_countdownPulseScale, name: "time_countdownPulseScale");
			time_countdownPulsePeriod = s.Serialize<float>(time_countdownPulsePeriod, name: "time_countdownPulsePeriod");
			time_countdownPulseColor = s.SerializeObject<Color>(time_countdownPulseColor, name: "time_countdownPulseColor");
		}
		public override uint? ClassCRC => 0xB4DBA90C;
	}
}

