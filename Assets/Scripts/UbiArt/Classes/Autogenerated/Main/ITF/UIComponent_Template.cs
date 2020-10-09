using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class UIComponent_Template : ActorComponent_Template {
		public bool is2D;
		public float showingFadeDuration;
		public float hidingFadeDuration;
		public Path fontName;
		public float fontHeight;
		public Color textColor;
		public Color textColorHighlighted;
		public Color textColorInactive;
		public Color actorColorHighlighted;
		public Color actorColorInactive;
		public Color actorColor;
		public uint textMode;
		public uint textModeY;
		public int defaultSelected;
		public int isActive;
		public int updatePos;
		public int rank;
		public string friendly;
		public string menuBaseName;
		public Vec2d animSize;
		public float fontHeightSelected;
		public Vec2d textShadowOffset;
		public Color textShadowColor;
		public float lineSpacingFactor;
		public int forceUseAnimSize;
		public bool bool__0;
		public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (!(this is UITextBox_Template)) {
					fontName = s.SerializeObject<Path>(fontName, name: "fontName");
					fontHeight = s.Serialize<float>(fontHeight, name: "fontHeight");
					textColor = s.SerializeObject<Color>(textColor, name: "textColor");
					textColorHighlighted = s.SerializeObject<Color>(textColorHighlighted, name: "textColorHighlighted");
					textColorInactive = s.SerializeObject<Color>(textColorInactive, name: "textColorInactive");
					actorColorHighlighted = s.SerializeObject<Color>(actorColorHighlighted, name: "actorColorHighlighted");
					actorColorInactive = s.SerializeObject<Color>(actorColorInactive, name: "actorColorInactive");
					actorColor = s.SerializeObject<Color>(actorColor, name: "actorColor");
					textMode = s.Serialize<uint>(textMode, name: "textMode");
					textModeY = s.Serialize<uint>(textModeY, name: "textModeY");
					defaultSelected = s.Serialize<int>(defaultSelected, name: "defaultSelected");
					isActive = s.Serialize<int>(isActive, name: "isActive");
					updatePos = s.Serialize<int>(updatePos, name: "updatePos");
					rank = s.Serialize<int>(rank, name: "rank");
					friendly = s.Serialize<string>(friendly, name: "friendly");
					menuBaseName = s.Serialize<string>(menuBaseName, name: "menuBaseName");
					animSize = s.SerializeObject<Vec2d>(animSize, name: "animSize");
					fontHeightSelected = s.Serialize<float>(fontHeightSelected, name: "fontHeightSelected");
					textShadowOffset = s.SerializeObject<Vec2d>(textShadowOffset, name: "textShadowOffset");
					textShadowColor = s.SerializeObject<Color>(textShadowColor, name: "textShadowColor");
					lineSpacingFactor = s.Serialize<float>(lineSpacingFactor, name: "lineSpacingFactor");
					forceUseAnimSize = s.Serialize<int>(forceUseAnimSize, name: "forceUseAnimSize");
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				bool__0 = s.Serialize<bool>(bool__0, name: "bool__0");
				bool__1 = s.Serialize<bool>(bool__1, name: "bool__1");
				showingFadeDuration = s.Serialize<float>(showingFadeDuration, name: "showingFadeDuration");
				hidingFadeDuration = s.Serialize<float>(hidingFadeDuration, name: "hidingFadeDuration");
			} else if (Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.RL) {
				is2D = s.Serialize<bool>(is2D, name: "is2D", options: CSerializerObject.Options.BoolAsByte);
				showingFadeDuration = s.Serialize<float>(showingFadeDuration, name: "showingFadeDuration");
				hidingFadeDuration = s.Serialize<float>(hidingFadeDuration, name: "hidingFadeDuration");
			} else {
				is2D = s.Serialize<bool>(is2D, name: "is2D");
				showingFadeDuration = s.Serialize<float>(showingFadeDuration, name: "showingFadeDuration");
				hidingFadeDuration = s.Serialize<float>(hidingFadeDuration, name: "hidingFadeDuration");
			}
		}
		public override uint? ClassCRC => 0x55D95E2A;
	}
}

