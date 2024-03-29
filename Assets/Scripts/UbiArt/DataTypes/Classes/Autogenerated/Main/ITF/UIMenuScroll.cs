namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class UIMenuScroll : UIMenuBasic {
		public Vec2d itemOffset;
		public int itemVisiblesCount;
		public bool displayOutItems;
		public StringID separatorModel;
		public Vec3d itemStartPos;
		public Vec3d separatorStartPos;
		public CArrayP<uint> spawnRequestIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL || s.Settings.Game == Game.VH) {
				itemOffset = s.SerializeObject<Vec2d>(itemOffset, name: "itemOffset");
				itemVisiblesCount = s.Serialize<int>(itemVisiblesCount, name: "itemVisiblesCount");
				displayOutItems = s.Serialize<bool>(displayOutItems, name: "displayOutItems");
				separatorModel = s.SerializeObject<StringID>(separatorModel, name: "separatorModel");
				itemStartPos = s.SerializeObject<Vec3d>(itemStartPos, name: "itemStartPos");
				separatorStartPos = s.SerializeObject<Vec3d>(separatorStartPos, name: "separatorStartPos");
			} else {
				itemOffset = s.SerializeObject<Vec2d>(itemOffset, name: "itemOffset");
				itemVisiblesCount = s.Serialize<int>(itemVisiblesCount, name: "itemVisiblesCount");
				displayOutItems = s.Serialize<bool>(displayOutItems, name: "displayOutItems");
				separatorModel = s.SerializeObject<StringID>(separatorModel, name: "separatorModel");
				itemStartPos = s.SerializeObject<Vec3d>(itemStartPos, name: "itemStartPos");
				separatorStartPos = s.SerializeObject<Vec3d>(separatorStartPos, name: "separatorStartPos");
				spawnRequestIndex = s.SerializeObject<CArrayP<uint>>(spawnRequestIndex, name: "spawnRequestIndex");
			}
		}
		public override uint? ClassCRC => 0x0B43C905;
	}
}

