using UnityEngine;

namespace UbiArt.ITF {
	public partial class SoundComponent_Template : ActorComponent_Template {
		[Serialize("soundList"     )] public CList<SoundDescriptor_Template> soundList;
		[Serialize("inputs"        )] public CList<InputDesc> inputs;
		[Serialize("WwiseBankList" )] public CList<PathRef> WwiseBankList;
		[Serialize("WwiseInputList")] public CList<WwiseInputDesc> WwiseInputList;
		[Serialize("defaultSound"  )] public StringID defaultSound;
		[Serialize("volume"        )] public Volume volume;
		[Serialize("musicList"     )] public Placeholder musicList;
		[Serialize("busMixList"    )] public Placeholder busMixList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(soundList));
				SerializeField(s, nameof(defaultSound));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(inputs));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(soundList));
				SerializeField(s, nameof(defaultSound));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(musicList));
				SerializeField(s, nameof(busMixList));
			} else {
				SerializeField(s, nameof(soundList));
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(WwiseBankList));
				SerializeField(s, nameof(WwiseInputList));
			}
		}
		public override uint? ClassCRC => 0xD94D6C53;
	}
}

