using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIMenuBasic_Template : UIItem_Template {
		[Serialize("validateItemSounds"   )] public Placeholder validateItemSounds;
		[Serialize("nextItemMinAngle"     )] public float nextItemMinAngle;
		[Serialize("nextItemMaxAngle"     )] public float nextItemMaxAngle;
		[Serialize("nextItemMaxOffset"    )] public Vector2 nextItemMaxOffset;
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
		[Games(GameFlags.VH)]
		public partial class ValidateItemSound : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			[Serialize("StringID__1")] public StringID StringID__1;
			[Serialize("StringID__2")] public StringID StringID__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(StringID__1));
				SerializeField(s, nameof(StringID__2));
			}
		}
		public override uint? ClassCRC => 0x8C2AD444;
	}
}

