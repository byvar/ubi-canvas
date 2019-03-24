using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuBasic : UIMenu {
		[Serialize("validateItemSounds"   )] public CList<UIMenuBasic.ValidateItemSound> validateItemSounds;
		[Serialize("WwiseActivateSounds"  )] public CList<StringID> WwiseActivateSounds;
		[Serialize("WwiseDeactivateSounds")] public CList<StringID> WwiseDeactivateSounds;
		[Serialize("WwiseValidateSounds"  )] public CList<StringID> WwiseValidateSounds;
		[Serialize("WwiseBackSounds"      )] public CList<StringID> WwiseBackSounds;
		[Serialize("defaultItem"          )] public StringID defaultItem;
		[Serialize("defaultValidate"      )] public StringID defaultValidate;
		[Serialize("defaultPadItem"       )] public StringID defaultPadItem;
		[Serialize("backItem"             )] public StringID backItem;
		[Serialize("actionItem"           )] public StringID actionItem;
		[Serialize("otherItem"            )] public StringID otherItem;
		[Serialize("leftItem"             )] public StringID leftItem;
		[Serialize("rightItem"            )] public StringID rightItem;
		[Serialize("upItem"               )] public StringID upItem;
		[Serialize("downItem"             )] public StringID downItem;
		[Serialize("cursorItem"           )] public StringID cursorItem;
		[Serialize("cursorOffset"         )] public Vector2 cursorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(defaultItem));
					SerializeField(s, nameof(backItem));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(defaultItem));
					SerializeField(s, nameof(backItem));
					SerializeField(s, nameof(actionItem));
					SerializeField(s, nameof(otherItem));
					SerializeField(s, nameof(leftItem));
					SerializeField(s, nameof(rightItem));
					SerializeField(s, nameof(upItem));
					SerializeField(s, nameof(downItem));
					SerializeField(s, nameof(cursorItem));
					SerializeField(s, nameof(cursorOffset));
				}
			} else {
				SerializeField(s, nameof(validateItemSounds));
				SerializeField(s, nameof(WwiseActivateSounds));
				SerializeField(s, nameof(WwiseDeactivateSounds));
				SerializeField(s, nameof(WwiseValidateSounds));
				SerializeField(s, nameof(WwiseBackSounds));
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(defaultItem), "Empty");
						SerializeFieldAsChoiceList(s, nameof(defaultValidate), "Empty");
						SerializeFieldAsChoiceList(s, nameof(backItem), "Empty");
						SerializeFieldAsChoiceList(s, nameof(defaultPadItem), "Empty");
					} else {
						SerializeField(s, nameof(defaultItem));
						SerializeField(s, nameof(defaultValidate));
						SerializeField(s, nameof(backItem));
						SerializeField(s, nameof(defaultPadItem));
					}
				}
			}
		}
		[Games(GameFlags.RA)]
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
		public override uint? ClassCRC => 0x93AE77AE;
	}
}

