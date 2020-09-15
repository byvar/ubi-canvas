using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class UIMenuScroll : UIMenuBasic {
		[Serialize("itemOffset"       )] public Vec2d itemOffset;
		[Serialize("itemVisiblesCount")] public int itemVisiblesCount;
		[Serialize("displayOutItems"  )] public bool displayOutItems;
		[Serialize("separatorModel"   )] public StringID separatorModel;
		[Serialize("itemStartPos"     )] public Vec3d itemStartPos;
		[Serialize("separatorStartPos")] public Vec3d separatorStartPos;
		[Serialize("spawnRequestIndex")] public CArray<uint> spawnRequestIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(itemOffset));
				SerializeField(s, nameof(itemVisiblesCount));
				SerializeField(s, nameof(displayOutItems));
				SerializeField(s, nameof(separatorModel));
				SerializeField(s, nameof(itemStartPos));
				SerializeField(s, nameof(separatorStartPos));
			} else {
				SerializeField(s, nameof(itemOffset));
				SerializeField(s, nameof(itemVisiblesCount));
				SerializeField(s, nameof(displayOutItems));
				SerializeField(s, nameof(separatorModel));
				SerializeField(s, nameof(itemStartPos));
				SerializeField(s, nameof(separatorStartPos));
				SerializeField(s, nameof(spawnRequestIndex));
				SerializeField(s, nameof(spawnRequestIndex));
			}
		}
		public override uint? ClassCRC => 0x0B43C905;
	}
}

