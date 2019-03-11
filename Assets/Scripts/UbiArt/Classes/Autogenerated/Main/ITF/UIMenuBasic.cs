using UnityEngine;

namespace UbiArt.ITF {
	public partial class UIMenuBasic : UIMenu {
		[Serialize("validateItemSounds"   )] public CList<UIMenuBasic.ValidateItemSound> validateItemSounds;
		[Serialize("WwiseActivateSounds"  )] public CList<StringID> WwiseActivateSounds;
		[Serialize("WwiseDeactivateSounds")] public CList<StringID> WwiseDeactivateSounds;
		[Serialize("WwiseValidateSounds"  )] public CList<StringID> WwiseValidateSounds;
		[Serialize("WwiseBackSounds"      )] public CList<StringID> WwiseBackSounds;
		[Serialize("defaultItem"          )] public StringID defaultItem;
		[Serialize("defaultItem"          )] public Enum_defaultItem defaultItem;
		[Serialize("defaultValidate"      )] public Enum_defaultValidate defaultValidate;
		[Serialize("backItem"             )] public Enum_backItem backItem;
		[Serialize("defaultPadItem"       )] public StringID defaultPadItem;
		[Serialize("defaultPadItem"       )] public Enum_defaultPadItem defaultPadItem;
		[Serialize("backItem"             )] public StringID backItem;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(defaultItem));
					SerializeField(s, nameof(backItem));
				}
			} else {
				SerializeField(s, nameof(validateItemSounds));
				SerializeField(s, nameof(WwiseActivateSounds));
				SerializeField(s, nameof(WwiseDeactivateSounds));
				SerializeField(s, nameof(WwiseValidateSounds));
				SerializeField(s, nameof(WwiseBackSounds));
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(defaultItem));
					SerializeField(s, nameof(defaultItem));
					SerializeField(s, nameof(defaultValidate));
					SerializeField(s, nameof(backItem));
					SerializeField(s, nameof(defaultPadItem));
					SerializeField(s, nameof(defaultPadItem));
				}
			}
		}
		public partial class ValidateItemSound : CSerializable {
			[Serialize("itemId"       )] public StringID itemId;
			[Serialize("mainSoundId"  )] public StringID mainSoundId;
			[Serialize("remoteSoundId")] public StringID remoteSoundId;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(itemId));
				SerializeField(s, nameof(mainSoundId));
				SerializeField(s, nameof(remoteSoundId));
			}
		}
		public enum Enum_defaultItem {
			[Serialize("Empty")] Empty = -1,
		}
		public override uint? ClassCRC => 0x93AE77AE;
	}
}

