using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class SoundComponent_Template : ActorComponent_Template {
		public CListO<SoundDescriptor_Template> soundList;
		public StringID defaultSound;
		public CListO<InputDesc> inputs;
		public CListO<PathRef> WwiseBankList;
		public CListO<Path> WwiseBankList2;
		public CListO<WwiseInputDesc> WwiseInputList;
		public bool defaultSoundIsAlwaysActive;
		public Volume volume;
		public CListO<Generic<Event>> musicList;
		public CListO<Generic<Event>> busMixList;
		public bool RegisterRtpcListener;
		public bool UseDefaultEmitter;
		public bool unk_RFR;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO) {
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
			} else if (Settings.s.game == Settings.Game.RFR) {
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				unk_RFR = s.Serialize<bool>(unk_RFR, name: "unk_RFR");
			} else if( Settings.s.game == Settings.Game.COL) {
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				WwiseBankList2 = s.SerializeObject<CListO<Path>>(WwiseBankList2, name: "WwiseBankList");
				WwiseInputList = s.SerializeObject<CListO<WwiseInputDesc>>(WwiseInputList, name: "WwiseInputList");
				RegisterRtpcListener = s.Serialize<bool>(RegisterRtpcListener, name: "RegisterRtpcListener");
				UseDefaultEmitter = s.Serialize<bool>(UseDefaultEmitter, name: "UseDefaultEmitter");
			} else if (Settings.s.game == Settings.Game.RL) {
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				musicList = s.SerializeObject<CListO<Generic<Event>>>(musicList, name: "musicList");
				busMixList = s.SerializeObject<CListO<Generic<Event>>>(busMixList, name: "busMixList");
			} else {
				soundList = s.SerializeObject<CListO<SoundDescriptor_Template>>(soundList, name: "soundList");
				defaultSound = s.SerializeObject<StringID>(defaultSound, name: "defaultSound");
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				WwiseBankList = s.SerializeObject<CListO<PathRef>>(WwiseBankList, name: "WwiseBankList");
				WwiseInputList = s.SerializeObject<CListO<WwiseInputDesc>>(WwiseInputList, name: "WwiseInputList");
				defaultSoundIsAlwaysActive = s.Serialize<bool>(defaultSoundIsAlwaysActive, name: "defaultSoundIsAlwaysActive");
			}
		}
		public override uint? ClassCRC => 0xD94D6C53;
	}
}

