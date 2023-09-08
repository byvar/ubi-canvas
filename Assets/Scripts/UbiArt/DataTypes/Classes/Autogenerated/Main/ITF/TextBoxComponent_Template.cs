namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class TextBoxComponent_Template : UIComponent_Template {
		public CListO<FontTextArea.Style> styles;
		public float depthOffset;
		public CListO<Path> preSpawnedActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
				styles = s.SerializeObject<CListO<FontTextArea.Style>>(styles, name: "styles");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				preSpawnedActorPaths = s.SerializeObject<CListO<Path>>(preSpawnedActorPaths, name: "preSpawnedActorPaths");
			} else {
				styles = s.SerializeObject<CListO<FontTextArea.Style>>(styles, name: "styles");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
			}
		}
		public override uint? ClassCRC => 0x657ACC79;
	}
}

