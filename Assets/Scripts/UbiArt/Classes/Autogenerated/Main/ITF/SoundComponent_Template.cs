using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.COL | GameFlags.RL)]
	public partial class SoundComponent_Template : ActorComponent_Template {
		[Serialize("soundList"                 )] public CList<SoundDescriptor_Template> soundList;
		[Serialize("defaultSound"              )] public StringID defaultSound;
		[Serialize("inputs"                    )] public CList<InputDesc> inputs;
		[Serialize("WwiseBankList"             )] public CList<PathRef> WwiseBankList;
		[Serialize("WwiseInputList"            )] public CList<WwiseInputDesc> WwiseInputList;
		[Serialize("defaultSoundIsAlwaysActive")] public bool defaultSoundIsAlwaysActive;
		[Serialize("volume"                    )] public Volume volume;
		[Serialize("inputs"                    )] public CArray<InputDesc> inputs;
		[Serialize("musicList"                 )] public Placeholder musicList;
		[Serialize("busMixList"                )] public Placeholder busMixList;
		[Serialize("WwiseBankList"             )] public Volume WwiseBankList;
		[Serialize("RegisterRtpcListener"      )] public CArray<InputDesc> RegisterRtpcListener;
		[Serialize("UseDefaultEmitter"         )] public int UseDefaultEmitter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(soundList));
				SerializeField(s, nameof(defaultSound));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(inputs));
			} else if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(soundList));
				SerializeField(s, nameof(defaultSound));
				SerializeField(s, nameof(WwiseBankList));
				SerializeField(s, nameof(RegisterRtpcListener));
				SerializeField(s, nameof(UseDefaultEmitter));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(soundList));
				SerializeField(s, nameof(defaultSound));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(musicList));
				SerializeField(s, nameof(busMixList));
			} else {
				SerializeField(s, nameof(soundList));
				SerializeField(s, nameof(defaultSound));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(WwiseBankList));
				SerializeField(s, nameof(WwiseInputList));
				SerializeField(s, nameof(defaultSoundIsAlwaysActive));
			}
		}
		public override uint? ClassCRC => 0xD94D6C53;
	}
}

