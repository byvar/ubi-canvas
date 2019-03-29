using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.COL)]
	public partial class Unknown_RL_7_sub_38B040 : SoundCommand {
		[Serialize("name"         )] public StringID name;
		[Serialize("activate"     )] public int activate;
		[Serialize("buslist"      )] public CList<StringID> buslist;
		[Serialize("factor"       )] public float factor;
		[Serialize("aux"          )] public uint aux;
		[Serialize("reverbParams" )] public Unknown_RL_1377_sub_388210 reverbParams;
		[Serialize("blendDuration")] public float blendDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(activate));
			SerializeField(s, nameof(buslist));
			SerializeField(s, nameof(factor));
			SerializeField(s, nameof(aux));
			SerializeField(s, nameof(reverbParams));
			SerializeField(s, nameof(blendDuration));
		}
		public override uint? ClassCRC => 0xAC4D988E;

		[Games(GameFlags.RL)]
		public partial class Unknown_RL_1377_sub_388210 : CSerializable {
			[Serialize("XAudio2ReflectionsDelay"   )] public uint XAudio2ReflectionsDelay;
			[Serialize("XAudio2ReverbDelay"        )] public char XAudio2ReverbDelay;
			[Serialize("XAudio2RearDelay"          )] public char XAudio2RearDelay;
			[Serialize("XAudio2PositionLeft"       )] public char XAudio2PositionLeft;
			[Serialize("XAudio2PositionRight"      )] public char XAudio2PositionRight;
			[Serialize("XAudio2PositionMatrixLeft" )] public char XAudio2PositionMatrixLeft;
			[Serialize("XAudio2PositionMatrixRight")] public char XAudio2PositionMatrixRight;
			[Serialize("XAudio2EarlyDiffusion"     )] public char XAudio2EarlyDiffusion;
			[Serialize("XAudio2LateDiffusion"      )] public char XAudio2LateDiffusion;
			[Serialize("XAudio2LowEQGain"          )] public char XAudio2LowEQGain;
			[Serialize("XAudio2LowEQCutoff"        )] public char XAudio2LowEQCutoff;
			[Serialize("XAudio2HighEQGain"         )] public char XAudio2HighEQGain;
			[Serialize("XAudio2HighEQCutoff"       )] public char XAudio2HighEQCutoff;
			[Serialize("XAudio2RoomFilterFreq"     )] public float XAudio2RoomFilterFreq;
			[Serialize("XAudio2RoomFilterMain"     )] public float XAudio2RoomFilterMain;
			[Serialize("XAudio2RoomFilterHF"       )] public float XAudio2RoomFilterHF;
			[Serialize("XAudio2ReflectionsGain"    )] public float XAudio2ReflectionsGain;
			[Serialize("XAudio2ReverbGain"         )] public float XAudio2ReverbGain;
			[Serialize("XAudio2DecayTime"          )] public float XAudio2DecayTime;
			[Serialize("XAudio2Density"            )] public float XAudio2Density;
			[Serialize("XAudio2RoomSize"           )] public float XAudio2RoomSize;
			[Serialize("XAudio2DisableLateField"   )] public int XAudio2DisableLateField;
			[Serialize("PS3Room"                   )] public float PS3Room;
			[Serialize("PS3Room_HF"                )] public float PS3Room_HF;
			[Serialize("PS3Decay_time"             )] public float PS3Decay_time;
			[Serialize("PS3Decay_HF_ratio"         )] public float PS3Decay_HF_ratio;
			[Serialize("PS3Reflections"            )] public float PS3Reflections;
			[Serialize("PS3Reflections_delay"      )] public float PS3Reflections_delay;
			[Serialize("PS3Reverb"                 )] public float PS3Reverb;
			[Serialize("PS3Reverb_delay"           )] public float PS3Reverb_delay;
			[Serialize("PS3Diffusion"              )] public float PS3Diffusion;
			[Serialize("PS3Density"                )] public float PS3Density;
			[Serialize("PS3_HF_reference"          )] public float PS3_HF_reference;
			[Serialize("PS3MixChannel"             )] public int PS3MixChannel;
			[Serialize("PS3EarlyReflectionPattern" )] public uint PS3EarlyReflectionPattern;
			[Serialize("PS3LateReverbPattern"      )] public uint PS3LateReverbPattern;
			[Serialize("PS3EarlyReflectionScaler"  )] public float PS3EarlyReflectionScaler;
			[Serialize("PS3_LF_reference"          )] public float PS3_LF_reference;
			[Serialize("PS3_room_LF"               )] public float PS3_room_LF;
			[Serialize("AXColoration"              )] public float AXColoration;
			[Serialize("AXTime"                    )] public float AXTime;
			[Serialize("AXDamping"                 )] public float AXDamping;
			[Serialize("AXPreDelay"                )] public float AXPreDelay;
			[Serialize("AXCrosstalk"               )] public float AXCrosstalk;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(XAudio2ReflectionsDelay));
				SerializeField(s, nameof(XAudio2ReverbDelay));
				SerializeField(s, nameof(XAudio2RearDelay));
				SerializeField(s, nameof(XAudio2PositionLeft));
				SerializeField(s, nameof(XAudio2PositionRight));
				SerializeField(s, nameof(XAudio2PositionMatrixLeft));
				SerializeField(s, nameof(XAudio2PositionMatrixRight));
				SerializeField(s, nameof(XAudio2EarlyDiffusion));
				SerializeField(s, nameof(XAudio2LateDiffusion));
				SerializeField(s, nameof(XAudio2LowEQGain));
				SerializeField(s, nameof(XAudio2LowEQCutoff));
				SerializeField(s, nameof(XAudio2HighEQGain));
				SerializeField(s, nameof(XAudio2HighEQCutoff));
				SerializeField(s, nameof(XAudio2RoomFilterFreq));
				SerializeField(s, nameof(XAudio2RoomFilterMain));
				SerializeField(s, nameof(XAudio2RoomFilterHF));
				SerializeField(s, nameof(XAudio2ReflectionsGain));
				SerializeField(s, nameof(XAudio2ReverbGain));
				SerializeField(s, nameof(XAudio2DecayTime));
				SerializeField(s, nameof(XAudio2Density));
				SerializeField(s, nameof(XAudio2RoomSize));
				SerializeField(s, nameof(XAudio2DisableLateField));
				SerializeField(s, nameof(PS3Room));
				SerializeField(s, nameof(PS3Room_HF));
				SerializeField(s, nameof(PS3Decay_time));
				SerializeField(s, nameof(PS3Decay_HF_ratio));
				SerializeField(s, nameof(PS3Reflections));
				SerializeField(s, nameof(PS3Reflections_delay));
				SerializeField(s, nameof(PS3Reverb));
				SerializeField(s, nameof(PS3Reverb_delay));
				SerializeField(s, nameof(PS3Diffusion));
				SerializeField(s, nameof(PS3Density));
				SerializeField(s, nameof(PS3_HF_reference));
				SerializeField(s, nameof(PS3MixChannel));
				SerializeField(s, nameof(PS3EarlyReflectionPattern));
				SerializeField(s, nameof(PS3LateReverbPattern));
				SerializeField(s, nameof(PS3EarlyReflectionScaler));
				SerializeField(s, nameof(PS3_LF_reference));
				SerializeField(s, nameof(PS3_room_LF));
				SerializeField(s, nameof(AXColoration));
				SerializeField(s, nameof(AXTime));
				SerializeField(s, nameof(AXDamping));
				SerializeField(s, nameof(AXPreDelay));
				SerializeField(s, nameof(AXCrosstalk));
			}
		}
	}
}

