using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ChallengeBonusComponent_Template : ActorComponent_Template {
		public float waitTimeBeforeTeleporting;
		public float pulsatingFrequency;
		public float pulsatingAmplitude;
		public float pulsatingStartTime;
		public Color pulsatingTimerColor;
		public Generic<Event> startMusicEvent;
		public Generic<Event> stopMusicEvent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitTimeBeforeTeleporting = s.Serialize<float>(waitTimeBeforeTeleporting, name: "waitTimeBeforeTeleporting");
			pulsatingFrequency = s.Serialize<float>(pulsatingFrequency, name: "pulsatingFrequency");
			pulsatingAmplitude = s.Serialize<float>(pulsatingAmplitude, name: "pulsatingAmplitude");
			pulsatingStartTime = s.Serialize<float>(pulsatingStartTime, name: "pulsatingStartTime");
			pulsatingTimerColor = s.SerializeObject<Color>(pulsatingTimerColor, name: "pulsatingTimerColor");
			startMusicEvent = s.SerializeObject<Generic<Event>>(startMusicEvent, name: "startMusicEvent");
			stopMusicEvent = s.SerializeObject<Generic<Event>>(stopMusicEvent, name: "stopMusicEvent");
		}
		public override uint? ClassCRC => 0x766EA9FE;
	}
}

