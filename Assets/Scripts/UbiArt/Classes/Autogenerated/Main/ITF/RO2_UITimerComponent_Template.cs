using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UITimerComponent_Template : UIComponent_Template {
		[Serialize("time_hasMillisecond"            )] public bool time_hasMillisecond;
		[Serialize("time_countdownPulseThreshold"   )] public float time_countdownPulseThreshold;
		[Serialize("time_countdownPulseScale"       )] public float time_countdownPulseScale;
		[Serialize("time_countdownPulsePeriod"      )] public float time_countdownPulsePeriod;
		[Serialize("time_countdownPulseColor"       )] public Color time_countdownPulseColor;
		[Serialize("time_countdownSFXStart"         )] public StringID time_countdownSFXStart;
		[Serialize("time_countdownSFXStop"          )] public StringID time_countdownSFXStop;
		[Serialize("counterTypeSpriteIndex_Lum"     )] public uint counterTypeSpriteIndex_Lum;
		[Serialize("counterTypeSpriteIndex_Time"    )] public uint counterTypeSpriteIndex_Time;
		[Serialize("counterTypeSpriteIndex_Distance")] public uint counterTypeSpriteIndex_Distance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(time_hasMillisecond));
			SerializeField(s, nameof(time_countdownPulseThreshold));
			SerializeField(s, nameof(time_countdownPulseScale));
			SerializeField(s, nameof(time_countdownPulsePeriod));
			SerializeField(s, nameof(time_countdownPulseColor));
			SerializeField(s, nameof(time_countdownSFXStart));
			SerializeField(s, nameof(time_countdownSFXStop));
			SerializeField(s, nameof(counterTypeSpriteIndex_Lum));
			SerializeField(s, nameof(counterTypeSpriteIndex_Time));
			SerializeField(s, nameof(counterTypeSpriteIndex_Distance));
		}
		public override uint? ClassCRC => 0x63ED6DBE;
	}
}

