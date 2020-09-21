using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIMenuBasic_Template : UIItem_Template {
		public CListO<ValidateItemSound> validateItemSounds;
		public float nextItemMinAngle;
		public float nextItemMaxAngle;
		public Vec2d nextItemMaxOffset;
		public int isNextItemByMaxOffset;
		public int useDiagonalNavigation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				validateItemSounds = s.SerializeObject<CListO<ValidateItemSound>>(validateItemSounds, name: "validateItemSounds");
			} else if (Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				nextItemMinAngle = s.Serialize<float>(nextItemMinAngle, name: "nextItemMinAngle");
				nextItemMaxAngle = s.Serialize<float>(nextItemMaxAngle, name: "nextItemMaxAngle");
				nextItemMaxOffset = s.SerializeObject<Vec2d>(nextItemMaxOffset, name: "nextItemMaxOffset");
				isNextItemByMaxOffset = s.Serialize<int>(isNextItemByMaxOffset, name: "isNextItemByMaxOffset");
				useDiagonalNavigation = s.Serialize<int>(useDiagonalNavigation, name: "useDiagonalNavigation");
			} else {
			}
		}
		[Games(GameFlags.VH | GameFlags.RL)]
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
		public override uint? ClassCRC => 0x8C2AD444;
	}
}

