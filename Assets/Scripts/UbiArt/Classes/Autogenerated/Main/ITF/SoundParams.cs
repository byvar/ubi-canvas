using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL)]
	public partial class SoundParams : CSerializable {
		[Serialize("numChannels"    )] public uint numChannels;
		[Serialize("loop"           )] public int loop;
		[Serialize("playMode"       )] public PlayMode playMode;
		[Serialize("playMode"       )] public PlayMode2 playMode2;
		[Serialize("randomVolMin"   )] public Volume randomVolMin;
		[Serialize("randomVolMax"   )] public Volume randomVolMax;
		[Serialize("delay"          )] public float delay;
		[Serialize("randomDelay"    )] public float randomDelay;
		[Serialize("randomPitchMin" )] public float randomPitchMin;
		[Serialize("randomPitchMax" )] public float randomPitchMax;
		[Serialize("fadeInTime"     )] public float fadeInTime;
		[Serialize("fadeOutTime"    )] public float fadeOutTime;
		[Serialize("filterFrequency")] public float filterFrequency;
		[Serialize("filterQ"        )] public float filterQ;
		[Serialize("filterType"     )] public FilterType filterType;
		[Serialize("filterType"     )] public FilterType2 filterType2;
		[Serialize("metronomeType"  )] public uint metronomeType;
		[Serialize("playOnNext"     )] public uint playOnNext;
		[Serialize("modifiers"      )] public CArray<Generic<SoundModifier>> modifiers;
		
		[Serialize("playModeInput"  )] public StringID playModeInput;
		[Serialize("isMusic"        )] public int isMusic;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(numChannels));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(playMode2));
				SerializeField(s, nameof(playModeInput));
				SerializeField(s, nameof(randomVolMin));
				SerializeField(s, nameof(randomVolMax));
				SerializeField(s, nameof(delay));
				SerializeField(s, nameof(randomDelay));
				SerializeField(s, nameof(randomPitchMin));
				SerializeField(s, nameof(randomPitchMax));
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(filterFrequency));
				SerializeField(s, nameof(filterType2));
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(playOnNext));
				SerializeField(s, nameof(modifiers));
				SerializeField(s, nameof(isMusic));
			} else {
				SerializeField(s, nameof(numChannels));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(playMode));
				SerializeField(s, nameof(randomVolMin));
				SerializeField(s, nameof(randomVolMax));
				SerializeField(s, nameof(delay));
				SerializeField(s, nameof(randomDelay));
				SerializeField(s, nameof(randomPitchMin));
				SerializeField(s, nameof(randomPitchMax));
				SerializeField(s, nameof(fadeInTime));
				SerializeField(s, nameof(fadeOutTime));
				SerializeField(s, nameof(filterFrequency));
				SerializeField(s, nameof(filterQ));
				SerializeField(s, nameof(filterType));
				SerializeField(s, nameof(metronomeType));
				SerializeField(s, nameof(playOnNext));
				SerializeField(s, nameof(modifiers));
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

