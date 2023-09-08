namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventSetReverbOnAux : Event {
		public uint XAudio2ReflectionsDelay;
		public char XAudio2ReverbDelay;
		public char XAudio2RearDelay;
		public char XAudio2PositionLeft;
		public char XAudio2PositionRight;
		public char XAudio2PositionMatrixLeft;
		public char XAudio2PositionMatrixRight;
		public char XAudio2EarlyDiffusion;
		public char XAudio2LateDiffusion;
		public char XAudio2LowEQGain;
		public char XAudio2LowEQCutoff;
		public char XAudio2HighEQGain;
		public char XAudio2HighEQCutoff;
		public float XAudio2RoomFilterFreq;
		public float XAudio2RoomFilterMain;
		public float XAudio2RoomFilterHF;
		public float XAudio2ReflectionsGain;
		public float XAudio2ReverbGain;
		public float XAudio2DecayTime;
		public float XAudio2Density;
		public float XAudio2RoomSize;
		public int XAudio2DisableLateField;
		public float PS3Room;
		public float PS3Room_HF;
		public float PS3Decay_time;
		public float PS3Decay_HF_ratio;
		public float PS3Reflections;
		public float PS3Reflections_delay;
		public float PS3Reverb;
		public float PS3Reverb_delay;
		public float PS3Diffusion;
		public float PS3Density;
		public float PS3_HF_reference;
		public int PS3MixChannel;
		public uint PS3EarlyReflectionPattern;
		public uint PS3LateReverbPattern;
		public float PS3EarlyReflectionScaler;
		public float PS3_LF_reference;
		public float PS3_room_LF;
		public float AXColoration;
		public float AXTime;
		public float AXDamping;
		public float AXPreDelay;
		public float AXCrosstalk;
		public float BlendDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				XAudio2ReflectionsDelay = s.Serialize<uint>(XAudio2ReflectionsDelay, name: "XAudio2ReflectionsDelay");
				XAudio2ReverbDelay = s.Serialize<char>(XAudio2ReverbDelay, name: "XAudio2ReverbDelay");
				XAudio2RearDelay = s.Serialize<char>(XAudio2RearDelay, name: "XAudio2RearDelay");
				XAudio2PositionLeft = s.Serialize<char>(XAudio2PositionLeft, name: "XAudio2PositionLeft");
				XAudio2PositionRight = s.Serialize<char>(XAudio2PositionRight, name: "XAudio2PositionRight");
				XAudio2PositionMatrixLeft = s.Serialize<char>(XAudio2PositionMatrixLeft, name: "XAudio2PositionMatrixLeft");
				XAudio2PositionMatrixRight = s.Serialize<char>(XAudio2PositionMatrixRight, name: "XAudio2PositionMatrixRight");
				XAudio2EarlyDiffusion = s.Serialize<char>(XAudio2EarlyDiffusion, name: "XAudio2EarlyDiffusion");
				XAudio2LateDiffusion = s.Serialize<char>(XAudio2LateDiffusion, name: "XAudio2LateDiffusion");
				XAudio2LowEQGain = s.Serialize<char>(XAudio2LowEQGain, name: "XAudio2LowEQGain");
				XAudio2LowEQCutoff = s.Serialize<char>(XAudio2LowEQCutoff, name: "XAudio2LowEQCutoff");
				XAudio2HighEQGain = s.Serialize<char>(XAudio2HighEQGain, name: "XAudio2HighEQGain");
				XAudio2HighEQCutoff = s.Serialize<char>(XAudio2HighEQCutoff, name: "XAudio2HighEQCutoff");
				XAudio2RoomFilterFreq = s.Serialize<float>(XAudio2RoomFilterFreq, name: "XAudio2RoomFilterFreq");
				XAudio2RoomFilterMain = s.Serialize<float>(XAudio2RoomFilterMain, name: "XAudio2RoomFilterMain");
				XAudio2RoomFilterHF = s.Serialize<float>(XAudio2RoomFilterHF, name: "XAudio2RoomFilterHF");
				XAudio2ReflectionsGain = s.Serialize<float>(XAudio2ReflectionsGain, name: "XAudio2ReflectionsGain");
				XAudio2ReverbGain = s.Serialize<float>(XAudio2ReverbGain, name: "XAudio2ReverbGain");
				XAudio2DecayTime = s.Serialize<float>(XAudio2DecayTime, name: "XAudio2DecayTime");
				XAudio2Density = s.Serialize<float>(XAudio2Density, name: "XAudio2Density");
				XAudio2RoomSize = s.Serialize<float>(XAudio2RoomSize, name: "XAudio2RoomSize");
				XAudio2DisableLateField = s.Serialize<int>(XAudio2DisableLateField, name: "XAudio2DisableLateField");
				PS3Room = s.Serialize<float>(PS3Room, name: "PS3Room");
				PS3Room_HF = s.Serialize<float>(PS3Room_HF, name: "PS3Room_HF");
				PS3Decay_time = s.Serialize<float>(PS3Decay_time, name: "PS3Decay_time");
				PS3Decay_HF_ratio = s.Serialize<float>(PS3Decay_HF_ratio, name: "PS3Decay_HF_ratio");
				PS3Reflections = s.Serialize<float>(PS3Reflections, name: "PS3Reflections");
				PS3Reflections_delay = s.Serialize<float>(PS3Reflections_delay, name: "PS3Reflections_delay");
				PS3Reverb = s.Serialize<float>(PS3Reverb, name: "PS3Reverb");
				PS3Reverb_delay = s.Serialize<float>(PS3Reverb_delay, name: "PS3Reverb_delay");
				PS3Diffusion = s.Serialize<float>(PS3Diffusion, name: "PS3Diffusion");
				PS3Density = s.Serialize<float>(PS3Density, name: "PS3Density");
				PS3_HF_reference = s.Serialize<float>(PS3_HF_reference, name: "PS3_HF_reference");
				PS3MixChannel = s.Serialize<int>(PS3MixChannel, name: "PS3MixChannel");
				PS3EarlyReflectionPattern = s.Serialize<uint>(PS3EarlyReflectionPattern, name: "PS3EarlyReflectionPattern");
				PS3LateReverbPattern = s.Serialize<uint>(PS3LateReverbPattern, name: "PS3LateReverbPattern");
				PS3EarlyReflectionScaler = s.Serialize<float>(PS3EarlyReflectionScaler, name: "PS3EarlyReflectionScaler");
				PS3_LF_reference = s.Serialize<float>(PS3_LF_reference, name: "PS3_LF_reference");
				PS3_room_LF = s.Serialize<float>(PS3_room_LF, name: "PS3_room_LF");
				AXColoration = s.Serialize<float>(AXColoration, name: "AXColoration");
				AXTime = s.Serialize<float>(AXTime, name: "AXTime");
				AXDamping = s.Serialize<float>(AXDamping, name: "AXDamping");
				AXPreDelay = s.Serialize<float>(AXPreDelay, name: "AXPreDelay");
				AXCrosstalk = s.Serialize<float>(AXCrosstalk, name: "AXCrosstalk");
				BlendDuration = s.Serialize<float>(BlendDuration, name: "BlendDuration");
			} else {
			}
		}
		public override uint? ClassCRC => 0xCEDE3BFA;
	}
}

