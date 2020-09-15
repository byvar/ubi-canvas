using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class UIMenuBasic : UIMenu {
		public CList<UIMenuBasic.ValidateItemSound> validateItemSounds;
		public CList<StringID> WwiseActivateSounds;
		public CList<StringID> WwiseDeactivateSounds;
		public CList<StringID> WwiseValidateSounds;
		public CList<StringID> WwiseBackSounds;
		public StringID defaultItem;
		public StringID defaultValidate;
		public StringID defaultPadItem;
		public StringID backItem;
		public StringID actionItem;
		public StringID otherItem;
		public StringID leftItem;
		public StringID rightItem;
		public StringID upItem;
		public StringID downItem;
		public StringID cursorItem;
		public Vec2d cursorOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					defaultItem = s.SerializeObject<StringID>(defaultItem, name: "defaultItem");
					backItem = s.SerializeObject<StringID>(backItem, name: "backItem");
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					defaultItem = s.SerializeObject<StringID>(defaultItem, name: "defaultItem");
					backItem = s.SerializeObject<StringID>(backItem, name: "backItem");
					actionItem = s.SerializeObject<StringID>(actionItem, name: "actionItem");
					otherItem = s.SerializeObject<StringID>(otherItem, name: "otherItem");
					leftItem = s.SerializeObject<StringID>(leftItem, name: "leftItem");
					rightItem = s.SerializeObject<StringID>(rightItem, name: "rightItem");
					upItem = s.SerializeObject<StringID>(upItem, name: "upItem");
					downItem = s.SerializeObject<StringID>(downItem, name: "downItem");
					cursorItem = s.SerializeObject<StringID>(cursorItem, name: "cursorItem");
					cursorOffset = s.SerializeObject<Vec2d>(cursorOffset, name: "cursorOffset");
				}
			} else {
				validateItemSounds = s.SerializeObject<CList<UIMenuBasic.ValidateItemSound>>(validateItemSounds, name: "validateItemSounds");
				WwiseActivateSounds = s.SerializeObject<CList<StringID>>(WwiseActivateSounds, name: "WwiseActivateSounds");
				WwiseDeactivateSounds = s.SerializeObject<CList<StringID>>(WwiseDeactivateSounds, name: "WwiseDeactivateSounds");
				WwiseValidateSounds = s.SerializeObject<CList<StringID>>(WwiseValidateSounds, name: "WwiseValidateSounds");
				WwiseBackSounds = s.SerializeObject<CList<StringID>>(WwiseBackSounds, name: "WwiseBackSounds");
				if (s.HasFlags(SerializeFlags.Default)) {
					if (s.HasFlags(SerializeFlags.Editor)) {
						SerializeFieldAsChoiceList(s, nameof(defaultItem), "Empty");
						SerializeFieldAsChoiceList(s, nameof(defaultValidate), "Empty");
						SerializeFieldAsChoiceList(s, nameof(backItem), "Empty");
						SerializeFieldAsChoiceList(s, nameof(defaultPadItem), "Empty");
					} else {
						defaultItem = s.SerializeObject<StringID>(defaultItem, name: "defaultItem");
						defaultValidate = s.SerializeObject<StringID>(defaultValidate, name: "defaultValidate");
						backItem = s.SerializeObject<StringID>(backItem, name: "backItem");
						defaultPadItem = s.SerializeObject<StringID>(defaultPadItem, name: "defaultPadItem");
					}
				}
			}
		}
		[Games(GameFlags.RA)]
		public partial class ValidateItemSound : CSerializable {
			public StringID itemId;
			public StringID mainSoundId;
			public StringID remoteSoundId;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				itemId = s.SerializeObject<StringID>(itemId, name: "itemId");
				mainSoundId = s.SerializeObject<StringID>(mainSoundId, name: "mainSoundId");
				remoteSoundId = s.SerializeObject<StringID>(remoteSoundId, name: "remoteSoundId");
			}
		}
		public override uint? ClassCRC => 0x93AE77AE;
	}
}

