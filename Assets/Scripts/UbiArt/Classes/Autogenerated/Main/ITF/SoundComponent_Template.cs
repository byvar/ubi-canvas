using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.COL | GameFlags.RL)]
	public partial class SoundComponent_Template : ActorComponent_Template {
		public CList<SoundDescriptor_Template> soundList;
		public StringID defaultSound;
		public CList<InputDesc> inputs;
		public CList<PathRef> WwiseBankList;
		public CList<Path> WwiseBankList2;
		public CList<WwiseInputDesc> WwiseInputList;
		public bool defaultSoundIsAlwaysActive;
		public Volume volume;
		public CList<Generic<Event>> musicList;
		public CList<Generic<Event>> busMixList;
		public bool RegisterRtpcListener;
		public bool UseDefaultEmitter;
		public bool unk_RFR;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO) {
				soundList = s.SerializeObject<CList<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
			} else if (Settings.s.game == Settings.Game.RFR) {
				soundList = s.SerializeObject<CList<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
				unk_RFR = s.Serialize<bool>(unk_RFR, name: "unk_RFR");
			} else if( Settings.s.game == Settings.Game.COL) {
				soundList = s.SerializeObject<CList<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
				WwiseBankList2 = s.SerializeObject<CList<Path>>(WwiseBankList2, name: "WwiseBankList2");
				WwiseInputList = s.SerializeObject<CList<WwiseInputDesc>>(WwiseInputList, name: "WwiseInputList");
				RegisterRtpcListener = s.Serialize<bool>(RegisterRtpcListener, name: "RegisterRtpcListener");
				UseDefaultEmitter = s.Serialize<bool>(UseDefaultEmitter, name: "UseDefaultEmitter");
			} else if (Settings.s.game == Settings.Game.RL) {
				soundList = s.SerializeObject<CList<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
				musicList = s.SerializeObject<CList<Generic<Event>>>(musicList, name: "musicList");
				busMixList = s.SerializeObject<CList<Generic<Event>>>(busMixList, name: "busMixList");
			} else {
				soundList = s.SerializeObject<CList<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
				WwiseBankList = s.SerializeObject<CList<PathRef>>(WwiseBankList, name: "WwiseBankList");
				WwiseInputList = s.SerializeObject<CList<WwiseInputDesc>>(WwiseInputList, name: "WwiseInputList");
				defaultSoundIsAlwaysActive = s.Serialize<bool>(defaultSoundIsAlwaysActive, name: "defaultSoundIsAlwaysActive");
			}
		}
		public override uint? ClassCRC => 0xD94D6C53;
	}
}

