using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.RO | GameFlags.VH)]
	public partial class UIComponent_Template : ActorComponent_Template {
		[Serialize("is2D"                 )] public bool is2D;
		[Serialize("showingFadeDuration"  )] public float showingFadeDuration;
		[Serialize("hidingFadeDuration"   )] public float hidingFadeDuration;
		[Serialize("fontName"             )] public Path fontName;
		[Serialize("fontHeight"           )] public float fontHeight;
		[Serialize("textColor"            )] public Color textColor;
		[Serialize("textColorHighlighted" )] public Color textColorHighlighted;
		[Serialize("textColorInactive"    )] public Color textColorInactive;
		[Serialize("actorColorHighlighted")] public Color actorColorHighlighted;
		[Serialize("actorColorInactive"   )] public Color actorColorInactive;
		[Serialize("actorColor"           )] public Color actorColor;
		[Serialize("textMode"             )] public uint textMode;
		[Serialize("textModeY"            )] public uint textModeY;
		[Serialize("defaultSelected"      )] public int defaultSelected;
		[Serialize("isActive"             )] public int isActive;
		[Serialize("updatePos"            )] public int updatePos;
		[Serialize("rank"                 )] public int rank;
		[Serialize("friendly"             )] public string friendly;
		[Serialize("menuBaseName"         )] public string menuBaseName;
		[Serialize("animSize"             )] public Vector2 animSize;
		[Serialize("fontHeightSelected"   )] public float fontHeightSelected;
		[Serialize("textShadowOffset"     )] public Vector2 textShadowOffset;
		[Serialize("textShadowColor"      )] public Color textShadowColor;
		[Serialize("lineSpacingFactor"    )] public float lineSpacingFactor;
		[Serialize("forceUseAnimSize"     )] public int forceUseAnimSize;
		[Serialize("bool__0"              )] public bool bool__0;
		[Serialize("bool__1"              )] public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (!(this is UITextBox_Template)) {
					SerializeField(s, nameof(fontName));
					SerializeField(s, nameof(fontHeight));
					SerializeField(s, nameof(textColor));
					SerializeField(s, nameof(textColorHighlighted));
					SerializeField(s, nameof(textColorInactive));
					SerializeField(s, nameof(actorColorHighlighted));
					SerializeField(s, nameof(actorColorInactive));
					SerializeField(s, nameof(actorColor));
					SerializeField(s, nameof(textMode));
					SerializeField(s, nameof(textModeY));
					SerializeField(s, nameof(defaultSelected));
					SerializeField(s, nameof(isActive));
					SerializeField(s, nameof(updatePos));
					SerializeField(s, nameof(rank));
					SerializeField(s, nameof(friendly));
					SerializeField(s, nameof(menuBaseName));
					SerializeField(s, nameof(animSize));
					SerializeField(s, nameof(fontHeightSelected));
					SerializeField(s, nameof(textShadowOffset));
					SerializeField(s, nameof(textShadowColor));
					SerializeField(s, nameof(lineSpacingFactor));
					SerializeField(s, nameof(forceUseAnimSize));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(bool__1));
				SerializeField(s, nameof(showingFadeDuration));
				SerializeField(s, nameof(hidingFadeDuration));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(is2D), boolAsByte: true);
				SerializeField(s, nameof(showingFadeDuration));
				SerializeField(s, nameof(hidingFadeDuration));
			} else {
				SerializeField(s, nameof(is2D));
				SerializeField(s, nameof(showingFadeDuration));
				SerializeField(s, nameof(hidingFadeDuration));
			}
		}
		public override uint? ClassCRC => 0x55D95E2A;
	}
}

