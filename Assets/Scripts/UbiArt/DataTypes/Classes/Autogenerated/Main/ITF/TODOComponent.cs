using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.LegendsAndUp)]
	public partial class TODOComponent : ActorComponent {
		public CString TextLabel;
		public int drawUsingEngine;
		public float drawBoxWidth;
		public float drawBoxHeight;
		public float textSize;
		public float textAlpha;
		public float textRed;
		public float textGreen;
		public float textBlue;
		public float backgroundAlpha;
		public float backgroundRed;
		public float backgroundGreen;
		public float backgroundBlue;
		public int centerText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					TextLabel = s.Serialize<CString>(TextLabel, name: "TextLabel");
					drawUsingEngine = s.Serialize<int>(drawUsingEngine, name: "drawUsingEngine");
					drawBoxWidth = s.Serialize<float>(drawBoxWidth, name: "drawBoxWidth");
					drawBoxHeight = s.Serialize<float>(drawBoxHeight, name: "drawBoxHeight");
					textSize = s.Serialize<float>(textSize, name: "textSize");
					textAlpha = s.Serialize<float>(textAlpha, name: "textAlpha");
					textRed = s.Serialize<float>(textRed, name: "textRed");
					textGreen = s.Serialize<float>(textGreen, name: "textGreen");
					textBlue = s.Serialize<float>(textBlue, name: "textBlue");
					backgroundAlpha = s.Serialize<float>(backgroundAlpha, name: "backgroundAlpha");
					backgroundRed = s.Serialize<float>(backgroundRed, name: "backgroundRed");
					backgroundGreen = s.Serialize<float>(backgroundGreen, name: "backgroundGreen");
					backgroundBlue = s.Serialize<float>(backgroundBlue, name: "backgroundBlue");
					centerText = s.Serialize<int>(centerText, name: "centerText");
				}
			} else {
			}
		}
		public override uint? ClassCRC => 0x1010A8F1;
	}
}

