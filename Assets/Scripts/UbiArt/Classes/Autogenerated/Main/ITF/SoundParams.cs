using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RL)]
	public partial class SoundParams : CSerializable {
		public uint numChannels;
		public int loop;
		public PlayMode playMode;
		public PlayMode2 playMode2;
		public Volume randomVolMin;
		public Volume randomVolMax;
		public float delay;
		public float randomDelay;
		public float randomPitchMin;
		public float randomPitchMax;
		public float fadeInTime;
		public float fadeOutTime;
		public float filterFrequency;
		public float filterQ;
		public FilterType filterType;
		public FilterType2 filterType2;
		public uint metronomeType;
		public uint playOnNext;
		public CArrayO<Generic<SoundModifier>> modifiers;
		
		public StringID playModeInput;
		public int isMusic;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				numChannels = s.Serialize<uint>(numChannels, name: "numChannels");
				loop = s.Serialize<int>(loop, name: "loop");
				playMode2 = s.Serialize<PlayMode2>(playMode2, name: "playMode");
				playModeInput = s.SerializeObject<StringID>(playModeInput, name: "playModeInput");
				randomVolMin = s.SerializeObject<Volume>(randomVolMin, name: "randomVolMin");
				randomVolMax = s.SerializeObject<Volume>(randomVolMax, name: "randomVolMax");
				delay = s.Serialize<float>(delay, name: "delay");
				randomDelay = s.Serialize<float>(randomDelay, name: "randomDelay");
				randomPitchMin = s.Serialize<float>(randomPitchMin, name: "randomPitchMin");
				randomPitchMax = s.Serialize<float>(randomPitchMax, name: "randomPitchMax");
				fadeInTime = s.Serialize<float>(fadeInTime, name: "fadeInTime");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				filterFrequency = s.Serialize<float>(filterFrequency, name: "filterFrequency");
				filterType2 = s.Serialize<FilterType2>(filterType2, name: "filterType");
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				playOnNext = s.Serialize<uint>(playOnNext, name: "playOnNext");
				modifiers = s.SerializeObject<CArrayO<Generic<SoundModifier>>>(modifiers, name: "modifiers");
				isMusic = s.Serialize<int>(isMusic, name: "isMusic");
			} else {
				numChannels = s.Serialize<uint>(numChannels, name: "numChannels");
				loop = s.Serialize<int>(loop, name: "loop");
				playMode = s.Serialize<PlayMode>(playMode, name: "playMode");
				randomVolMin = s.SerializeObject<Volume>(randomVolMin, name: "randomVolMin");
				randomVolMax = s.SerializeObject<Volume>(randomVolMax, name: "randomVolMax");
				delay = s.Serialize<float>(delay, name: "delay");
				randomDelay = s.Serialize<float>(randomDelay, name: "randomDelay");
				randomPitchMin = s.Serialize<float>(randomPitchMin, name: "randomPitchMin");
				randomPitchMax = s.Serialize<float>(randomPitchMax, name: "randomPitchMax");
				fadeInTime = s.Serialize<float>(fadeInTime, name: "fadeInTime");
				fadeOutTime = s.Serialize<float>(fadeOutTime, name: "fadeOutTime");
				filterFrequency = s.Serialize<float>(filterFrequency, name: "filterFrequency");
				filterQ = s.Serialize<float>(filterQ, name: "filterQ");
				filterType = s.Serialize<FilterType>(filterType, name: "filterType");
				metronomeType = s.Serialize<uint>(metronomeType, name: "metronomeType");
				playOnNext = s.Serialize<uint>(playOnNext, name: "playOnNext");
				modifiers = s.SerializeObject<CArrayO<Generic<SoundModifier>>>(modifiers, name: "modifiers");
			}
		}
		public enum PlayMode {
			[Serialize("PlayMode_PlayFirst"         )] PlayFirst = 0,
			[Serialize("PlayMode_Random"            )] Random = 1,
			[Serialize("PlayMode_RandomRememberLast")] RandomRememberLast = 2,
			[Serialize("PlayMode_RandomSequence"    )] RandomSequence = 3,
			[Serialize("PlayMode_Sequence"          )] Sequence = 4,
			[Serialize("PlayMode_Input"             )] Input = 5,
		}
		public enum FilterType {
			[Serialize("FilterType_LowPass" )] LowPass = 0,
			[Serialize("FilterType_BandPass")] BandPass = 1,
			[Serialize("FilterType_HighPass")] HighPass = 2,
			[Serialize("FilterType_Notch"   )] Notch = 3,
			[Serialize("FilterType_None"    )] None = 4,
		}
		public enum PlayMode2 {
			[Serialize("PlayMode_PlayFirst"         )] PlayFirst = 0,
			[Serialize("PlayMode_Random"            )] Random = 1,
			[Serialize("PlayMode_RandomRememberLast")] RandomRememberLast = 2,
			[Serialize("PlayMode_RandomSequence"    )] RandomSequence = 3,
			[Serialize("PlayMode_Sequence"          )] Sequence = 4,
			[Serialize("PlayMode_Input"             )] Input = 5,
			[Serialize("Value_6")] Value_6 = 6,
		}
		public enum FilterType2 {
			[Serialize("FilterType_LowPass" )] LowPass = 0,
			[Serialize("FilterType_BandPass")] BandPass = 1,
			[Serialize("FilterType_HighPass")] HighPass = 2,
		}
	}
}

