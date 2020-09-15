using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIMenuBasic_Template : UIItem_Template {
		[Serialize("validateItemSounds"   )] public CList<ValidateItemSound> validateItemSounds;
		[Serialize("nextItemMinAngle"     )] public float nextItemMinAngle;
		[Serialize("nextItemMaxAngle"     )] public float nextItemMaxAngle;
		[Serialize("nextItemMaxOffset"    )] public Vec2d nextItemMaxOffset;
		[Serialize("isNextItemByMaxOffset")] public int isNextItemByMaxOffset;
		[Serialize("useDiagonalNavigation")] public int useDiagonalNavigation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(validateItemSounds));
			} else if (Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(nextItemMinAngle));
				SerializeField(s, nameof(nextItemMaxAngle));
				SerializeField(s, nameof(nextItemMaxOffset));
				SerializeField(s, nameof(isNextItemByMaxOffset));
				SerializeField(s, nameof(useDiagonalNavigation));
			} else {
			}
		}
		[Games(GameFlags.VH | GameFlags.RL)]
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
		public override uint? ClassCRC => 0x8C2AD444;
	}
}

