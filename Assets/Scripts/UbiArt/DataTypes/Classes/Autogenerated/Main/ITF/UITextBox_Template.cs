namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class UITextBox_Template : UIComponent_Template {
		public CListO<FontTextArea.Style> styles;
		public float depthOffset;
		public bool is2DNoScreenRatio;
		public float textHeight;
		public float boxWidth;
		public float boxHeight;
		public int isDrawBox;
		public Cropping croppingMode;
		public int usePages;
		public BoxPosition boxPosition;
		public CArrayO<StringID> textBlock;
		public Path texture;
		public Vec2d textureOffset2D;
		public Vec2d anchorOffset2D;
		public float zOffset;
		public int is2DText;
		public float zOffsetActors;
		public int useActorPosition;
		public int useActorScale;
		public int useActorRotation;
		public CListO<Path> preSpawnedActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				fontName = s.SerializeObject<Path>(fontName, name: "fontName");
				textMode = s.Serialize<uint>(textMode, name: "textMode");
				textModeY = s.Serialize<uint>(textModeY, name: "textModeY");
				textHeight = s.Serialize<float>(textHeight, name: "textHeight");
				boxWidth = s.Serialize<float>(boxWidth, name: "boxWidth");
				boxHeight = s.Serialize<float>(boxHeight, name: "boxHeight");
				isDrawBox = s.Serialize<int>(isDrawBox, name: "isDrawBox");
				croppingMode = s.Serialize<Cropping>(croppingMode, name: "croppingMode");
				usePages = s.Serialize<int>(usePages, name: "usePages");
				boxPosition = s.Serialize<BoxPosition>(boxPosition, name: "boxPosition");
				textBlock = s.SerializeObject<CArrayO<StringID>>(textBlock, name: "textBlock");
				texture = s.SerializeObject<Path>(texture, name: "texture");
				textureOffset2D = s.SerializeObject<Vec2d>(textureOffset2D, name: "textureOffset2D");
				anchorOffset2D = s.SerializeObject<Vec2d>(anchorOffset2D, name: "anchorOffset2D");
				zOffset = s.Serialize<float>(zOffset, name: "zOffset");
				is2DText = s.Serialize<int>(is2DText, name: "is2DText");
				zOffsetActors = s.Serialize<float>(zOffsetActors, name: "zOffsetActors");
				useActorPosition = s.Serialize<int>(useActorPosition, name: "useActorPosition");
				useActorScale = s.Serialize<int>(useActorScale, name: "useActorScale");
				useActorRotation = s.Serialize<int>(useActorRotation, name: "useActorRotation");
				textShadowOffset = s.SerializeObject<Vec2d>(textShadowOffset, name: "textShadowOffset");
				textShadowColor = s.SerializeObject<Color>(textShadowColor, name: "textShadowColor");
				lineSpacingFactor = s.Serialize<float>(lineSpacingFactor, name: "lineSpacingFactor");
			} else if (s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
				styles = s.SerializeObject<CListO<FontTextArea.Style>>(styles, name: "styles");
				preSpawnedActorPaths = s.SerializeObject<CListO<Path>>(preSpawnedActorPaths, name: "preSpawnedActorPaths");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
			} else {
				styles = s.SerializeObject<CListO<FontTextArea.Style>>(styles, name: "styles");
				preSpawnedActorPaths = s.SerializeObject<CListO<Path>>(preSpawnedActorPaths, name: "preSpawnedActorPaths");
				depthOffset = s.Serialize<float>(depthOffset, name: "depthOffset");
				is2DNoScreenRatio = s.Serialize<bool>(is2DNoScreenRatio, name: "is2DNoScreenRatio");
			}
		}
		public enum Cropping {
			[Serialize("Cropping_Scale")] Scale = 0,
			[Serialize("Cropping_Cut"  )] Cut = 1,
		}
		public enum BoxPosition {
			[Serialize("BoxPosition_TopLeft")] TopLeft = 0,
			[Serialize("BoxPosition_Center" )] Center = 1,
			[Serialize("BoxPosition_Left"   )] Left = 2,
		}
		public override uint? ClassCRC => 0x7F7A3028;
	}
}

