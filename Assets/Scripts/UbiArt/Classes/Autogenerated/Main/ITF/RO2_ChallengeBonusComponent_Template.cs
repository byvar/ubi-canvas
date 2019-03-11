using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ChallengeBonusComponent_Template : ActorComponent_Template {
		[Serialize("waitTimeBeforeTeleporting")] public float waitTimeBeforeTeleporting;
		[Serialize("pulsatingFrequency"       )] public float pulsatingFrequency;
		[Serialize("pulsatingAmplitude"       )] public float pulsatingAmplitude;
		[Serialize("pulsatingStartTime"       )] public float pulsatingStartTime;
		[Serialize("startMusicEvent"          )] public Generic<Event> startMusicEvent;
		[Serialize("stopMusicEvent"           )] public Generic<Event> stopMusicEvent;
		[Serialize("pulsatingTimerColor"      )] public Color pulsatingTimerColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(waitTimeBeforeTeleporting));
				SerializeField(s, nameof(pulsatingFrequency));
				SerializeField(s, nameof(pulsatingAmplitude));
				SerializeField(s, nameof(pulsatingStartTime));
				SerializeField(s, nameof(pulsatingTimerColor));
				SerializeField(s, nameof(startMusicEvent));
				SerializeField(s, nameof(stopMusicEvent));
			} else {
				SerializeField(s, nameof(waitTimeBeforeTeleporting));
				SerializeField(s, nameof(pulsatingFrequency));
				SerializeField(s, nameof(pulsatingAmplitude));
				SerializeField(s, nameof(pulsatingStartTime));
				SerializeField(s, nameof(startMusicEvent));
				SerializeField(s, nameof(stopMusicEvent));
			}
		}
		public override uint? ClassCRC => 0x766EA9FE;
	}
}

