using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class SimpleTextComponent : ActorComponent {
		public string TextLabel;
		public LocalisationId lineId;
		public bool drawUsingEngine;
		public float drawBoxWidth;
		public float drawBoxHeight;
		public float textSize;
		public Color textColor;
		public Color backgroundColor;
		public bool centerText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					TextLabel = (string)s.Serialize<CString>((CString)TextLabel, name: "TextLabel");
					lineId = s.SerializeObject<LocalisationId>(lineId, name: "lineId");
					drawUsingEngine = s.Serialize<bool>(drawUsingEngine, name: "drawUsingEngine");
					drawBoxWidth = s.Serialize<float>(drawBoxWidth, name: "drawBoxWidth");
					drawBoxHeight = s.Serialize<float>(drawBoxHeight, name: "drawBoxHeight");
					textSize = s.Serialize<float>(textSize, name: "textSize");
					textColor = s.SerializeObject<Color>(textColor, name: "textColor");
					backgroundColor = s.SerializeObject<Color>(backgroundColor, name: "backgroundColor");
					centerText = s.Serialize<bool>(centerText, name: "centerText");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					TextLabel = s.Serialize<string>(TextLabel, name: "TextLabel");
					lineId = s.SerializeObject<LocalisationId>(lineId, name: "lineId");
					drawUsingEngine = s.Serialize<bool>(drawUsingEngine, name: "drawUsingEngine");
					drawBoxWidth = s.Serialize<float>(drawBoxWidth, name: "drawBoxWidth");
					drawBoxHeight = s.Serialize<float>(drawBoxHeight, name: "drawBoxHeight");
					textSize = s.Serialize<float>(textSize, name: "textSize");
					textColor = s.SerializeObject<Color>(textColor, name: "textColor");
					backgroundColor = s.SerializeObject<Color>(backgroundColor, name: "backgroundColor");
					centerText = s.Serialize<bool>(centerText, name: "centerText");
				}
			}
		}
		public override uint? ClassCRC => 0x8162686D;
	}
}

