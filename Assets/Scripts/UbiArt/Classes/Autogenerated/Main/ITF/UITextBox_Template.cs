using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class UITextBox_Template : UIComponent_Template {
		[Serialize("styles"              )] public CList<FontTextArea.Style> styles;
		[Serialize("depthOffset"         )] public float depthOffset;
		[Serialize("is2DNoScreenRatio"   )] public bool is2DNoScreenRatio;
		[Serialize("textHeight"          )] public float textHeight;
		[Serialize("boxWidth"            )] public float boxWidth;
		[Serialize("boxHeight"           )] public float boxHeight;
		[Serialize("isDrawBox"           )] public int isDrawBox;
		[Serialize("croppingMode"        )] public Cropping croppingMode;
		[Serialize("usePages"            )] public int usePages;
		[Serialize("boxPosition"         )] public BoxPosition boxPosition;
		[Serialize("textBlock"           )] public CArray<StringID> textBlock;
		[Serialize("texture"             )] public Path texture;
		[Serialize("textureOffset2D"     )] public Vector2 textureOffset2D;
		[Serialize("anchorOffset2D"      )] public Vector2 anchorOffset2D;
		[Serialize("zOffset"             )] public float zOffset;
		[Serialize("is2DText"            )] public int is2DText;
		[Serialize("zOffsetActors"       )] public float zOffsetActors;
		[Serialize("useActorPosition"    )] public int useActorPosition;
		[Serialize("useActorScale"       )] public int useActorScale;
		[Serialize("useActorRotation"    )] public int useActorRotation;
		[Serialize("preSpawnedActorPaths")] public CList<Path> preSpawnedActorPaths;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(fontName));
				SerializeField(s, nameof(textMode));
				SerializeField(s, nameof(textModeY));
				SerializeField(s, nameof(textHeight));
				SerializeField(s, nameof(boxWidth));
				SerializeField(s, nameof(boxHeight));
				SerializeField(s, nameof(isDrawBox));
				SerializeField(s, nameof(croppingMode));
				SerializeField(s, nameof(usePages));
				SerializeField(s, nameof(boxPosition));
				SerializeField(s, nameof(textBlock));
				SerializeField(s, nameof(texture));
				SerializeField(s, nameof(textureOffset2D));
				SerializeField(s, nameof(anchorOffset2D));
				SerializeField(s, nameof(zOffset));
				SerializeField(s, nameof(is2DText));
				SerializeField(s, nameof(zOffsetActors));
				SerializeField(s, nameof(useActorPosition));
				SerializeField(s, nameof(useActorScale));
				SerializeField(s, nameof(useActorRotation));
				SerializeField(s, nameof(textShadowOffset));
				SerializeField(s, nameof(textShadowColor));
				SerializeField(s, nameof(lineSpacingFactor));
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(styles));
				SerializeField(s, nameof(preSpawnedActorPaths));
				SerializeField(s, nameof(depthOffset));
			} else {
				SerializeField(s, nameof(styles));
				SerializeField(s, nameof(preSpawnedActorPaths));
				SerializeField(s, nameof(depthOffset));
				SerializeField(s, nameof(is2DNoScreenRatio));
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

