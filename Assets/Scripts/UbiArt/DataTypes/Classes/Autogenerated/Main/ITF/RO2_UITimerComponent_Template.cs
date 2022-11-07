namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_UITimerComponent_Template : UIComponent_Template {
		public bool time_hasMillisecond;
		public float time_countdownPulseThreshold;
		public float time_countdownPulseScale;
		public float time_countdownPulsePeriod;
		public Color time_countdownPulseColor;
		public StringID time_countdownSFXStart;
		public StringID time_countdownSFXStop;
		public uint counterTypeSpriteIndex_Lum;
		public uint counterTypeSpriteIndex_Time;
		public uint counterTypeSpriteIndex_Distance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			time_hasMillisecond = s.Serialize<bool>(time_hasMillisecond, name: "time_hasMillisecond");
			time_countdownPulseThreshold = s.Serialize<float>(time_countdownPulseThreshold, name: "time_countdownPulseThreshold");
			time_countdownPulseScale = s.Serialize<float>(time_countdownPulseScale, name: "time_countdownPulseScale");
			time_countdownPulsePeriod = s.Serialize<float>(time_countdownPulsePeriod, name: "time_countdownPulsePeriod");
			time_countdownPulseColor = s.SerializeObject<Color>(time_countdownPulseColor, name: "time_countdownPulseColor");
			time_countdownSFXStart = s.SerializeObject<StringID>(time_countdownSFXStart, name: "time_countdownSFXStart");
			time_countdownSFXStop = s.SerializeObject<StringID>(time_countdownSFXStop, name: "time_countdownSFXStop");
			counterTypeSpriteIndex_Lum = s.Serialize<uint>(counterTypeSpriteIndex_Lum, name: "counterTypeSpriteIndex_Lum");
			counterTypeSpriteIndex_Time = s.Serialize<uint>(counterTypeSpriteIndex_Time, name: "counterTypeSpriteIndex_Time");
			counterTypeSpriteIndex_Distance = s.Serialize<uint>(counterTypeSpriteIndex_Distance, name: "counterTypeSpriteIndex_Distance");
		}
		public override uint? ClassCRC => 0x63ED6DBE;
	}
}

